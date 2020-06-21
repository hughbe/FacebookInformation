using System.Collections.Generic;
using Newtonsoft.Json;

namespace FacebookInformation
{
    public class PrimaryLocation
    {
        [JsonProperty("city_region_pairs")]
        public IReadOnlyList<IReadOnlyList<string>> CityRegionPairs { get; set; }

        [JsonProperty("zipcode")]
        public IReadOnlyList<string> Zipcode { get; set; }
    }
}
