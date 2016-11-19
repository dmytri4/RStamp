using System;
using System.Xml;
using System.Xml.Serialization;

namespace RStamp
{
	[Serializable()]
	public class Stamp
	{
		public double Diameter { get; set;}
		public StampBordersInfo Border;

		public Stamp()
		{
			Diameter = 50; //Rs=50mm
			Border   = new StampBordersInfo();
		}
	}
}
