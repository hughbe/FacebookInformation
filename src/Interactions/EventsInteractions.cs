using System.Collections.Generic;
using Newtonsoft.Json;

namespace FacebookInformation
{
    public class EventsInteractions
    {
        [JsonProperty("events_interactions")]
        public IReadOnlyList<Interaction> All { get; set; }
    }
}
