using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DnD_4e.Mechanics;

namespace DnD_4e.Entities
{
	public class PlayerStatus
	{
		public PlayerCharacter Player
		{ get; private set; }

		public int UsedHealingSurges
		{ get; set; }

		public int HitPoints
		{ get; set; }
		public int TemporaryHitPoints
		{ get; set; }

		public int UsedActionPoints
		{ get; set; }

		public int UsedItemDailies
		{ get; set; }

		public List<IStatusEffect> StatusEffects
		{ get; set; }
	}
}
