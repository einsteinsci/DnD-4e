using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DnD_4e.Mechanics;
using DnD_4e.Build.Items.MagicItems;
using DnD_4e.Events;
using DnD_4e.Util;

namespace DnD_4e.Build.Items
{
	public abstract class MeleeWeapon : WeaponBase
	{
		public const string DEFENSIVE_MODIFIER = "item.weapon.defensive";

		public abstract bool OffHand
		{ get; }

		public abstract bool Versatile // two-handed for small pc's
		{ get; }

		public abstract bool Reach
		{ get; }

		public abstract bool HighCrit
		{ get; }

		public abstract int Brutal
		{ get; }

		public abstract bool Defensive
		{ get; }

		public List<CritBonus> GetCritBonuses(int playerLevel)
		{
			List<CritBonus> crits = new List<CritBonus>();
			if (HighCrit)
			{
				int diceCount = DamageRoll.Count * MagicItem.BonusByTier(playerLevel);
                crits.Add(new CritBonus(new DieSetup(DamageRoll.Type, diceCount)));
			}

			if (Enchantment != null)
			{
				crits.Add(Enchantment.CritBonus);
			}

			return crits;
		}

		public override void OnItemLoad(PlayerEventArgs e)
		{
			if (Defensive)
			{
				// Only one Defensive modifier per player
				e.Player.ArmorClass.Modifiers.AddSet(DEFENSIVE_MODIFIER, 1);
			}
		}

		public override void OnItemUnload(PlayerEventArgs e)
		{
			if (Defensive)
			{
				e.Player.ArmorClass.Modifiers.Remove(DEFENSIVE_MODIFIER);
			}
		}
	}
}
