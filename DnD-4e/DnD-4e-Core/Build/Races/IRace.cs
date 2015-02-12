using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DnD_4e.Core;
using DnD_4e.Lore;
using DnD_4e.Mechanics;

namespace DnD_4e.Build.Races
{
	public interface IRace
	{
		string RaceName
		{ get; }

		List<AbilityScoreType> AbilityScores
		{ get; }

		Origin RaceOrigin
		{ get; }

		bool IsConstruct
		{ get; }

		EntitySize Size
		{ get; }

		int Speed
		{ get; }

		VisionType Vision
		{ get; }

		List<Languages> InitialLanguages
		{ get; }
	}
}
