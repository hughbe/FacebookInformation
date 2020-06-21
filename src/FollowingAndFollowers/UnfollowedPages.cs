using System.Collections.Generic;
using Newtonsoft.Json;

namespace FacebookInformation
{
    public class UnfollowedPages
    {
        [JsonProperty("pages_unfollowed")]
        public IReadOnlyList<UnfollowedPage> All { get; set; }
    }
}
