using System.Collections.Generic;
using Newtonsoft.Json;

namespace FacebookInformation
{
    public class ProfileEmails
    {
        [JsonProperty("emails")]
        public IReadOnlyList<string> Emails { get; set; }

        [JsonProperty("previous_emails")]
        public IReadOnlyList<string> PreviousEmails { get; set; }

        [JsonProperty("pending_emails")]
        public IReadOnlyList<string> PendingEmails { get; set; }

        [JsonProperty("ad_account_emails")]
        public IReadOnlyList<string> AdAccountEmails { get; set; }
    }
}
