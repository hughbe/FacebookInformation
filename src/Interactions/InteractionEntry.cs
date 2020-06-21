using System;
using Newtonsoft.Json;

namespace FacebookInformation
{
    public class InteractionEntry
    {
        [JsonProperty("timestamp")]
        public long Timestamp { get; set; }

        [JsonProperty("data")]
        public InteractionEntryData Data { get; set; }

        public DateTime Date => Utilities.DateFromTimestampSeconds(Timestamp);
    }
}
