using System.Collections.Generic;
using Newtonsoft.Json;

namespace FacebookInformation
{
    public class LifeEvent
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("start_date")]
        public ProfileDate StartDate { get; set; }

        [JsonProperty("end_date")]
        public ProfileDate EndDate { get; set; }

        [JsonProperty("place")]
        public Place Place { get; set; }

        public override string ToString() => Title;
    }
}
