using System.Collections.Generic;
using Newtonsoft.Json;

namespace FacebookInformation
{
    public class Notifications
    {
        [JsonProperty("notifications")]
        public IReadOnlyList<Notification> All { get; set; }
    }
}
