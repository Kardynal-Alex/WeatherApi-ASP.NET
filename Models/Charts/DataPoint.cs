using System;
using System.Runtime.Serialization;

namespace WeatherApi.Models.Charts
{
    [DataContract]
	public class DataPoint
    {
		public DataPoint(string label, decimal y)
		{
			this.Label = label;
			this.Y = y;
		}

		[DataMember(Name = "label")]
		public string Label = "";

		[DataMember(Name = "y")]
		public Nullable<decimal> Y = null;
	}
}
