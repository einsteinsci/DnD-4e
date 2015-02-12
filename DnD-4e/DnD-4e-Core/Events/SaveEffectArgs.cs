using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DnD_4e.Mechanics;

namespace DnD_4e.Events
{
	public class SaveEffectArgs : PlayerEventArgs
	{
		public IStatusEffect savedEffect
		{ get; private set; }
	}
}
