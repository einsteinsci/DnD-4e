using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DnD_4e.Events;

namespace DnD_4e.Build.Items.MagicItems.SuperiorImplement
{
	public class DistantSuperiorProperty : SuperiorImplementPropertyBase
	{
		public override string Name
		{
			get
			{
				return "Distant";
			}
		}

		public override void OnLoadEquip(PlayerEventArgs e)
		{
			
			throw new NotImplementedException();
		}

		public override void OnUnequip(PlayerEventArgs e)
		{
			throw new NotImplementedException();
		}
	}
}
