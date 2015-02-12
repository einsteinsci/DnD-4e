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

		public DmgType Type
		{ get; set; }

		public Damage(int amount) : this(amount, DmgType.Physical)
		{ }

		public Damage(int amount, DmgType type)
		{
			Amount = amount;
			Type = type;
		}

		public override string ToString()
		{
			return Amount.ToString() + " " + Type.ToString().ToLower() + " damage";
		}
	}
}
