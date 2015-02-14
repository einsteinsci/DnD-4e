using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DnD_4e.Lore;

namespace DnD_4e.Build.Items.Armor
{
	public class Leather : ArmorBase
	{
		public override string Name
		{
			get
			{
				return "Leather";
			}
		}

		public override int ArmorBonus
		{
			get
			{
				return 2;
			}
		}

		public override int CheckPenalty
		{
			get
			{
				return 0;
			}
		}

		public override int MinimumEnhancement
		{
			get
			{
				return 0;
			}
		}

		public override Cash Price
		{
			get
			{
				return Cash.GP(25);
			}
		}

		public override int SpeedPenalty
		{
			get
			{
				return 0;
			}
		}

		public override ArmorType Type
		{
			get
			{
				return ArmorType.Leather;
			}
		}

		public override int Weight
		{
			get
			{
				return 15;
			}
		}
	}
}
