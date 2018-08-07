using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace HollowKnightMod
{
    // ReSharper disable once UnusedMember.Global
    public class HollowKnightMod : Mod
    {
        private Texture2D _origLifeCrystal;
        private Texture2D _origHeart;

        private new Texture2D GetTexture(string tex)
        {
            return base.GetTexture("Textures/{tex}");
        }

        public override void Load()
        {
            _origLifeCrystal = Main.itemTexture[29];
            Main.itemTexture[ItemID.LifeCrystal] = GetTexture("Mask_Shard");

            _origHeart = Main.heartTexture;
            Main.heartTexture = GetTexture("Mask");
        }

        public override void Unload()
        {
            Main.itemTexture[ItemID.LifeCrystal] = _origLifeCrystal;
            Main.heartTexture = _origHeart;
        }
    }
}