using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace RStamp
{
	[Serializable()]
	public class Stamp
	{
		public double Diameter { get; set; }
		public StampBordersInfo Border;
		public StampStrings Strings;
		public StampImages Images;

		private string Base64EncodedCenterImg;

		//Default Ctor
		public Stamp()
		{
			Diameter = 50; //Rs=50mm
			Border = new StampBordersInfo();
			Strings = new StampStrings();
			Images = new StampImages();
		}

		//Save Stamp object into xml file
		public void SerializeToXml(string path)
		{
			XmlSerializer ser = new XmlSerializer(typeof(Stamp)); 	//Serializer component creation
			TextWriter writer = new StreamWriter(path);				//Place to save xml file
			ser.Serialize(writer, this);							//Serialization
			writer.Close();											//Close writing stream after the end of serialization
		}

		//Load Stamp object from xml file
		public static Stamp DeserializeFromXml(string path)
		{
			XmlSerializer ser = new XmlSerializer(typeof(Stamp));
			TextReader reader = new StreamReader(path);
			return (Stamp)ser.Deserialize(reader);
		}
	}
}
