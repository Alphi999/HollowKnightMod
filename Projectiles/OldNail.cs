using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace HollowKnightMod.Projectiles
{
    public class OldNail : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("OldNail");
            Main.projFrames[projectile.type] = 28;
        }

        public override void SetDefaults()
        {
            projectile.width = 64;
            projectile.height = 50;
            projectile.friendly = true;
            projectile.penetrate = -1;
            projectile.tileCollide = false;
            projectile.melee = true;
            projectile.ownerHitCheck = true;
            projectile.usesLocalNPCImmunity = true;
            projectile.localNPCHitCooldown = 0;
        }
    }

}
         