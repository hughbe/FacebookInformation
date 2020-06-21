using System;
using Newtonsoft.Json;

namespace FacebookInformation
{
    public class PreferenceEntry
    {
        [JsonProperty("timestamp")]
        public long Timestamp { get; set; }

        [JsonProperty("data")]
        public PreferenceEntryData Data { get; set; }

        public DateTime Date => Utilities.DateFromTimestampSeconds(Timestamp);

        public override string ToString() => $"({Date}) {Data}";
    }
}
