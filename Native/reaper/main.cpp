#include <sys/prctl.h>
#include <string>
#include <sys/wait.h>
#include <errno.h>

// Takes everything after -- and runs it.
// Kind of like launchwrapper, but this is executed like:
// reaper SteamLaunch AppId=730 -- /bin/bash
// Most likely so the steam client can look at what games are running and keep track of them easily
int main(int argc, char *argv[]) {
    // This is the index of the remainder of the args
    int argc_executable = 0;

    for (size_t i = 0; i < argc; i++)
    {
        // Finds -- and saves the position of everything after it (the thing to execute)
        if (std::string(argv[i]) == "--" && (i + 1 < argc))
        {
            argc_executable = i + 1;
        }
    }

    if (argc_executable == 0)
    {
        return 1;
    }

    // A subreaper is kinda like an init system, but just for it's children
    prctl(PR_SET_CHILD_SUBREAPER, 1);

    auto fork_result = fork();
    if (fork_result == -1)
    {
        return 1;
    }
    if (fork_result == 0) {
        execvp(argv[argc_executable],argv + argc_executable);
    }

    // Wait for all processes to have exited, then we close ourselves
    int waitResult = 0; 
    do 
    {
        do
        {
            waitResult = wait(nullptr);
        } while (waitResult != -1);
    } while (errno != ECHILD);

}