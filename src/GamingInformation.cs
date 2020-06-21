using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace FacebookInformation
{
    public class GamingInformation
    {
        public GamingInformation(string folderPath)
        {
            FolderPath = folderPath;
        }

        private string FolderPath { get; }

        public InstantGames InstantGames
            => Utilities.Read<InstantGames>(FolderPath, "instant_games");
    }
}
