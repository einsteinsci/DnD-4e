using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DnD_4e.Build.Items;
using DnD_4e.Entities;
using DnD_4e.Map;

namespace DnD_4e.Build.Powers.Targeting
{
	public enum MeleeReach
	{
		One,
		Touch,
		Weapon
	}

	public class MeleeTargeting : TargetingMode
	{
		public override TargetingModeIcon Icon
		{ 
			get
			{
				return TargetingModeIcon.Melee;
			}
		}

		public override bool ChooseTargets
		{
			get
			{
				return true;
			}
		}

		public MeleeReach Reach
		{ get; private set; }

		public bool IsBasicAttack
		{ get; private set; }

		public MeleeWeapon Weapon
		{ get; private set; }

		public override int MaxTargets
		{
			get
			{
				return _maxTargets;
			}
		}
		int _maxTargets;

		public MeleeTargeting(MeleeReach reach, int maxTargets, MeleeWeapon weapon)
		{
			Reach = reach;
			_maxTargets = maxTargets;
			Weapon = weapon;
		}
		public MeleeTargeting(MeleeReach reach, int maxTargets, MeleeWeapon weapon, bool basicAttack) :
			this(reach, maxTargets, weapon)
		{
			IsBasicAttack = basicAttack;
		}

		public override bool AreTargetsValid(IMapGrid map, Creature user, List<Creature> targets, GridSquare origin)
		{
			if (targets.Count > MaxTargets)
			{
				return false;
			}

			return true;
		}

		public override bool IsTargetValid(IMapGrid map, Creature user, Creature target, GridSquare origin)
		{
			switch (Reach)
			{
			case MeleeReach.One:
				return map.WalkingDistance(user, target) <= 1;
			case MeleeReach.Touch:
				return map.WalkingDistance(user, target) <= user.Reach;
			case MeleeReach.Weapon:
				return map.WalkingDistance(user, target) <= user.Reach + Weapon.ReachLength - 1;
			default:
				return false;
			}
		}
	}
}
