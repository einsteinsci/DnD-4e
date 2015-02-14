using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DnD_4e.Build.Items.MagicItems;
using DnD_4e.Events;
using DnD_4e.Lore;

namespace DnD_4e.Build.Items
{
	public abstract class MasterworkArmor : ArmorBase
	{
		public override Cash Price
		{
			get
			{
				return MagicItem.Price;
			}
		}

		public abstract void OnItemLoaded(PlayerEventArgs e);

		public MasterworkArmor(MagicArmor magicItem)
		{
			if (magicItem == null)
			{
				throw new ArgumentNullException("magicItem", "Masterwork armor cannot be mundane.");
			}

			MagicItem = magicItem;
		}
	}
}
