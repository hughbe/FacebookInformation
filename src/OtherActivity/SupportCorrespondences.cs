using System.Collections.Generic;
using Newtonsoft.Json;

namespace FacebookInformation
{
    public class SupportCorrespondences
    {
        [JsonProperty("support_correspondence")]
        public IReadOnlyList<SupportCorrespondence> All { get; set; }
    }
}
