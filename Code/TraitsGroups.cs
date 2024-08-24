using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModTemplate.Code
{
    class TraitGroup
    {
        public static string MoreStuff = "MoreStuff";

        public static void init()
        {
            ActorTraitGroupAsset MoreStuff = new ActorTraitGroupAsset();
            MoreStuff.id = "MoreStuff";
            MoreStuff.name = "MoreStuff";
            MoreStuff.color = Toolbox.makeColor("#5b16c9", 1f);
            AssetManager.trait_groups.add(MoreStuff);
        }
    }
}
