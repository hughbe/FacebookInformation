using System;
using Newtonsoft.Json;

namespace FacebookInformation
{
    public class RejectedFriendRequest : Friend
    {
        [JsonProperty("marked_as_spam")]
        public bool MarkedAsSpam { get; set; }
    }
}
