using Newtonsoft.Json;

namespace FacebookInformation
{
    public class AddressBookDetails
    {
        [JsonProperty("contact_point")]
        public string ContactPoint { get; set; }
    }
}
