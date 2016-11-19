using System;
using Cairo;

namespace RStamp
{
	public class StampStringsParams
	{
		public string FontFamily { get; set;}
		public double FontSizeMm { get; set;}
		public Color FontColor { get; set;}
		public FontWeight Weight { get; set;}
		public FontSlant Slant { get; set;}

		public StampStringsParams()
		{
			FontFamily = "Arial";			//Def font family is standard windows Arial 
			FontSizeMm = 5.0;				//Def font size is 5 mm in height
			FontColor = new Color(0, 0, 0); //Default font color is black
			Weight = FontWeight.Normal;     //Def font weight is 300
			Slant = FontSlant.Normal;		//Def font slant is normal

		}
	}
}
