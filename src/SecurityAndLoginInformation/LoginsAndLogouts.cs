using System.Collections.Generic;
using Newtonsoft.Json;

namespace FacebookInformation
{
    public class LoginsAndLogouts
    {
        [JsonProperty("account_accesses")]
        public IReadOnlyList<AccountAccess> All { get; set; }
    }
}
