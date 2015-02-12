using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DnD_4e.Entities;

namespace DnD_4e.Events
{
	public class AttackRollEventArgs : PlayerEventArgs
	{
		public List<Entity> Targeted
		{ get; private set; }
	}
}
