using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DnD_4e.Entities;
using DnD_4e.Mechanics;

namespace DnD_4e.Events
{
	public class SaveEffectArgs : PlayerEventArgs
	{
		public IStatusEffect SavedEffect
		{ get; private set; }

		public SaveEffectArgs(PlayerCharacter pc, List<Creature> allies, List<Creature> enemies,
			IStatusEffect effect) : base(pc, allies, enemies)
		{
			SavedEffect = effect;
		}
	}
}
