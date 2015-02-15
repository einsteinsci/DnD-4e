using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DnD_4e.Events;

namespace DnD_4e.Build.Items.MagicItems.SuperiorImplement
{
	public abstract class SuperiorImplementPropertyBase
	{
		public MagicImplement Owner
		{ get; set; }

		public abstract string Name
		{ get; }

		public abstract void OnLoadEquip(PlayerEventArgs e);
		public abstract void OnUnequip(PlayerEventArgs e);
	}
}
