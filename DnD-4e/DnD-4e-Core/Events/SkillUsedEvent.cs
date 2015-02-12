using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DnD_4e.Core.Skills;

namespace DnD_4e.Events
{
	public class SkillUsedEventArgs : PlayerEventArgs
	{
		public SkillType SkillUsed
		{ get; private set; }
	}
}
