using System.Collections.Generic;
using Newtonsoft.Json;

namespace FacebookInformation
{
    public class EventInvitations
    {
        [JsonProperty("events_invited")]
        public IReadOnlyList<Event> All { get; set; }
    }
}
