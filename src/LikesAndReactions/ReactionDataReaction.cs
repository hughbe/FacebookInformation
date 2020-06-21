using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace FacebookInformation
{
    public class ReactionDataReaction
    {
        [JsonProperty("reaction")]
        public string Reaction { get; set; }

        [JsonProperty("actor")]
        public string Actor { get; set; }

        public override string ToString() => $"{Reaction} ({Actor})";
    }
}
