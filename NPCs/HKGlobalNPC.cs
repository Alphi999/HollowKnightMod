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

            if (npc.type == )

            return true;
        }
    }
}
