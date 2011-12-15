#!/bin/sh
mkdir -p output/Release
MONO_PATH="./lib/common:$MONO_PATH" gmcs -out:output/Release/wsedit.exe -lib:lib/mono -r:System.Windows.Forms,Palaso,PalasoUIWindowsForms,Palaso.TestUtilities src/wsedit.cs src/Properties/AssemblyInfo.cs
cp lib/common/* output/Release/
cp lib/mono/* output/Release/
cd output/Release/ && tar cfz ../wsedit.tgz *
