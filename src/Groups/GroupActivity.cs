using System;
using Newtonsoft.Json;

namespace FacebookInformation
{
    public class GroupActivity
    {
        [JsonProperty("timestamp")]
        public long Timestamp { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        public DateTime Date => Utilities.DateFromTimestampSeconds(Timestamp);

        public override string ToString() => $"({Date}) {Title}";
    }
}
