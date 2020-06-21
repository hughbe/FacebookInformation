using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace FacebookInformation
{
    public class UsedIpAddress
    {
        [JsonProperty("ip")]
        public string Ip { get; set; }

        [JsonProperty("action")]
        public string Action { get; set; }

        [JsonProperty("timestamp")]
        public long Timestamp { get; set; }

        public DateTime Date => Utilities.DateFromTimestampSeconds(Timestamp);

        public override string ToString() => $"({Date}) {Action} - {Ip}";
    }
}
