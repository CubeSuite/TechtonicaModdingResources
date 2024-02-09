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
- Equinox's Mod Utils - [Download](https://techtonica.starfluxgames.com/mod.php?id=221365) - [Documentation](https://github.com/CubeSuite/TTMod-EquinoxsModUtils)

## Striped and Publicised dlls
There is a [nuget package](https://www.nuget.org/packages/techtonica-libs) that contains striped and publicised dll's for techtonica. You can add it to your mod to gain access to the games classes using:
```
dotnet add package techtonica-libs --version 0.2.1-c3
```
