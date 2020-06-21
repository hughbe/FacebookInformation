using System.Collections.Generic;
using Newtonsoft.Json;

namespace FacebookInformation
{
    public class AdsInterests
    {
        [JsonProperty("topics")]
        public IReadOnlyList<string> Topics { get; set; }
    }
}
