using Newtonsoft.Json;

namespace FacebookInformation
{
    public class MediaMetadata
    {
        [JsonProperty("photo_metadata")]
        public MediaPhotoMetadata PhotoMetadata { get; set; }

        [JsonProperty("video_metadata")]
        public MediaVideoMetadata VideoMetadata { get; set; }
    }
}
