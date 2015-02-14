using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD_4e.Build.Items.MagicItems
{
	public enum ItemSlot
	{
		Misc,
		Head,
		Neck,
		Arms,
		Waist,
		RingLeft,
		RingRight,
		Armor,
		Feet
	}

	public abstract class SlottedItem : MagicItem
	{
		public abstract ItemSlot Slot
		{ get; }
	}
}
