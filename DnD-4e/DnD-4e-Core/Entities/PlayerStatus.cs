﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DnD_4e.Build.Powers;
using DnD_4e.Events;
using DnD_4e.Mechanics;

namespace DnD_4e.Entities
{
	public partial class PlayerCharacter
	{
		public class PlayerStatus : CreatureStatus
		{
			public PlayerCharacter Player
			{ get; private set; }

			public int MilestonesReached
			{ get; set; }

			public int UsedItemDailies
			{ get; set; }

			public PlayerStatus(PlayerCharacter pc) : base(pc)
			{
				Player = pc;
			}
			
			public override void ApplyDamage(Damage damage, float damageMultiplier, Creature attacker, bool ko)
			{
				int hpLoss = damage.Amount;

				AttackedEventArgs e = new AttackedEventArgs(Player, Player.Allies, Enemies, attacker);
                Player.OnDamageTaken(e);

				if (e.Cancelled)
				{
					return;
				}

				#region RESISTANCE
				List<DmgType> resistanceTypes = new List<DmgType>();
				foreach (Resistance r in Player.Resistances.Values)
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
					foreach (Resistance r in Player.Resistances.Values)
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
				foreach (Resistance v in Player.Vulnerabilities.Values)
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
					foreach (Resistance v in Player.Vulnerabilities.Values)
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

				if (Bloodied && !bloodiedAlready)
				{
					Player.OnBloodied(e);
				}

				if (Dying && !dyingAlready)
				{
					Player.OnDying(e);
				}

				if (HitPoints < -Player.BloodiedValue) // DEAD
				{
					Player.OnDying(e); // call it again. Think ring/cloak of the phoenix
				}
			}

			public override void Heal(int amount, Creature healer)
			{
				PlayerEventArgs e = new PlayerEventArgs(Player, Player.Allies, Enemies);
				Player.OnDamageHealed(e);

				if (e.Cancelled)
				{
					return; // no heal for you!
				}

				HitPoints = Math.Max(HitPoints, 0);	// move to zero if dying
				KO = false; // un-KO
				HitPoints += amount;
			}
		}
	}
}
