using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace FacebookInformation
{
    public class Comments
    {
        [JsonProperty("comments")]
        public IReadOnlyList<Comment> All { get; set; }
    }
}
