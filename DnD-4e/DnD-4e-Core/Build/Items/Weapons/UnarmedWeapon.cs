using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DnD_4e.Lore;
using DnD_4e.Mechanics;

namespace DnD_4e.Build.Items.Weapons
{
	public class UnarmedWeapon : MeleeWeapon
	{
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
				return WeaponGroup.Unarmed;
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
				return "Unarmed Attack";
			}
		}

		public override bool OffHand
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
				return Cash.Zero;
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
				return true;
			}
		}

		public override bool Versatile
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
				return 0;
			}
		}
	}
}
