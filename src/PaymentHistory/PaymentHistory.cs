using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace FacebookInformation
{
    public class PaymentHistory
    {
        [JsonProperty("payments")]
        public Payments All { get; set; }
    }
}
