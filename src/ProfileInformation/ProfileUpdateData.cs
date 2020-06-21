using System;
using Newtonsoft.Json;

namespace FacebookInformation
{
    public class ProfileUpdateData
    {
        [JsonProperty("backdated_timestamp")]
        public long BackdatedTimestamp { get; set; }

        public DateTime BackdatedDate => Utilities.DateFromTimestampSeconds(BackdatedTimestamp);

        public override string ToString() => BackdatedDate.ToString();
    }
}
