using System;
using Newtonsoft.Json;

namespace FacebookInformation
{
    public class MessagePhoto
    {
        [JsonProperty("uri")]
        public string Uri { get; set; }

        [JsonProperty("creation_timestamp")]
        public long CreationTimestamp { get; set; }

        public DateTime CreationDate => Utilities.DateFromTimestampSeconds(CreationTimestamp);

        public override string ToString() => $"({CreationDate}) {Uri}";
    }
}
