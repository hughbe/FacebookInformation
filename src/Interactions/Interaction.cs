using System.Collections.Generic;
using Newtonsoft.Json;

namespace FacebookInformation
{
    public class Interaction
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("entries")]
        public IReadOnlyList<InteractionEntry> Entries { get; set; }
    }
}
