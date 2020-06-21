using Newtonsoft.Json;

namespace FacebookInformation
{
    public class LastActivity
    {
        [JsonProperty("last_activity_time")]
        public LastActivityTime LastActivityTime { get; set; }

        public override string ToString() => LastActivityTime.ToString();
    }
}
