using Newtonsoft.Json;

namespace FacebookInformation
{
    public class AttachmentData
    {
        [JsonProperty("external_context")]
        public AttachmentExternalContext ExternalContext { get; set; }

        [JsonProperty("media")]
        public Media Media { get; set; }

        [JsonProperty("place")]
        public Place Place { get; set; }

        [JsonProperty("for_sale_item")]
        public ForSaleItem ForSaleItem { get; set; }

        [JsonProperty("event")]
        public YourEvent Event { get; set; }

        [JsonProperty("poll")]
        public Poll Poll { get; set; }

        [JsonProperty("life_event")]
        public LifeEvent LifeEvent { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        public override string ToString() => ExternalContext?.ToString() ?? Media.ToString();
    }
}
