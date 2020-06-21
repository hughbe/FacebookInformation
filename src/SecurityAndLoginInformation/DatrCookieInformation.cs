using System.Collections.Generic;
using Newtonsoft.Json;

namespace FacebookInformation
{
    public class DatrCookieInformation
    {
        [JsonProperty("datr_stats")]
        public IReadOnlyDictionary<string, IReadOnlyList<int>> All { get; set; }
    }
}
