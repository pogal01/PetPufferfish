using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace PetPuffer.Items.PetsS
{
	public class PufferfishPet : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("The Tasty Crayfish");
			Tooltip.SetDefault("I bet a pufferfish would want to eat this.");
		}

		public override void SetDefaults()
		{
			item.CloneDefaults(ItemID.ZephyrFish);
			item.shoot = mod.ProjectileType("PufferFishPet");
			item.buffType = mod.BuffType("PufferfishPet");
		}

	
		public override void UseStyle(Player player)
		{
			if (player.whoAmI == Main.myPlayer && player.itemTime == 0)
			{
				player.AddBuff(item.buffType, 3600, true);
			}
		}
	}
}