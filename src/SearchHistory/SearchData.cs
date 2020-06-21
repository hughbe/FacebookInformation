using Newtonsoft.Json;

namespace FacebookInformation
{
    public class SearchData
    {
        [JsonProperty("text")]
        public string Text { get; set; }

        public override string ToString() => Text;
    }
}
