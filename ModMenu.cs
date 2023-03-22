using Modding;
using Satchel.BetterMenus;

namespace HKmodTest
{
    internal static class ModMenu
    {
        internal static Menu? MenuRef;
        internal static Menu BuildMenu(ModToggleDelegates toggleDelegates)
        {
            return new Menu(
                name: "HKmodTest",
                elements: new Element[]
                {
                    Blueprints.CreateToggle(toggleDelegates,"Toggle Mod", "", "On","Off"),
                });
        }
        internal static MenuScreen GetMenu(MenuScreen lastMenu, ModToggleDelegates? toggleDelegates)
        {
            MenuRef ??= BuildMenu((ModToggleDelegates)toggleDelegates);
            return MenuRef.GetMenuScreen(lastMenu);
        }
    }
}