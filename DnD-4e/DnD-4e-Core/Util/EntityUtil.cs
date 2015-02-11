using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DnD_4e.Core;
using DnD_4e.Races;

namespace DnD_4e.Util
{
	public static class EntityUtil
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
	}
}
