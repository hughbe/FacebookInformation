using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace FacebookInformation
{
    public class LocationHistoryEntry
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("coordinate")]
        public PlaceCoordinate Coordinate { get; set; }

        [JsonProperty("creation_timestamp")]
        public long CreationTimestamp { get; set; }

        public DateTime CreationDate => Utilities.DateFromTimestampSeconds(CreationTimestamp);

        public override string ToString() => $"{Name}, {Coordinate}";
    }
}
