using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace FacebookInformation
{
    public class FacebookInformation
    {
        public FacebookInformation(string folderPath)
        {
            FolderPath = folderPath;
        }

        private string FolderPath { get; }

        public AboutYouInformation AboutYou => new AboutYouInformation(Path.Combine(FolderPath, "about_you"));

        public AdsAndBusinessesInformation AdsAndBusinesses => new AdsAndBusinessesInformation(Path.Combine(FolderPath, "ads_and_businesses"));

        public AppsAndWebsitesInformation AppsAndWebsites => new AppsAndWebsitesInformation(Path.Combine(FolderPath, "apps_and_websites"));

        public Comments Comments => Utilities.Read<Comments>(Path.Combine(FolderPath, "comments"), "comments");

        public EventsInformation Events => new EventsInformation(Path.Combine(FolderPath, "events"));

        public GamingInformation Gaming => new GamingInformation(Path.Combine(FolderPath, "facebook_gaming"));

        public FilesInformation Files => new FilesInformation(Path.Combine(FolderPath, "files"));

        public FollowingAndFollowersInformation FollowingAndFollowers => new FollowingAndFollowersInformation(Path.Combine(FolderPath, "following_and_followers"));

        public FriendsInformation Friends => new FriendsInformation(Path.Combine(FolderPath, "friends"));

        public GroupsInformation Groups => new GroupsInformation(Path.Combine(FolderPath, "groups"));

        public InformationUsedForReccomendationsInformation InformationUsedForReccomendations => new InformationUsedForReccomendationsInformation(Path.Combine(FolderPath, "information_used_for_recommendations"));

        public InteractionsInformation Interactions => new InteractionsInformation(Path.Combine(FolderPath, "interactions"));

        public LikesAndReactionsInformation LikesAndReactions => new LikesAndReactionsInformation(Path.Combine(FolderPath, "likes_and_reactions"));

        public LocationInformation Location => new LocationInformation(Path.Combine(FolderPath, "location"));

        public MarketplaceInformation Marketplace => new MarketplaceInformation(Path.Combine(FolderPath, "marketplace"));

        public MessagesInformation Messages => new MessagesInformation(Path.Combine(FolderPath, "messages"));

        public OtherActivityInformation OtherActivity => new OtherActivityInformation(Path.Combine(FolderPath, "other_activity"));

        public PagesInformation Pages => new PagesInformation(Path.Combine(FolderPath, "pages"));

        public PaymentHistory PaymentHistory => Utilities.Read<PaymentHistory>(Path.Combine(FolderPath, "payment_history"), "payment_history");

        public PhotosAndVideosInformation PhotosAndVideos => new PhotosAndVideosInformation(Path.Combine(FolderPath, "photos_and_videos"));

        public IReadOnlyList<Post> Posts => Utilities.Read<IReadOnlyList<Post>>(Path.Combine(FolderPath, "posts"), "your_posts_1");

        public ProfileInformationInformation ProfileInformation => new ProfileInformationInformation(Path.Combine(FolderPath, "profile_information"));

        public SavedItemsAndCollections SavedItemsAndCollections => Utilities.Read<SavedItemsAndCollections>(Path.Combine(FolderPath, "saved_items_and_collections"), "saved_items_and_collections");

        public SearchHistory SearchHistory => Utilities.Read<SearchHistory>(Path.Combine(FolderPath, "search_history"), "your_search_history");

        public SecurityAndLoginInformation SecurityAndLoginInformation => new SecurityAndLoginInformation(Path.Combine(FolderPath, "security_and_login_information"));

        public PlacesYouCreated PlacesYouCreated => Utilities.Read<PlacesYouCreated>(Path.Combine(FolderPath, "your_places"), "places_you've_created");
    }
}
