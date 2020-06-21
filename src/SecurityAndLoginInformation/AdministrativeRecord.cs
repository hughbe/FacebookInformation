using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace FacebookInformation
{
    public class AdministrativeRecord
    {
        [JsonProperty("event")]
        public string Event { get; set; }

        [JsonProperty("session")]
        public AdministrativeRecordSession Session { get; set; }

        [JsonProperty("extra_info")]
        public AdministrativeRecordExtraInformation ExtraInformation { get; set; }

        public override string ToString() => Event;
    }
}
