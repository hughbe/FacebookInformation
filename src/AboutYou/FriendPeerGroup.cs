using Newtonsoft.Json;

namespace FacebookInformation
{
    public class FriendPeerGroup
    {
        [JsonProperty("friend_peer_group")]
        public string PeerGroup { get; set; }

        public override string ToString() => PeerGroup;
    }
}
