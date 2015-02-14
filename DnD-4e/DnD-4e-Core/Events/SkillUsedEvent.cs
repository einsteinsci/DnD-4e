using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DnD_4e.Core.Skills;
using DnD_4e.Entities;

namespace DnD_4e.Events
{
	public class SkillUsedEventArgs : PlayerEventArgs
	{
		public SkillType SkillUsed
		{ get; private set; }

		public SkillUsedEventArgs(PlayerCharacter pc, List<Creature> allies, List<Creature> enemies,
			SkillType skill) : base(pc, allies, enemies)
		{
			SkillUsed = skill;
		}
	}
}
