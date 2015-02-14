using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DnD_4e.Build.Items.MagicItem;
using DnD_4e.Lore;

namespace DnD_4e.Build.Items
{
	public enum ArmorType
	{
		Cloth,
		Leather,
		Hide,
		Chain,
		Scale,
		Plate
	}

	public abstract class ArmorBase : IItem
	{
		public abstract string Name
		{ get; }

		public abstract ArmorType Type
		{ get; }

		public abstract int ArmorBonus
		{ get; }

		public abstract int MinimumEnhancement
		{ get; }

		public bool Masterwork
		{
			get
			{
				return MinimumEnhancement > 0;
			}
		}

		/// <summary>
		/// Armor penalty to Str, Con, and Dex-based skills. Set as negative unless somehow a bonus.
		/// </summary>
		public abstract int CheckPenalty
		{ get; }

		/// <summary>
		/// Penalty to speed due to weight. Set as negative unless somehow a bonus.
		/// </summary>
		public abstract int SpeedPenalty
		{ get; }

		public abstract Cash Price
		{ get; }

		public abstract int Weight
		{ get; }

		public MagicArmor MagicItem
		{ get; set; }
	}
}
