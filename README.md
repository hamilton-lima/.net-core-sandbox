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

