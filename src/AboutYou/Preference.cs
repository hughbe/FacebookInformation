using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace FacebookInformation
{
    public class Preference
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("entries")]
        public IReadOnlyList<PreferenceEntry> Entries { get; set; }

        public override string ToString() => $"{Name} ({Description})";
    }
}
