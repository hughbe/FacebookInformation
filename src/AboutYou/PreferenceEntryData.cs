using Newtonsoft.Json;

namespace FacebookInformation
{
    public class PreferenceEntryData
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("uri")]
        public string Uri { get; set; }

        public override string ToString() => $"{Name} ({Uri})";
    }
}
