using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DnD_4e.Mechanics;

namespace DnD_4e.Build.Items
{
	public abstract class RangedWeapon : WeaponBase
	{
		public abstract int LongRange
		{ get; }

		public int ShortRange
		{
			get
			{
				return LongRange / 2;
			}
		}

		public abstract ActionType Load
		{ get; }

		public override bool IsRanged
		{
			get
			{
				return true;
			}
		}
	}
}
