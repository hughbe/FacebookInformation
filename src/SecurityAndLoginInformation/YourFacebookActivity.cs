using Newtonsoft.Json;

namespace FacebookInformation
{
    public class YourFacebookActivity
    {
        [JsonProperty("last_activity")]
        public LastActivity LastActivity { get; set; }

        public override string ToString() => LastActivity.ToString();
    }
}
