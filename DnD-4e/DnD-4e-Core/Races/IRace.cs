using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DnD_4e.Lore;
using DnD_4e.Mechanics;

namespace DnD_4e.Races
{
	public interface IRace
	{
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
