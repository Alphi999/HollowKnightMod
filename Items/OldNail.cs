using Terraria.ID;
using Terraria.ModLoader;

namespace HollowKnightMod.Items
{
    // ReSharper disable once UnusedMember.Global
    public class OldNail : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Old Nail");
            Tooltip.SetDefault("The remains of an old nail, wilted with age.");
        }

        public override void SetDefaults()
        {
            item.damage = 20;
            item.melee = true;
            item.width = 40;
            item.height = 40;
            item.useTime = 20;
            item.useAnimation = 20;
            item.useStyle = 1;
            item.knockBack = 6;
            item.value = 10000;
            item.rare = 2;
            item.UseSound = SoundID.Item1;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.DirtBlock, 10);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}