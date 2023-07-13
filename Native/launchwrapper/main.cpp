#include <iostream>
#include <string>
#include <cstring>
#include <vector>
#include <map>
#include <unistd.h>

// What are these?
std::vector<std::string> vars
{
    "ENABLE_VULKAN_RENDERDOC_CAPTURE",
    "PROTON_LOG",
    "WINEDEBUG"
};

std::map<std::string, std::string> launchargs;

#define ENVVAR_SIZE 1024

bool apply_environment()
{
    char *XDG_RUNTIME_DIR = getenv("XDG_RUNTIME_DIR");
    if (XDG_RUNTIME_DIR == NULL) {
        std::cout << "launchwrapper: XDG_RUNTIME_DIR not set";
        return false;
    }
    for (size_t i = 0; i < vars.size(); i++)
    {
        std::string filename;
        filename.append(XDG_RUNTIME_DIR).append("/steam/env/").append(vars[i]);

        auto handle = fopen(filename.c_str(), "r");
        if (handle == nullptr) {
            std::cerr << "launchwrapper: failed to open file " << filename << std::endl;
            continue;
        }

        char data[ENVVAR_SIZE];
        auto read = fread(data, 1, ENVVAR_SIZE, handle);
        if (ferror(handle) != 0) {
            std::cerr << "launchwrapper: failed to fread()" << std::endl;
            continue;
        }

        // Why is this done?
        data[read - 1] = NULL;

        setenv(vars[i].c_str(), data, 1);
        std::cout << "launchwrapper: " << vars[i] << "=" << data << std::endl;
    }
    return true;
}

// This executable sets environment variables from $XDG_RUNTIME_DIR/steam/env/ENVVAR_NAME
// It is ran as such:
// launchwrapper -- /bin/bash
int main(int argc, char *argv[])
{
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
    std::cerr << "launchwrapper: No executable specified!" << std::endl;
    exit(EXIT_FAILURE);
  }
  
  auto result = apply_environment();
  if (result == false) {
    std::cerr << "launchwrapper: Applying environment variables failed!" << std::endl;
    exit(EXIT_FAILURE);
  }
  return execvp(argv[argc_executable], argv + argc_executable);
}