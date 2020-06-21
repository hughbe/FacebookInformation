using Newtonsoft.Json;

namespace FacebookInformation
{
    public class ExternalContext
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        public override string ToString() => Url;
    }
}
