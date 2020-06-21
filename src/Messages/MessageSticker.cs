using Newtonsoft.Json;

namespace FacebookInformation
{
    public class MessageSticker
    {
        [JsonProperty("uri")]
        public string Uri { get; set; }

        public override string ToString() => Uri;
    }
}
