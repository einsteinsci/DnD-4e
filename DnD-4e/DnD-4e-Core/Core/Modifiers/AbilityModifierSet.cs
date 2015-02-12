using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD_4e.Core.Modifiers
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

		public IntModifier ModifierForScore(AbilityScoreType score)
		{
			IntModifier res = new IntModifier(Base[score]);
			foreach (KeyValuePair<string, AbilitySet> pair in Modifiers)
			{
				string key = pair.Key;
				AbilitySet set = pair.Value;

				if (set[score] != 0)
				{
					res.Modifiers.Add(key, set[score]);
				}
			}

			return res;
		}
	}
}
