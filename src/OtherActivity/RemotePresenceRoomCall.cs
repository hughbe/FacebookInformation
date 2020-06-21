using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace FacebookInformation
{
    public class RemotePresenceRoomCall
    {
        [JsonProperty("start_time")]
        public long StartTime { get; set; }

        [JsonProperty("end_time")]
        public long EndTime { get; set; }

        [JsonProperty("call_type")]
        public int CallType { get; set; }

        [JsonProperty("call_participants")]
        public IReadOnlyList<RemotePresenceRoomCallParticipant> Participants { get; set; }

        public DateTime StartDate => Utilities.DateFromTimestampSeconds(StartTime);

        public DateTime EndDate => Utilities.DateFromTimestampSeconds(EndTime);
    }
}
