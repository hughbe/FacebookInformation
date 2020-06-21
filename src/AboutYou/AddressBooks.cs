using System.Collections.Generic;
using Newtonsoft.Json;

namespace FacebookInformation
{
    public class AddressBooks
    {
        [JsonProperty("address_book")]
        public AddressBook AddressBook { get; set; }
    }
}
