using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD_4e.Core.Skills
{
	public enum SkillType
	{
		Acrobatics = 0,
		Arcana,
		Athletics,
		Bluff,
		Diplomacy,
		Dungeoneering,
		Endurance,
		Heal,
		History,
		Insight,
		Intimidate,
		Nature,
		Perception,
		Religion,
		Stealth,
		Streetwise,
		Thievery
	}

	/// <summary>
	/// Possibly deprecated
	/// </summary>
	public class Skill
	{
		public const int TRAINING_AMOUNT = 5;
		public const string TRAINING_KEY = "training";

		public string Name
		{ get; private set; }

		public SkillType Type
		{ get; private set; }

		public AbilityScoreType Ability
		{ get; private set; }

		protected Skill(string name, SkillType type, AbilityScoreType ability)
		{
			Name = name;
			Type = type;
			Ability = ability;
		}

		#region Skills
		public Skill Acrobatics
		{
			get
			{
				return new Skill("Acrobatics", SkillType.Acrobatics, AbilityScoreType.Dex);
			}
		}
		public Skill Arcana
		{
			get
			{
				return new Skill("Arcana", SkillType.Arcana, AbilityScoreType.Int);
			}
		}
		public Skill Athletics
		{
			get
			{
				return new Skill("Athletics", SkillType.Athletics, AbilityScoreType.Str);
			}
		}
		public Skill Bluff
		{
			get
			{
				return new Skill("Bluff", SkillType.Bluff, AbilityScoreType.Cha);
			}
		}
		public Skill Diplomacy
		{
			get
			{
				return new Skill("Diplomacy", SkillType.Diplomacy, AbilityScoreType.Cha);
			}
		}
		public Skill Dungeoneering
		{
			get
			{
				return new Skill("Dungeoneering", SkillType.Dungeoneering, AbilityScoreType.Wis);
			}
		}
		public Skill Endurance
		{
			get
			{
				return new Skill("Endurance", SkillType.Endurance, AbilityScoreType.Con);
			}
		}
		public Skill Heal
		{
			get
			{
				return new Skill("Heal", SkillType.Heal, AbilityScoreType.Wis);
			}
		}
		public Skill History
		{
			get
			{
				return new Skill("History", SkillType.History, AbilityScoreType.Int);
			}
		}
		public Skill Insight
		{
			get
			{
				return new Skill("Insight", SkillType.Insight, AbilityScoreType.Wis);
			}
		}
		public Skill Intimidate
		{
			get
			{
				return new Skill("Intimidate", SkillType.Intimidate, AbilityScoreType.Cha);
			}
		}
		public Skill Nature
		{
			get
			{
				return new Skill("Nature", SkillType.Nature, AbilityScoreType.Wis);
			}
		}
		public Skill Perception
		{
			get
			{
				return new Skill("Perception", SkillType.Perception, AbilityScoreType.Wis);
			}
		}
		public Skill Religion
		{
			get
			{
				return new Skill("Religion", SkillType.Religion, AbilityScoreType.Int);
			}
		}
		public Skill Stealth
		{
			get
			{
				return new Skill("Stealth", SkillType.Stealth, AbilityScoreType.Dex);
			}
		}
		public Skill Streetwise
		{
			get
			{
				return new Skill("Streetwise", SkillType.Streetwise, AbilityScoreType.Cha);
			}
		}
		public Skill Thievery
		{
			get
			{
				return new Skill("Thievery", SkillType.Thievery, AbilityScoreType.Dex);
			}
		}
		#endregion
	}
}
