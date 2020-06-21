using System;
using Newtonsoft.Json;

namespace FacebookInformation
{
    public class ProfileInformation
    {
        [JsonProperty("profile")]
        public Profile Profile { get; set; }

        public override string ToString() => Profile.ToString();
    }
}
