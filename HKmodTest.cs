using Modding;

namespace HKmodTest
{
    public class HKmodTest : Mod, ICustomMenuMod, ITogglableMod, ILocalSettings<ModLocalSettings>, IGlobalSettings<ModGlobalSettings>
    {
        new public string GetName() => "HKmodTest";
        public override string GetVersion() => "0.0.01";
        public override int LoadPriority() => 0;
        public static ModLocalSettings LocalSettings { get; set; } = new ModLocalSettings();
        public void OnLoadLocal(ModLocalSettings s) => LocalSettings = s;
        public ModLocalSettings OnSaveLocal() => LocalSettings;
        public static ModGlobalSettings GlobalSettings { get; set; } = new();
        void IGlobalSettings<ModGlobalSettings>.OnLoadGlobal(ModGlobalSettings s) { GlobalSettings = s; }
        ModGlobalSettings IGlobalSettings<ModGlobalSettings>.OnSaveGlobal() { return GlobalSettings; }
        public static ModInitialize modHooks { get; set; } = new();
        public override void Initialize()
        {
            Log("Initializing");
            modHooks.Hook();
            Log("Initialized");
        }
        public void Unload()
        {
            Log("Unloading");
            modHooks.Unhook();
            Log("Unloaded");
        }
        public bool ToggleButtonInsideMenu { get; } = true;
        public MenuScreen GetMenuScreen(MenuScreen modListMenu, ModToggleDelegates? toggleDelegates)
        {
            return ModMenu.GetMenu(modListMenu, toggleDelegates);
        }
    }
}