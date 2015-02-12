﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DnD_4e.Entities;

namespace DnD_4e.Events
{
	public delegate void PlayerEvent(PlayerEventArgs e);
	public delegate void SkillUsedEvent(SkillUsedEventArgs e);
	public delegate void SaveEffect(SaveEffectArgs e);
}
