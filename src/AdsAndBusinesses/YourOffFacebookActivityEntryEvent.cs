using System;
using Newtonsoft.Json;

namespace FacebookInformation
{
    public class YourOffFacebookActivityEntryEvent
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("timestamp")]
        public long Timestamp { get; set; }

        public DateTime Date => Utilities.DateFromTimestampSeconds(Timestamp);
    }
}
