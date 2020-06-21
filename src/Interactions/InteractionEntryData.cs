using System;
using Newtonsoft.Json;

namespace FacebookInformation
{
    public class InteractionEntryData
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("uri")]
        public string Uri { get; set; }

        [JsonProperty("num_clicks")]
        public int? NumberOfClicks { get; set; }
    }
}
