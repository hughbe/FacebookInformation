using System.Collections.Generic;
using Newtonsoft.Json;

namespace FacebookInformation
{
    public class VisitedThing
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("entries")]
        public IReadOnlyList<VisitedEntry> Entries { get; set; }

        public override string ToString() => $"{Name} ({Description})";
    }
}
