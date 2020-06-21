using Newtonsoft.Json;

namespace FacebookInformation
{
    public class LastActivityTime
    {
        [JsonProperty("website")]
        public LastActivityTimeEntry Website { get; set; }

        [JsonProperty("Facebook app")]
        public LastActivityTimeEntry FacebookApp { get; set; }

        [JsonProperty("iPhone")]
        public LastActivityTimeEntry iPhone { get; set; }

        [JsonProperty("Mobile Web")]
        public LastActivityTimeEntry MobileWeb { get; set; }
    }
}
