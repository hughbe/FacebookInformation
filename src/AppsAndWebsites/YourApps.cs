using System.Collections.Generic;
using Newtonsoft.Json;

namespace FacebookInformation
{
    public class YourApps
    {
        [JsonProperty("admined_apps")]
        public IReadOnlyList<App> AdminedApps { get; set; }
    }
}
