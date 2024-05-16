using FMOD.Studio;
using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helium.Patches
{
    public class VOPlaybackManagerPatch
    {
        [HarmonyPatch(typeof(VOPlaybackManager), "GetDialogueEventInstance")]
        [HarmonyPostfix]
        static void TurnUpPitch(ref EventInstance __result) {
            __result.setPitch(1.5f);
        }
    }
}
