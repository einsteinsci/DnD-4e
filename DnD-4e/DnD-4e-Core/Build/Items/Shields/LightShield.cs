using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DnD_4e.Lore;

namespace DnD_4e.Build.Items.Shields
{
	public class LightShield : ShieldBase
	{
		public override int ArmorCheckPenalty
		{
			get
			{
				return 0;
			}
		}

		public override string Name
		{
			get
			{
				return "Light Shield";
			}
		}

		public override Cash Price
		{
			get
			{
				return Cash.GP(5);
			}
		}

		public override int ShieldBonus
		{
			get
			{
				return 1;
			}
		}

		public override int SpeedPenalty
		{
			get
			{
				return 0;
			}
		}

		public override ShieldType Type
		{
			get
			{
				return ShieldType.Light;
			}
		}

		public override int Weight
		{
			get
			{
				return 6;
			}
		}
	}
}
