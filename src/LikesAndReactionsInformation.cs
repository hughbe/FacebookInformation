using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace FacebookInformation
{
    public class LikesAndReactionsInformation
    {
        public LikesAndReactionsInformation(string folderPath)
        {
            FolderPath = folderPath;
        }

        private string FolderPath { get; }

        public LikesOnExternalSites LikesOnExternalSites
            => Utilities.Read<LikesOnExternalSites>(FolderPath, "likes_on_external_sites");

        public PageLikes PageLikes
            => Utilities.Read<PageLikes>(FolderPath, "pages");

        public PostsAndCommentsLikes PostsAndCommentsLikes
            => Utilities.Read<PostsAndCommentsLikes>(FolderPath, "posts_and_comments");
    }
}
