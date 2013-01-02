call git config --global --replace-all filter.TabsVsSpaces.smudge "python '%~dp0\TabSpaceConverter.py' MakeSpaces"
call git config --global --replace-all filter.TabsVsSpaces.clean "python '%~dp0\TabSpaceConverter.py' MakeTabs"
