using System;
using Newtonsoft.Json;

namespace FacebookInformation
{
    public class YourEvent : Event
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("place")]
        public Place Place { get; set; }

        [JsonProperty("create_timestamp")]
        public long CreatedTimestamp { get; set; }

        public DateTime CreatedDate => Utilities.DateFromTimestampSeconds(CreatedTimestamp);
    }
}
