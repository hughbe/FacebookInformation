using System.Collections.Generic;
using Newtonsoft.Json;

namespace FacebookInformation
{
    public class AccountStatusChanges
    {
        [JsonProperty("account_status_changes")]
        public IReadOnlyList<AccountStatusChange> All { get; set; }
    }
}
