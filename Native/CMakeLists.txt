cmake_minimum_required(VERSION 3.25)
project(opensteamclient LANGUAGES CXX) 

set(CMAKE_CXX_STANDARD 20)

set(CMAKE_BUILD_TYPE MinSizeRel)

set(CMAKE_ARCHIVE_OUTPUT_DIRECTORY ${NATIVE_OUTPUT_FOLDER})
set(CMAKE_LIBRARY_OUTPUT_DIRECTORY ${NATIVE_OUTPUT_FOLDER})
set(CMAKE_RUNTIME_OUTPUT_DIRECTORY ${NATIVE_OUTPUT_FOLDER})

if (BUILD_PLATFORM_TARGET STREQUAL "linux")
    add_executable(reaper ${PROJECT_SOURCE_DIR}/reaper/main.cpp)
    add_executable(steam-launch-wrapper ${PROJECT_SOURCE_DIR}/launchwrapper/main.cpp)

    add_executable(steamserviced ${PROJECT_SOURCE_DIR}/serviced/main.cpp)
    set_target_properties(steamserviced PROPERTIES COMPILE_FLAGS "-m32" LINK_FLAGS "-m32")

    # Fake steam service
    add_library(steamservice SHARED ${PROJECT_SOURCE_DIR}/fakeservice/main.cpp)
    set_target_properties(steamservice PROPERTIES PREFIX "")
endif()

if (BUILD_PLATFORM_TARGET STREQUAL "windows")
    
endif()

# steamutl, a library that allows us to use Valve's CUtl* from C#-land
file(GLOB_RECURSE steamutl_sources CONFIGURE_DEPENDS "steamutl/*.cpp")
add_library(steamutl SHARED ${steamutl_sources})
target_include_directories(steamutl PRIVATE "steamutl/MiniUTL")

# Save build timestamp to file
string(TIMESTAMP UNIX_TIMESTAMP "%s") 
file(WRITE ${NATIVE_OUTPUT_FOLDER}/../build_timestamp ${UNIX_TIMESTAMP})