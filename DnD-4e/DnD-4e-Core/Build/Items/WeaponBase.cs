using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DnD_4e.Build.Items.MagicItems;
using DnD_4e.Build.Powers;
using DnD_4e.Events;
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

	public enum WeaponProficiencyLevel
	{
		Simple,
		Military,
		Superior
	}

	public abstract class WeaponBase : IItem
	{
		public abstract string Name
		{ get; }

		public abstract WeaponProficiencyLevel ProficiencyLevel
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

		public MagicWeapon Enchantment
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

		public virtual void OnItemLoad(PlayerEventArgs e)
		{ }
		public virtual void OnItemUnload(PlayerEventArgs e)
		{ }
	}
}
