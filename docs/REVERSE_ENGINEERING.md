# Reverse Engineering

A shallow guide on figuring out how Steam works.
Note that this in most cases is not necessary, unless you are doing something that isn't well documented. 

## Warning(s)
Mucking around with the Steam client may lead to:
- Account termination
- Non-functional client install
- Corruption
- VAC bans

This should come without saying, but DO NOT play anticheat games if you are running a debugger or profiler or other tool on Steam. 

And also, DO NOT muck with the Local Steam Client service. This is the service responsible for VAC, and any mucking about while a VAC game is running will probably get you banned. 

## Tools

### Ghidra
No guide for this by us, just a couple things to know:

- `steamui.so` is extremely helpful. Just make sure the version matches ours, or else vtable calls will be incorrect. SteamUI has things like:
	- Web-to-native mappings (`User.SetLoginInformation` etc)
	- All the interfaces you can get from `IClientEngine` (Search for any interface's name or `ClientAPI_Init`, there should be a long function that initializes all the interfaces) 

- You should use the `linux64/steamclient.so` for Ghidra

- Whenever you come across a vtable call with an offset like `+ 0x20`, you should turn it into Decimal and then divide it by 4. Now you know the index of the function in a given vtable, just look it up from `tools/generated_interfaces` if you know the interface name.

  

### VProf
See [vprof.md](https://github.com/Rosentti/opensteamclient/blob/master/docs/VPROF.md).

### CEF devtools
Since large parts of Steam are made with React+CEF, it's quite easy to debug and find out how some things work. 
Launch Steam with `-opendevtools` to open the CEF dev tools. 
