using Newtonsoft.Json;

namespace FacebookInformation
{
    public class ViewedEntryData
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("uri")]
        public string Uri { get; set; }

        [JsonProperty("share")]
        public string Share { get; set; }

        [JsonProperty("watch_time")]
        public int? WatchTime { get; set; }

        [JsonProperty("watch_position_seconds")]
        public double? WatchPositionSeconds { get; set; }

        public override string ToString() => $"{Name} ({Uri})";
    }
}
