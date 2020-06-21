using System.Collections.Generic;
using Newtonsoft.Json;

namespace FacebookInformation
{
    public class Preferences
    {
        [JsonProperty("preferences")]
        public IReadOnlyList<Preference> All { get; set; }
    }
}
