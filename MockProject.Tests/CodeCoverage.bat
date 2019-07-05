@echo off

REM Clean and build the project
dotnet clean
dotnet build /p:DebugType=Full

REM Instrument assemblies in our test project to detect hits for source files from our main project
dotnet minicover instrument --workdir ../ --assemblies MockProject.Tests/**/bin/**/*.dll --sources MockProject/**/*.cs --exclude-sources MockProject/*.cs

REM Reset previous counters
dotnet minicover reset --workdir ../

REM Run the tests
dotnet test --no-build

REM Uninstrument assemblies in case we want to deploy
dotnet minicover uninstrument --workdir ../

REM Print the console report
dotnet minicover report --workdir ../ --threshold 70
