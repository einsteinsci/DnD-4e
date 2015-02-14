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
using DnD_4e.Build.Items;
using DnD_4e.Powers;
using DnD_4e.Mechanics;

namespace DnD_4e.Entities
{
	public enum Tier
	{
		Heroic = 0,
		Paragon,
		Epic
	}

	public sealed partial class PlayerCharacter
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
		{ get; set; }

		public IEpicDestiny EpicDestiny
		{ get; set; }

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

		public Dictionary<string, Resistance> Resistances // yep, there are temp resistances
		{ get; private set; }

		public Dictionary<string, Resistance> Vulnerabilities // pretty much all of these will be temp
		{ get; private set; }

		public Dictionary<string, IStatusEffect> Immunities // of course temp immunities too
		{ get; private set; }
		
		public PlayerStatus Status
		{ get; private set; }

		public List<IPower> Powers
		{ get; private set; }

		public List<WeaponBase> Weapons
		{ get; private set; }

		public ArmorBase Armor
		{ get; set; }

		public List<IPower> ItemPowers
		{ get; private set; }

		public List<Languages> Languages
		{ get; private set; }

		public IntModifier CarryingCapacityBuffer // Think Bag of Holding / Handy Haversack
		{ get; private set; }
		public int CarryingCapacityNormal
		{
			get
			{
				return Abilities.ResultNoTemp.Str * 10 + CarryingCapacityBuffer.Result;
			}
		}
		public int CarryingCapacityHeavy
		{
			get
			{
				return Abilities.ResultNoTemp.Str * 20 + CarryingCapacityBuffer.Result;
			}
		}
		public int CarryingCapacityMaximum
		{
			get
			{
				return Abilities.ResultNoTemp.Str * 50 + CarryingCapacityBuffer.Result;
			}
		}

		public List<IRitual> Rituals
		{ get; private set; }

		public List<Creature> Allies
		{ get; private set; }

#pragma warning	disable CS0067 // Yes, I know I haven't used these yet.
		public event PlayerEvent OnActionPointUsed;
		public event AttackedEvent OnDamageTaken;
		public event AttackedEvent OnBloodied;
		public event AttackedEvent OnDying;
		public event PlayerEvent OnDamageHealed;
		public event PlayerEvent OnHealingSurgeUsed;
		public event PlayerEvent OnInitiativeRolled;
		public event SkillUsedEvent OnSkillUsed;
		public event PreAttackRollEvent OnAttackRoll;
		public event PostAttackRollEvent OnAttackRollFinished;
		public event PreDamageRollEvent OnDamageRoll;
		public event PostDamageRollEvent OnDamageRollFinished;
		public event PlayerEvent OnCritScored;
#pragma warning restore CS0067

		// TODO: Stuff here
		public PlayerCharacter()
		{

		}

		public void PostInit()
		{
			PlayerEventArgs e = new PlayerEventArgs(this, Allies, null);

		}
	}
}
