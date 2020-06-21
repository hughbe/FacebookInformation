using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace FacebookInformation
{
    public class OtherActivityInformation
    {
        public OtherActivityInformation(string folderPath)
        {
            FolderPath = folderPath;
        }

        private string FolderPath { get; }

        public PokesInformation Pokes
            => Utilities.Read<PokesInformation>(FolderPath, "pokes");

        public PollsYouVotedOn PollsYouVotedOn
            => Utilities.Read<PollsYouVotedOn>(FolderPath, "polls_you_voted_on");

        public RoomsJoined RoomsJoined
            => Utilities.Read<RoomsJoined>(FolderPath, "rooms_joined");

        public SupportCorrespondences SupportCorrespondences
            => Utilities.Read<SupportCorrespondences>(FolderPath, "support_correspondences");
    }
}
