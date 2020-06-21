using System;
using Newtonsoft.Json;

namespace FacebookInformation
{
    public class ProfilePhoneNumber
    {
        [JsonProperty("phone_type")]
        public ProfilePhoneNumberType Type { get; set; }

        [JsonProperty("phone_number")]
        public string Number { get; set; }

        [JsonProperty("verified")]
        public bool Verified { get; set; }

        public override string ToString() => $"{Number} ({Type})";
    }
}
