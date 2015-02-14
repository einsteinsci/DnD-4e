using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DnD_4e.Build.Items.MagicItem;
using DnD_4e.Lore;

namespace DnD_4e.Build.Items
{
	public enum ShieldType
	{
		Light,
		Heavy
	}

	public abstract class ShieldBase : IItem
	{
		public abstract string Name
		{ get; }

		public abstract Cash Price
		{ get; }

		public abstract int Weight
		{ get; }

		public abstract ShieldType Type
		{ get; }

		public abstract int ShieldBonus
		{ get; }

		// still negative
		public abstract int ArmorCheckPenalty
		{ get; }

		// probably zero, but any penalty should be negative
		public abstract int SpeedPenalty
		{ get; }

		public MagicShield MagicItem
		{ get; set; }
	}
}
