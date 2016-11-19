using System;
using Cairo;

namespace RStamp
{
	[Serializable()]
	public class StampStringsParams
	{
		//Font style properties
		public string FontFamily { get; set;}
		public double FontSizeMm { get; set;}
		public Color FontColor { get; set;}
		public FontWeight Weight { get; set;}
		public FontSlant Slant { get; set;}

		//Line and symbol intervals
		public double LineIntervalMm { get; set;}
		public double SymbolIntervalMm { get; set;}
		public double IndentTopMm { get; set; }
		public double IndentBottomMm { get; set;}
		public double SpaceWidthMm { get; set;}
		public double TabWidthMm { get; set;}

		public StampStringsParams()
		{
			FontFamily = "Arial";			//Def font family is standard windows Arial 
			FontSizeMm = 5.0;				//Def font size is 5 mm in height
			FontColor = new Color(0, 0, 0); //Default font color is black
			Weight = FontWeight.Normal;     //Def font weight is 300
			Slant = FontSlant.Normal;       //Def font slant is normal

			LineIntervalMm = 0.1;
			SymbolIntervalMm = 0.0;
			IndentTopMm = 0.0;
			IndentBottomMm = 0.0;
			SpaceWidthMm = FontSizeMm;
			TabWidthMm = 3.0 * FontSizeMm;
		}
	}
}
