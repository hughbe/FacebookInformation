using Newtonsoft.Json;

namespace FacebookInformation
{
    public class MessageParticipant
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        public override string ToString() => Name;
    }
}
