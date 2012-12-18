call git config --global filter.TabsVsSpaces.smudge '%~dp0\TabSpaceConverter\bin\Debug\TabSpaceConverter.exe' MakeSpaces
call git config --global filter.TabsVsSpaces.clean '%~dp0\TabSpaceConverter\bin\Debug\TabSpaceConverter.exe' MakeTabs
