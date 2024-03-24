# Techtonica Modding Resources & Guides
A collection of resources, guides and useful links for making Techtonica mods.

## Useful Links
[Visual Studio "BepInEx Modding Templates" video guide](https://www.youtube.com/watch?v=KopYonyplXs)

[BepInEx Guide Index](https://docs.bepinex.dev/master/articles/index.html)

[Writing a basic plugin](https://docs.bepinex.dev/articles/dev_guide/plugin_tutorial/)

[Introduction to C#](https://learn.microsoft.com/en-us/dotnet/csharp/tour-of-csharp/tutorials/)

[The Unity Tutorial For Complete Beginners](https://www.youtube.com/watch?v=XtQMytORBmM)

[Unity - Introduction](https://www.tutorialspoint.com/unity/unity_introduction.htm)

## Libraries
If a library exists that adds the functionality you need, it's a good idea to utilise it. This can help with mod compatibility problems.
- [WalrusLib](https://techtonica.starfluxgames.com/mod.php?id=220809)
- [Equinox's Mod Utils](https://thunderstore.io/c/techtonica/p/Equinox/EquinoxsModUtils/) - [Documentation](https://github.com/CubeSuite/TTMod-EquinoxsModUtils)

## How To Release A Mod

### Setup

1. Create a folder on your pc somewhere to store the mod's files.
1. In it, create another folder called 'plugins'
1. If your mod has a config file, create another folder called 'config'
1. Clone this repo to have local copies of the files, just be sure to pull changes as they are made.

### Filling Out Info Files
   
1. From this repo, download a copy of 'Mod Description Template.md' to the folder and rename it 'README.md'.
1. Follow the instructions in the template to fill it out. Don't forget to delete the instructions when you're done.
1. If you're using imgur for images, make sure you:
   1. Right click the image.
   1. Click 'Open image in new tab'.
   1. Copy the link from the new tab.
1. From this repo, download a copy of 'manifest.json' to the folder.
1. Open 'manifest.json' and fill out the missing details. Note:
   1. The 'name' field cannot contain spaces. I recommend using the ModName format.
   1. Description is the tagline that is displayed in most mod loaders and there is a limit to its length. Shorter is better.
   1. Make sure you remember to increase the version number each time you update your mod. You cannot overwrite a previous release, Thunderstore will reject it.
   1. If your mod is dependant on others, open those mods in your browser and look for the field 'Dependency string' and add it to your dependencies array in quotation marks.
   1. website_url should be your github repo, it can be left blank.
1. I recommend creating a folder on your PC called 'Release Template' that contains these files, so that for future mod releases, you can copy and paste this folder to use your own versions of these templates.

The dependencies field should look like this when it's not empty:

```json
"dependencies" : [
  "Equinox-EquinoxsModUtils-2.3.1"
]
```

### Adding Mod Files

1. Create a 256x256 PNG image and name it 'icon.png' and save it in the folder.
1. Navigate to '{Game Folder}/BepInEx/plugins' and look for a folder with the name of your mod.
   1. If you can't find it, you need to build your mod in Visual Studio.
   2. If you're not using the Visual Studio template linked to earlier, look for the .dll in your project's 'bin' folder.
1. Copy that folder to your mod's 'plugins' folder that you created earlier.
1. If your mod has a config file:
   1. Navigate to '{Game Folder}/BepInEx/config' and find the file called '{Your Mod's GUID}.cfg'
   1. Copy it to your mod's 'config' folder that you created earlier.
1. Select all the files in your mod's folder, right click and select 'Compress To ZIP File' and name it '{Your Mod Name}.zip'

### Publishing The Mod

If this is your first mod, you'll need to do the following steps:
1. Go to [Thunderstore](https://thunderstore.io/)
1. In the top right, click 'Login with'
1. Log in with one of the three options available.
1. In the top right, click 'Settings'.
1. Click the 'Teams' category.
1. Click 'Create Team'
   1. Consider the team name as your display name.
   1. For example, my username is cube_suite_dev, but all my mods are by 'Equinox'
  
1. Go to [the upload page](https://thunderstore.io/package/create/)
1. Drag your .zip file to the box that says 'Choose or drag file here'
1. Choose your Team in the Team dropdown box
1. Choose 'Techtonica' in the communities box.
1. Choose 'Mods' or 'Libraries' for the category as appropraite. E.g. Equinox's Mod Utils is a library.
1. Click 'Submit' and wait for both loading bars to turn green.
1. Click 'View listing' in the GUI that appears if the upload is successful.
1. Post a message on the Techtonica Discord channel #mod-releases to announce your mod release or update.

Updating a mod works exactly the same way, Thunderstore will work out that it's an update and not a new release, just be sure to update the version number in your manifest.json
