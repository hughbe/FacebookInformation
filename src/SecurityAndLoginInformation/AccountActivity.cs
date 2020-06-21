using System.Collections.Generic;
using Newtonsoft.Json;

namespace FacebookInformation
{
    public class AccountActivity
    {
        [JsonProperty("account_activity")]
        public IReadOnlyList<AccountActivityEntry> All { get; set; }
    }
}
