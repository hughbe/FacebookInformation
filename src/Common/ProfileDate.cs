using System;
using Newtonsoft.Json;

namespace FacebookInformation
{
    public class ProfileDate
    {
        [JsonProperty("year")]
        public int Year { get; set; }

        [JsonProperty("month")]
        public int Month { get; set; }

        [JsonProperty("day")]
        public int Day { get; set; }

        public DateTime Date => new DateTime(Year, Month, Day);

        public override string ToString() => Date.ToString();
    }
}
