using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace FacebookInformation
{
    public class Post
    {
        [JsonProperty("timestamp")]
        public long Timestamp { get; set; }

        [JsonProperty("attachments")]
        public IReadOnlyList<Attachment> Attachments { get; set; }

        [JsonProperty("tags")]
        public IReadOnlyList<string> Tags { get; set; }

        [JsonProperty("data")]
        public IReadOnlyList<PostData> Data { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        public DateTime Date => Utilities.DateFromTimestampSeconds(Timestamp);

        public override string ToString() => $"({Date}) {Title}";
    }
}
