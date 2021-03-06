﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DnD_4e.Build.Powers;
using DnD_4e.Entities;
using DnD_4e.Events;
using DnD_4e.Lore;

namespace DnD_4e.Build.Items.MagicItems
{
	public abstract class MagicItem : IItem
	{
		public abstract string MagicItemName
		{ get; }

		public abstract int MinimumLevel
		{ get; }

		public abstract string Name
		{ get; }

		public List<PowerBase> Powers
		{ get; private set; }

		public abstract Cash Price
		{ get; }

		public abstract int Weight
		{ get; }

		public int Level
		{ get; set; }
		public int BonusTier
		{
			get
			{
				return BonusByTier(Level);
            }
		}
		public int BonusHalfTier
		{
			get
			{
				return BonusByHalfTier(Level);
			}
		}

		public MagicItem()
		{
			Powers = new List<PowerBase>();
		}

		public static int BonusByTier(int level)
		{
			return ((level - 1) / 10) + 1;
		}
		public static int BonusByTier(Tier tier)
		{
			switch (tier)
			{
			case Tier.Heroic:
				return 1;
			case Tier.Paragon:
				return 2;
			case Tier.Epic:
				return 3;
			default:
				throw new ArgumentOutOfRangeException("Not a valid tier: " + tier.ToString());
			}
		}
		public static int BonusByHalfTier(int level)
		{
			return ((level - 1) / 5) + 1;
		}

		public abstract void OnItemLoadEquip(PlayerEventArgs e);
		public abstract void OnItemUnequip(PlayerEventArgs e);
	}
}
