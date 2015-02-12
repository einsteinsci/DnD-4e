using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DnD_4e.Build.Classes;
using DnD_4e.Build.Epic;
using DnD_4e.Build.Feats;
using DnD_4e.Build.Paragon;
using DnD_4e.Build.Races;
using DnD_4e.Build.Rituals;
using DnD_4e.Build.Powers;

using DnD_4e.Core.Modifiers;
using DnD_4e.Core.Skills;

using DnD_4e.Lore;
using DnD_4e.Util;
using DnD_4e.Events;

namespace DnD_4e.Entities
{
	public enum Tier
	{
		Heroic = 0,
		Paragon,
		Epic
	}

	public sealed class PlayerCharacter
	{
		public string Name
		{ get; set; }

		public string Player
		{ get; set; }

		public IRace Race
		{ get; private set; }

		public IClass Class
		{ get; private set; }

		public IParagonPath ParagonPath
		{ get; private set; }

		public IEpicDestiny EpicDestiny
		{ get; private set; }

		public int Level
		{ get; private set; }
		public Tier Tier
		{
			get
			{
				return (Tier)((Level - 1)/ 10);
			}
		}

		public int Experience
		{ get; private set; }
		public bool CanLevelUp
		{
			get
			{
				return Experience >= PlayerUtil.RequiredXP()[Level + 1];
			}
		}

		public IntModifier ArmorClass
		{ get; private set; }

		public IntModifier Fortitude
		{ get; private set; }
		public IntModifier Reflex
		{ get; private set; }
		public IntModifier Will
		{ get; private set; }

		public AbilityModifierSet Abilities
		{ get; private set; }

		public Dictionary<int, IFeat> Feats
		{ get; private set; }

		public SkillSet Skills
		{ get; private set; }

		public IntModifier Speed
		{ get; private set; }

		public IntModifier Initiative
		{ get; private set; }

		public IntModifier PassivePerception
		{ get; private set; }
		public IntModifier PassiveInsight
		{ get; private set; }

		public IntModifier MaxHitPoints
		{ get; private set; }
		public int BloodiedValue
		{
			get
			{
				return MaxHitPoints.Result / 2;
			}
		}
		public int HealingSurgeValue
		{
			get
			{
				return BloodiedValue / 2;
			}
		}

		public IntModifier MaxHealingSurges
		{ get; private set; }
		
		public PlayerStatus Status
		{ get; private set; }

		public List<IPower> Powers
		{ get; private set; }

		public List<IPower> ItemPowers
		{ get; private set; }

		public List<Languages> Languages
		{ get; private set; }

		public int CarryingCapacityNormal
		{
			get
			{
				return Abilities.ResultNoTemp.Str * 10;
			}
		}
		public int CarryingCapacityHeavy
		{
			get
			{
				return Abilities.ResultNoTemp.Str * 20;
			}
		}
		public int CarryingCapacityMaximum
		{
			get
			{
				return Abilities.ResultNoTemp.Str * 50;
			}
		}

		public List<IRitual> Rituals
		{ get; private set; }

		public event PlayerEvent OnActionPointUsed;
		public event PlayerEvent OnDamageTaken;
		public event PlayerEvent OnDamageHealed;
	}
}
