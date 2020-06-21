using Newtonsoft.Json;

namespace FacebookInformation
{
    public class MediaThumbnail
    {
        [JsonProperty("uri")]
        public string Uri { get; set; }

        public override string ToString() => Uri;
    }
}
