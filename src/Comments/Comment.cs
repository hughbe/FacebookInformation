using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace FacebookInformation
{
    public class Comment
    {
        [JsonProperty("timestamp")]
        public long Timestamp { get; set; }

        [JsonProperty("attachments")]
        public IReadOnlyList<Attachment> Attachments { get; set; }

        [JsonProperty("data")]
        public IReadOnlyList<CommentData> Data { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        public DateTime Date => Utilities.DateFromTimestampSeconds(Timestamp);

        public override string ToString() => $"({Date}) {Title}";
    }
}
