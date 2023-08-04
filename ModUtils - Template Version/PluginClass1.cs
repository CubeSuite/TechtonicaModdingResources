using BepInEx;
using BepInEx.Configuration;
using BepInEx.Logging;
using HarmonyLib;
using UnityEngine;

namespace $safeprojectname$
{
    [BepInPlugin(MyGUID, PluginName, VersionString)]
    public class $safeprojectname$Plugin : BaseUnityPlugin
    {
        private const string MyGUID = "com.equinox.$safeprojectname$";
        private const string PluginName = "$safeprojectname$";
        private const string VersionString = "1.0.0";

        private static readonly Harmony Harmony = new Harmony(MyGUID);
        public static ManualLogSource Log = new ManualLogSource(PluginName);

        private void Awake() {
            Logger.LogInfo($"PluginName: {PluginName}, VersionString: {VersionString} is loading...");
            Harmony.PatchAll();

            // ToDo: Patch with Harmony

            Logger.LogInfo($"PluginName: {PluginName}, VersionString: {VersionString} is loaded.");
            Log = Logger;
        }

        // If you use this function, see 'Using BepInEx Update()' on GitHubLink
        // If not, delete it
        // ToDo: Delete the relevent line if you do not need its event
        private void Update() {
            if(!ModUtils.hasGameStateLoaded) ModUtils.CheckIfGameStateLoaded();
            if(!ModUtils.hasGameDefinesLoaded) ModUtils.CheckIfGameDefinesLoaded();
            if(!ModUtils.hasSaveStateLoaded) ModUtils.CheckIfSaveStateLoaded();
            if(!ModUtils.hasTechTreeStateLoaded) ModUtils.CheckIfTechTreeStateLoaded();
        }

        private void OnGameStateLoaded(object sender, EventArgs e){
            // ToDo: Add code or delete
        }

        private void OnGameDefinesLoaded(object sender, EventArgs e){
            // ToDo: Add code or delete
        }


        private void OnSaveStateLoaded(object sender, EventArgs e){
            // ToDo: Add code or delete
        }

        private void OnTechTreeStateLoaded(object sender, EventArgs e){
            // ToDo: Add code or delete
        }
    }
}
