using System;
using System.Xml;
using System.Xml.Serialization;

namespace RStamp
{
	public class Stamp
	{
		public double StampDiameter { get; set;}

		public Stamp()
		{
			StampDiameter = 50; //Rs=50mm
		}
	}
}
