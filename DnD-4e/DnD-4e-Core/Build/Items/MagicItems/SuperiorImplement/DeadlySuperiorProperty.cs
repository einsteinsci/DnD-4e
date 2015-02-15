using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DnD_4e.Events;

namespace DnD_4e.Build.Items.MagicItems.SuperiorImplement
{
	public class DeadlySuperiorProperty : SuperiorImplementPropertyBase
	{
		public const string DEADLY_MOD = "superior.deadly";

		public override string Name
		{
			get
			{
				return "Deadly";
			}
		}

		public override void OnLoadEquip(PlayerEventArgs e)
		{
			e.Player.ImplementDamage[Owner].Modifiers.Add(DEADLY_MOD, Owner.BonusTier); // +1 per tier
		}

		public override void OnUnequip(PlayerEventArgs e)
		{
			e.Player.ImplementDamage[Owner].Modifiers.Remove(DEADLY_MOD);
		}
	}
}
