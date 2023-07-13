import fs from 'fs';
import path from "path";
import { SteamworksDumper } from "./steamworksdumper";
import { CLIENT_MAIN_BINARIES_NAME, ClientManifest } from "./manifest"
import { Project } from "./project";
import { Difference, execWrap, find32BitELFBinaryRecursive, mkdir, rm } from "./util";
import { ClientDifference, ClientDump } from './dump';
import { VirtualHeader } from './csharp/virtualheader';
import { VersionInfo } from './csharp/versioninfo';
    
export async function Main(): Promise<number> {
    console.info("Starting OSWUpdater");

    console.info("Determining opensteamclient project location...");

    var projectDir: string;
    try {
        projectDir = Project.GetProjectDirectory();
        console.info("Found project at " + projectDir);
    } catch (e) {
        console.error("Couldn't find project, aborting")
        console.error(e);
        return 1;
    }

    console.info("Creating work folder...");
    var workDir: string;
    try {
        workDir = path.resolve("./work");
        mkdir(workDir);
    } catch (e) {
        console.error("Failed to create work folders, aborting");
        console.error(e);
        return 1;
    } 

    console.info("Reading current manifest..")

    mkdir(`${projectDir}/Manifests`);

    var oldManifestFilePathWin32: string = `${projectDir}/Manifests/steam_client_win32.vdf`
    var oldManifestFilePathOSX: string = `${projectDir}/Manifests/steam_client_osx.vdf`
    var oldManifestFilePath: string = `${projectDir}/Manifests/steam_client_ubuntu12.vdf`
    var oldManifest: ClientManifest = ClientManifest.LoadFromFile(oldManifestFilePath);
    
    console.info("Downloading latest client manifests..")
    var newManifestWin32: ClientManifest = await ClientManifest.UseNewest("win32");
    var newManifestOSX: ClientManifest = await ClientManifest.UseNewest("osx");
    var newManifest: ClientManifest = await ClientManifest.UseNewest("ubuntu12");

    console.info("Creating versioned work dir...")
    var versionedWorkDir: string = `${workDir}/${newManifest.version}`;
    mkdir(versionedWorkDir)
    mkdir(`${versionedWorkDir}/zips`)
    mkdir(`${versionedWorkDir}/extracted`)
    mkdir(`${versionedWorkDir}/dumped_data`)

    // Save the manifest on disk 
    
    var newManifestFilePathWin32: string = `${versionedWorkDir}/steam_client_win32.vdf`;
    {
        if (!fs.existsSync(newManifestFilePathWin32)) {
            console.info(`Saving Win32 manifest to ${newManifestFilePathWin32}`)
            newManifestWin32.SaveManifestToFile(newManifestFilePathWin32);
        } 
    }

    var newManifestFilePathOSX: string = `${versionedWorkDir}/steam_client_osx.vdf`;
    {
        if (!fs.existsSync(newManifestFilePathOSX)) {
            console.info(`Saving OSX manifest to ${newManifestFilePathOSX}`)
            newManifestOSX.SaveManifestToFile(newManifestFilePathOSX);
        } 
    }

    var newManifestFilePath: string = `${versionedWorkDir}/steam_client_ubuntu12.vdf`;
    {
        if (!fs.existsSync(newManifestFilePath)) {
            console.info(`Saving manifest to ${newManifestFilePath}`)
            newManifest.SaveManifestToFile(newManifestFilePath);
        } 
    }
    
    if (oldManifest.version != newManifest.version) {
        console.info(`Version changed ${oldManifest.version} -> ${newManifest.version}`)
    } else {
        console.info(`Version unchanged ${oldManifest.version} == ${newManifest.version}, quitting`)
        return 0;
    }

    let binsDownloadTarget: string = `${versionedWorkDir}/zips/${CLIENT_MAIN_BINARIES_NAME}.zip`;
    let binsExtractedTarget: string = path.resolve(`${versionedWorkDir}/extracted/${CLIENT_MAIN_BINARIES_NAME}`)

    if (fs.existsSync(binsDownloadTarget) && fs.statSync(binsDownloadTarget).size == newManifest.zips[CLIENT_MAIN_BINARIES_NAME].size) {
        console.info(`${binsDownloadTarget} already on disk and filesize matches. Skipping download.`);
    } else {
        console.info(`Downloading ${newManifest.zips[CLIENT_MAIN_BINARIES_NAME].fullURL} to ${binsDownloadTarget}...`);

        try {
            await newManifest.zips[CLIENT_MAIN_BINARIES_NAME].DownloadThis(binsDownloadTarget);
        } catch (e) {
            console.error(`Failed to download ${newManifest.zips[CLIENT_MAIN_BINARIES_NAME].fullURL}, aborting`)
            return 1;
        }
    }

    
    console.info(`Extracting ${binsDownloadTarget} to ${binsExtractedTarget}`)

    mkdir(binsExtractedTarget);

    try {
        await execWrap(`unzip -u "${binsDownloadTarget}" -d "${binsExtractedTarget}"`, {});
    } catch (error) {
        console.error("Failed to execute unzip. Are you missing unzip?");
        console.error(error);
    }

    console.info("Locating 32-bit steamui.so...")

    var steamuiLocation: string = "";
    try {
        steamuiLocation = await find32BitELFBinaryRecursive(binsExtractedTarget, "steamui.so");
    } catch (e) {
        console.error("Failed to find steamui.so, aborting");
        return 1;
    }

    console.info(`Found steamui.so at ${steamuiLocation}`)

    console.info("Locating 32-bit steamclient.so...")
    var steamclientLocation: string = "";
    try {
        steamclientLocation = await find32BitELFBinaryRecursive(binsExtractedTarget, "steamclient.so");
    } catch (e) {
        console.error("Failed to find steamclient.so, aborting");
        return 1;
    }
    console.info(`Found steamclient.so at ${steamclientLocation}`)

    console.info("Reading old dumped_data...");
    var oldDump: ClientDump;
    var oldDumpedDataPath: string = `${projectDir}/dumped_data/`;
    oldDump = await ClientDump.ReadFromDirectory(oldDumpedDataPath);
    
    if (fs.existsSync(`${versionedWorkDir}/dumped_data/emsg_list.json`)) {
        console.info("Not dumping new steamclient, files already exist.")
    } else {
        console.info("Dumping new steamclient...");
        let dumper = new SteamworksDumper();
        await dumper.dump(steamclientLocation, `${versionedWorkDir}/dumped_data/`); 
    }

    console.info("Reading new dumped_data...");
    var newDump: ClientDump;
    var newDumpedDataPath: string = `${versionedWorkDir}/dumped_data/`;
    newDump = await ClientDump.ReadFromDirectory(newDumpedDataPath);
    
    console.info("Calculating differences (1/2)...")
    var diff: ClientDifference = oldDump.CompareTo(newDump)

    console.info("Differences: ")
    printDifference(diff.interfaces, "interfaces", "name", "functions have changed");
    printDifference(diff.methods, "methods", "name", "arg count, other changes are undetectable");
    printDifference(diff.callbacks, "callbacks", "name", "size");
    printDifference(diff.eMsgs, "EMsgs", "name", "name");
    
    console.info("Generating new headers...")
    for (const iface of newDump.interfaces) {
        const index = newDump.interfaces.indexOf(iface);

        if (fs.existsSync(`${projectDir}/OpenSteamworks/Generated/${iface.name}.cs`)) {
            console.info(`${iface.name}: Reading previous header for type information (1/3) (header ${index}/${newDump.interfaces.length})`)
            var header: VirtualHeader = await VirtualHeader.LoadFromFile(`${projectDir}/OpenSteamworks/Generated/${iface.name}.cs`, iface.name);

            console.info(`${iface.name}: Patching header with new info (2/3) (header ${index}/${newDump.interfaces.length})`)
            header.PatchWithDump(iface);

            console.info(`${iface.name}: Writing new header to disk (3/3) (header ${index}/${newDump.interfaces.length})`)
            await header.OverwriteOldFile();
        } else {
            console.info(`${iface.name}: Creating new header based on dump (1/2) (header ${index}/${newDump.interfaces.length})`)
            var header: VirtualHeader = await VirtualHeader.CreateFromDump(`${projectDir}/OpenSteamworks/Generated/${iface.name}.cs`, iface);

            console.info(`${iface.name}: Writing new header to disk (2/2) (header ${index}/${newDump.interfaces.length})`)
            await header.OverwriteOldFile();
        }
        
    }
    
    console.info("Updating installed manifests...")
    rm(oldManifestFilePath);
    fs.cpSync(newManifestFilePath, oldManifestFilePath)

    rm(oldManifestFilePathWin32);
    fs.cpSync(newManifestFilePathWin32, oldManifestFilePathWin32)

    rm(oldManifestFilePathOSX);
    fs.cpSync(newManifestFilePathOSX, oldManifestFilePathOSX)

    
    console.info("Copying new dumped_data to project dir...")
    fs.rmSync(oldDumpedDataPath, {recursive: true, force: true});
    fs.cpSync(`${versionedWorkDir}/dumped_data`, oldDumpedDataPath, { recursive: true });
    
    console.info("Generating new VersionInfo.cs")
    var versionFilePath = `${projectDir}/OpenSteamworks/Generated/VersionInfo.cs`;
    
    if (fs.existsSync(versionFilePath)) {
        fs.rmSync(versionFilePath);
    }

    VersionInfo.CreateVersionFileFromManifest(versionFilePath, newManifest);

    console.info("Done")
    
    return 0;
}

function printDifference<T>(diff: Difference<T>, name: string, property: string, changeExplanation?: string): void {
    console.info(`${diff.additions.length} new ${name}:`)
    if (diff.additions.length > 0) {
        console.info(diff.additions.map(val => (val as any)[property]).join(", "))
    }
    
    console.info(`${diff.removals.length} removed ${name}`)
    if (diff.removals.length > 0) {
        console.info(diff.removals.map(val => (val as any)[property]).join(", "))
    }

    console.info(`${diff.changes.length} changed ${name} ${changeExplanation ? `(${changeExplanation})` : ""}`)
    if (diff.changes.length > 0) {
        console.info(diff.changes.map(val => (val as any)[property]).join(", "))
    }
}