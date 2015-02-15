using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD_4e
{
	public static class HouseRules
	{
		public static string RulesSetupName
		{ get; set; }

		/// <summary>
		/// If true, Accurate Superior implements provide a +2 bonus instead of a +1.
		/// </summary>
		public static bool AccurateImplementsPlus2
		{ get; set; }
	}
}
