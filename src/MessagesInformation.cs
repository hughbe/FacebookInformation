using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace FacebookInformation
{
    public class MessagesInformation
    {
        public MessagesInformation(string folderPath)
        {
            FolderPath = folderPath;
        }

        public string FolderPath { get; }

        public MessagesCollection ArchivedThreads => new MessagesCollection(Path.Combine(FolderPath, "archived_threads"));

        public MessagesCollection FilteredThreads => new MessagesCollection(Path.Combine(FolderPath, "filtered_threads"));

        public MessagesCollection Inbox => new MessagesCollection(Path.Combine(FolderPath, "inbox"));

        public MessagesCollection MessageRequests => new MessagesCollection(Path.Combine(FolderPath, "message_requests"));
    }
}
