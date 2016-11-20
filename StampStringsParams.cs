using System;
using Cairo;

namespace RStamp
{
	[Serializable()]
	public class StampStringsParams
	{
		//Font style properties getters and setters
		public string FontFamily { get; set;}
		public double FontSizeMm { get; set;}
		public Color FontColor { get; set;}
		public FontWeight Weight { get; set;}
		public FontSlant Slant { get; set;}

		//Line and symbol intervals getters/setters
		public double LineIntervalMm { get; set;}
		public double SymbolIntervalMm { get; set;}
		public double IndentTopMm { get; set; }
		public double IndentBottomMm { get; set;}
		public double SpaceWidthMm { get; set;}
		public double TabWidthMm { get; set;}

		public short DelimiterCharUtf8 { get; set;}

		public StampStringsParams()
		{
			FontFamily = "Arial";			//Def font family is standard windows Arial 
			FontSizeMm = 5.0;				//Def font size is 5 mm in height
			FontColor = new Color(0, 0, 0); //Default font color is black
			Weight = FontWeight.Normal;     //Def font weight is 300
			Slant = FontSlant.Normal;       //Def font slant is normal

			LineIntervalMm = 0.1;			//Def interval between lines is 0.1 mm in height
			SymbolIntervalMm = 0.0;			//Def interval between symbols
			IndentTopMm = 0.0;				//Def indentation by the top in mm
			IndentBottomMm = 0.0;			//Def indentation by the bottom in mm
			SpaceWidthMm = FontSizeMm;		//Def width of the spaces is equal to font size
			TabWidthMm = 3.0 * FontSizeMm;	//Def tabulation width is equal font size multiplied by three

			DelimiterCharUtf8 = (short)'*';	 //Def delimiter char is star symbol
		}
	}
}
