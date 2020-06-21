using System.Collections.Generic;
using Newtonsoft.Json;

namespace FacebookInformation
{
    public class Poll
    {
        [JsonProperty("question")]
        public string Question { get; set; }

        [JsonProperty("options")]
        public IReadOnlyList<PollOption> Options { get; set; }

        public override string ToString() => $"{Question}: {Options.Count} options";
    }
}
