using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace dotaMod.General.items.Placeable
{
	public class DockingMusicBox : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Music Box (Docking)");
		}

		public override void SetDefaults() {
			item.useStyle = 1;
			item.useTurn = true;
			item.useAnimation = 15;
			item.useTime = 10;
			item.autoReuse = true;
			item.consumable = true;
			//item.createTile = TileType<Tiles.DockingMusicBox>();
			item.width = 24;
			item.height = 24;
			item.rare = 4;
			item.value = 100000;
			item.accessory = true;
		}
	}
}
