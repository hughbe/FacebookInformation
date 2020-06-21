using System.Collections.Generic;
using Newtonsoft.Json;

namespace FacebookInformation
{
    public class Attachment
    {
        [JsonProperty("data")]
        public IReadOnlyList<AttachmentData> Data { get; set; }

        public override string ToString() => Data.ToString();
    }
}
