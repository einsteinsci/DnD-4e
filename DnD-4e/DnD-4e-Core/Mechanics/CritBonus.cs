using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DnD_4e.Powers;

namespace DnD_4e.Mechanics
{
	public struct CritBonus
	{
		public DmgType Type
		{ get; set; }

		public DieSetup Dice
		{ get; set; }

		public CritBonus(DieSetup dice) : this(DmgType.Physical, dice)
		{ }
		public CritBonus(DmgType type, DieSetup dice)
		{
			Type = type;
			Dice = dice;
		}
	}
}
