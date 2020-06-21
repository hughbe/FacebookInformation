using System.Collections.Generic;
using Newtonsoft.Json;

namespace FacebookInformation
{
    public class ProfilePage
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("pages")]
        public IReadOnlyList<string> Pages { get; set; }

        [JsonProperty("timestamps")]
        public IReadOnlyList<long> Timestamps { get; set; }

        public override string ToString() => Name;
    }
}
