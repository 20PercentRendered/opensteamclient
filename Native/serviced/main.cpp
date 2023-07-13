#include <stdio.h>
#include <iostream>
#include <thread>
#include <signal.h>
#include <link.h>

// DEBUGGER
#include <signal.h>
#include <csignal> // or C++ style alternative

bool done = false;
void handle_sigint(int sig)
{
    done = true;
}

void WaitForControlSignalToContinue() {
  std::cout << "Kill with CTRL+C" << std::endl;
  signal(SIGINT, handle_sigint);
  while (!done) {
    std::this_thread::sleep_for(std::chrono::milliseconds(1000));
  }
  done = false;
  signal(SIGINT, SIG_DFL);
}

// Find this by looking at SteamService_StartThread with Ghidra and seeing what function it calls
//TODO: use signature scanning to avoid having to manually decompile every time
int (*SteamServiceInternal_StartThread)(void* ipcServerPtr, const char *pszIPCName, bool bCrossProcess, bool bCrossSession, bool unknown);

// Shuts down the service
void (*SteamService_Shutdown)();

// The main function used to get most service related classes, kind of like IClientEngine
void *(*SteamService_GetIPCServer)();

//TODO: This is really fishy and could potentially be VAC bannable (we don't have .valvesig section)
int main(int argc, char *argv[]) {
    auto dl_handle = dlopen("ubuntu12_32/steamservice.so", RTLD_NOW);
    if (dl_handle == nullptr) {
        std::cerr << "dl_handle == nullptr!!!" << std::endl;
        return 1;
    }
    // IPC names are defined in BSetIpPortFromName
    std::string ipcName = "SteamClientService";

    Dl_info info;

    // Init is (always?) the first function exported in an ELF (libraries and executables).
    void *initPtr = dlsym(dl_handle, "_init");

    // 0x45f70 (addr of SteamServiceInternal_StartThread) - 0x10000(base of steamservice.so)
    // 0x5ee50
    uintptr_t offset = 0x37DE0;
    if (initPtr == nullptr) {
        std::cerr << "InitPtr == nullptr!!!" << std::endl;
        return 1;
    }

    std::cout << "SteamService _init is at " << (void *)(initPtr) << std::endl;
    // get info (including base address) of steamservice loaded in memory
    dladdr((void *)initPtr, &info);

    // calculate the location of SteamServiceInternal_StartThread
    uintptr_t internalStartPtr = ((uintptr_t)info.dli_fbase + offset);

    // here to aid in debugging (if info is 0 the lookup failed)
    std::cout << "dladdr returned  " << (void *)(&info) << std::endl;

    std::cout << "SteamService fbase is at " << (void *)(info.dli_fbase) << std::endl;
    std::cout << "SteamServiceInternal_StartThread is at " << (void *)internalStartPtr << std::endl;

    std::cout << "Starting SteamService using ipcName " << ipcName << std::endl;

    *(void**)(&SteamService_GetIPCServer) = dlsym(dl_handle, "SteamService_GetIPCServer");
    *(void**)(&SteamService_Shutdown) = dlsym(dl_handle, "SteamService_Shutdown");
    *(void**)(&SteamServiceInternal_StartThread) = (void *)internalStartPtr;

    if (SteamService_GetIPCServer == nullptr) {
        std::cerr << "SteamService_GetIPCServer == nullptr!!!" << std::endl;
        return 1;
    }

    if (SteamServiceInternal_StartThread == nullptr) {
        std::cerr << "SteamServiceInternal_StartThread == nullptr (wtf?)" << std::endl;
        return 1;
    }

    void *servicePtr = SteamService_GetIPCServer();
    std::cout << "Service ptr " << servicePtr << std::endl;
    
    // true, false, true is the one used on windows, on linux it is false, false, true by default
    int returnCode = SteamServiceInternal_StartThread(servicePtr, ipcName.c_str(), true, false, true);

    std::cout << "SteamService_ptr is " << servicePtr << std::endl;
    std::cout << "SteamServiceInternal_StartThread returned " << returnCode << std::endl;

    WaitForControlSignalToContinue();
    SteamService_Shutdown();
}