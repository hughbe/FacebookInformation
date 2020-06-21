using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace FacebookInformation
{
    public class LocationInformation
    {
        public LocationInformation(string folderPath)
        {
            FolderPath = folderPath;
        }

        private string FolderPath { get; }

        public LocationHistory LocationHistory
            => Utilities.Read<LocationHistory>(FolderPath, "location_history");

        public PrimaryLocationInformation PrimaryLocation
            => Utilities.Read<PrimaryLocationInformation>(FolderPath, "primary_location");
    }
}
