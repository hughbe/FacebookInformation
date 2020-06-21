using System.Collections.Generic;
using Newtonsoft.Json;

namespace FacebookInformation
{
    public class EventResponses
    {
        [JsonProperty("events_joined")]
        public IReadOnlyList<YourEvent> Joined { get; set; }

        [JsonProperty("events_declined")]
        public IReadOnlyList<YourEvent> Declined { get; set; }

        [JsonProperty("events_interested")]
        public IReadOnlyList<YourEvent> Interested { get; set; }
    }
}
