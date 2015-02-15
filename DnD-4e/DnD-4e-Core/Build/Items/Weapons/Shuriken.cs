using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DnD_4e.Lore;
using DnD_4e.Mechanics;

namespace DnD_4e.Build.Items.Weapons
{
	public class Shuriken : RangedWeapon
	{
		public override WeaponProficiencyLevel ProficiencyLevel
		{
			get
			{
				return WeaponProficiencyLevel.Superior;
			}
		}

		public override DieSetup DamageRoll
		{
			get
			{
				return new DieSetup(DieType.d4);
			}
		}

		public override WeaponGroup Group
		{
			get
			{
				return WeaponGroup.LightBlade;
			}
		}

		public override WeaponHandedness Handedness
		{
			get
			{
				return WeaponHandedness.OneHanded;
			}
		}

		public override int LongRange
		{
			get
			{
				return 12;
			}
		}

		public override string Name
		{
			get
			{
				return "Shuriken";
			}
		}

		public override Cash Price
		{
			get
			{
				return Cash.GP(1);
			}
		}

		public override bool Small
		{
			get
			{
				return false;
			}
		}

		public override int Weight
		{
			get
			{
				return 0; // not worth calculating
			}
		}

		public override ActionType Load
		{
			get
			{
				return ActionType.None; // thrown
			}
		}
	}
}
