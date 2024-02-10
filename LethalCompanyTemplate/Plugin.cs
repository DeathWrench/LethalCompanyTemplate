using BepInEx;

namespace LethalCompanyTemplate
{
    [BepInPlugin("GUID", "NAME", "VERSION X.X.X")]
    public class Plugin : BaseUnityPlugin
    {
        private void Awake()
        {
            // Plugin startup logic
            Logger.LogInfo($"Plugin {"GUID"} is loaded!");
        }
    }
}
