using System;
using System.Runtime.Serialization;

namespace WeatherApi.Models.Charts
{
    [DataContract]
	public class DataPoint1
    {
		public DataPoint1(string label, int y)
		{
			this.Label = label;
			this.Y = y;
		}

		[DataMember(Name = "label")]
		public string Label = "";

		[DataMember(Name = "y")]
		public Nullable<int> Y = null;
	}
}
