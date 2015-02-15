using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DnD_4e.Events;

namespace DnD_4e.Build.Items.MagicItems.SuperiorImplement
{
	public class AccurateSuperiorProperty : SuperiorImplementPropertyBase
	{
		public const string ACCURACY_MOD = "superior.accurate";

		public static int Bonus
		{
			get
			{
				return HouseRules.AccurateImplementsPlus2 ? 2 : 1;
            }
		}

		public override string Name
		{
			get
			{
				return "Accurate";
			}
		}

		public override void OnLoadEquip(PlayerEventArgs e)
		{
			e.Player.ImplementAttacks[Owner].Modifiers.Add(ACCURACY_MOD, Bonus);
		}

		public override void OnUnequip(PlayerEventArgs e)
		{
			e.Player.ImplementAttacks[Owner].Modifiers.Remove(ACCURACY_MOD);
		}
	}
}
