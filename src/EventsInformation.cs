using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace FacebookInformation
{
    public class EventsInformation
    {
        public EventsInformation(string folderPath)
        {
            FolderPath = folderPath;
        }

        public string FolderPath { get; }

        public EventInvitations Invitations
            => Utilities.Read<EventInvitations>(FolderPath, "event_invitations");

        public YourEventResponses YourEventResponses
            => Utilities.Read<YourEventResponses>(FolderPath, "your_event_responses");

        public YourEvents YourEvents
            => Utilities.Read<YourEvents>(FolderPath, "your_events");
    }
}
