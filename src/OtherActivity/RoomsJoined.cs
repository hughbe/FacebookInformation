using System.Collections.Generic;
using Newtonsoft.Json;

namespace FacebookInformation
{
    public class RoomsJoined
    {
        [JsonProperty("remote_presence_rooms")]
        public IReadOnlyList<RemotePresenceRoom> RemotePresenceRooms { get; set; }
    }
}
