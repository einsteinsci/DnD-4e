using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD_4e.Events
{
	public class PostAttackRollEventArgs : AttackRollEventArgs
	{
		public int RollResult
		{ get; private set; }

		public bool Hit
		{ get; private set; }
	}
}
