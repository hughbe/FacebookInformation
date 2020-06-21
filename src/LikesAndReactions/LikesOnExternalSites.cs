using System.Collections.Generic;
using Newtonsoft.Json;

namespace FacebookInformation
{
    public class LikesOnExternalSites
    {
        [JsonProperty("other_likes")]
        public IReadOnlyList<LikeOnExternalSite> All { get; set; }
    }
}
