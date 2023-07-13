import fsp from 'fs/promises';
import fs from 'fs';
import { ClientDump, ClientInterface, ClientFunction } from '../dump';
import { replaceRange } from '../util';

export interface VirtualFunction {
    returnType: string;
    name: string;
    args: string[];
    precedingLines: string[];
    postBody?: string;
}

//const DEBUG_LOG = console.log;
const DEBUG_LOG = (...args: any) => { };

function VirtualFunction_ToString(func: VirtualFunction, indent: string): string {
    var asStr = "";
    for (let line = 0; line < func.precedingLines.length; line++) {
        const text = func.precedingLines[line];
        asStr += indent+text + "\n"
    }

    if (!(func.returnType.endsWith(" "))) {
        func.returnType += " ";
    }

    var suffix = "";

    if (func.postBody) {
        if (func.postBody.trimStart().startsWith(";")) {
            suffix = func.postBody;
        } else if (func.postBody.trimStart().startsWith("//")) {
            suffix = "; " + func.postBody;
        } else {
            suffix = func.postBody + ";"
        }
    } else {
        suffix = ";"
    }

    asStr += indent+`public ${func.returnType}${func.name}(${func.args.join(",")})${suffix}`;
    return asStr;
}

export class VirtualHeader {
    public name: string;
    private loadedFrom?: string;
    private firstClassLine = -1;
    private lastClassLine = -1;
    public functions: VirtualFunction[] = [];

    // Creates stub file and returns the line number of "public interface ClassName"
    private static CreateStubFile(path: string, classname: string): number {
        var fullText = "";
        var ret: number = 0;
        fullText += "//==========================  AUTO-GENERATED FILE  ================================\n"
        fullText += "//\n"
        fullText += "// This file is partially auto-generated.\n"
        fullText += "// If functions are removed, your changes to that function will be lost.\n"
        fullText += "// Parameter types and names however are preserved if the function stays unchanged.\n"
        fullText += "// Feel free to change parameters to be more accurate. \n"
        fullText += "// Do not use C#s unsafe features in these files. It breaks JIT.\n"
        fullText += "//\n"
        fullText += "//=============================================================================\n"
        fullText += "\n"
        fullText += `using System;\n`
        fullText += `\n`
        fullText += "namespace OpenSteamworks.Generated;\n"
        fullText += "\n"
        fullText += `public interface ${classname}\n`
        ret = fullText.length;
        fullText += "{\n"
        fullText += "}\n"
        fs.writeFileSync(path, fullText);
        return ret;
    }

    async WriteNewFullFile(path: string): Promise<void> {
        // First create a stub file with a parseable class header
        VirtualHeader.CreateStubFile(path, this.name);

        // Load that file
        var newHeader = await VirtualHeader.LoadFromFile(path, this.name);

        // Copy the functions over
        for (const func of this.functions) {
            newHeader.functions.push(func);
        }

        // And save
        await newHeader.OverwriteOldFile();
    }

    // Writes to an existing file between the specified lines.
    async OverwriteOldFile(): Promise<void> {
        if (!this.loadedFrom) {
            throw "Not loaded from a file, cannot override."
        }

        if (!fs.existsSync(this.loadedFrom)) {
            throw "Original file doesn't exist, cannot overwrite."
        }

        if (this.firstClassLine == -1) {
            throw "We don't know the first class line. Cannot overwrite."
        }

        if (this.lastClassLine == -1) {
            throw "We don't know the last class line. Cannot overwrite."
        }

        // load the file into an array
        var lines: string[] = [];
        var file = await fsp.open(this.loadedFrom);
        {
            for await (const line of file.readLines()) {
                lines.push(line);
            }
        }

        // Just in case
        await file.close();

        // Why do we need to re-open it? Does readLines close?
        file = await fsp.open(this.loadedFrom, "w");

        DEBUG_LOG("old "+lines.length)
        for (const line of lines) {
            DEBUG_LOG(line);
        }

        // remove everything between firstClassLine and lastClassLine
        lines.splice(this.firstClassLine, (this.lastClassLine - this.firstClassLine)+1);

        DEBUG_LOG("spliced "+lines.length)
        for (const line of lines) {
            DEBUG_LOG(line);
        }

        lines.splice(this.firstClassLine, 0, ...this.ToString().split("\n"));

        DEBUG_LOG("new "+lines.length)
        for (const line of lines) {
            DEBUG_LOG(line);
        }

        await file.writeFile(Buffer.from(lines.join("\n")));
        await file.close();
    }

    ToString(): string {
        var fullStr = "";
        fullStr += `public interface ${this.name}\n`
        fullStr += "{\n"
        for (const func of this.functions) {
            fullStr += VirtualFunction_ToString(func, "    ") + "\n";
        }
        // This one doesn't have a newline. That's intentional.
        fullStr += "}"
        
        return fullStr;
    }

    // Patches this interface with new functions from a dump, removing and shifting functions as necessary
    PatchWithDump(dump: ClientInterface): void {
        var newFuncs: VirtualFunction[] = [];
        var index = 1;

        // This gets rid of duplicates
        var usedFuncs: VirtualFunction[] = [];

        for (const dumpfunc of dump.functions) {
            var oldfunc: VirtualFunction | undefined = undefined;
            for (const thisfunc of this.functions) {
                // Should we also do "thisfunc.args.length == Number(dumpfunc.argc)"?
                if (thisfunc.name == dumpfunc.name && !usedFuncs.includes(thisfunc)) {
                    usedFuncs.push(thisfunc);
                    oldfunc = thisfunc;
                    break;
                }
            }
            
            var funcToAdd: VirtualFunction;
            var addWarning: boolean = false;
            if (oldfunc != undefined) {
                if (oldfunc.postBody) {
                    var indexOfArgc = oldfunc.postBody.indexOf("argc: ");
                    if (oldfunc.postBody.includes("argc: ")) {            
                        replaceRange(oldfunc.postBody, indexOfArgc, indexOfArgc+6, `argc: ${dumpfunc.argc}`)
                    }

                    var indexOfIndex = oldfunc.postBody.indexOf("index: ", indexOfArgc);
                    if (oldfunc.postBody.includes("index: ", indexOfArgc)) {
                        replaceRange(oldfunc.postBody, indexOfIndex, indexOfIndex+7, `index: ${index}`)
                    }

                } else {
                    oldfunc.postBody = ` // argc: ${dumpfunc.argc}, index: ${index}`; 
                }
                

                addWarning = (Number(dumpfunc.argc) != oldfunc.args.length);
                
                funcToAdd = oldfunc;
            } else {
                addWarning = (Number(dumpfunc.argc) != 0);
                funcToAdd = { name: dumpfunc.name, args: [], postBody: ` // argc: ${dumpfunc.argc}, index: ${index}`, returnType: "unknown_ret", precedingLines: [] };
            }

            const unknownBehaviourWarning = "// WARNING: Do not use this function! Unknown behaviour will occur!";
            const argcCountNotMatchWarning = "// WARNING: Argument count doesn't match argc! Remove this once this has been corrected!"
            if (funcToAdd.name.endsWith("_DONTUSE")) {
                if (!funcToAdd.precedingLines.includes(unknownBehaviourWarning))
                funcToAdd.precedingLines.push(unknownBehaviourWarning)
            } else if (addWarning) {
                // Remove leftover warnings
                if (Number(dumpfunc.argc) == 0) {
                    var index = funcToAdd.precedingLines.indexOf(argcCountNotMatchWarning);
                    if (index !== -1) {
                        funcToAdd.precedingLines.splice(index, 1);
                    }
                    
                    // Clear the args array just in case
                    // Func has 0 argc so it should have no args
                    funcToAdd.args = [];
                }
                if ((Number(dumpfunc.argc) != 0) && !funcToAdd.precedingLines.includes(argcCountNotMatchWarning)) {
                    funcToAdd.precedingLines.push(argcCountNotMatchWarning)
                }
            }
            
            newFuncs.push(funcToAdd);

            index++;
        }
        this.functions = newFuncs;
    }
    
    // Writes a full file, including include guards.
    static async CreateFromDump(fullpath: string, dump: ClientInterface): Promise<VirtualHeader> {
        // First create a stub file with include guards and a parseable class header
        VirtualHeader.CreateStubFile(fullpath, dump.name);

        // Then load the file we just created
        var header = await this.LoadFromFile(fullpath, dump.name);

        // And patch it
        header.PatchWithDump(dump);

        return header;
    }

    static async LoadFromFile(fullpath: string, abstract_class_name: string): Promise<VirtualHeader> {
        var header = new VirtualHeader(abstract_class_name);
        header.loadedFrom = fullpath;

        const file = await fsp.open(fullpath);
        var lines: string[] = [];
        {
            var lineNum: number = 0;
            for await (const line of file.readLines()) {
                lines[lineNum] = line;
                lineNum++;
            }
        }
        
        var currentlyInHeader: boolean = false;
        var lastProcessedLine: number = -1;

        // Loop over the lines in order.
        for (let line = 0; line < lines.length; line++) {
            const text = lines[line];
            const textTrimmed = text.trimStart();
            DEBUG_LOG(`${line}:${text}`)
            console.group();

            // Find the first line where the interface is
            if (header.firstClassLine == -1 && textTrimmed.startsWith(`public interface ${abstract_class_name}`)) {
                lastProcessedLine = line+1;
                header.firstClassLine = line;
                currentlyInHeader = true;
                DEBUG_LOG("classdef starts at " + line)
            }

            if (currentlyInHeader && textTrimmed == "}") {
                header.lastClassLine = line;
                currentlyInHeader = false;
                DEBUG_LOG("end of classdef");
            }

            // Past this point, we need to be parsing the header
            if (!header.firstClassLine) continue;

            if (textTrimmed.startsWith("public") && textTrimmed.includes("(") && textTrimmed.includes(")")) {
            } else {
                console.groupEnd();
                continue;
            }

            var func: VirtualFunction = { returnType: "", name: "", args: [], precedingLines: [], postBody: undefined };
            var realText = text;
            realText = realText.replace("public ", "").trimStart();

            
            var nameAndReturn = realText.substring(0, realText.indexOf("("));

            DEBUG_LOG("nameAndReturn: " + nameAndReturn)

            // Begin with parsing the name so we can get everything between the start and name
            var name = nameAndReturn.substring(nameAndReturn.lastIndexOf(" ")).trimStart();

            // Rest of the string is the return value
            var ret = nameAndReturn.replace(name, "");

            DEBUG_LOG("name:" + name)
            DEBUG_LOG("ret:" + ret)
            func.returnType = ret;
            func.name = name;

            realText = realText.substring(realText.indexOf("("));

            DEBUG_LOG("realtext: " + realText);

            // Arg parsing
            var args: string[] = [];
            {
                var argsText = realText.substring(realText.indexOf("(") + 1, realText.lastIndexOf(")"));
                var currentNesting: number = 0;

                // A very fancy args.split(",")
                var thisArg = "";
                for (var i = 0; i < argsText.length; i++) {
                    
                    DEBUG_LOG("thisStr: " + thisArg)
                    const c = argsText[i];
                    DEBUG_LOG(c);
                    // Handle nesting
                    switch (c) {
                        case "<":
                            currentNesting++;
                            break;
                            
                        case ">":
                            currentNesting--;
                            break;
                    }

                    DEBUG_LOG("currentNesting: " + currentNesting)

                    if (currentNesting > 0) {
                        thisArg += c;
                        continue;
                    }

                    if (c == ",") {
                        DEBUG_LOG("comma")
                        args.push(thisArg);
                        thisArg = "";
                        continue;
                    } else {
                        thisArg += c;
                    }
                }
                args.push(thisArg);
            }
            
            func.args = args;

            realText = realText.substring(realText.lastIndexOf(")")+1);

            DEBUG_LOG("Realtext " + realText);
            
            DEBUG_LOG("last processed: " + lastProcessedLine + " = '" + lines[lastProcessedLine] + "'")
            
            const unprocessedLines = line - lastProcessedLine;
            DEBUG_LOG("unprocessed lines " + unprocessedLines);

            // Previous line comments parsing
            for (let i: number = 1; i < unprocessedLines; i++) {
                const prevLine = lastProcessedLine + i;
                const prevText = lines[lastProcessedLine + i];
                DEBUG_LOG("prevLine: " + prevLine + " = '" + prevText + "'")
                func.precedingLines.push(prevText.trimStart());
            }
           

            // Store the rest of the function
            func.postBody = realText;
            

            DEBUG_LOG(func)
            console.groupEnd();
            lastProcessedLine = line;
            header.functions.push(func);
        }

        if (header.firstClassLine == -1) {
            console.warn("WARNING: couldn't find start of class")
        }

        if (header.lastClassLine == -1) {
            console.warn("WARNING: couldn't find end of class")
        }
        await file.close();
        return header;
    }

    constructor(name: string) {
        this.name = name;
    }
}
