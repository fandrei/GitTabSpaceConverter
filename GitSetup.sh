SCRIPT=$(readlink -f "$0")
SCRIPTPATH=`dirname "$SCRIPT"`

git config --global --replace-all filter.TabsVsSpaces.smudge "python '$SCRIPTPATH\TabSpaceConverter.py' MakeSpaces"
git config --global --replace-all filter.TabsVsSpaces.clean "python '$SCRIPTPATH\TabSpaceConverter.py' MakeTabs"
