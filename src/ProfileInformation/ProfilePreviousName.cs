using System;
using Newtonsoft.Json;

namespace FacebookInformation
{
    public class ProfilePreviousName
    {
        [JsonProperty("timestamp")]
        public long Timestamp { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        public DateTime Date => Utilities.DateFromTimestampSeconds(Timestamp);

        public override string ToString() => $"({Date}) {Name}";
    }
}
