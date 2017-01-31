Build a Visual Studio Code C# solution for .Net Core with unit tests from the scratch.

Table of contents:
1. Installation
2. Commands
3. Folders structure
4. Setup libraries or application projects
5. Setup unit tests project
6. Setup solution build

 ## Installation

1. [.NET Core SDK](https://www.microsoft.com/net/download/core)
2. [Visual Studio Code -- VS Code]( https://code.visualstudio.com/)
3. Open VS Code and click on Extensions (last icon of left side bar or `Ctrl + Shif + X`)
4. Install the extension “_C# for Visual Studio Code (powered by OmniSharp_”

## Commands list

In this guide we use the following commands: 
* [`dotnet new`](https://docs.microsoft.com/en-us/dotnet/articles/core/tools/dotnet-new) to create an up-to-date `project.json` file with NuGet dependencies.
* [`dotnet restore`]( https://docs.microsoft.com/en-us/dotnet/articles/core/tools/dotnet-restore), which calls into NuGet to restore the tree of dependencies.
* [`dotnet build`](https://docs.microsoft.com/en-us/dotnet/articles/core/tools/dotnet-build) to compile source files.
* `dotnet <assembly.dll>` to run the target application.
or:
* [`dotnet run`](https://docs.microsoft.com/en-us/dotnet/articles/core/tools/dotnet-run) to run your application from the source code. Relies on [dotnet build] to build source inputs before launching the program.
* `code .` to open Visual Studio Code for current location.

In the following sections we present a step by step guide to setup a VS Code solution with libraries, a console application and unit tests. If you want just check the final result then clone this repo and run the following commands in root folder:
* `code .`
* Type `Ctr + Shif + B` to build solution
* Type `Ctr + F5` to run `App` project
