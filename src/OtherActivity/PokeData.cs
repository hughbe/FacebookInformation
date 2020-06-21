using System;
using Newtonsoft.Json;

namespace FacebookInformation
{
    public class PokeData
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        public override string ToString() => Name;
    }
}
