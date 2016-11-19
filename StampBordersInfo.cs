using System;
namespace RStamp
{
	[Serializable()]
	public class StampBordersInfo
	{
		public double OuterBorderFirstThickness { get; set;}
		public double OuterBorderSecondThickness { get; set; }
		public double OuterBorderGap { get; set; }
		public double InnerBorderThickness { get; set; }

		//Default constructor
		public StampBordersInfo()
		{
			OuterBorderFirstThickness = 0.4;
			OuterBorderSecondThickness = 0.2;
			OuterBorderGap = 0.2;
			InnerBorderThickness = 0.2;
		}
	}
}
