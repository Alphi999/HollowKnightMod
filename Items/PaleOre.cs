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
            Tooltip.SetDefault("Material\n" +
                "Rare, pale metal that emanates an icy chill.\n" +
                "Prized by those who craft weapons.");
        }

        public override void SetDefaults()
        {
            item.width = 26;
            item.height = 26;
            item.value = 0;
            item.maxStack = 1;
            item.value = Terraria.Item.sellPrice(0, 0, 0, 0);
            item.rare = -12;
        }
    }
}
