using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DnD_4e.Entities;

namespace DnD_4e.Events
{
	public class AttackedEventArgs : PlayerEventArgs
	{
		public Entity Attacker
		{ get; private set; }

		public AttackedEventArgs(PlayerCharacter pc, List<Entity> allies, List<Entity> enemies, Entity attacker) :
			base(pc, allies, enemies)
		{
			Attacker = attacker;
		}
	}
}
