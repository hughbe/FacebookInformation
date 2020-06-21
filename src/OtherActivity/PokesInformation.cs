using System.Collections.Generic;
using Newtonsoft.Json;

namespace FacebookInformation
{
    public class PokesInformation
    {
        [JsonProperty("pokes")]
        public Pokes All { get; set; }
    }
}
