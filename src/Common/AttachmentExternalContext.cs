using Newtonsoft.Json;

namespace FacebookInformation
{
    public class AttachmentExternalContext
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        public override string ToString() => Url;
    }
}
