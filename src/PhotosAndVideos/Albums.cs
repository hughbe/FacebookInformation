using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace FacebookInformation
{
    public class Albums
    {
        public Albums(string folderPath)
        {
            FolderPath = folderPath;
        }

        public string FolderPath { get; }

        public string[] Ids => Directory.GetDirectories(FolderPath);

        public Album GetAlbum(string id)
            => Utilities.Read<Album>(FolderPath, id + ".json");

        public IReadOnlyList<Album> All
        {
            get
            {
                string[] ids = Ids;
                var list = new List<Album>(ids.Length);
                foreach (string id in ids)
                {
                    list.Add(GetAlbum(id));
                }

                return list;
            }
        }
    }
}
