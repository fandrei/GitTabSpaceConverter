call git config --global --replace-all filter.TabsVsSpaces.smudge "'%~dp0\TabSpaceConverter\bin\Debug\TabSpaceConverter.exe' MakeSpaces"
call git config --global --replace-all filter.TabsVsSpaces.clean "'%~dp0\TabSpaceConverter\bin\Debug\TabSpaceConverter.exe' MakeTabs"
