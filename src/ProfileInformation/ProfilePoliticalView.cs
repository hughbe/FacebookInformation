using Newtonsoft.Json;

namespace FacebookInformation
{
    public class ProfilePoliticalView
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        public override string ToString() => Name;
    }
}
