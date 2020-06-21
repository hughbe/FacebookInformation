using System.Collections.Generic;
using Newtonsoft.Json;

namespace FacebookInformation
{
    public class LastActivityTimeEntry
    {
        [JsonProperty("activity_by_day")]
        public IReadOnlyList<long> ActivityByDay { get; set; }
    }
}
