using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace FacebookInformation
{
    public class SupportCorrespondence
    {
        [JsonProperty("timestamp")]
        public long Timestamp { get; set; }

        [JsonProperty("subject")]
        public string Subject { get; set; }

        [JsonProperty("messages")]
        public IReadOnlyList<SupportCorrespondenceMessage> Messages { get; set; }

        public DateTime Date => Utilities.DateFromTimestampSeconds(Timestamp);

        public override string ToString() => $"({Date}) {Subject}";
    }
}
