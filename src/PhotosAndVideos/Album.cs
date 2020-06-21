using System.Collections.Generic;
using Newtonsoft.Json;

namespace FacebookInformation
{
    public class Album
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("photos")]
        public IReadOnlyList<Media> Photos { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
    }
}
