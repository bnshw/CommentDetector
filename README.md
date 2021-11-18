# CommentDetector

This program can be added to an project and detect any comments to exclude any comment out code.

## Install

Put the path of your project in the "settings.json".
Next go to the "build.ps1" and change the path in line 3 to your projects path.
If you don't have a build.ps1 yet create one like the example below:
```C#
cd ..\..\CommentDetector
.\CommentDetector.exe
cd ..\{build.ps1 path}
dotnet publish -o ..\..\Build -c Release -r win-x64 -p:PublishSingleFile=true --self-contained true ..\{project}.csproj
```
Now you can build your project.
