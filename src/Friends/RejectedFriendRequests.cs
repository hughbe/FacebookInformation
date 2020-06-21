using System.Collections.Generic;
using Newtonsoft.Json;

namespace FacebookInformation
{
    public class RejectedFriendRequests
    {
        [JsonProperty("rejected_requests")]
        public IReadOnlyList<RejectedFriendRequest> All { get; set; }
    }
}
