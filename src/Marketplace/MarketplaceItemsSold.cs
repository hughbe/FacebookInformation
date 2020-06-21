using System.Collections.Generic;
using Newtonsoft.Json;

namespace FacebookInformation
{
    public class MarketplaceItemsSold
    {
        [JsonProperty("items_selling")]
        public IReadOnlyList<ForSaleItem> All { get; set; }
    }
}
