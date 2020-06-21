using System.Collections.Generic;
using Newtonsoft.Json;

namespace FacebookInformation
{
    public class PeopleInteractions
    {
        [JsonProperty("people_items")]
        public IReadOnlyList<Interaction> All { get; set; }
    }
}
