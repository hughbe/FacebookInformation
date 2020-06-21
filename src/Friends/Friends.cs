using System.Collections.Generic;
using Newtonsoft.Json;

namespace FacebookInformation
{
    public class Friends
    {
        [JsonProperty("friends")]
        public IReadOnlyList<Friend> All { get; set; }
    }
}
