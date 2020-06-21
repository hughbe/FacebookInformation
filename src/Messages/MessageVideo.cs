using Newtonsoft.Json;

namespace FacebookInformation
{
    public class MessageVideo : MessagePhoto
    {
        [JsonProperty("thumbnail")]
        public MediaThumbnail Thumbnail { get; set; }
    }
}
