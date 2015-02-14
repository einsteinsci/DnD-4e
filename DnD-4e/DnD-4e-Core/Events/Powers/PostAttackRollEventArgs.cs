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
	public class PostAttackRollEventArgs : AttackRollEventArgs
	{
		public int RollResult
		{ get; private set; }

		public bool Hit
		{ get; private set; }

		public PostAttackRollEventArgs(PlayerCharacter pc, List<Entity> allies, List<Entity> enemies,
			Entity targeted, IntModifier bonus, IPower power, int rollResult, bool hit) : 
				base(pc, allies, enemies, targeted, bonus, power)
		{
			RollResult = rollResult;
			Hit = hit;
		}
	}
}
