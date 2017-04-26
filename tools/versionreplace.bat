echo off

FOR /F "tokens=* USEBACKQ" %%F IN (`git rev-list HEAD --count`) DO (
SET buildnumber=%%F
)

set csprojfile=%1

echo Setting buildnumber %buildnumber%
%~dp0sed.exe -i -E "s/(<Version>[0-9]\.[0-9]\.[0-9]\.)[0-9](<\/Version>)/\1%buildnumber%\2/" %csprojfile%
type %csprojfile%