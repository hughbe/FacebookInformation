using System;
using Newtonsoft.Json;

namespace FacebookInformation
{
    public class Event
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("start_timestamp")]
        public long StartTimestamp { get; set; }

        [JsonProperty("end_timestamp")]
        public long EndTimestamp { get; set; }

        public DateTime StartDate => Utilities.DateFromTimestampSeconds(StartTimestamp);

        public DateTime EndDate => Utilities.DateFromTimestampSeconds(EndTimestamp);

        public override string ToString() => $"({StartDate}-{EndDate}) {Name}";
    }
}
