using System.Collections.Generic;
using Newtonsoft.Json;

namespace FacebookInformation
{
    public class ActiveSessions
    {
        [JsonProperty("active_sessions")]
        public IReadOnlyList<ActiveSession> All { get; set; }
    }
}
