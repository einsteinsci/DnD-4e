using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD_4e.Build.Items.MagicItems
{
	public abstract class ArmsSlotMagicItem : SlottedItem
	{
		public override ItemSlot Slot
		{
			get
			{
				return ItemSlot.Arms;
			}
		}
	}
}
