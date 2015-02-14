using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD_4e.Build.Items
{
	public abstract class ThrownWeapon : WeaponBase
	{
		public abstract bool HeavyThrown
		{ get; }

		public abstract int LongRange
		{ get; }

		public int ShortRange
		{
			get
			{
				return LongRange / 2;
			}
		}
	}
}
