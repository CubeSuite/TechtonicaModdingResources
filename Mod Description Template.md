To fill out this template:
- Enter:
  - Name
  - Banner Image Link
  - Description

- Add links to screenshots, or delete section
- Fill out config options table or delete if not needed
  - If not needed, also delete step 5 from the installation instructions.
- Delete section about changing "HideGameManagerObject" if not needed.
- Fill out version compatibility table.

Use this site for generating the markdown tables: https://www.tablesgenerator.com/markdown_tables

# Mod Name

![Banner Image]()

## Description

Enter mod description here.

## Screenshots

## Config Options

| Name          |   Type  | Description | Default Value |  Range  |
|---------------|:-------:|-------------|:-------------:|:-------:|
| ExampleInt    | Integer | Does stuff  |       1       | 1 -> 30 |
| ExampleString |   Text  | Does things |   "Example"   |   N/A   |

&nbsp;
## Installation

If you are using Techtonica Mod Loader, you can ignore this section.

Note, this mod requires use of the BepInEx Update function. If you have not already done so for another mod, follow these instructions:
1. Find your game install folder.
2. Navigate to BepInEx\config.
3. Open BepInEx.cfg.
4. Find the setting "HideGameManagerObject".
5. Set it to "true".
6. Save & close.

### Techtonica Mod Loader Installation

You can download the Techtonica Mod Loader from [here](https://github.com/CubeSuite/TechtonicaModLoader/releases) and use that to install this mod.

### Manual Install Instructions

Note: If you are playing on Gamepass, your game version is likely behind the steam version. Please check the version compatibility chart below.

Your game folder is likely in one of these places:  
    • Steam: (A-Z):/steam/steamapps/common/Techtonica  
    • Gamepass: (A-Z):/XboxGames/Techtonica/Content  
    • Gamepass: Could also be in C:/Program Data/WindowsApps  

1. Download BepInEx v5.4.21 from [here](https://github.com/BepInEx/BepInEx/releases)
2. Follow the installation instructions [here](https://docs.bepinex.dev/articles/user_guide/installation/index.html)
3. Extract the contents of the .zip file for this mod.
4. Drag the "BepInEx" folder into your game folder.
5. Change config options. 

## Version Compatibility

|  Mod Version  |  Game Version  |
|:-------------:|:--------------:|
|     v1.x.x    |     v0.3.0e    |

## Changelog

### V1.0.0

Initial release.

&nbsp;
## Disclaimer

Note: NEW Games must be loaded, saved, and reloaded for mods to take effect. Existing saves will auto-apply mods. 
Please be sure to backup your saves before using mods: AppData\LocalLow\Fire Hose Games\Techtonica 
USE AT YOUR OWN RISK! Techtonica Devs do not provide support for Mods, and cannot recover saves damaged by mod usage.

Some assets may come from Techtonica or from the website created and owned by Fire Hose Games, who hold the copyright of Techtonica. All trademarks and registered trademarks present in any images are proprietary to Fire Hose Games.
