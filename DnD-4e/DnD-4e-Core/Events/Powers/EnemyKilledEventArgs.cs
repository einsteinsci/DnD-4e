using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DnD_4e.Entities;
using DnD_4e.Powers;

namespace DnD_4e.Events.Powers
{
	public class EnemyKilledEventArgs : PlayerEventArgs
	{
		public Creature Killed
		{ get; private set; }

		public Damage KillingDamage
		{ get; private set; }

		public EnemyKilledEventArgs(PlayerCharacter pc, List<Creature> allies, List<Creature> enemies, 
			Creature killed, Damage killingBlow) : base(pc, allies, enemies)
		{
			Killed = killed;
			KillingDamage = killingBlow;
		}
	}
}
