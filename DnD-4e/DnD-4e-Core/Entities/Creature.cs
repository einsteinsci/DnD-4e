using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DnD_4e.Build.Powers;
using DnD_4e.Core;
using DnD_4e.Core.Modifiers;
using DnD_4e.Core.Skills;
using DnD_4e.Lore;
using DnD_4e.Mechanics;
using DnD_4e.Util;

namespace DnD_4e.Entities
{
    public abstract partial class Creature
	{
		public virtual string Name
		{ get; set; }

		public int Level
		{ get; private set; }
		public Tier Tier
		{
			get
			{
				return (Tier)((Level - 1) / 10);
			}
		}

		public abstract EntitySize Size
		{ get; }
		public int Reach
		{
			get
			{
				return Size.Reach();
			}
		}

		public AbilityModifierSet Abilities
		{ get; set; }

		public IntModifier ArmorClass
		{ get; private set; }

		public IntModifier Fortitude
		{ get; private set; }
		public IntModifier Reflex
		{ get; private set; }
		public IntModifier Will
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

		public Dictionary<string, IStatusEffect> Immunities	// of course temp immunities too
		{ get; private set; }

		public virtual CreatureStatus Status
		{ get; private set; }

		public List<PowerBase> Powers
		{ get; private set; }

		public List<Creature> Allies
		{ get; private set; }

		public List<Languages> Languages
		{ get; private set; }

		public Creature()
		{
			Abilities = new AbilityModifierSet(new AbilitySet());

			ArmorClass = new IntModifier(0);
			Fortitude = new IntModifier(0);
			Reflex = new IntModifier(0);
			Will = new IntModifier(0);

			Skills = new SkillSet(Abilities);

			Speed = new IntModifier(0);
			Initiative = new IntModifier(0);
			PassivePerception = new IntModifier(Skills[SkillType.Perception].Result);
			PassiveInsight = new IntModifier(Skills[SkillType.Insight].Result);

			MaxHitPoints = new IntModifier(0);
			MaxHealingSurges = new IntModifier(0);

			Resistances = new Dictionary<string, Resistance>();
			Vulnerabilities = new Dictionary<string, Resistance>();
			Immunities = new Dictionary<string, IStatusEffect>();
		}
	}
}
