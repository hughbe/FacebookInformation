using System.Collections.Generic;
using Newtonsoft.Json;

namespace FacebookInformation
{
    public class YourGroups
    {
        [JsonProperty("groups_admined")]
        public IReadOnlyList<Group> Admined { get; set; }
    }
}
