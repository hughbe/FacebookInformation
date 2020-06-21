using System;
using System.IO;
using Newtonsoft.Json;

namespace FacebookInformation
{
    public class FaceRecognition
    {
        [JsonProperty("facial_data")]
        public FacialData FacialData { get; set; }
    }
}
