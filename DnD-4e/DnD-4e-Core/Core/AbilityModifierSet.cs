using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD_4e.Core
{
	public class AbilityModifierSet : ModifierBase<AbilitySet>
	{
		public override AbilitySet Result
		{
			get
			{
				return Base + Modifiers.Values.Aggregate((sum, set) => sum + set);
			}
		}

		public AbilityModifierSet(AbilitySet set) : base(set)
		{ }
	}
}
