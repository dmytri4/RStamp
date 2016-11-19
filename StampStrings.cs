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
			RoundStrings = new List<string>();
			CentralStrings = new List<string>();
			RoundStringParameters = new List<StampStringsParams>();
			CentralStringParameters = new List<StampStringsParams>();
		}
	}
}
