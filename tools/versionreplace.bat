echo off
set csprojfile=%1
set buildnumber=%2
echo Setting buildnumber %buildnumber%
%~dp0sed.exe -i -E "s/(<Version>[0-9]\.[0-9]\.[0-9]\.)[0-9](<\/Version>)/\1%buildnumber%\2/" %csprojfile%
type %csprojfile%