@echo off
if {%1}=={debug} SET bld=debug
if {%1}=={} SET bld=debug
if {%1}=={release} set bld=release

devenv FrontEnd.sln /clean
devenv FrontEnd.sln /rebuild %bld% /out buildlog.txt

if errorlevel 1 goto :ERROR

type buildlog.txt>>..\buildlog.txt
del buildlog.txt

..\Tools\setcolor green
echo Build success.

copy JavaScript.Html\bin\%bld%\JavaScript.Html.dll .\..\Target\JavaScript.Lang\

copy enyo\bin\%bld%\enyo.dll .\..\Target\JavaScript.Lang\
copy onyx\bin\%bld%\onyx.dll .\..\Target\JavaScript.Lang\

..\Tools\setcolor
goto :END

:ERROR
..\Tools\setcolor red
echo Build fail. Find detail information in build log.
..\Tools\setcolor
type buildlog.txt>>..\buildlog.txt
del buildlog.txt

:END