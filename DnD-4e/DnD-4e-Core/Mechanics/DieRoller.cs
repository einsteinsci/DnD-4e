using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DnD_4e.Core.Modifiers;

namespace DnD_4e.Mechanics
{
	public enum DieType
	{
		d4 = 4,
		d6 = 6,
		d8 = 8,
		d10 = 10,
		d12 = 12,
		d20 = 20,
		d100 = 100 // pair of d10's
	}

	public static class DieRoller
	{
		public const int CRIT = 20;

		public static Random Rand
		{ get; private set; }

		static bool initialized = false;

		public static void Init()
		{
			if (initialized)
			{
				return;
			}

			Rand = new Random();

			initialized = true;
		}

		public static int Roll(DieType type)
		{
			return Rand.Next((int)type) + 1;
		}
		public static int Roll(DieType type, int bonus)
		{
			return Roll(type) + bonus;
		}
		public static int Roll(DieType type, IntModifier mod)
		{
			return Roll(type, mod.Result);
		}

		public static int AttackRoll(int bonus, out bool crit)
		{
			int roll = Roll(DieType.d20);
			crit = (roll == CRIT);
			return roll + bonus;
		}
		public static int AttackRoll(IntModifier mod, out bool crit)
		{
			return AttackRoll(mod.Result, out crit);
		}

		public static bool Beat(DieType type, IntModifier mod, int valueToBeat)
		{
			return Roll(type, mod) >= valueToBeat;
		}
		public static bool Beat(DieType type, int bonus, int valueToBeat)
		{
			return Roll(type, bonus) >= valueToBeat;
		}
	}
}
