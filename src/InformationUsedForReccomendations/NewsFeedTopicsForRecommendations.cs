using System.Collections.Generic;
using Newtonsoft.Json;

namespace FacebookInformation
{
    public class NewsFeedTopicsForRecommendations
    {
        [JsonProperty("news_feed_topics")]
        public IReadOnlyList<string> All { get; set; }
    }
}
