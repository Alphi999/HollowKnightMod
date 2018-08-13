using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace HollowKnightMod.Items
{
    class PaleOre : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Pale Ore");
        }

        public override void SetDefaults()
        {
            item.width = 26;
            item.height = 26;
            item.value = 0;
            item.maxStack = 999;
        }
    }
}
