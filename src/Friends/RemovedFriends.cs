using System.Collections.Generic;
using Newtonsoft.Json;

namespace FacebookInformation
{
    public class RemovedFriends
    {
        [JsonProperty("deleted_friends")]
        public IReadOnlyList<Friend> All { get; set; }
    }
}
