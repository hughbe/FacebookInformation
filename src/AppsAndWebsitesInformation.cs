using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace FacebookInformation
{
    public class AppsAndWebsitesInformation
    {
        public AppsAndWebsitesInformation(string folderPath)
        {
            FolderPath = folderPath;
        }

        public string FolderPath { get; }

        public AppsAndWebsites AppsAndWebsites
            => Utilities.Read<AppsAndWebsites>(FolderPath, "apps_and_websites");

        public YourApps YourApps
            => Utilities.Read<YourApps>(FolderPath, "your_apps");
    }
}
