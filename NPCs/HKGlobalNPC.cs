using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Microsoft.Xna.Framework;

namespace HollowKnightMod.NPCs
{
    class HKGlobalNPC : GlobalNPC
    {
        public override bool PreNPCLoot(NPC npc)
        {
            if (npc.type == NPCID.SkeletronHead && !NPC.downedBoss3)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("PaleOre"));
            }

            if ((npc.type == NPCID.SkeletronPrime || 
                (npc.type == NPCID.Retinazer && !NPC.AnyNPCs(NPCID.Spazmatism)) ||
                (npc.type == NPCID.Spazmatism && !NPC.AnyNPCs(NPCID.Retinazer)) ||
                (npc.type == NPCID.TheDestroyer) && !NPC.downedMechBossAny))
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("PaleOre"));
            }

            if (npc.type == NPCID.Plantera && !NPC.downedPlantBoss)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("PaleOre"));
            }

            if (npc.type == NPCID.Golem && !NPC.downedGolemBoss)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("PaleOre"));
            }

            if (npc.type == NPCID.DukeFishron && !NPC.downedFishron)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("PaleOre"));
            }

            if (npc.type == NPCID.CultistBoss && !NPC.downedAncientCultist)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("PaleOre"));
            }

            return true;
        }
    }
}
