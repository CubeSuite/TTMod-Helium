using BepInEx;
using BepInEx.Configuration;
using BepInEx.Logging;
using HarmonyLib;
using Helium.Patches;
using UnityEngine;

namespace Helium
{
    [BepInPlugin(MyGUID, PluginName, VersionString)]
    public class HeliumPlugin : BaseUnityPlugin
    {
        private const string MyGUID = "com.equinox.Helium";
        private const string PluginName = "Helium";
        private const string VersionString = "1.0.0";

        private static readonly Harmony Harmony = new Harmony(MyGUID);
        public static ManualLogSource Log = new ManualLogSource(PluginName);

        private void Awake() {
            Logger.LogInfo($"PluginName: {PluginName}, VersionString: {VersionString} is loading...");
            Harmony.PatchAll();

            Harmony.CreateAndPatchAll(typeof(VOPlaybackManagerPatch));

            Logger.LogInfo($"PluginName: {PluginName}, VersionString: {VersionString} is loaded.");
            Log = Logger;
        }
    }
}
