using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace FacebookInformation
{
    public class MessagesCollection
    {
        public MessagesCollection(string folderPath)
        {
            FolderPath = folderPath;
        }

        public string FolderPath { get; }

        public string[] Ids => Directory.GetDirectories(FolderPath);

        public MessageThread GetMessage(string id)
            => Utilities.Read<MessageThread>(Path.Combine(FolderPath, id), "message_1");
    }
}
