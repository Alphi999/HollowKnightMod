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
        public static Texture2D OriginalheartTexture;
        public static Texture2D OriginalmanaTexture;
        public static Texture2D Originalheart2Texture;

        public HollowKnightMod()
        {
        }
        public override void Load()
        {
            OriginalLifeCrystalTexture = Main.itemTexture[29];
            Main.itemTexture[29] = this.GetTexture("Textures/Mask_Shard");

            OriginalheartTexture = Main.heartTexture;
            Main.heartTexture = this.GetTexture("Textures/Mask");

            OriginalmanaTexture = Main.manaTexture;
            Main.manaTexture = this.GetTexture("Textures/Scarlet_Flame");

            Originalheart2Texture = Main.heart2Texture;
            Main.heart2Texture = this.GetTexture("Textures/Lifeblood_Mask");
        }
        public override void Unload()
        {
            Main.itemTexture[29] = OriginalLifeCrystalTexture;

            Main.heartTexture = OriginalheartTexture;

            Main.manaTexture = OriginalmanaTexture;

            Main.heart2Texture = Originalheart2Texture;
        }
    }
}

