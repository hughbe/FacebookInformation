using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace FacebookInformation
{
    public class PhotosAndVideosInformation
    {
        public PhotosAndVideosInformation(string folderPath)
        {
            FolderPath = folderPath;
        }

        private string FolderPath { get; }

        public YourVideos YourVideos
            => Utilities.Read<YourVideos>(FolderPath, "your_videos");

        public Albums Albums => new Albums(Path.Combine(FolderPath, "album"));
    }
}
