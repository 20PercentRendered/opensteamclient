#include <cstdio>
#include <opensteamworks/SteamTypes.h>
#include "temporary_logging_solution.h"
#pragma once


class SteamClientMgr;
class SteamServiceMgr;
class URLProtocolHandler;
class AppManager;
class CommandLine;
class Bootstrapper;
class Updater;
class ThreadController;

extern SteamClientMgr *Global_SteamClientMgr;
extern SteamServiceMgr *Global_SteamServiceMgr;
extern bool Global_debugCbLogging;
extern URLProtocolHandler *Global_URLProtocolHandler;
extern CommandLine *Global_CommandLine;
extern Bootstrapper *Global_Bootstrapper;
extern Updater *Global_Updater;
extern ThreadController *Global_ThreadController;