using System.Collections.Generic;
using Newtonsoft.Json;

namespace FacebookInformation
{
    public class Pokes
    {
        [JsonProperty("activity_log_data")]
        public IReadOnlyList<ActivityLogPoke> ActivityLogData { get; set; }

        [JsonProperty("data")]
        public IReadOnlyList<Poke> Data { get; set; }
    }
}
