using System.Collections.Generic;
using Newtonsoft.Json;

namespace FacebookInformation
{
    public class YourVideos
    {
        [JsonProperty("videos")]
        public IReadOnlyList<Media> All { get; set; }
    }
}
