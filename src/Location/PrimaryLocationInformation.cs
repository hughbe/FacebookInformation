using Newtonsoft.Json;

namespace FacebookInformation
{
    public class PrimaryLocationInformation
    {
        [JsonProperty("primary_location")]
        public PrimaryLocation PrimaryLocation { get; set; }

        public override string ToString() => PrimaryLocation.ToString();
    }
}
