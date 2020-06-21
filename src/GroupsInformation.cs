using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace FacebookInformation
{
    public class GroupsInformation
    {
        public GroupsInformation(string folderPath)
        {
            FolderPath = folderPath;
        }

        private string FolderPath { get; }

        public YourGroupMembershipActivity YourGroupMembershipActivity
            => Utilities.Read<YourGroupMembershipActivity>(FolderPath, "your_group_membership_activity");

        public YourGroups YourGroups
            => Utilities.Read<YourGroups>(FolderPath, "your_groups");

        public YourPostsAndCommentsInGroups YourPostsAndCommentsInGroups
            => Utilities.Read<YourPostsAndCommentsInGroups>(FolderPath, "your_posts_and_comments_in_groups");
    }
}
