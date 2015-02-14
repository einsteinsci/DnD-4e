using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DnD_4e.Build.Powers;
using DnD_4e.Events;
using DnD_4e.Lore;

namespace DnD_4e.Build.Items.MagicItem
{
	public abstract class MagicItem : IItem
	{
		public abstract string MagicItemName
		{ get; }

		public abstract int MinimumLevel
		{ get; }

		public abstract string Name
		{ get; }

		public abstract List<IPower> Powers
		{ get; }

		public abstract Cash Price
		{ get; }

		public abstract int Weight
		{ get; }

		public abstract void OnItemLoaded(PlayerEventArgs e);
		public abstract void OnItemRemoved(PlayerEventArgs e);
	}
}
