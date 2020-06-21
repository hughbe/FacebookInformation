using System.Collections.Generic;
using Newtonsoft.Json;

namespace FacebookInformation
{
    public class NewsTopicsForRecommendations
    {
        [JsonProperty("news_topics")]
        public IReadOnlyList<string> All { get; set; }
    }
}
