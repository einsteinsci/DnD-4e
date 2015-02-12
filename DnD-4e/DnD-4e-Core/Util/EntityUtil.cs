using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DnD_4e.Mechanics;

namespace DnD_4e.Util
{
	public static class PlayerUtil
	{
		public static float SquaresTaken(this EntitySize size)
		{
			switch (size)
			{
			case EntitySize.Tiny:
				return 0.5f;
			case EntitySize.Small:
				return 1;
			case EntitySize.Medium:
				return 1;
			case EntitySize.Large:
				return 2;
			case EntitySize.Huge:
				return 3;
			case EntitySize.Gargantuan:
				return 4;
			default:
				return -1;
			}
		}

		public static int[] FeatLevels()
		{
			return new int[] {
				 1,  2,  4,  6,  8, 10,
				11, 12, 14, 16, 18, 20,
				21, 22, 24, 26, 28, 30
			};
		}

		public static int[] AbilityLevels()
		{
			return new int[] { 4, 8, 11, 14, 18, 21, 24, 28 };
		}

		public static Dictionary<int, int> RequiredXP()
		{
			Dictionary<int, int> res = new Dictionary<int, int>();

			res.Add(1, 0);
			res.Add(2, 1000);
			res.Add(3, 2250);
			res.Add(4, 3750);
			res.Add(5, 5500);
			res.Add(6, 7500);
			res.Add(7, 10000);
			res.Add(8, 13000);
			res.Add(9, 16500);
			res.Add(10, 20500);

			res.Add(11, 26000);
			res.Add(12, 32000);
			res.Add(13, 39000);
			res.Add(14, 47000);
			res.Add(15, 57000);
			res.Add(16, 69000);
			res.Add(17, 83000);
			res.Add(18, 99000);
			res.Add(19, 119000);
			res.Add(20, 143000);

			res.Add(21, 175000);
			res.Add(22, 210000);
			res.Add(23, 255000);
			res.Add(24, 310000);
			res.Add(25, 375000);
			res.Add(26, 450000);
			res.Add(27, 550000);
			res.Add(28, 675000);
			res.Add(29, 825000);
			res.Add(30, 1000000);

			return res;
		}
	}
}
