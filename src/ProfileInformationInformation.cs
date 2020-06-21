using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace FacebookInformation
{
    public class ProfileInformationInformation
    {
        public ProfileInformationInformation(string folderPath)
        {
            FolderPath = folderPath;
        }

        private string FolderPath { get; }

        public ProfileInformation ProfileInformation
            => Utilities.Read<ProfileInformation>(FolderPath, "profile_information");

        public ProfileUpdateHistory ProfileUpdateHistory
            => Utilities.Read<ProfileUpdateHistory>(FolderPath, "profile_update_history");
    }
}
