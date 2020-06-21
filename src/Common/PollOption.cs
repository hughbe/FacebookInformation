using Newtonsoft.Json;

namespace FacebookInformation
{
    public class PollOption
    {
        [JsonProperty("option")]
        public string Option { get; set; }

        [JsonProperty("voted")]
        public bool Voted { get; set; }

        public override string ToString() => $"{Option} (Voted: {Voted})";
    }
}
