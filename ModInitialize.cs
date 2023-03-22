using UnityEngine;
using Modding;
using System.Runtime.CompilerServices;

namespace HKmodTest
{
    public class ModInitialize : Mod
    {
        public void OnHeroUpdate()
        {;
            if (Input.GetKeyDown(KeyCode.Z))
            {
                Log("You jumped!");
            }
            if (Input.GetKeyDown(KeyCode.X))
            {
                Log("You slashed!");
            }
            if (Input.GetKeyDown(KeyCode.C))
            {
                Log("You dashed!");
            }
        }
        public void Hook()
        {
            ModHooks.HeroUpdateHook += OnHeroUpdate;
        }
        public void Unhook()
        {
            ModHooks.HeroUpdateHook -= OnHeroUpdate;
        }
    }
}
