using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD_4e.Build.Items.MagicItem
{
	public abstract class MagicShield : ArmsSlotMagicItem
	{
		public abstract List<ShieldType> ValidShields
		{ get; }
	}
}
