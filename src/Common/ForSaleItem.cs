using System;
using Newtonsoft.Json;

namespace FacebookInformation
{
    public class ForSaleItem
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("price")]
        public string Price { get; set; }

        [JsonProperty("seller")]
        public string Seller { get; set; }

        [JsonProperty("created_timestamp")]
        public long CreatedTimestamp { get; set; }

        [JsonProperty("updated_timestamp")]
        public long UpdatedTimestamp { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("marketplace")]
        public string Marketplace { get; set; }

        [JsonProperty("location")]
        public Place Location { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        public DateTime CreatedDate => Utilities.DateFromTimestampSeconds(CreatedTimestamp);

        public DateTime UpdatedDate => Utilities.DateFromTimestampSeconds(UpdatedTimestamp);
    }
}
