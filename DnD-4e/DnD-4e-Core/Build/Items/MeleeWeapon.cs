using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD_4e.Build.Items
{
	public abstract class MeleeWeapon : WeaponBase
	{
		public abstract bool OffHand
		{ get; }

		public abstract bool Versatile // two-handed for small pc's
		{ get; }

		public abstract bool Reach
		{ get; }

		public abstract bool HighCrit
		{ get; }
	}
}
