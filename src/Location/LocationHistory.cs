using System.Collections.Generic;
using Newtonsoft.Json;

namespace FacebookInformation
{
    public class LocationHistory
    {
        [JsonProperty("location_history")]
        public IReadOnlyList<LocationHistoryEntry> All { get; set; }
    }
}
