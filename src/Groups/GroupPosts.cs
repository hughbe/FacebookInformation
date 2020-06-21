using System.Collections.Generic;
using Newtonsoft.Json;

namespace FacebookInformation
{
    public class Posts
    {
        [JsonProperty("activity_log_data")]
        public IReadOnlyList<Post> ActivityLogData { get; set; }
    }
}
