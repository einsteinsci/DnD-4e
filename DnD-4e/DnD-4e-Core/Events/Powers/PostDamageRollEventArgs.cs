using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DnD_4e.Build.Powers;
using DnD_4e.Core.Modifiers;
using DnD_4e.Entities;
using DnD_4e.Mechanics;
using DnD_4e.Powers;

namespace DnD_4e.Events.Powers
{
	public class PostDamageRollEventArgs : DamageRollEventArgs
	{
		public int ResultingRoll
		{ get; private set; }

		public Damage DamageDealt
		{ get; private set; }

		public PostDamageRollEventArgs(PlayerCharacter pc, List<Creature> allies, List<Creature> enemies,
			List<Creature> targeted, IntModifier bonus, DieSetup? setup, PowerBase power, int result, 
			Damage damage) : base(pc, allies, enemies, targeted, bonus, setup, power) // this is getting ridiculous
		{

		}
	}
}
