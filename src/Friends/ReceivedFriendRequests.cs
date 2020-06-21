using System.Collections.Generic;
using Newtonsoft.Json;

namespace FacebookInformation
{
    public class ReceivedFriendRequests
    {
        [JsonProperty("received_requests")]
        public IReadOnlyList<Friend> All { get; set; }
    }
}
