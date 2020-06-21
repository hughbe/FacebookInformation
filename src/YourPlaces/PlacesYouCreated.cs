using System.Collections.Generic;
using Newtonsoft.Json;

namespace FacebookInformation
{
    public class PlacesYouCreated
    {
        [JsonProperty("your_places")]
        public IReadOnlyList<CreatedPlace> All { get; set; }
    }
}
