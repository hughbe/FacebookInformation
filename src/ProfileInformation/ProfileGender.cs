using Newtonsoft.Json;

namespace FacebookInformation
{
    public class ProfileGender
    {
        [JsonProperty("gender_option")]
        public string Option { get; set; }

        [JsonProperty("pronoun")]
        public string Pronoun { get; set; }

        public override string ToString() => Option;
    }
}
