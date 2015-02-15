using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DnD_4e.Events;
using DnD_4e.Mechanics;
using DnD_4e.Powers;

namespace DnD_4e.Entities
{
	public partial class Creature
	{
		public class CreatureStatus
		{
			public Creature Creature
			{ get; private set; }

			public List<Creature> Enemies
			{ get; private set; }

			public int UsedHealingSurges
			{ get; set; }

			public int HitPoints
			{ get; set; }
			public int TemporaryHitPoints
			{ get; set; }
			public bool Bloodied
			{
				get
				{
					return HitPoints < Creature.BloodiedValue;
				}
			}
			public bool Dying
			{
				get
				{
					return HitPoints <= 0 && !KO;
				}
			}

			/// <summary>
			/// Set to true when someone chooses to knock the creature out but not put them in the "dying" state.
			/// </summary>
			public bool KO
			{ get; set; }

			public int ActionPointsLeft
			{ get; set; }

			public List<IStatusEffect> StatusEffects
			{ get; set; }

			public CreatureStatus(Creature creature)
			{
				Creature = creature;
			}

			public void ApplyDamage(Damage dmg, Creature attacker)
			{
				ApplyDamage(dmg, 1.0f, attacker);
			}
			public void ApplyDamage(Damage dmg, float mult, Creature attacker)
			{
				ApplyDamage(dmg, mult, attacker, false);
			}
			public virtual void ApplyDamage(Damage damage, float damageMultiplier, Creature attacker, bool ko)
			{
				int hpLoss = damage.Amount;

				#region RESISTANCE
				List<DmgType> resistanceTypes = new List<DmgType>();
				foreach (Resistance r in Creature.Resistances.Values)
				{
					resistanceTypes.Add(r.Type);
				}

				bool hasResistanceToAll = true;
				foreach (DmgType dt in damage.Types)
				{
					if (!resistanceTypes.Contains(dt))
					{
						hasResistanceToAll = false;
						break;
					}
				}
				if (hasResistanceToAll)
				{
					Resistance? weakest = null;
					foreach (Resistance r in Creature.Resistances.Values)
					{
						if (damage.Types.Contains(r.Type))
						{
							if (weakest == null || r.Amount < weakest.Value.Amount)
							{
								weakest = r;
							}
						}
					}

					if (weakest != null) // always true
					{
						hpLoss -= weakest.Value.Amount;
					}
				}
				#endregion

				#region VULNERABILITY
				List<DmgType> vulnTypes = new List<DmgType>();
				foreach (Resistance v in Creature.Vulnerabilities.Values)
				{
					vulnTypes.Add(v.Type);
				}

				bool hasVulnerabilityToAny = false;
				foreach (DmgType dt in damage.Types)
				{
					if (vulnTypes.Contains(dt))
					{
						hasVulnerabilityToAny = true;
						break;
					}
				}

				if (hasVulnerabilityToAny)
				{
					Resistance? strongest = null;
					foreach (Resistance v in Creature.Vulnerabilities.Values)
					{
						if (damage.Types.Contains(v.Type))
						{
							if (strongest == null || v.Amount > strongest.Value.Amount)
							{
								strongest = v;
							}
						}
					}

					if (strongest != null) // always true;
					{
						hpLoss += strongest.Value.Amount;
					}
				}
				#endregion

				hpLoss = Math.Max(0, hpLoss);

				hpLoss = (int)((float)hpLoss * damageMultiplier);

				TemporaryHitPoints -= hpLoss;

				bool bloodiedAlready = Bloodied;
				bool dyingAlready = Dying || KO;

				if (TemporaryHitPoints < 0)
				{
					hpLoss = -TemporaryHitPoints;
					HitPoints -= hpLoss;
					TemporaryHitPoints = 0;

					if (HitPoints <= 0 && ko)
					{
						KO = true;
						HitPoints = 0;
					}
				}
			}

			public void Heal(int amount, Creature healer)
			{
				HitPoints = Math.Max(HitPoints, 0);	// move to zero if dying
				KO = false;	// un-KO
				HitPoints += amount;
			}
		}
	}
}
