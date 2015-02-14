using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DnD_4e.Events;
using DnD_4e.Lore;

namespace DnD_4e.Build.Items
{
	public interface IItem
	{
		string Name
		{ get; }

		Cash Price
		{ get; }

		/// <summary>
		/// Weight of weapon, in pounds.
		/// </summary>
		int Weight
		{ get; }

		void OnItemLoad(PlayerEventArgs e);
		void OnItemUnload(PlayerEventArgs e);
	}
}
