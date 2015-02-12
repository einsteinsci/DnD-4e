using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD_4e.Core.Modifiers
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
		public override int ResultNoTemp
		{
			get
			{
				return Base + Modifiers.Aggregate(0, (total, kvp) =>
				{
					if (!IsModifierTemporary(kvp.Key))
					{
						return total + kvp.Value;
					}
					return total;
				});
			}
		}

		public IntModifier(int i) : base(i)
		{ }

		public override string ToString()
		{
			return "[Base: " + Base.ToString() + "] " + Modifiers.ToString();
		}
	}
}
