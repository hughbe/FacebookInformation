using Newtonsoft.Json;

namespace FacebookInformation
{
    public class MediaPhotoMetadata
    {
        [JsonProperty("upload_ip")]
        public string UploadIp { get; set; }

        [JsonProperty("orientation")]
        public long Orientation { get; set; }

        [JsonProperty("latitude")]
        public double? Latitude { get; set; }

        [JsonProperty("longitude")]
        public double? Longitude { get; set; }
    }
}
