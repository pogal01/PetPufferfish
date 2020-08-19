using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace PetPufferfish.Projectiles.Pets
{
	public class PufferFishPet : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Puff the Pufferfish");
			Main.projFrames[projectile.type] = 4;
			Main.projPet[projectile.type] = true;
		}

		public override void SetDefaults()
		{
			projectile.CloneDefaults(ProjectileID.ZephyrFish);
			aiType = ProjectileID.ZephyrFish;
		}

		public override bool PreAI()
		{
			Player player = Main.player[projectile.owner];
			player.zephyrfish = false; // Relic from aiType
			return true;
		}

		public override void AI()
		{
			Player player = Main.player[projectile.owner];
			PetPufferfishPlayer modPlayer = player.GetModPlayer<PetPufferfishPlayer>();
			if (player.dead)
			{
				modPlayer.Pet = false;
			}
			if (modPlayer.Pet)
			{
				projectile.timeLeft = 2;
			}
		}
	}
}