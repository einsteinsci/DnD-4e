using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
		d100 = 100 // pair of d10's. Very rarely used.
	}

	public struct DieSetup
	{
		/// <summary>
		/// Type of die to roll
		/// </summary>
		public DieType Type
		{ get; set; }

		/// <summary>
		/// Number of dice
		/// </summary>
		public int Count
		{ get; set; }

		/// <summary>
		/// Defines a new DieSetup of 1d20
		/// </summary>
		public DieSetup() : this(DieType.d20)
		{ }
		/// <summary>
		/// Defines a new DieSetup of 1[type]
		/// </summary>
		/// <param name="type">Die type</param>
		public DieSetup(DieType type) : this(type, 1)
		{ }
		/// <summary>
		/// Defines a new DieSetup of count[type]
		/// </summary>
		/// <param name="type">Die type</param>
		/// <param name="count">Number of dice</param>
		public DieSetup(DieType type, int count)
		{
			Type = type;
			Count = count;
		}

		public override string ToString()
		{
			return Count.ToString() + Type.ToString();
		}
	}
}
