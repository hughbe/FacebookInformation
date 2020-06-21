using System.Collections.Generic;
using Newtonsoft.Json;

namespace FacebookInformation
{
    public class ViewedChildren
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("entries")]
        public IReadOnlyList<ViewedEntry> Entries { get; set; }

        public override string ToString() => $"{Name} ({Description})";
    }
}
