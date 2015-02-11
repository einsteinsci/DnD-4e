using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD_4e.Core
{
	public abstract class ModifierBase<T>
	{
		public T Base
		{ get; set; }

		public Dictionary<string, T> Modifiers
		{ get; set; }

		public abstract T Result
		{ get; }

		public ModifierBase(T baseVal)
		{
			Base = baseVal;
			Modifiers = new Dictionary<string, T>();
		}
	}
}
