using System;
using Newtonsoft.Json;

namespace FacebookInformation
{
    public class AdvertisersWhoYouInteractedWithHistoryEntry
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("action")]
        public string Action { get; set; }

        [JsonProperty("timestamp")]
        public long Timestamp { get; set; }

        public DateTime Date => Utilities.DateFromTimestampSeconds(Timestamp);
    }
}
