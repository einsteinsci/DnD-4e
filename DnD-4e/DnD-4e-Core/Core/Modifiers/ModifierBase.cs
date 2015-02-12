using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD_4e.Core.Modifiers
{
	public abstract class ModifierBase<T>
	{
		public const string TEMP_MODIFIER_PREFIX = "temp.";

		public T Base
		{ get; set; }

		public Dictionary<string, T> Modifiers
		{ get; set; }

		public abstract T Result
		{ get; }
		public abstract T ResultNoTemp
		{ get; }

		public ModifierBase(T baseVal)
		{
			Base = baseVal;
			Modifiers = new Dictionary<string, T>();
		}

		public static bool IsModifierTemporary(string key)
		{
			return key.StartsWith(TEMP_MODIFIER_PREFIX, StringComparison.CurrentCultureIgnoreCase);
		}
	}
}
