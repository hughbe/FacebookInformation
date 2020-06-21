using System.Collections.Generic;
using Newtonsoft.Json;

namespace FacebookInformation
{
    public class PageLikes
    {
        [JsonProperty("page_likes")]
        public IReadOnlyList<PageLike> All { get; set; }
    }
}
