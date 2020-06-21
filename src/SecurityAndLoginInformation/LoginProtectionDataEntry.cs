using System.Collections.Generic;
using Newtonsoft.Json;

namespace FacebookInformation
{
    public class LoginProtectionDataEntry
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("session")]
        public LoginProtectionDataEntrySession Session { get; set; }

        public override string ToString() => Name;
    }
}
