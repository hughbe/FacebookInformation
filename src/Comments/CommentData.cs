using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace FacebookInformation
{
    public class CommentData
    {
        [JsonProperty("comment")]
        public CommentComment Comment { get; set; }

        public override string ToString() => Comment.ToString();
    }
}
