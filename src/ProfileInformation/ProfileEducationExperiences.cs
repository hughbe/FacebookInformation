using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace FacebookInformation
{
    public class ProfileEducationExperiences
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("start_timestamp")]
        public long StartTimestamp { get; set; }

        [JsonProperty("end_timestamp")]
        public long EndTimestamp { get; set; }

        [JsonProperty("graduated")]
        public bool Graduated { get; set; }

        [JsonProperty("timestamp")]
        public long Timestamp { get; set; }

        [JsonProperty("concentrations")]
        public IReadOnlyList<string> Concentrations { get; set; }

        [JsonProperty("school_type")]
        public ProfileSchoolType SchoolType { get; set; }

        public DateTime Date => Utilities.DateFromTimestampSeconds(Timestamp);

        public DateTime StartDate => Utilities.DateFromTimestampSeconds(StartTimestamp);

        public DateTime EndDate => Utilities.DateFromTimestampSeconds(EndTimestamp);

        public override string ToString() => $"({Date}) {Name}";
    }
}
