using System.Collections.Generic;
using Newtonsoft.Json;

namespace FacebookInformation
{
    public class AdvertisersWhoUploadedContactListWithYouInformation
    {
        [JsonProperty("custom_audiences")]
        public IReadOnlyList<string> CustomAudiences { get; set; }
    }
}
