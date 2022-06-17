using CelestiumMod;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace CelestiumMod.Tiles
{
	public class Viridistone : ModTile
	{
		public override void SetStaticDefaults() {
			Main.tileSolid[Type] = true;
			Main.tileMergeDirt[Type] = true;
			Main.tileBlockLight[Type] = true;
			Main.tileLighted[Type] = true;
			ItemDrop = ModContent.ItemType<Items.Viridistone>();
			AddMapEntry(new Color(255, 30, 200));
		}

		public override void NumDust(int i, int j, bool fail, ref int num) {
			num = fail ? 1 : 3;
		}

		public override void ModifyLight(int i, int j, ref float r, ref float g, ref float b) {
			r = 0.5f;
			g = 0.5f;
			b = 0.5f;
            
		}
	}
}