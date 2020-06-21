using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace FacebookInformation
{
    public class Poke
    {
        [JsonProperty("poker")]
        public string Poker { get; set; }

        [JsonProperty("pokee")]
        public string Pokee { get; set; }

        [JsonProperty("rank")]
        public int Rank { get; set; }

        [JsonProperty("timestamp")]
        public long Timestamp { get; set; }

        public DateTime Date => Utilities.DateFromTimestampSeconds(Timestamp);

        public override string ToString() => $"({Date}) {Poker} poked {Pokee}";
    }
}
