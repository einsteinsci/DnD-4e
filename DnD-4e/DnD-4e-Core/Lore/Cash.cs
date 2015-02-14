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
		{
			get
			{
				return _ad;
			}
			set
			{
				_ad = Math.Max(0, value);
			}
		}
		int _ad;
		public int PlatinumPieces
		{
			get
			{
				return _pp;
			}
			set
			{
				_pp = value;
				while (_pp >= 100)
				{
					_pp -= 100;
					AstralDiamonds++;
				}
				while (_gp < 0)
				{
					_pp += 100;
					AstralDiamonds--;
				}
			}
		}
		int _pp;
		public int GoldPieces
		{
			get
			{
				return _gp;
			}
			set
			{
				_gp = value;
				while (_gp >= 100)
				{
					_gp -= 100;
					PlatinumPieces++;
				}
				while (_gp < 0)
				{
					_gp += 100;
					PlatinumPieces--;
				}
			}
		}
		int _gp;
		public int SilverPieces
		{
			get
			{
				return _sp;
			}
			set
			{
				_sp = value;
				while (_sp >= 10)
				{
					_sp -= 10;
					GoldPieces++;
				}
				while (_sp < 0)
				{
					_sp += 10;
					GoldPieces--;
				}
			}
		}
		int _sp;
		public int CopperPieces
		{
			get
			{
				return _cp;
			}
			set
			{
				_cp = value;
				while (_cp >= 10)
				{
					_cp -= 10;
					SilverPieces++;
				}
				while (_cp < 0)
				{
					_cp += 10;
					SilverPieces--;
				}
			}
		}
		int _cp;

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

		public Cash(int ad, int pp, int gp, int sp, int cp)
		{
			_ad = 0;
			_pp = 0;
			_gp = 0;
			_sp = 0;
			_cp = 0;

			AstralDiamonds = ad;
			PlatinumPieces = pp;
			GoldPieces = gp;
			SilverPieces = sp;
			CopperPieces = cp;
		}
		public Cash(int gp) : this(0, 0, gp, 0, 0)
		{ }

		public static Cash AD(int ad)
		{
			return new Cash(ad, 0, 0, 0, 0);
		}
		public static Cash PP(int pp)
		{
			return new Cash(0, pp, 0, 0, 0);
		}
		public static Cash GP(int gp)
		{
			return new Cash(0, 0, gp, 0, 0);
		}
		public static Cash SP(int sp)
		{
			return new Cash(0, 0, 0, sp, 0);
		}
		public static Cash CP(int cp)
		{
			return new Cash(0, 0, 0, 0, cp);
		}

		public static Cash Zero
		{
			get
			{
				return new Cash(0, 0, 0, 0, 0);
			}
		}

		public override string ToString()
		{
			string res = "";
			if (AstralDiamonds > 0)
			{
				res += AstralDiamonds.ToString() + "ad ";
			}
			if (PlatinumPieces > 0)
			{
				res += PlatinumPieces.ToString() + "pp ";
			}
			if (GoldPieces > 0)
			{
				res += GoldPieces.ToString() + "gp ";
			}
			if (SilverPieces > 0)
			{
				res += SilverPieces.ToString() + "sp ";
			}
			if (CopperPieces > 0)
			{
				res += CopperPieces.ToString() + "cp";
			}

			return res.Trim();
		}
	}
}
