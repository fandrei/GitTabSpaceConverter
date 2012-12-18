run the GitSetup.bat file (it will register filter to convert spaces and tabs automatically; files in the working copy will have spaces and in repository will have tabs)

add the following line to the ".git/info/attributes" file of every project you need to convert tabs/spaces for (add other file types as well)
*.cs  filter=TabsVsSpaces

to convert all existing local copy files, use this command:
git checkout HEAD -- **
