using System.Collections.Generic;
using Newtonsoft.Json;

namespace FacebookInformation
{
    public class ProfileUpdateHistory
    {
        [JsonProperty("profile_updates")]
        public IReadOnlyList<ProfileUpdate> All { get; set; }
    }
}
