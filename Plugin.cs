using BepInEx;
using BepInEx.Configuration;
using HarmonyLib;

namespace PurpleSuitUnlocker
{
    [BepInPlugin(PLUGIN_GUID, PLUGIN_NAME, PLUGIN_VERSION)]
    public class Plugin : BaseUnityPlugin
    {
        const string PLUGIN_GUID = "butterystancakes.lethalcompany.purplesuitunlocker", PLUGIN_NAME = "Purple Suit Unlocker", PLUGIN_VERSION = "1.1.1";
        public static ConfigEntry<bool> configEventRequirement;

        void Awake()
        {
            configEventRequirement = Config.Bind("Purple Suit Unlocker", "EventRequirement", true, "Require event to be completed.");
            new Harmony(PLUGIN_GUID).PatchAll();
            Logger.LogInfo($"{PLUGIN_NAME} v{PLUGIN_VERSION} loaded");
        }
    }
}