using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD_4e.Lore
{
	public struct Cash
	{
		public int AstralDiamonds
		{ get; set; }
		public int PlatinumPieces
		{ get; set; }
		public int GoldPieces
		{ get; set; }
		public int SilverPieces
		{ get; set; }
		public int CopperPieces
		{ get; set; }

		public int TotalPP
		{
			get
			{
				return AstralDiamonds * 100 + PlatinumPieces;
			}
		}
		public int TotalGP
		{
			get
			{
				return TotalPP * 100 + GoldPieces;
			}
		}
		public int TotalSP
		{
			get
			{
				return TotalGP * 10 + SilverPieces;
			}
		}
		public int TotalCP
		{
			get
			{
				return TotalSP * 10 + CopperPieces;
			}
		}
	}
}
