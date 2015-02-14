using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DnD_4e.Entities;

namespace DnD_4e.Events
{
	public class PlayerEventArgs : EventArgs
	{
		public PlayerCharacter Player
		{ get; private set; }

		public List<Creature> Allies
		{ get; private set; }

		public List<Creature> Enemies
		{ get; private set; }

		public bool Cancelled
		{ get; private set; }

		public PlayerEventArgs(PlayerCharacter pc, List<Creature> allies, List<Creature> enemies)
		{
			Player = pc;
			Allies = allies;
			Enemies = enemies;
			Cancelled = false;
		}

		public void Cancel()
		{
			Cancelled = true;
		}
	}
}
