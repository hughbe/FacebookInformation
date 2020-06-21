using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace FacebookInformation
{
    public class PagesInformation
    {
        public PagesInformation(string folderPath)
        {
            FolderPath = folderPath;
        }

        private string FolderPath { get; }
    }
}
