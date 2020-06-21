using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace FacebookInformation
{
    public class AboutYouInformation
    {
        public AboutYouInformation(string folderPath)
        {
            FolderPath = folderPath;
        }

        public string FolderPath { get; }

        public FaceRecognition FaceRecognition
            => Utilities.Read<FaceRecognition>(FolderPath, "face_recognition");

        public FriendPeerGroup FriendPeerGroup
            => Utilities.Read<FriendPeerGroup>(FolderPath, "friend_peer_group");

        public Notifications Notifications
            => Utilities.Read<Notifications>(FolderPath, "notifications");

        public Preferences Preferences
            => Utilities.Read<Preferences>(FolderPath, "preferences");

        public Viewed Viewed
            => Utilities.Read<Viewed>(FolderPath, "viewed");

        public Visited Visited
            => Utilities.Read<Visited>(FolderPath, "visited");

        public AddressBooks AddressBook
            => Utilities.Read<AddressBooks>(FolderPath, "your_address_books");
    }
}
