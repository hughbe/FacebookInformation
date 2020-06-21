using System.Collections.Generic;
using Newtonsoft.Json;

namespace FacebookInformation
{
    public class YourOffFacebookActivity
    {
        [JsonProperty("off_facebook_activity")]
        public IReadOnlyList<YourOffFacebookActivityEntry> All { get; set; }
    }
}
