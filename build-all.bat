@echo off

%windir%\Microsoft.NET\Framework\v4.0.30319\csc /out:.\tools\setcolor.exe .\tools\setcolor.cs
::%windir%\Microsoft.NET\Framework\v4.0.30319\csc /out:.\tools\versioncontrol.exe .\tools\versioncontrol.cs

::.\tools\versioncontrol .\SJC 1.0
::.\tools\versioncontrol .\FrontEnd 1.0
::.\tools\versioncontrol .\BackEnd 1.0

echo build start>buildlog.txt

cd Compiler
call build %1
cd ..

cd FrontEnd
call build %1
cd ..

::cd BackEnd
::call build %1
::cd ..


echo build finish>>buildlog.txt

%windir%\Microsoft.NET\Framework\v4.0.30319\csc /out:.\tools\codestat.exe .\tools\codestat.cs 
Tools\CodeStat . cs,js > lines.txt