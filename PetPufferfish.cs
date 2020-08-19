using Terraria.ModLoader;

namespace PetPufferfish
{
	class PufferfishMod : Mod
	{
		public PufferfishMod()
		{
			Properties = new ModProperties()
			{
				Autoload = true,
				AutoloadGores = true,
				AutoloadSounds = true
			};
		}
	}
}
