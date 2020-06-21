using Newtonsoft.Json;

namespace FacebookInformation
{
    public class FacialData
    {
        [JsonProperty("threshold_green")]
        public double ThresholdGreen { get; set; }

        [JsonProperty("threshold_yellow")]
        public double ThresholdYellow { get; set; }

        [JsonProperty("threshold_red")]
        public double ThresholdRed { get; set; }

        [JsonProperty("example_count")]
        public int ExampleCount { get; set; }

        [JsonProperty("raw_data")]
        public string RawData { get; set; }
    }
}
