@echo off
dotnet clean
dotnet build /p:DebugType=Full
dotnet minicover instrument --workdir ../ --assemblies MockProject.Tests/**/bin/**/*.dll --sources MockProject/**/*.cs --exclude-sources MockProject/*.cs
dotnet minicover reset --workdir ../
dotnet test --no-build
dotnet minicover uninstrument --workdir ../
dotnet minicover report --workdir ../ --threshold 60