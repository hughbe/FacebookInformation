using System.Collections.Generic;
using Newtonsoft.Json;

namespace FacebookInformation
{
    public class AddressBook
    {
        [JsonProperty("address_book")]
        public IReadOnlyList<AddressBookEntry> All { get; set; }
    }
}
