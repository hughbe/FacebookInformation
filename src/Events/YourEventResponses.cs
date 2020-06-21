using System.Collections.Generic;
using Newtonsoft.Json;

namespace FacebookInformation
{
    public class YourEventResponses
    {
        [JsonProperty("event_responses")]
        public EventResponses Responses { get; set; }
    }
}
