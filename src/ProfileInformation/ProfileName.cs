using System;
using Newtonsoft.Json;

namespace FacebookInformation
{
    public class ProfileName
    {
        [JsonProperty("full_name")]
        public string FullName { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("middle_name")]
        public string MiddleName { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        public override string ToString() => FullName;
    }
}
