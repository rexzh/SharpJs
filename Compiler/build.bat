@echo off
if {%1}=={debug} SET bld=debug
if {%1}=={} SET bld=debug
if {%1}=={release} set bld=release

devenv SharpJs.sln /clean
devenv SharpJs.sln /rebuild %bld% /out buildlog.txt

if errorlevel 1 goto :ERROR

type buildlog.txt>>..\buildlog.txt
del buildlog.txt

..\Tools\setcolor green
echo Build success.

copy JavaScript\bin\%bld%\*.dll .\..\Target\JavaScript.Lang\

copy SJC\bin\%bld%\*.exe .\..\Target\SJC\
copy SJC\bin\%bld%\*.dll .\..\Target\SJC\

del .\..\Target\SJC\*.vshost.*

..\Tools\setcolor
goto :END

:ERROR
..\Tools\setcolor red
echo Build fail. Find detail information in build log.
..\Tools\setcolor
type buildlog.txt>>..\buildlog.txt
del buildlog.txt

:END