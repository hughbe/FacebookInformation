using System.Collections.Generic;
using Newtonsoft.Json;

namespace FacebookInformation
{
    public class PostsAndCommentsLikes
    {
        [JsonProperty("reactions")]
        public IReadOnlyList<Reaction> Reactions { get; set; }
    }
}
