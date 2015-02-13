using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD_4e.Events
{
	public class PostDamageRollEventArgs : DamageRollEventArgs
	{
		public int ResultingRoll
		{ get; private set; }
	}
}
