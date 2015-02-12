using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DnD_4e.Core.Modifiers;

namespace DnD_4e.Core.Skills
{
	public sealed class SkillSet : IDictionary<SkillType, IntModifier>
	{
		public const int COUNT = 17;

		public AbilityModifierSet Abilities
		{ get; private set; }

		public IntModifier Acrobatics
		{ get; private set; }
		public IntModifier Arcana
		{ get; private set; }
		public IntModifier Athletics
		{ get; private set; }
		public IntModifier Bluff
		{ get; private set; }
		public IntModifier Diplomacy
		{ get; private set; }
		public IntModifier Dungeoneering
		{ get; private set; }
		public IntModifier Endurance
		{ get; private set; }
		public IntModifier Heal
		{ get; private set; }
		public IntModifier History
		{ get; private set; }
		public IntModifier Insight
		{ get; private set; }
		public IntModifier Intimidate
		{ get; private set; }
		public IntModifier Nature
		{ get; private set; }
		public IntModifier Perception
		{ get; private set; }
		public IntModifier Religion
		{ get; private set; }
		public IntModifier Stealth
		{ get; private set; }
		public IntModifier Streetwise
		{ get; private set; }
		public IntModifier Thievery
		{ get; private set; }

		public SkillSet(AbilityModifierSet abilities)
		{
			Abilities = abilities;
		}

		public void TrainSkill(SkillType type)
		{
			IntModifier mod = Get(type);
			if (!mod.Modifiers.ContainsKey(Skill.TRAINING_KEY))
			{
				mod.Modifiers.Add(Skill.TRAINING_KEY, Skill.TRAINING_AMOUNT);
			}
		}
		public void UntrainSkill(SkillType type)
		{
			IntModifier mod = Get(type);
			if (mod.Modifiers.ContainsKey(Skill.TRAINING_KEY))
			{
				mod.Modifiers.Remove(Skill.TRAINING_KEY);
			}
		}
		public bool IsTrained(SkillType type)
		{
			IntModifier mod = Get(type);
			return mod.Modifiers.ContainsKey(Skill.TRAINING_KEY);
		}

		public IntModifier Get(SkillType type)
		{
			return this[type];
		}

		#region IDictionary<TKey, TVal>

		/// <summary>
		/// Avoid setting if at all possible.
		/// </summary>
		/// <param name="key">SkillType to retrieve.</param>
		/// <returns>IntModifier for that skill</returns>
		public IntModifier this[SkillType key]
		{
			get
			{
				switch (key)
				{
				case SkillType.Acrobatics:
					return Acrobatics;
				case SkillType.Arcana:
					return Arcana;
				case SkillType.Athletics:
					return Athletics;
				case SkillType.Bluff:
					return Bluff;
				case SkillType.Diplomacy:
					return Diplomacy;
				case SkillType.Dungeoneering:
					return Dungeoneering;
				case SkillType.Endurance:
					return Endurance;
				case SkillType.Heal:
					return Heal;
				case SkillType.History:
					return History;
				case SkillType.Insight:
					return Insight;
				case SkillType.Intimidate:
					return Intimidate;
				case SkillType.Nature:
					return Nature;
				case SkillType.Perception:
					return Perception;
				case SkillType.Religion:
					return Religion;
				case SkillType.Stealth:
					return Stealth;
				case SkillType.Streetwise:
					return Streetwise;
				case SkillType.Thievery:
					return Thievery;
				default:
					return null;
				}
			}
			set
			{
				switch (key)
				{
				case SkillType.Acrobatics:
					Acrobatics = value;
					return;
				case SkillType.Arcana:
					Arcana = value;
					return;
				case SkillType.Athletics:
					Athletics = value;
					return;
				case SkillType.Bluff:
					Bluff = value;
					return;
				case SkillType.Diplomacy:
					Diplomacy = value;
					return;
				case SkillType.Dungeoneering:
					Dungeoneering = value;
					return;
				case SkillType.Endurance:
					Endurance = value;
					return;
				case SkillType.Heal:
					Heal = value;
					return;
				case SkillType.History:
					History = value;
					return;
				case SkillType.Insight:
					Insight = value;
					return;
				case SkillType.Intimidate:
					Intimidate = value;
					return;
				case SkillType.Nature:
					Nature = value;
					return;
				case SkillType.Perception:
					Perception = value;
					return;
				case SkillType.Religion:
					Religion = value;
					return;
				case SkillType.Stealth:
					Stealth = value;
					return;
				case SkillType.Streetwise:
					Streetwise = value;
					return;
				case SkillType.Thievery:
					Thievery = value;
					return;
				default:
					return;
				}
			}
		}

		/// <summary>
		/// "Seventeen, sir!"
		/// </summary>
		public int Count
		{
			get
			{
				return COUNT;
			}
		}

		public bool IsReadOnly
		{
			get
			{
				return false;
			}
		}

		public ICollection<SkillType> Keys
		{
			get
			{
				ICollection<SkillType> keys = new List<SkillType>();
				Array allTypes = Enum.GetValues(typeof(SkillType));
				foreach (SkillType type in allTypes.OfType<SkillType>())
				{
					keys.Add(type);
				}

				return keys;
			}
		}

		public ICollection<IntModifier> Values
		{
			get
			{
				ICollection<IntModifier> vals = new List<IntModifier>();
				Array allTypes = Enum.GetValues(typeof(SkillType));
				foreach (SkillType type in allTypes.OfType<SkillType>())
				{
					vals.Add(this[type]);
				}

				return vals;
			}
		}

		public void Add(KeyValuePair<SkillType, IntModifier> item)
		{
			throw new InvalidOperationException("New skill types cannot be added to a SkillSet instance.");
		}

		public void Add(SkillType key, IntModifier value)
		{
			throw new InvalidOperationException("New skill types cannot be added to a SkillSet instance.");
		}

		public void Clear()
		{
			throw new InvalidOperationException("Skill types cannot be removed from a SkillSet instance.");
		}

		public bool Contains(KeyValuePair<SkillType, IntModifier> item)
		{
			return ContainsKey(item.Key);
		}

		public bool ContainsKey(SkillType key)
		{
			return this[key] != null;
		}

		public void CopyTo(KeyValuePair<SkillType, IntModifier>[] array, int arrayIndex)
		{
			array = new KeyValuePair<SkillType, IntModifier>[COUNT];

			for (int i = arrayIndex; i < COUNT; i++)
			{
				array[i] = new KeyValuePair<SkillType, IntModifier>((SkillType)i, this[(SkillType)i]);
			}
		}

		public IEnumerator<KeyValuePair<SkillType, IntModifier>> GetEnumerator()
		{
			throw new NotImplementedException();
		}

		public bool Remove(KeyValuePair<SkillType, IntModifier> item)
		{
			throw new InvalidOperationException("Skill types cannot be removed from a SkillSet instance.");
		}

		public bool Remove(SkillType key)
		{
			throw new InvalidOperationException("Skill types cannot be removed from a SkillSet instance.");
		}

		public bool TryGetValue(SkillType key, out IntModifier value)
		{
			IntModifier buf = this[key];

			if (buf == null)
			{
				value = null;
				return false;
			}

			value = buf;
			return true;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			throw new NotImplementedException();
		}

		public class SkillEnumerator : IEnumerator<KeyValuePair<SkillType, IntModifier>>
		{
			int iterator;
			SkillSet set;

			public SkillEnumerator(SkillSet _set)
			{
				set = _set;
				iterator = -1;
			}

			public KeyValuePair<SkillType, IntModifier> Current
			{
				get
				{
					return new KeyValuePair<SkillType, IntModifier>((SkillType)iterator, set[(SkillType)iterator]);
				}
			}

			object IEnumerator.Current
			{
				get
				{
					return Current;
				}
			}

			public void Dispose()
			{ }

			public bool MoveNext()
			{
				iterator++;

				if (iterator >= COUNT)
				{
					iterator = COUNT - 1;
					return false;
				}

				return true;
			}

			public void Reset()
			{
				iterator = -1; // BEFORE the first element
			}
		}
		#endregion

		public override string ToString()
		{
			string res = "Trained in: ";
			foreach (SkillType type in Keys)
			{
				if (IsTrained(type))
				{
					res += type.ToString() + ", ";
				}
			}
			return res.TrimEnd(',');
		}
	}
}
