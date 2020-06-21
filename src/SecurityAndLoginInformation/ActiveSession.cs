using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace FacebookInformation
{
    public class ActiveSession
    {
        [JsonProperty("created_timestamp")]
        public long CreatedTimestamp { get; set; }

        [JsonProperty("updated_timestamp")]
        public long UpdatedTimestamp { get; set; }

        [JsonProperty("ip_address")]
        public string IpAddress { get; set; }

        [JsonProperty("user_agent")]
        public string UserAgent { get; set; }

        [JsonProperty("datr_cookie")]
        public string DatrCookie { get; set; }

        [JsonProperty("device")]
        public string Device { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }

        [JsonProperty("app")]
        public string App { get; set; }

        public DateTime CreatedDate => Utilities.DateFromTimestampSeconds(CreatedTimestamp);

        public DateTime UpdatedDate => Utilities.DateFromTimestampSeconds(UpdatedTimestamp);

        public override string ToString() => $"({CreatedDate}) {App}";
    }
}
