using System.Collections.Generic;
using Newtonsoft.Json;

namespace FacebookInformation
{
    public class UsedIpAddresses
    {
        [JsonProperty("used_ip_address")]
        public IReadOnlyList<UsedIpAddress> All { get; set; }
    }
}
