using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace FacebookInformation
{
    public class LoginProtectionDataEntrySession
    {
        [JsonProperty("created_timestamp")]
        public long CreatedTimestamp { get; set; }

        [JsonProperty("updated_timestamp")]
        public long UpdatedTimestamp { get; set; }

        [JsonProperty("ip_address")]
        public string IpAddress { get; set; }

        public DateTime CreatedDate => Utilities.DateFromTimestampSeconds(CreatedTimestamp);

        public DateTime UpdatedDate => Utilities.DateFromTimestampSeconds(UpdatedTimestamp);

        public override string ToString() => $"({CreatedDate}) {IpAddress}";
    }
}
