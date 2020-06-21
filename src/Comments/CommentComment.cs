using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace FacebookInformation
{
    public class CommentComment
    {
        [JsonProperty("timestamp")]
        public long Timestamp { get; set; }

        [JsonProperty("comment")]
        public string Comment { get; set; }

        [JsonProperty("author")]
        public string Author { get; set; }

        [JsonProperty("group")]
        public string Group { get; set; }

        public DateTime Date => Utilities.DateFromTimestampSeconds(Timestamp);

        public override string ToString() => $"({Date}) {Comment} ({Author})";
    }
}
