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

        public HollowKnightMod()
        {
        }
        public override void Load()
        {
            OriginalLifeCrystalTexture = Main.itemTexture[29];
            Main.itemTexture[29] = this.GetTexture("Textures/Mask_Shard");

            OriginalheartTexture = Main.heartTexture;
            Main.heartTexture = this.GetTexture("Textures/Mask");
        }
        public override void Unload()
        {
            Main.itemTexture[29] = OriginalLifeCrystalTexture;

            Main.heartTexture = OriginalheartTexture;
        }
    }
}

