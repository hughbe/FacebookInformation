using Newtonsoft.Json;

namespace FacebookInformation
{
    public class ReactionData
    {
        [JsonProperty("reaction")]
        public ReactionDataReaction Reaction { get; set; }

        public override string ToString() => Reaction.ToString();
    }
}
