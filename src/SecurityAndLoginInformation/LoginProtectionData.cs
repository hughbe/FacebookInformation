using System.Collections.Generic;
using Newtonsoft.Json;

namespace FacebookInformation
{
    public class LoginProtectionData
    {
        [JsonProperty("login_protection_data")]
        public IReadOnlyList<LoginProtectionDataEntry> All { get; set; }
    }
}
