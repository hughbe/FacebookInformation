using System;
using Newtonsoft.Json;

namespace FacebookInformation
{
    public class VisitedEntry
    {
        [JsonProperty("timestamp")]
        public long Timestamp { get; set; }

        [JsonProperty("data")]
        public VisitedEntryData Data { get; set; }

        public DateTime Date => Utilities.DateFromTimestampSeconds(Timestamp);

        public override string ToString() => $"({Date}) {Data}";
    }
}
