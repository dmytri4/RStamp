using System;
using System.Collections.Generic;

namespace RStamp
{
	public class StampImages
	{
		public List<string> ImagesList { get; set;}
		public List<StampImagesParams> Parameters { get; set;}

		public StampImages()
		{
			ImagesList = new List<string>();
			Parameters = new List<StampImagesParams>();
		}
	}
}
