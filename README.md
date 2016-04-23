# Arks Mod Tool

A mod utility tool to provide various client-side game adjustments for Phantasy Star Online 2.

This project is strictly the work of a fan and is not affiliated with Sega or any other game development organization.

As a developer, I respect the rights administered to Sega as both the developer and publisher of Phantasy Star Online 2 and will cease development on this project immediately if requested to do so by an appropriate authority.


Jason Lim

## Build Instructions

In order to build the application, it is necessary to acquire a memory dump of the unmodified pso2 process. This can be acquired by running the MemDumpTool in the tools folder while pso2 is running:
```
MemDumpTool.exe pso2.exe -o=../MemDump/pso2.mem
```
Note that the tool must be run with administrator privileges or it will not be able to acquire the memory snapshot.

Once a memory dump of pso2 has been acquired, the application may be built as a normal application from Visual Studio.
