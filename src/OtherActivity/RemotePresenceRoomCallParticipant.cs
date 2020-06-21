using Newtonsoft.Json;

namespace FacebookInformation
{
    public class RemotePresenceRoomCallParticipant
    {
        [JsonProperty("identifier")]
        public string Identifier { get; set; }

        public override string ToString() => Identifier;
    }
}
