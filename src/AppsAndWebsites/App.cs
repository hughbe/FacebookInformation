using System;
using Newtonsoft.Json;

namespace FacebookInformation
{
    public class App
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("added_timestamp")]
        public long AddedTimestamp { get; set; }

        public DateTime AddedDate => Utilities.DateFromTimestampSeconds(AddedTimestamp);

        public override string ToString() => Name;
    }
}
