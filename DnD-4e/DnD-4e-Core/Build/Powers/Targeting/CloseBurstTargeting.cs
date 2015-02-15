using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DnD_4e.Entities;
using DnD_4e.Map;

namespace DnD_4e.Build.Powers.Targeting
{
	public class CloseBurstTargeting : TargetingMode
	{
		public override bool ChooseTargets
		{
			get
			{
				return false;
			}
		}

		public override TargetingModeIcon Icon
		{
			get
			{
				return TargetingModeIcon.Close;
			}
		}

		public override int MaxTargets
		{
			get
			{
				return _maxTargets;
			}
		}

		private int _maxTargets;

		public int BurstSize
		{
			get;
			private set;
		}

		public override bool AreTargetsValid(IMapGrid map, Creature user, List<Creature> targets)
		{
			return true;
		}

		public override bool IsTargetValid(IMapGrid map, Creature user, Creature target)
		{
			return map.WalkingDistance(user, target) <= BurstSize;
		}

		public CloseBurstTargeting(int maxTargets, int size) :
			this(size)
		{
			_maxTargets = maxTargets;
		}

		public CloseBurstTargeting(int size)
		{
			BurstSize = size;
		}
	}
}