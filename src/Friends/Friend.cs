using System;
using Newtonsoft.Json;

namespace FacebookInformation
{
    public class Friend
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("timestamp")]
        public long Timestamp { get; set; }

        [JsonProperty("contact_info")]
        public string ContactInfo { get; set; }

        public DateTime Date => Utilities.DateFromTimestampSeconds(Timestamp);

        public override string ToString() => $"({Date}) {Name}";
    }
}
