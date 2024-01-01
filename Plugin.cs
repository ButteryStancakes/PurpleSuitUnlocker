using BepInEx;
using BepInEx.Configuration;
using HarmonyLib;

namespace PurpleSuitUnlocker
{
    [BepInPlugin(PLUGIN_GUID, PLUGIN_NAME, PLUGIN_VERSION)]
    public class Plugin : BaseUnityPlugin
    {
        const string PLUGIN_GUID = "butterystancakes.lethalcompany.purplesuitunlocker", PLUGIN_NAME = "Purple Suit Unlocker", PLUGIN_VERSION = "1.0.0";
        public static ConfigEntry<bool> configKeepTwoHanded;

        void Awake()
        {
            new Harmony(PLUGIN_GUID).PatchAll();

            Logger.LogInfo($"{PLUGIN_NAME} v{PLUGIN_VERSION} loaded");
        }
    }
}