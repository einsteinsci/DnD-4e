﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using DnD_4e.Core;

namespace DnD_4e.Entities
{
    public abstract class Entity
    {
		public AbilityModifierSet Abilities
		{ get; set; }
    }
}