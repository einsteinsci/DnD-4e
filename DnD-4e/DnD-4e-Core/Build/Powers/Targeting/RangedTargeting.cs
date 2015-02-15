using DnD_4e.Build.Items;
using DnD_4e.Entities;
using DnD_4e.Map;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD_4e.Build.Powers.Targeting
{
	public enum RangedType
	{
		Weapon,
		Value
	}

	public class RangedTargeting : TargetingMode
	{
		public override TargetingModeIcon Icon
		{ 
			get
			{
				return TargetingModeIcon.Ranged;
			}
		}

		public RangedType RangeType
		{ get; private set; }

		public int? RangeValue
		{ get; private set; }

		public bool IsBasicAttack
		{ get; private set; }

		public RangedWeapon Weapon
		{ get; private set; }

		public override bool ChooseTargets
		{
			get
			{
				return true;
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

		public RangedTargeting(RangedWeapon weapon, int maxTargets, bool basicAttack) :
			this(weapon, maxTargets)
		{
			IsBasicAttack = basicAttack;
		}

		public RangedTargeting(RangedWeapon weapon, int maxTargets)
		{
			RangeType = RangedType.Weapon;
			RangeValue = null;
			Weapon = weapon;
			_maxTargets = maxTargets;
		}

		public RangedTargeting(int range, int maxTargets, bool basicAttack) :
			this(range, maxTargets)
		{
			IsBasicAttack = basicAttack;
		}

		public RangedTargeting(int range, int maxTargets)
		{
			RangeType = RangedType.Value;
			Weapon = null;
			RangeValue = range;
			_maxTargets = maxTargets;
		}

		public override bool AreTargetsValid(IMapGrid map, Creature user, List<Creature> targets, GridSquare origin)
		{
			if (targets.Count > MaxTargets)
			{
				return false;
			}

			// other stuff

			return true;
		}

		public override bool IsTargetValid(IMapGrid map, Creature user, Creature target, GridSquare origin)
		{
			bool los = map.LineOfSight(user, target);
			bool loe = map.LineOfEffect(user, target);

			if (!los || !loe)
			{
				return false;
			}

			switch (RangeType)
			{
			case RangedType.Weapon:
				return map.WalkingDistance(user, target) <= Weapon.LongRange;

			case RangedType.Value:
				return map.WalkingDistance(user, target) <= RangeValue.Value;

			default:
				return false;
			}
		}
	}
}