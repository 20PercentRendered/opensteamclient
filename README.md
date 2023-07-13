# OpenSteamClient (C# Avalonia version)
A partially open-source Steam client for Linux (C# version). 

# Features
- 64-bit (but needs 32-bit only steamservice for some functionality)
- No steamwebhelper requirement
- All games supported (technically)
- VAC supported (you can play, but you _might_ get banned. We're not responsible if you get banned.)
- Uses Avalonia UI
- Supports Windows

# Blockers
Current blockers are marked as BLOCKER. Just search for it in all the files.

# Developing
See DEVELOPING.md in the root of this repo.
This will eventually replace the old opensteamclient.

# Screenshots
C# build underway. No screenshots yet.

# Usage
This is only meant for developers. 
Once this is good enough I will write new install instructions. For now end users can use the old opensteamclient by switching to the master branch.
If you're a dev, be cautious about adding things, as I am probably working on it already.

# System requirements
## Distro requirements
- ??? (TODO: Fill this)

# Q&A

## Partially open source?
This is a GUI for Valve's own Steam Client binaries like `steamclient.so` and `steamservice.so`. 
Those binaries are not open source and Valve doesn't officially support 3rd-party usage of these. 
This also means we inherit design choices and potential bugs from these files.
Due to this, we cannot fix everything, such as the client not conforming to the XDG paths specification.

Additionally, Valve does not provide any headers or code to go along with these binaries, so this project essentially works because of guesswork by lots of community members and projects (Thank you!) (such as [open-steamworks](https://github.com/SteamRE/open-steamworks), [open-steamworks fork by m4dEngi](https://github.com/m4dEngi/open-steamworks), [SteamTracking](https://github.com/SteamDatabase/SteamTracking), [protobufs dumped from the steam client](https://github.com/SteamDatabase/Protobufs) and [MiniUTL](https://github.com/FWGS/MiniUTL)). 

Also, thank you Valve for improving Linux gaming, and making a native Steam Client in the first place.

## What version of Steam's binaries do you use?
The repo includes a copy of `steam_client_ubuntu12.vdf`, which shows the version and has download paths for the binaries.
The urls point to regular zip files, just use `unzip`.

## The client crashes a lot or doesn't start
Delete ~/.local/share/opensteam and try again. Also check that you have a PC that meets the requirements for steam officially.
Also, run OpenSteamClient from the terminal and post the logs in a Github issue clearly describing your situation. 
