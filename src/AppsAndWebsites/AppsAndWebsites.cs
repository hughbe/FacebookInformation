using System.Collections.Generic;
using Newtonsoft.Json;

namespace FacebookInformation
{
    public class AppsAndWebsites
    {
        [JsonProperty("installed_apps")]
        public IReadOnlyList<App> InstalledApps { get; set; }
    }
}
