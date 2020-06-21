using System.Collections.Generic;
using Newtonsoft.Json;

namespace FacebookInformation
{
    public class YourEvents
    {
        [JsonProperty("your_events")]
        public IReadOnlyList<YourEvent> All { get; set; }
    }
}
