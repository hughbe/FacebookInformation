using Newtonsoft.Json;

namespace FacebookInformation
{
    public class MessageShare
    {
        [JsonProperty("link")]
        public string Link { get; set; }

        [JsonProperty("share_text")]
        public string Text { get; set; }

        public override string ToString() => Link ?? Text;
    }
}
