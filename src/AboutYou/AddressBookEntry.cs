using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace FacebookInformation
{
    public class AddressBookEntry
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("details")]
        public IReadOnlyList<AddressBookDetails> Details { get; set; }

        [JsonProperty("created_timestamp")]
        public long CreatedTimestamp { get; set; }

        [JsonProperty("updated_timestamp")]
        public long UpdatedTimestamp { get; set; }

        public DateTime CreatedDate => Utilities.DateFromTimestampSeconds(CreatedTimestamp);

        public DateTime UpdatedDate => Utilities.DateFromTimestampSeconds(UpdatedTimestamp);

        public override string ToString() => Name;
    }
}
