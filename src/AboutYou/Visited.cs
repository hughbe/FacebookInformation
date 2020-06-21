using System.Collections.Generic;
using Newtonsoft.Json;

namespace FacebookInformation
{
    public class Visited
    {
        [JsonProperty("visited_things")]
        public IReadOnlyList<VisitedThing> All { get; set; }
    }
}
