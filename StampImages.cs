using System;
using System.Collections.Generic;

namespace RStamp
{
	public class StampImages
	{
		public List<string> ImagesList { get; set;} //base64 encoded images list
		public List<StampImagesParams> Parameters { get; set;}

		public StampImages()
		{
			ImagesList = new List<string>();
			Parameters = new List<StampImagesParams>();
		}

		public void LoadImage(string path)
		{
			
		}
	}
}
