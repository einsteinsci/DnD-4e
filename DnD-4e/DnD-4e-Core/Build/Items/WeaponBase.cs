using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DnD_4e.Build.Items.MagicItem;
using DnD_4e.Build.Powers;
using DnD_4e.Lore;
using DnD_4e.Mechanics;

namespace DnD_4e.Build.Items
{
	public enum WeaponHandedness
	{
		OneHanded = 1,
		TwoHanded = 2,
	}

	public enum WeaponGroup
	{
		None = 0,
		Unarmed,
		Axe,
		Bow,
		Crossbow,
		Flail,
		Hammer,
		HeavyBlade,
		LightBlade,
		Mace,
		Pick,
		Sling,
	}

	public abstract class WeaponBase : IItem
	{
		public abstract string Name
		{ get; }

		public abstract WeaponHandedness Handedness
		{ get; }

		public int ProficiencyBonus
		{
			get
			{
				if (Group == WeaponGroup.LightBlade ||
					Group == WeaponGroup.HeavyBlade)
				{
					return 3;
				}
				else
				{
					return 2; // Spiked chain [flail] overrides this
				}
			}
		}

		public abstract WeaponGroup Group
		{ get; }

		public abstract bool Small
		{ get; }

		public abstract DieSetup DamageRoll
		{ get; }

		public MagicWeapon MagicItem
		{ get; set; }

		public abstract Cash Price
		{ get; }

		public abstract int Weight
		{ get; }

		public IPower BasicAttack
		{
			get
			{
				return null; // BasicAttack will be coming later
			}
		}
	}
}
