using System.Collections.Generic;
using Newtonsoft.Json;

namespace FacebookInformation
{
    public class Viewed
    {
        [JsonProperty("viewed_things")]
        public IReadOnlyList<ViewedThing> All { get; set; }
    }
}
