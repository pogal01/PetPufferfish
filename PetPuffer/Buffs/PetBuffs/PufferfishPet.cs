using Terraria;
using Terraria.ModLoader;

namespace PetPuffer.Buffs.PetBuffs
{
    public class PufferfishPet : ModBuff
    {
        public override void SetDefaults()
        {
            DisplayName.SetDefault("Puff the pufferfish");
            Description.SetDefault("Puff is the best pufferfish of them all.");
            Main.buffNoTimeDisplay[Type] = true;
            Main.vanityPet[Type] = true;
        }

       

        public override void Update(Player player, ref int buffIndex)
        {
            player.buffTime[buffIndex] = 18000;
			player.GetModPlayer<PetPufferPlayer>().Pet = true;
			bool petProjectileNotSpawned = player.ownedProjectileCounts[mod.ProjectileType("PufferFishPet")] <= 0;
            if (petProjectileNotSpawned && player.whoAmI == Main.myPlayer)
            {
                Projectile.NewProjectile(player.position.X + (float)(player.width / 2), player.position.Y + (float)(player.height / 2), 0f, 0f, mod.ProjectileType("PufferFishPet"), 0, 0f, player.whoAmI, 0f, 0f);
            }
        }
    }
}