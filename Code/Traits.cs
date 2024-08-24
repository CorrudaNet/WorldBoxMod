using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;


namespace ModTemplate.Code
{
    class Traits
    {
        public static void init()
        {
            /*
                
            */

            ActorTrait retardedTrait = new ActorTrait();
            retardedTrait.id = "retarded";
            retardedTrait.group_id = TraitGroup.MoreStuff;
            retardedTrait.can_be_cured = false; // This trait cannot be cured duh

            retardedTrait.path_icon = "GameResources/ui/Icons/Icon.png";
            retardedTrait.type = TraitType.Negative;
            retardedTrait.base_stats[S.health] = -5.0f;
            retardedTrait.base_stats[S.warfare] = -1000005.0f;
            retardedTrait.base_stats[S.fertility] = 15.0f;
            retardedTrait.base_stats[S.speed] = -4.5f;
            retardedTrait.base_stats[S.damage] = -35.5f;


            // The gifted trait
            ActorTrait giftedTrait = new ActorTrait();
            giftedTrait.id = "gifted";
            giftedTrait.group_id = TraitGroup.MoreStuff;
            giftedTrait.can_be_cured = false;
            giftedTrait.birth = 0.0001f;

            giftedTrait.path_icon = "GameResources/ui/Icons/Icon.png";
            giftedTrait.type = TraitType.Positive;

            // Psycho Trait
            ActorTrait psychoTrait = new ActorTrait();
            psychoTrait.id = "psycho";
            psychoTrait.group_id = TraitGroup.MoreStuff;
            psychoTrait.inherit = 35.0f;
            psychoTrait.can_be_cured = false;

            psychoTrait.path_icon = "GameResources/ui/Icons/Icon.png";
            psychoTrait.type = TraitType.Negative;


            AssetManager.traits.add(retardedTrait);
            AssetManager.traits.add(giftedTrait);
            AssetManager.traits.add(psychoTrait);
        }
    }
}
