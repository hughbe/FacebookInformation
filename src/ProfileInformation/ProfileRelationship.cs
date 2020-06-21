using System;
using Newtonsoft.Json;

namespace FacebookInformation
{
    public class ProfileRelationship
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("timestamp")]
        public long Timestamp { get; set; }

        public DateTime Date => Utilities.DateFromTimestampSeconds(Timestamp);

        public override string ToString() => $"({Date}) {Status}";
    }
}
