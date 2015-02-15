using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DnD_4e.Build.Classes;
using DnD_4e.Build.Epic;
using DnD_4e.Build.Feats;
using DnD_4e.Build.Paragon;
using DnD_4e.Build.Races;
using DnD_4e.Build.Rituals;
using DnD_4e.Build.Powers;

using DnD_4e.Core.Modifiers;

using DnD_4e.Util;
using DnD_4e.Events;
using DnD_4e.Build.Items;
using DnD_4e.Build.Items.MagicItems;

namespace DnD_4e.Entities
{
	public enum Tier
	{
		Heroic = 0,
		Paragon,
		Epic
	}

	public sealed partial class PlayerCharacter : Creature
	{
		public string HumanPlayer
		{ get; set; }

		public IRace Race
		{ get; private set; }

		public IClass Class
		{ get; private set; }

		public IParagonPath ParagonPath
		{ get; set; }

		public IEpicDestiny EpicDestiny
		{ get; set; }

		public int Experience
		{ get; private set; }
		public bool CanLevelUp
		{
			get
			{
				return Experience >= PlayerUtil.RequiredXP()[Level + 1];
			}
		}

		public List<IFeat> Feats
		{ get; private set; }

		public List<WeaponBase> WeaponProficiencies
		{ get; private set; }

		public List<ArmorType> ArmorProficiencies
		{ get; private set; }
		
		public new PlayerStatus Status
		{ get; private set; }

		/// <summary>
		/// Anytime a weapon is added, a KVP must be added to attack and damage dictionaries
		/// </summary>
		public List<WeaponBase> Weapons
		{ get; private set; }
		public Dictionary<WeaponBase, IntModifier> WeaponAttacks
		{ get; private set; }
		public Dictionary<WeaponBase, IntModifier> WeaponDamage
		{ get; private set; }

		/// <summary>
		/// Anytime an implement is added, a KVP must be added to attack and damage dictionaries
		/// </summary>
		public List<MagicImplement> Implements
		{ get; private set; }
		public Dictionary<MagicImplement, IntModifier> ImplementAttacks
		{ get; private set; }
		public Dictionary<MagicImplement, IntModifier> ImplementDamage
		{ get; private set; }

		public ArmorBase Armor
		{ get; set; }

		public Dictionary<ItemSlot, SlottedItem> SlotItems
		{ get; private set; }
		public bool IsWearingShield
		{
			get
			{
				return SlotItems[ItemSlot.Arms] is MagicShield;
			}
		}

		public List<PowerBase> ItemPowers
		{ get; private set; }

		public IntModifier CarryingCapacityBuffer // Think Bag of Holding / Handy Haversack
		{ get; private set; }
		public int CarryingCapacityNormal
		{
			get
			{
				return Abilities.ResultNoTemp.Str * 10 + CarryingCapacityBuffer.Result;
			}
		}
		public int CarryingCapacityHeavy
		{
			get
			{
				return Abilities.ResultNoTemp.Str * 20 + CarryingCapacityBuffer.Result;
			}
		}
		public int CarryingCapacityMaximum
		{
			get
			{
				return Abilities.ResultNoTemp.Str * 50 + CarryingCapacityBuffer.Result;
			}
		}

		public List<IRitual> Rituals
		{ get; private set; }

#pragma warning	disable CS0067 // Yes, I know I haven't used these yet.
		public event PlayerEvent OnActionPointUsed;
		public event AttackedEvent OnDamageTaken;
		public event AttackedEvent OnBloodied;
		public event AttackedEvent OnDying;
		public event PlayerEvent OnDamageHealed;
		public event PlayerEvent OnHealingSurgeUsed;
		public event PlayerEvent OnInitiativeRolled;
		public event SkillUsedEvent OnSkillUsed;
		public event PreAttackRollEvent OnAttackRoll;
		public event PostAttackRollEvent OnAttackRollFinished;
		public event PreDamageRollEvent OnDamageRoll;
		public event PostDamageRollEvent OnDamageRollFinished;
		public event PlayerEvent OnCritScored;
#pragma warning restore CS0067

		// TODO: Stuff here
		public PlayerCharacter() : base()
		{
			Feats = new List<IFeat>();
			Weapons = new List<WeaponBase>();
			Implements = new List<MagicImplement>();
			WeaponProficiencies = new List<WeaponBase>();
			ArmorProficiencies = new List<ArmorType>();
			SlotItems = new Dictionary<ItemSlot, SlottedItem>();
			ItemPowers = new List<PowerBase>();
		}

		// As if the player put on the items, learned the powers, feats, etc. for the first time.
		public void PostInit()
		{
			// TODO: FEATS

			PlayerEventArgs e = new PlayerEventArgs(this, Allies, null);
			foreach (SlottedItem item in SlotItems.Values)
			{
				item.OnItemLoadEquip(e);
			}
			foreach (WeaponBase weapon in Weapons)
			{
				weapon.OnItemLoadEquip(e);
			}
			foreach (MagicImplement imp in Implements)
			{
				imp.OnItemLoadEquip(e);
			}

			// TODO: POWERS
		}
	}
}
