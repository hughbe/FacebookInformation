using Newtonsoft.Json;

namespace FacebookInformation
{
    public class ProfileBloodInformation
    {
        [JsonProperty("blood_donor_status")]
        public ProfileBloodDonorStatus DonorStatus { get; set; }

        public override string ToString() => DonorStatus.ToString();
    }
}
