using System;
using System.Collections.Generic;
namespace RStamp
{
	public class StampStrings
	{
		public List<string> RoundStrings;
		public List<string> CentralStrings;
		public List<StampStringsParams> RoundStringParameters;
		public List<StampStringsParams> CentralStringParameters;

		public StampStrings()
		{
			//Creating an empty lists
			RoundStrings = new List<string>();
			CentralStrings = new List<string>();
			RoundStringParameters = new List<StampStringsParams>();
			CentralStringParameters = new List<StampStringsParams>();

			//Setting default values to lists
			RoundStrings.Add("This is a first round string");
			RoundStrings.Add("This is a second round string");
			RoundStringParameters.Add(new StampStringsParams());
			RoundStringParameters.Add(new StampStringsParams());
		}
	}
}
