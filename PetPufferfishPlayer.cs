using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ModLoader.IO;
using Terraria.GameInput;

namespace PetPufferfish
{
    public class PetPufferfishPlayer : ModPlayer
    {
        private const int saveVersion = 0;
        public bool Pet = false;
        public static bool hasProjectile;


        public override void ResetEffects()
        {
            Pet = false;
        }

    }
        

 }