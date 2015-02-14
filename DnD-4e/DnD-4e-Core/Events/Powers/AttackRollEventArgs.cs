using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DnD_4e.Build.Powers;
using DnD_4e.Core.Modifiers;
using DnD_4e.Entities;

namespace DnD_4e.Events.Powers
{
	public class AttackRollEventArgs : PlayerEventArgs
	{
		public Entity Targeted
		{ get; private set; }

		public IntModifier Bonus
		{ get; private set; }

		public IPower Power
		{ get; private set; }

		public AttackRollEventArgs(PlayerCharacter pc, List<Entity> allies, List<Entity> enemies, 
			Entity targeted, IntModifier bonus, IPower power) : base(pc, allies, enemies)
		{
			Targeted = targeted;
			Bonus = bonus;
			Power = power;
		}
	}
}
