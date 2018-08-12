using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ModLoader;

namespace HollowKnightMod
{
    public class HollowKnightMod : Mod
    {
        public static Texture2D OriginalLifeCrystalTexture;
        public static Texture2D OriginalLifeFruitTexture
        public static Texture2D OriginalLifeFruitTileTexture;
        public static Texture2D OriginalheartTexture;
        public static Texture2D Originalheart2Texture;

        public HollowKnightMod()
        {
        }
        public override void Load()
        {
            OriginalLifeCrystalTexture = Main.itemTexture[29];
            Main.itemTexture[29] = this.GetTexture("Textures/Mask_Shard");

            OriginalLifeFruitTexture = Main.itemTexture[1291];
            Main.itemTexture[1291] = this.GetTexutre("Textures/Lifeblood_Fruit");

            OriginalLifeFruitTileTexture = Main.tileTexture[236];
            Main.tileTexture[236] = this.GetTexture("Texture/Lifeblood_Cocoon");

            OriginalheartTexture = Main.heartTexture;
            Main.heartTexture = this.GetTexture("Textures/Mask");

            Originalheart2Texture = Main.heart2Texture;
            Main.heart2Texture = this.GetTexture("Textures/Lifeblood_Mask");
        }
        public override void Unload()
        {
            Main.itemTexture[29] = OriginalLifeCrystalTexture;

            Main.itemTexture[1291] = OriginalLifeFruitTexture;

            Main.tileTexture[236] = OriginalLifeFruitTileTexture;

            Main.heartTexture = OriginalheartTexture;

            Main.heart2Texture = Originalheart2Texture;
        }
    }
}

