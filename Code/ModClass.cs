using NeoModLoader.api;
using UnityEngine;
using life;
using AOT;
using ai;
using WorldBoxConsole;


namespace ModTemplate.Code
{
    public class ModClass : BasicMod<ModClass>
    {
        protected override void OnModLoad()
        {
            // Load your mod here

            WorldBoxConsole.Console.print("Mod has loaded.");

            // Init the traits
            Traits.init();
            TraitGroup.init();

            WorldEvents.DoomsDay();
            
        }

        public bool doomsday = false;


        void Update()
        {
            if (doomsday == true)
            {
                WorldEvents.DoomsDay();
            }
        }
    }
}
