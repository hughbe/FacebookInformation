using System;
using Newtonsoft.Json;

namespace FacebookInformation
{
    public class PostData
    {
        [JsonProperty("post")]
        public string Post { get; set; }

        [JsonProperty("comment")]
        public CommentComment Comment { get; set; }

        [JsonProperty("update_timestamp")]
        public long? UpdateTimestamp { get; set; }

        [JsonProperty("published_timestamp")]
        public long? PublishedTimestamp { get; set; }

        public DateTime? UpdateDate => UpdateTimestamp != null ? (DateTime?)Utilities.DateFromTimestampSeconds(UpdateTimestamp.Value) : null;

        public DateTime? PublishedDate => PublishedTimestamp != null ? (DateTime?)Utilities.DateFromTimestampSeconds(PublishedTimestamp.Value) : null;
    }
}
