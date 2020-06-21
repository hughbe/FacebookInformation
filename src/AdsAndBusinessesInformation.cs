using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace FacebookInformation
{
    public class AdsAndBusinessesInformation
    {
        public AdsAndBusinessesInformation(string folderPath)
        {
            FolderPath = folderPath;
        }

        public string FolderPath { get; }

        public AdsInterests AdsInterests
            => Utilities.Read<AdsInterests>(FolderPath, "ads_interests");

        public AdvertisersWhoUploadedContactListWithYouInformation AdvertisersWhoUploadedContactListWithYouInformation
            => Utilities.Read<AdvertisersWhoUploadedContactListWithYouInformation>(FolderPath, "advertisers_who_uploaded_a_contact_list_with_your_information");

        public AdvertisersWhoYouInteractedWith AdvertisersWhoYouInteractedWith
            => Utilities.Read<AdvertisersWhoYouInteractedWith>(FolderPath, "advertisers_you've_interacted_with");

        public YourOffFacebookActivity YourOffFacebookActivity
            => Utilities.Read<YourOffFacebookActivity>(FolderPath, "your_off-facebook_activity");
    }
}
