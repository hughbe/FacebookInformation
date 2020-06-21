using System.Collections.Generic;
using Newtonsoft.Json;

namespace FacebookInformation
{
    public class PollsYouVotedOn
    {
        [JsonProperty("poll_votes")]
        public IReadOnlyList<PollVote> All { get; set; }
    }
}
