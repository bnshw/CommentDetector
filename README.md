# Comment Detector

This program can be added to a project and detect any comments to exclude any comment out code.

## Install

<p>1. Put the path of your project in the "settings.json". <br>
2. Next go to the "build.ps1" and change the path in line 3 to your projects path. <br>
3. If you don't have a build.ps1 yet create one like the example below: </p>

```C#
cd ..\..\CommentDetector
.\CommentDetector.exe
cd ..\{build.ps1 path}
dotnet publish -o ..\..\Build -c Release -r win-x64 -p:PublishSingleFile=true --self-contained true ..\{project}.csproj
```
Now you can build your project.
