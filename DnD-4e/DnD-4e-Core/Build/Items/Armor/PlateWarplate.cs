using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DnD_4e.Build.Items.MagicItems;
using DnD_4e.Events;
using DnD_4e.Lore;

namespace DnD_4e.Build.Items.Armor
{
	public class PlateWarplate : MasterworkArmor
	{
		public override string Name
		{
			get
			{
				return "Warplate";
			}
		}

		public override int ArmorBonus
		{
			get
			{
				return 11;
			}
		}

		public override int CheckPenalty
		{
			get
			{
				return -2;
			}
		}

		public override int MinimumEnhancement
		{
			get
			{
				return 4;
			}
		}

		public override int SpeedPenalty
		{
			get
			{
				return -1;
			}
		}

		public override ArmorType Type
		{
			get
			{
				return ArmorType.Plate;
			}
		}

		public override int Weight
		{
			get
			{
				return 50; // whew!
			}
		}

		public PlateWarplate(MagicArmor magicItem)
			: base(magicItem)
		{ }

		public override void OnItemLoaded(PlayerEventArgs e)
		{
			// absolutely nothing special
		}
	}
}
