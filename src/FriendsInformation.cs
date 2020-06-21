using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace FacebookInformation
{
    public class FriendsInformation
    {
        public FriendsInformation(string folderPath)
        {
            FolderPath = folderPath;
        }

        private string FolderPath { get; }

        public Friends Friends
            => Utilities.Read<Friends>(FolderPath, "friends");

        public ReceivedFriendRequests ReceivedFriendRequests
            => Utilities.Read<ReceivedFriendRequests>(FolderPath, "received_friend_requests");

        public RejectedFriendRequests RejectedFriendRequests
            => Utilities.Read<RejectedFriendRequests>(FolderPath, "rejected_friend_requests");

        public RemovedFriends RemovedFriends
            => Utilities.Read<RemovedFriends>(FolderPath, "removed_friends");

        public SentFriendRequests SentFriendRequests
            => Utilities.Read<SentFriendRequests>(FolderPath, "sent_friend_requests");
    }
}
