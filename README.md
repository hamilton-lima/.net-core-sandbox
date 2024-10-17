# .net-core-sandbox
Study notes for .net core 

## How to install on linux

```
wget https://packages.microsoft.com/config/ubuntu/$(lsb_release -rs)/packages-microsoft-prod.deb -O packages-microsoft-prod.deb
sudo dpkg -i packages-microsoft-prod.deb
rm packages-microsoft-prod.deb

sudo apt-get update
sudo apt-get install -y dotnet-sdk-8.0
```

## Commands reference

https://learn.microsoft.com/en-us/dotnet/core/tools/dotnet


### Create a new console application

dotnet new console -n HelloWorld

### Install dev kit for C#

Name: C# Dev Kit
Id: ms-dotnettools.csdevkit
Description: Official C# extension from Microsoft
Version: 1.11.14
Publisher: Microsoft
VS Marketplace Link: https://marketplace.visualstudio.com/items?itemName=ms-dotnettools.csdevkit

## Create a solution and add Console and test projects to it

``` 
dotnet new sln -n HelloWorld
dotnet new console -n HelloWorld.Console
dotnet new xunit -n HelloWorld.Tests
dotnet sln HelloWorld.sln add HelloWorld.Console/HelloWorld.Console.csproj
dotnet sln HelloWorld.sln add HelloWorld.Tests/HelloWorld.Tests.csproj
cd HelloWorld.Tests
dotnet add reference ../HelloWorld.Console/HelloWorld.Console.csproj
``` 

- Adding to the same solution, does not create the reference between projects! 🔥 
- To execute the program `dotnet run` 
- To test `dotnet test` 

## Adding some test reports 

```
cd path/to/HelloWorld.Tests
dotnet new tool-manifest
dotnet tool install dotnet-reportgenerator-globaltool
dotnet tool install coverlet.console
dotnet add package coverlet.collector

Create GenerateTestReport.sh
chmod +x GenerateTestReport.sh
``` 

## Packages and packages ... errr... nuggets! 🐔🍗

https://www.nuget.org

This seems to be the boss of all nugets! https://www.nuget.org/packages/newtonsoft.json/

