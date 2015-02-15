using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DnD_4e.Entities;
using DnD_4e.Map;

namespace DnD_4e.Build.Powers.Targeting
{
	public enum Targets
	{
		Personal,
		Creatures,
		YouAndAllies,
		Allies,
		Enemies,
	}

	public enum TargetingModeIcon
	{
		Melee,
		Ranged,
		Close,
		Area
	}

	public abstract class TargetingMode
	{
		public abstract TargetingModeIcon Icon
		{ get; }

		/// <summary>
		/// Maximum number of targets ("one or two creatures" = 2). Set to 0 for unlimited/all.
		/// </summary>
		public abstract int MaxTargets
		{ get; }
		 
		public abstract bool ChooseTargets
		{ get; }

		public abstract bool IsTargetValid(IMapGrid map, Creature user, Creature target, GridSquare origin);
		public abstract bool AreTargetsValid(IMapGrid map, Creature user, List<Creature> targets, GridSquare origin);
	}
}
