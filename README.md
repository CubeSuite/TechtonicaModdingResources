# Techtonica Modding Resources & Guides
A collection of resources, guides and useful links for making Techtonica mods.

# Useful Links
[Visual Studio "BepInEx Modding Templates" video guide](https://www.youtube.com/watch?v=KopYonyplXs)

[BepInEx Guide Index](https://docs.bepinex.dev/master/articles/index.html)

[Writing a basic plugin](https://docs.bepinex.dev/articles/dev_guide/plugin_tutorial/)

[Introduction to C#](https://learn.microsoft.com/en-us/dotnet/csharp/tour-of-csharp/tutorials/)

[The Unity Tutorial For Complete Beginners](https://www.youtube.com/watch?v=XtQMytORBmM)

[Unity - Introduction](https://www.tutorialspoint.com/unity/unity_introduction.htm)

# Libraries
If a library exists that adds the functionality you need, it's a good idea to utilise it. This can help with mod compatibility problems.
- [WalrusLib](https://techtonica.starfluxgames.com/mod.php?id=220809)
- ResourcesFromJSON - WIP
  
# How To Use ModUtils.cs

## Important Note

Currently, in order for BepInEx's Update() function to run in Techtonica, we need to change a BepInEx config option.
This applies to anyone who uses a mod that uses ModUtils or the BepInEx Update() function, so copy and paste these instructions to your mod description.

1. Find your game install folder.
   - Steam: <Drive>:\steam\steamapps\common\Techtonica
   - Gamepass: <Drive>:\XboxGames\Techtonica\Content
   - Gamepass: Could also be in C:\Program Data\WindowsApps
2. Navigate to BepInEx\config.
3. Open BepInEx.cfg.
4. Find the setting 'HideGameManagerObject'.
5. Set it to 'true'.
6. Save & close.

## Template Version - Have access to ModUtils in every mod you make
1. Follow the first useful link to setup the BepInEx Modding Template for Visual Studio.
   - If you can't find the 'Unity Mod (BepInEx)' template when starting a new project:
      - Navigate to /Documents/Visual Studio 20xx/Templates/ProjectTemplates
      - Rename the folder 'C#' to 'CSharp'
3. Download the files ModUtils.cs and PluginClass1.cs from [here](https://github.com/CubeSuite/TechtonicaModdingResources/tree/main/ModUtils%20-%20Template%20Version).
4. Navigate to /Documents/Visual Studio 20xx/Templates/ProjectTemplates/CSharp.
5. Unzip the file 'Unity Mod (BepInEx).zip'.
6. Delete the .zip file.
7. Open the unzipped folder.

Read the notes under the next instruction before replacing the files.

8. Replace the files in there with the ones you downloaded.
   - Note, my version of PluginClass1.cs does not include the examples of how to use config options.
   - Make a note of these elsewhere if you haven't leared how to use config options yet.
9. Delete the 'UTILS' folder.
10. Open PluginClass1.cs.
11. Replace the name 'equinox' with your own in the line ```private const string MyGUID = "com.equinox.$safeprojectname$";```.
12. Save & close.
13. Open 'UnityModTemplate.csproj' in a text editor.
14. Change the line ```<Compile Include="Utils/ModUtils.cs" />``` to ```<Compile Include="ModUtils.cs" />```.
15. Save & close.
16. Open 'MyTemplate.vstemplate' in a text / code editor.
17. Delete the following lines:

```
<Folder Name="Utils" TargetFolderName="Utils">
    <ProjectItem ReplaceParameters="true" TargetFileName="ModUtils.cs">UtilsClass1.cs</ProjectItem>
</Folder>
```
18. Select everything in the 'Unity Mod (BepInEx)' folder, right click and choose 'Compress to ZIP file'.
19. Set the name as 'Unity Mod (BepInEx).zip'.
20. Start a new project using the temmplate, open the Task List and address all the ToDo comments.

## Non-Template Version - Access ModUtils in the projects you add it to.

1. Copy the class from inside [ModUtils - Non-Template Version.cs](https://github.com/CubeSuite/TechtonicaModdingResources/blob/main/ModUtils%20-%20Non-Template%20Version.cs)
2. Paste the class somewhere in your mod's code
3. Go to the Update() function for your mod
4. Add the following lines:
```
if(!ModUtils.hasGameStateLoaded) ModUtils.CheckIfGameStateLoaded();
if(!ModUtils.hasGameDefinesLoaded) ModUtils.CheckIfGameDefinesLoaded();
if(!ModUtils.hasSaveStateLoaded) ModUtils.CheckIfSaveStateLoaded();
if(!ModUtils.hasTechTreeStateLoaded) ModUtils.CheckIfTechTreeStateLoaded();
```
5. Write functions to call when the events in ModUtils are triggered, e.g.
```
private void OnGameStateLoaded(object sender, EventArgs e){
  // Code that requires GameState to be loaded before running
}
```
