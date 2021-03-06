﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DnD_4e.Entities;

namespace DnD_4e.Map
{
	public interface IMapGrid
	{
		int WalkingDistance(Creature a, Creature b);
		int WalkingDistance(GridSquare square, Creature creature);

		bool LineOfSight(Creature looker, Creature target);
		bool LineOfEffect(Creature attacker, Creature target);

		GridSquare GetSquareOf(Creature creature);
	}
}
