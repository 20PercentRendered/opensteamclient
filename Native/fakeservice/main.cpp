#include <cstdlib>
#include <iostream>

void *fakeReturnVal = (void*)0x0;
extern "C" void SteamService_Shutdown()
{
}
extern "C" void* SteamService_StartThread(void* servicePtr, const char* ipcName, bool, bool, bool) {
    std::cout << "[FakeSteamService] Tried to start thread with name " << ipcName << std::endl;
    servicePtr = fakeReturnVal;
    return fakeReturnVal;
}
extern "C" void* SteamService_GetIPCServer() {
    std::cout << "[FakeSteamService] GetIPCServer faked with " << fakeReturnVal << std::endl;
    return fakeReturnVal;
}