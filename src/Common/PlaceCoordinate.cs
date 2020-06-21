using Newtonsoft.Json;

namespace FacebookInformation
{
    public class PlaceCoordinate
    {
        [JsonProperty("latitude")]
        public double Latitude { get; set; }

        [JsonProperty("longitude")]
        public double Longitude { get; set; }

        public override string ToString() => $"{Latitude}, {Longitude}";
    }
}
