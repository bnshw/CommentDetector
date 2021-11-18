dotnet publish -o ..\Build -c Release -r win-x64 -p:PublishSingleFile=true --self-contained true .\CommentDetector.csproj
xcopy .\Json\settings.json ..\Build /E /Y /I
xcopy ..\Build C:\Users\BenSc\Documents\ApuDoingStuff\CommentDetector /E /Y /I