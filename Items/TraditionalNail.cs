using Terraria.ID;
using Terraria.ModLoader;
using Terraria;

namespace HollowKnightMod.Items
{
    public class TraditionalNail : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Traditional Nail");
            Tooltip.SetDefault("A traditional weapon of Hallownest.");
        }

        public override void SetDefaults()
        {
            item.damage = 42;
            item.melee = true;
            item.width = 26;
            item.height = 70;
            item.useTime = 45;
            item.knockBack = 5;
            item.value = Terraria.Item.sellPrice(0, 0, 0, 0);
            item.rare = 2;
            item.UseSound = SoundID.Item1;
            item.shoot = mod.ProjectileType("OldNail");
            item.useAnimation = 50;
            item.useStyle = 5;
            item.noUseGraphic = true;
            item.noMelee = true;
            item.autoReuse = true;
            item.noMelee = true;
            item.shootSpeed = 1f;
        }
		
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.ItemType("OldNail"), 1);
            recipe.AddIngredient(mod.ItemType("PaleOre"), 1); 			
			recipe.AddTile(16);               
			recipe.SetResult (item.type,1);
			recipe.AddRecipe();
		}
    }
}