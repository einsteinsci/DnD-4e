using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DnD_4e.Build.Powers;
using DnD_4e.Core.Modifiers;
using DnD_4e.Entities;
using DnD_4e.Mechanics;

namespace DnD_4e.Events.Powers
{
	public class DamageRollEventArgs : PlayerEventArgs
	{
		public List<Entity> Targeted
		{ get; private set; }

		public IntModifier Bonus
		{ get; private set; }

		public DieSetup? DieSetup
		{ get; private set; }

		public IPower Power
		{ get; private set; }

		public DamageRollEventArgs(PlayerCharacter pc, List<Entity> allies, List<Entity> enemies, 
			List<Entity> targeted, IntModifier bonus, DieSetup? setup, IPower power) : base(pc, allies, enemies)
		{
			Targeted = targeted;
			Bonus = bonus;
			DieSetup = setup;
			Power = power;
		}
	}
}
