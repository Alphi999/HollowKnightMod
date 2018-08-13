using Terraria.ID;
using Terraria.ModLoader;
using Terraria;

namespace HollowKnightMod.Items
{
    public class OldNail : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Old Nail");
            Tooltip.SetDefault("A traditional weapon of Hallownest, wilted with age.");
        }

        public override void SetDefaults()
        {
            item.damage = 20;
            item.melee = true;
            item.width = 26;
            item.height = 70;
            item.useTime = 55;
            item.knockBack = 4;
            item.value = Terraria.Item.sellPrice(0, 0, 0, 0);
            item.rare = 2;
            item.UseSound = SoundID.Item1;
            item.shoot = mod.ProjectileType("OldNail");
            item.useAnimation = 50;
            item.useStyle = 5;
            item.noUseGraphic = true;
            item.noMelee = true;
            item.autoReuse = false;
            item.noMelee = true;
            item.shootSpeed = 1f;
        }

        /*public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.DirtBlock, 10);               we should probably change this -s
			recipe.AddTile(TileID.WorkBenches);               ok yeah fair enough honestly it spawns with the player -a
			recipe.SetResult(item);
			recipe.AddRecipe();
		}*/
    }
}