using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DnD_4e.Events.Powers;

namespace DnD_4e.Events
{
	public delegate void PlayerEvent(PlayerEventArgs e);
	public delegate void SkillUsedEvent(SkillUsedEventArgs e);
	public delegate void SaveEffectEvent(SaveEffectArgs e);
	public delegate void PreAttackRollEvent(AttackRollEventArgs e);
	public delegate void PostAttackRollEvent(PostAttackRollEventArgs e);
	public delegate void PreDamageRollEvent(DamageRollEventArgs e);
	public delegate void PostDamageRollEvent(PostDamageRollEventArgs e);
	public delegate void AttackedEvent(AttackedEventArgs e);
}
