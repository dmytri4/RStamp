using System;
namespace RStamp
{
	public class StampStringsParams
	{
		public string FontFamily { get; set;}
		public double FontSizeMm { get; set;}

		public StampStringsParams()
		{
			FontFamily = "Arial";
			FontSizeMm = 5.0;
		}
	}
}
