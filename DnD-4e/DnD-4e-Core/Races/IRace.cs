using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DnD_4e_Core.Lore;
using DnD_4e_Core.Mechanics;

namespace DnD_4e.Races
{
	public interface IRace
	{
		EntitySize Size
		{ get; }

		List<Languages> InitialLanguages
		{ get; }
	}
}
