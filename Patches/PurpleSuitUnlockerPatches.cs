using HarmonyLib;

namespace PurpleSuitUnlocker.Patches
{
    [HarmonyPatch]
    class PurpleSuitUnlockerPatches
    {
        [HarmonyPatch(typeof(StartOfRound), "Start")]
        [HarmonyPostfix]
        public static void PostStart()
        {
            UnlockPurpleSuit.SpawnPurpleSuit();
        }

        [HarmonyPatch(typeof(StartOfRound), "ResetShip")]
        [HarmonyPostfix]
        public static void PostResetShip()
        {
            UnlockPurpleSuit.SpawnPurpleSuit();
        }
    }
}