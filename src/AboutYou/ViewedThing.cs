using System.Collections.Generic;
using Newtonsoft.Json;

namespace FacebookInformation
{
    public class ViewedThing
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("children")]
        public IReadOnlyList<ViewedChildren> Children { get; set; }

        [JsonProperty("entries")]
        public IReadOnlyList<ViewedEntry> Entries { get; set; }

        public override string ToString() => $"{Name} ({Description})";
    }
}
