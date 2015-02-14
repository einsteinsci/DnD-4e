using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DnD_4e.Lore;
using DnD_4e.Mechanics;

namespace DnD_4e.Build.Items.Weapons
{
	// Example implementation
	public class Longsword : MeleeWeapon
	{
		#region weapon data
		public override DieSetup DamageRoll
		{
			get
			{
				return new DieSetup(DieType.d8);
			}
		}

		public override WeaponGroup Group
		{
			get
			{
				return WeaponGroup.HeavyBlade;
			}
		}

		public override WeaponHandedness Handedness
		{
			get
			{
				return WeaponHandedness.OneHanded;
			}
		}

		public override bool HighCrit
		{
			get
			{
				return false;
			}
		}

		public override string Name
		{
			get
			{
				return "Longsword";
			}
		}

		public override bool OffHand
		{
			get
			{
				return false;
			}
		}

		public override bool Reach
		{
			get
			{
				return false;
			}
		}

		public override bool Small
		{
			get
			{
				return false;
			}
		}

		public override bool Versatile
		{
			get
			{
				return true;
			}
		}

		public override Cash Price
		{
			get
			{
				return Cash.GP(15);
			}
		}

		public override int Weight
		{
			get
			{
				return 4;
			}
		}
		#endregion
	}
}
