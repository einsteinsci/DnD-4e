using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Misc. Mechanics-related enums.
/// </summary>
namespace DnD_4e.Mechanics
{
	public enum EntitySize
	{
		Tiny = -1,
		Small = 0,
		Medium,
		Large,
		Huge,
		Gargantuan,
	}

	public enum VisionType
	{
		Normal = 0,
		LowLightVision,
		Darkvision
	}

	public enum Defense
	{
		ArmorClass = 0,
		Fortitude,
		Reflex,
		Will
	}
}
