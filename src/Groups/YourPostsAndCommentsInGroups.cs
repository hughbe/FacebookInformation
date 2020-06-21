using System.Collections.Generic;
using Newtonsoft.Json;

namespace FacebookInformation
{
    public class YourPostsAndCommentsInGroups
    {
        [JsonProperty("group_posts")]
        public Posts Posts { get; set; }
    }
}
