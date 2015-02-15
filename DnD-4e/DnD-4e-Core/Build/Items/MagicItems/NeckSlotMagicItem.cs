using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DnD_4e.Entities;
using DnD_4e.Events;
using DnD_4e.Util;

namespace DnD_4e.Build.Items.MagicItems
{
	public abstract class NeckSlotMagicItem : SlottedItem
	{
		public const string NECKSLOT_MODIFIER = "item.neckslot.defenses";

		public override ItemSlot Slot
		{
			get
			{
				return ItemSlot.Neck;
			}
		}

		public override void OnItemLoadEquip(PlayerEventArgs e)
		{
			// There should never be more than one, so just set to the last one in case of overlap.
			e.Player.Fortitude.Modifiers.AddSet(NECKSLOT_MODIFIER, BonusHalfTier);
			e.Player.Reflex.Modifiers.AddSet(NECKSLOT_MODIFIER, BonusHalfTier);
			e.Player.Will.Modifiers.AddSet(NECKSLOT_MODIFIER, BonusHalfTier);
		}

		public override void OnItemUnequip(PlayerEventArgs e)
		{
			e.Player.Fortitude.Modifiers.Remove(NECKSLOT_MODIFIER);
			e.Player.Reflex.Modifiers.Remove(NECKSLOT_MODIFIER);
			e.Player.Will.Modifiers.Remove(NECKSLOT_MODIFIER);
		}
	}
}
