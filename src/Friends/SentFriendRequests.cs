using System.Collections.Generic;
using Newtonsoft.Json;

namespace FacebookInformation
{
    public class SentFriendRequests
    {
        [JsonProperty("sent_requests")]
        public IReadOnlyList<Friend> All { get; set; }
    }
}
