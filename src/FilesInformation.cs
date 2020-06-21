using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace FacebookInformation
{
    public class FilesInformation
    {
        public FilesInformation(string folderPath)
        {
            FolderPath = folderPath;
        }

        private string FolderPath { get; }

        public string[] Names => Directory.GetDirectories(FolderPath);
    }
}
