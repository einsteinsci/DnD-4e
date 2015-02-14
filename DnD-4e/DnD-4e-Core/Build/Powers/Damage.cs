using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD_4e.Powers
{
	public enum DmgType
	{
		Physical = 0,
		Acid,
		Cold,
		Fire,
		Force,
		Lightning,
		Necrotic,
		Poison,
		Psychic,
		Radiant,
		Thunder
	}

	public struct Damage
	{
		public int Amount
		{ get; set; }

		public DmgType[] Types
		{ get; set; }

		public Damage(int amount) : this(amount, DmgType.Physical)
		{ }

		public Damage(int amount, params DmgType[] types)
		{
			Amount = amount;
			Types = types;
		}

		public override string ToString()
		{
			return Amount.ToString() + " " + Types.ToString().ToLower() + " damage";
		}
	}
}
