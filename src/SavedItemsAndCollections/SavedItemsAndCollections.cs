using System.Collections.Generic;
using Newtonsoft.Json;

namespace FacebookInformation
{
    public class SavedItemsAndCollections
    {
        [JsonProperty("saves_and_collections")]
        public IReadOnlyList<SavedItem> All { get; set; }
    }
}
