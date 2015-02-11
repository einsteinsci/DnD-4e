using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD_4e.Core
{
	public class IntModifier : ModifierBase<int>
	{
		public override int Result
		{
			get
			{
				return Base + Modifiers.Values.Aggregate((sum, i) => sum + i);
			}
		}

		public IntModifier(int i) : base(i)
		{ }
	}
}
