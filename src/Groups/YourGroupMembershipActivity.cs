using System.Collections.Generic;
using Newtonsoft.Json;

namespace FacebookInformation
{
    public class YourGroupMembershipActivity
    {
        [JsonProperty("groups_joined")]
        public IReadOnlyList<GroupActivity> Joined { get; set; }
    }
}
