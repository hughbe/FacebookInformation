using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace FacebookInformation
{
    public class FollowingAndFollowersInformation
    {
        public FollowingAndFollowersInformation(string folderPath)
        {
            FolderPath = folderPath;
        }

        public string FolderPath { get; }

        public UnfollowedPages UnfollowedPages
            => Utilities.Read<UnfollowedPages>(FolderPath, "unfollowed_pages");
    }
}
