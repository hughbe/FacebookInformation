using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace FacebookInformation
{
    public class CreatedPlace
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("creation_timestamp")]
        public long CreationTimestamp { get; set; }

        public DateTime CreationDate => Utilities.DateFromTimestampSeconds(CreationTimestamp);

        public override string ToString() => $"({CreationDate}) {Name}";
    }
}
