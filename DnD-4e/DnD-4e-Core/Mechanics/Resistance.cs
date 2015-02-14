using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DnD_4e.Powers;

namespace DnD_4e.Mechanics
{
	/// <summary>
	/// Separate from Damage as resistance/vulnerability never has more than one type.
	/// </summary>
	public struct Resistance
	{
		public DmgType Type
		{ get; set; }

		public int Amount
		{ get; set; }

		public Resistance(DmgType type, int amount)
		{
			Type = type;
			Amount = amount;
		}

		public override string ToString()
		{
			// not including "resist" as this is also for vulnerability
			return Amount.ToString() + " " + Type.ToString();
		}
	}
}
