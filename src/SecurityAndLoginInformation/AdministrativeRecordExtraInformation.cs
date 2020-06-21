using Newtonsoft.Json;

namespace FacebookInformation
{
    public class AdministrativeRecordExtraInformation
    {
        [JsonProperty("old_name")]
        public string OldName { get; set; }

        [JsonProperty("new_name")]
        public string NewName { get; set; }

        [JsonProperty("old_number")]
        public string OldNumber { get; set; }

        [JsonProperty("old_vanity")]
        public string OldVanity { get; set; }

        [JsonProperty("new_vanity")]
        public string NewVanity { get; set; }

        [JsonProperty("old_email")]
        public string OldEmail { get; set; }

        [JsonProperty("new_email")]
        public string NewEmail { get; set; }

        [JsonProperty("new_number")]
        public string NewNumber { get; set; }

    }
}
