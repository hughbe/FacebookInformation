using System;
using Newtonsoft.Json;

namespace FacebookInformation
{
    public class Notification
    {
        [JsonProperty("timestamp")]
        public long Timestamp { get; set; }

        [JsonProperty("unread")]
        public bool Unread { get; set; }

        [JsonProperty("href")]
        public string Href { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        public DateTime Date => Utilities.DateFromTimestampSeconds(Timestamp);

        public override string ToString() => $"({Date}) {Text}";
    }
}
