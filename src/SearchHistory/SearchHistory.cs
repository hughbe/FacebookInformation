using System.Collections.Generic;
using Newtonsoft.Json;

namespace FacebookInformation
{
    public class SearchHistory
    {
        [JsonProperty("searches")]
        public IReadOnlyList<Search> All { get; set; }
    }
}
