
SET ProjectDir=%~1
SET OutDir=%~2
SET AssemblyName=%~3

echo Copying Fake "WoW.exe"
copy /y "%ProjectDir%%OutDir%\%AssemblyName%.exe" ..\TestPaths\WoWPathsValid\WoW.exe
