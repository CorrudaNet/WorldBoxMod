using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using WorldBoxConsole;

namespace ModTemplate.Code
{
    class WorldEvents : AssetLibrary<EraAsset>
    {
        public static void DoomsDay()
        {
            EraAsset WomenDontHaveRights = new EraAsset
            {
                id = "WomenDontHaveRights",
                path_icon = "GameResources/ui/Icons/Icon.png",
                overlay_chaos = true,
                global_unfreeze_world = true,

                bonus_loyalty = -1000,
                bonus_opinion = -1000,
                grow_vegetation = false,
                years_min = 100,
                years_max = 150
            };

            AssetManager.era_library.add(WomenDontHaveRights);
        }

        public static void Init()
        {

        }
    }
}
