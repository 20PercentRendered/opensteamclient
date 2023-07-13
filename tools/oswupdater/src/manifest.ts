import https from 'https';
import fs from 'fs';
import * as VDF from '@node-steam/vdf';

// A zip as defined in the downloadable manifest
interface C2SClientZip {
    file: string;
    size: number;
    sha2: string;
    zipvz?: string;
    sha2vz?: string;
    IsBootstrapperPackage?: boolean;
}

export const CLIENT_MAIN_BINARIES_NAME = "bins_ubuntu12";

export class ClientZip implements C2SClientZip {
    file: string;
    size: number;
    sha2: string;
    zipvz?: string;
    sha2vz?: string;
    IsBootstrapperPackage?: boolean;
    constructor(c2s: C2SClientZip) {
        this.file = c2s.file;
        this.size = c2s.size;
        this.sha2 = c2s.sha2;
        this.zipvz = c2s.zipvz;
        this.sha2vz = c2s.sha2vz
        this.IsBootstrapperPackage = c2s.IsBootstrapperPackage;
    }

    DownloadThis(destination: string): Promise<void> {
        return new Promise<void>((resolve, reject) => {
            try {
                const file = fs.createWriteStream(destination);
                https.get(this.fullURL, (response) => {
                    response.pipe(file);

                    file.on("finish", () => {
                        file.close();
                        resolve();
                    });
                });
            } catch (e) {
                reject(e);
            }
        })
    }
    
    get fullURL(): string {
        return `https://client-update.akamai.steamstatic.com/` + this.file;
    }
}

export class ClientManifest {
    public version: number = -1;
    public zips: { [name: string]: ClientZip } = {};
    private manifestString: string = "";

    GetManifestAsString(): string {
        return this.manifestString;
    }

    static LoadFromString(text: string): ClientManifest {
        let manifest = new ClientManifest();
        manifest.manifestString = text;
        
        // the manifest contains a "ubuntu12" bit. show only that object
        var asJson: any = Object.values(VDF.parse(text))[0];

        // Gets all C2SClientZip's and creates ClientZips from them (can't cast since JS is dumb)
        // There isn't a better way to loop over an object's keys and values...
        for (const __item of Object.keys(asJson)) {
            let _item: unknown = asJson[__item];
            if (!(_item as any).file) {
                continue;
            }

            let item: C2SClientZip = <C2SClientZip>_item;
            console.log("zip: " + __item + " " + item.file);

            manifest.zips[__item] = new ClientZip(item);
        }
        
        manifest.version = asJson.version;

        console.log(asJson);
        return manifest;
    }

    SaveManifestToFile(path: string) {
        fs.writeFileSync(path, this.manifestString);
    }

    static LoadFromFile(path: string): ClientManifest {
        return this.LoadFromString(fs.readFileSync(path).toString());
    }

    static UseNewest(platform: string): Promise<ClientManifest> {
        return new Promise<ClientManifest>((resolve, reject) => {

            // This function is a sin against everything javascript
            var downloadPromise = new Promise<Buffer>((resolve, reject) => {
                https.get("https://media.steampowered.com/client/steam_client_"+platform, (res) => {
                    const data: any = [];
                    res.on('data', (chunk) => {
                    data.push(chunk);
                    }).on('end', () => {
                        resolve(Buffer.concat(data));
                        
                    });
                }).on('error', (err) => {
                    reject('download error: ' + err)
                });
                
            });

            downloadPromise.then((buf) => {
                resolve(this.LoadFromString(buf.toString()))
            }).catch((e) => {
                reject("Failed to download newest manifest: " + e);
            })
        })
       
    }
}