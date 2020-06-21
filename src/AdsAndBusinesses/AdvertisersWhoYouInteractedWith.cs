using System.Collections.Generic;
using Newtonsoft.Json;

namespace FacebookInformation
{
    public class AdvertisersWhoYouInteractedWith
    {
        [JsonProperty("history")]
        public IReadOnlyList<AdvertisersWhoYouInteractedWithHistoryEntry> History { get; set; }
    }
}
