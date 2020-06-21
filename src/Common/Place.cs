using System;
using Newtonsoft.Json;

namespace FacebookInformation
{
    public class Place
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("coordinate")]
        public PlaceCoordinate Coordinate { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        public override string ToString() => $"{Name}, {Address}";
    }
}
