using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DnD_4e.Core;

namespace DnD_4e_Core.Core.Skills
{
	public enum SkillType
	{
		Acrobatics,
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

	public class Skill
	{
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
	}
}
