using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace FacebookInformation
{
    public class Payments
    {
        [JsonProperty("preferred_currency")]
        public string PreferredCurrency { get; set; }

        [JsonProperty("payments")]
        public IReadOnlyList<Payment> All { get; set; }
    }
}
