using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DnD_4e.Core.Modifiers;

namespace DnD_4e.Mechanics
{
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
		public static int Roll(DieSetup setup)
		{
			int total = 0;
			for (int i = 0; i < setup.Count; i++)
			{
				total += Roll(setup.Type);
			}
			return total;
		}
		public static int Roll(DieSetup setup, int bonus)
		{
			return Roll(setup) + bonus;
		}
		public static int Roll(DieSetup setup, IntModifier mod)
		{
			return Roll(setup, mod.Result);
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

		public static bool Beat(DieType type, int bonus, int valueToBeat)
		{
			return Beat(type, 1, bonus, valueToBeat);
		}
		public static bool Beat(DieType type, int count, int bonus, int valueToBeat)
		{
			return Roll(type, count, bonus) >= valueToBeat;
		}
		public static bool Beat(DieType type, int count, IntModifier mod, int valueToBeat)
		{
			return Beat(type, count, mod.Result, valueToBeat);
		}
	}
}
