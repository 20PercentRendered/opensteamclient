import fs from "fs"
import path from "path"

export namespace Project {
    var cachedProjectDir: string = "";
    export function GetProjectDirectory(): string {
        if (cachedProjectDir != "")
            return cachedProjectDir;

        // Go up recursively until we find OpenSteamClient.sln
        var found: boolean = false;
        var currentPath: string = __dirname;
        while (!found) {
            found = fs.existsSync(currentPath + "/OpenSteamClient.sln");
            if (!found) {
                currentPath = path.resolve(currentPath + "/../");
                if (currentPath == "/") {
                    throw "Couldn't find OpenSteamClient.sln in parent directories of this script. "
                }
            }
        }
        cachedProjectDir = currentPath;
        return currentPath;
    }
}