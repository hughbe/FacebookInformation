using System.Collections.Generic;
using Newtonsoft.Json;

namespace FacebookInformation
{
    public class RemotePresenceRoom
    {
        [JsonProperty("calls")]
        public IReadOnlyList<RemotePresenceRoomCall> Calls { get; set; }
    }
}
