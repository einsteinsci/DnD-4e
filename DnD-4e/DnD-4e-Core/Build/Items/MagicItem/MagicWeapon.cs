using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DnD_4e.Events;

namespace DnD_4e.Build.Items.MagicItem
{
	public abstract class MagicWeapon : MagicItem
	{
		public abstract List<WeaponGroup> ValidWeaponGroups
		{ get; }

		public abstract void OnAttack(PlayerEventArgs e);
	}
}
