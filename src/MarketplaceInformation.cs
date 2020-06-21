using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace FacebookInformation
{
    public class MarketplaceInformation
    {
        public MarketplaceInformation(string folderPath)
        {
            FolderPath = folderPath;
        }

        private string FolderPath { get; }

        public MarketplaceItemsSold ItemsSold
            => Utilities.Read<MarketplaceItemsSold>(FolderPath, "items_sold");
    }
}
