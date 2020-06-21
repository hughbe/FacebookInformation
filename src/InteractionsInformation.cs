using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace FacebookInformation
{
    public class InteractionsInformation
    {
        public InteractionsInformation(string folderPath)
        {
            FolderPath = folderPath;
        }

        private string FolderPath { get; }

        public EventsInteractions Events
            => Utilities.Read<EventsInteractions>(FolderPath, "events");

        public MenuItemsInteractions MenuItems
            => Utilities.Read<MenuItemsInteractions>(FolderPath, "menu_items");

        public PeopleInteractions People
            => Utilities.Read<PeopleInteractions>(FolderPath, "people");
    }
}
