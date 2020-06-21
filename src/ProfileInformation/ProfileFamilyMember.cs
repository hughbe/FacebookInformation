using System;
using Newtonsoft.Json;

namespace FacebookInformation
{
    public class ProfileFamilyMember
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("relation")]
        public string Relation { get; set; }

        [JsonProperty("timestamp")]
        public long Timestamp { get; set; }

        public DateTime Date => Utilities.DateFromTimestampSeconds(Timestamp);

        public override string ToString() => $"({Date}) {Name} - {Relation}";
    }
}
