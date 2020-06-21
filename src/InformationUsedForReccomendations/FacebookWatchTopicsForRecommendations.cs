using System.Collections.Generic;
using Newtonsoft.Json;

namespace FacebookInformation
{
    public class FacebookWatchTopicsForRecommendations
    {
        [JsonProperty("facebook_watch_topics")]
        public IReadOnlyList<string> All { get; set; }
    }
}
