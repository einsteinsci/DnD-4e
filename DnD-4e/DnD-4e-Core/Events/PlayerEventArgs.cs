using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DnD_4e.Entities;

namespace DnD_4e.Events
{
	public class PlayerEventArgs
	{
		public PlayerCharacter Player
		{ get; private set; }

		public List<Entity> Allies
		{ get; private set; }

		public List<Entity> Enemies
		{ get; private set; }

		public PlayerEventArgs(PlayerCharacter pc, List<Entity> allies, List<Entity> enemies)
		{
			Player = pc;
			Allies = allies;
			Enemies = enemies;
		}
	}
}
