﻿using System;
using Cairo;

namespace RStamp
{
	[Serializable()]
	public class StampBordersInfo
	{
		public double OuterBorderFirstThickness { get; set;}
		public double OuterBorderSecondThickness { get; set; }
		public double OuterBorderGap { get; set; }
		public double InnerBorderThickness { get; set; }
		public double InnerBorderRadius { get; set;}

		public Color InnerBorderColor { get; set;}
		public Color OuterBorderColor { get; set; }

		//Default constructor
		public StampBordersInfo()
		{
			OuterBorderFirstThickness = 0.4;
			OuterBorderSecondThickness = 0.2;
			OuterBorderGap = 0.2;
			InnerBorderThickness = 0.2;
			InnerBorderRadius = 15; //Ri = 15mm

			//By default the colours of a stamp is black
			InnerBorderColor = new Color(0, 0, 0);
			OuterBorderColor = new Color(0, 0, 0);
		}
	}
}
