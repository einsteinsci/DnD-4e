﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DnD_4e.Entities;

namespace DnD_4e.Events
{
	public class AttackedEventArgs : PlayerEventArgs
	{
		public Creature Attacker
		{ get; private set; }

		public AttackedEventArgs(PlayerCharacter pc, List<Creature> allies, List<Creature> enemies, Creature attacker) :
			base(pc, allies, enemies)
		{
			Attacker = attacker;
		}
	}
}
