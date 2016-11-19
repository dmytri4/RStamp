using System;
using System.Xml;
using System.Xml.Serialization;

namespace RStamp
{
	[Serializable()]
	public class Stamp
	{
		public double StampDiameter { get; set;}
		public StampBordersInfo BorderGeometry;

		public Stamp()
		{
			StampDiameter = 50; //Rs=50mm
			BorderGeometry = new StampBordersInfo();
		}
	}
}
