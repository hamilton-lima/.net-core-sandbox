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
``` 