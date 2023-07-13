# Developing "guide"

## Architecture breakdown
OpenSteamClient is split into two main parts:
- ClientUI which has a AvaloniaUI based GUI
- ClientConsole which has a subshell-style CLI
Common code for both these projects (think: remembered credentials, API wrappers, achievement handling, ConCommands) should go into Common.
All the stuff that interfaces natively with steamclient.so should go into OpenSteamworks (think: wrappers for IClient* APIs, util funcs to handle valve's data formats, but nothing more advanced)

## Dependencies
You'll need:
- dotnet
- multilib enabled for the steam service (if on linux) 
