using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace FacebookInformation
{
    public class AdministrativeRecordSession
    {
        [JsonProperty("created_timestamp")]
        public long CreatedTimestamp { get; set; }

        [JsonProperty("ip_address")]
        public string IpAddress { get; set; }

        [JsonProperty("user_agent")]
        public string UserAgent { get; set; }

        [JsonProperty("datr_cookie")]
        public string DatrCookie { get; set; }

        public DateTime CreatedDate => Utilities.DateFromTimestampSeconds(CreatedTimestamp);
    }
}
