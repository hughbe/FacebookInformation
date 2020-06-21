using System;
using Newtonsoft.Json;

namespace FacebookInformation
{
    public class Media
    {
        [JsonProperty("uri")]
        public string Uri { get; set; }

        [JsonProperty("creation_timestamp")]
        public long CreationTimestamp { get; set; }

        [JsonProperty("media_metadata")]
        public MediaMetadata Metadata { get; set; }

        [JsonProperty("thumbnail")]
        public MediaThumbnail Thumbnail { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        public DateTime CreationDate => Utilities.DateFromTimestampSeconds(CreationTimestamp);

        public override string ToString() => Uri;
    }
}
