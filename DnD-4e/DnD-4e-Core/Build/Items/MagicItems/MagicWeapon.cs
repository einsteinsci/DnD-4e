using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DnD_4e.Events;
using DnD_4e.Mechanics;

namespace DnD_4e.Build.Items.MagicItems
{
	public abstract class MagicWeapon : MagicItem
	{
		public abstract CritBonus CritBonus
		{ get; }

		public abstract List<WeaponGroup> ValidWeaponGroups
		{ get; }

		public abstract void OnAttack(PlayerEventArgs e);
	}
}
