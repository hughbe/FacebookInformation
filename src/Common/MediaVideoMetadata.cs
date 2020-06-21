using System;
using Newtonsoft.Json;

namespace FacebookInformation
{
    public class MediaVideoMetadata
    {
        [JsonProperty("upload_ip")]
        public string UploadIp { get; set; }

        [JsonProperty("upload_timestamp")]
        public long UploadTimestamp { get; set; }

        public DateTime UploadDate => Utilities.DateFromTimestampSeconds(UploadTimestamp);
    }
}
