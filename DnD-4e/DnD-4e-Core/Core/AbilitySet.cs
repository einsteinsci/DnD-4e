using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD_4e.Core
{
	public enum AbilityScoreType
	{
		Str, Con,
		Dex, Int,
		Wis, Cha
	}

	public class AbilitySet
	{
		public int Str
		{ get; set; }
		public int Con
		{ get; set; }

		public int Dex
		{ get; set; }
		public int Int
		{ get; set; }

		public int Wis
		{ get; set; }
		public int Cha
		{ get; set; }

		public AbilitySet() : this(0, 0, 0, 0, 0, 0)
		{ }
		public AbilitySet(int str, int con, int dex, int _int, int wis, int cha)
		{
			Str = str;
			Con = con;
			Dex = dex;
			Int = _int;
			Wis = wis;
			Cha = cha;
		}

		public int ACStat()
		{
			return Math.Max(Dex, Int);
		}

		public int FortStat()
		{
			return Math.Max(Str, Con);
		}

		public int RefStat()
		{
			return Math.Max(Dex, Int);
		}

		public int WillStat()
		{
			return Math.Max(Wis, Cha);
		}

		#region OPERATORS

		public static bool operator==(AbilitySet a, AbilitySet b)
		{
			return a.Equals(b);
		}
		public static bool operator!=(AbilitySet a, AbilitySet b)
		{
			return !a.Equals(b);
		}

		public static AbilitySet operator+(AbilitySet a, AbilitySet b)
		{
			return new AbilitySet(a.Str + b.Str, a.Con + b.Con,
				a.Dex + b.Dex, a.Int + b.Int,
				a.Wis + b.Wis, a.Cha + b.Cha);
		}
		public static AbilitySet operator+(AbilitySet a, int b)
		{
			return new AbilitySet(a.Str + b, a.Con + b, a.Dex + b,
				a.Int + b, a.Wis + b, a.Cha + b);
		}
		public static AbilitySet operator-(AbilitySet a, AbilitySet b)
		{
			return new AbilitySet(a.Str - b.Str, a.Con - b.Con,
				a.Dex - b.Dex, a.Int - b.Int,
				a.Wis - b.Wis, a.Cha - b.Cha);
		}
		public static AbilitySet operator-(AbilitySet a, int b)
		{
			return new AbilitySet(a.Str - b, a.Con - b, a.Dex - b,
				a.Int - b, a.Wis - b, a.Cha - b);
		}
		public static AbilitySet operator*(AbilitySet a, int b)
		{
			return new AbilitySet(a.Str * b, a.Con * b, a.Dex * b,
				a.Int * b, a.Wis * b, a.Cha * b);
		}
		public static AbilitySet operator/(AbilitySet a, int b)
		{
			return new AbilitySet(a.Str / b, a.Con / b, a.Dex / b,
				a.Int / b, a.Wis / b, a.Cha / b);
		}

		#endregion

		public override bool Equals(object obj)
		{
			if (obj is AbilitySet)
			{
				AbilitySet o = (AbilitySet)obj;
				return o.Str == Str && o.Con == Con &&
					o.Dex == Dex && o.Int == Int &&
					o.Wis == Wis && o.Wis == Wis;
			}

			return false;
		}
		public override int GetHashCode()
		{
			// one byte per score (max score value of 256)
			double res = (byte)Str << 8 * 5;
			res += (byte)Con << 8 * 4;
			res += (byte)Dex << 8 * 3;
			res += (byte)Int << 8 * 2;
			res += (byte)Wis << 8;
			res += (byte)Cha;	// byte cast needed to not step on other scores' toes

			return res.GetHashCode(); // overlap is possible, but highly unlikely
		}

		public override string ToString()
		{
			return "STR: " + Str + "\tCON: " + Con +
				"\nDEX: " + Dex + "\tINT: " + Int +
				"\nWIS: " + Wis + "\tCHA: " + Cha;
		}
	}
}
