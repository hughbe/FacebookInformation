using System.Collections.Generic;
using Newtonsoft.Json;

namespace FacebookInformation
{
    public class YourOffFacebookActivityEntry
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("events")]
        public IReadOnlyList<YourOffFacebookActivityEntryEvent> Events { get; set; }

        public override string ToString() => Name;
    }
}
