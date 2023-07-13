# Using VProf
VProf (Valve Profiler) is a tool that you can use to see which functions get called when you do certain things. Oh and you can also use it for profiling.

## Usage

1. Launch ValveSteam (with `-profilestartup` if you want to profile during startup)

2. Open the console (use `-console` arg or [steam://open/console](steam://open/console))

3. Run `profile_on` (skip if you used `-profilestartup`)

4. Run `profile_show_gui`

5. Lots of windows will pop up, close the ones that you're not interested in. (`Steam3 Client Engine` and `SteamUI Thread` are most useful)

6. Do whatever action you want to debug

7. Run `profile_off`
