#// ---------------------------------------------------------------------------------------
#//                                   Hiperspace
#//                        Copyright (c) 2024 Cepheis Ltd
#//                                    www.cepheis.com
#//
#// This file is part of Hiperspace and is distributed under the GPL Open Source License. 
#// ---------------------------------------------------------------------------------------
# CMakeList.txt : CMake project for rockshare, include source and define
# project specific logic here.
#
cmake_minimum_required (VERSION 3.20)

project ("rockshare")

# Add source to this project's executable.
add_executable (rockshare 
  "src/rockshare.cpp" 
  "include/rockshare.h" 
  "include/HipServer.h" 
  "src/HipServer.cpp" 
  "include/SpacePool.h" 
  "src/SparePool.cpp" 
  "include/SpaceConnection.h" 
  "src/SpaceConnection.cpp" 
  "include/RockSpace.h" 
  "src/RockSpace.cpp" 
  "include/HipException.h" 
  "include/Token.h")


# Enable Hot Reload for MSVC compilers if supported.
if (POLICY CMP0141)
  cmake_policy(SET CMP0141 NEW)
  set(CMAKE_MSVC_DEBUG_INFORMATION_FORMAT "$<IF:$<AND:$<C_COMPILER_ID:MSVC>,$<CXX_COMPILER_ID:MSVC>>,$<$<CONFIG:Debug,RelWithDebInfo>:EditAndContinue>,$<$<CONFIG:Debug,RelWithDebInfo>:ProgramDatabase>>")
endif()

if (CMAKE_VERSION VERSION_GREATER 3.12)
  set_property(TARGET rockshare PROPERTY CXX_STANDARD 20)
  target_compile_features (rockshare PRIVATE cxx_std_20)
endif()

if(NOT MSVC)
  set(CMAKE_CXX_FLAGS "${CMAKE_CXX_FLAGS} -std=c++latest")
else()
  add_definitions(-D_WIN32_WINNT=0x0A00)
  add_definitions(/std:c++20)
endif()

set (CMAKE_CXX_STANDARD 20)


# dependencies
message("toolchain ${CMAKE_TOOLCHAIN_FILE}")
include(${CMAKE_TOOLCHAIN_FILE})
#target_include_directories(rockset, PRIVATE include)
include_directories(include)

find_package(fmt CONFIG REQUIRED)
find_package(protobuf CONFIG REQUIRED)
find_package(TBB CONFIG REQUIRED) 
find_package(gRPC CONFIG REQUIRED)
find_package(ZLIB REQUIRED)
find_package(Boost COMPONENTS program_options REQUIRED)
find_package(RocksDB CONFIG REQUIRED)

#target_link_libraries(rockshare PRIVATE boost-endian) 

# sub directories
add_subdirectory(proto) 
#add_subdirectory(src) 
  
# Link dependencies
target_link_libraries(rockshare PRIVATE p3protolib)
target_link_libraries(rockshare PRIVATE fmt::fmt-header-only)
target_link_libraries(rockshare PRIVATE protobuf::libprotoc protobuf::libprotobuf protobuf::libprotobuf-lite)
target_link_libraries(rockshare PRIVATE TBB::tbb TBB::tbbmalloc TBB::tbbmalloc_proxy)
target_link_libraries(rockshare PRIVATE gRPC::gpr gRPC::grpc gRPC::grpc++ gRPC::grpc++_alts)
target_link_libraries(rockshare PRIVATE ZLIB::ZLIB)
target_link_libraries(rockshare PRIVATE RocksDB::rocksdb RocksDB::rocksdb-shared)
target_link_libraries(rockshare PRIVATE Boost::program_options)

