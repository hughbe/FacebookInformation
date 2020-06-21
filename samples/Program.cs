using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using Nest;
using Newtonsoft.Json;

namespace FacebookInformation
{
    class Program
    {
        private static void DumpInformation(FacebookInformation information)
        {
            Console.WriteLine();
            Console.WriteLine("Dumping about_you/face_recognition.json");
            Console.WriteLine($"ThresholdGreen: {information.AboutYou.FaceRecognition.FacialData.ThresholdGreen}");
            Console.WriteLine($"ThresholdYellow: {information.AboutYou.FaceRecognition.FacialData.ThresholdYellow}");
            Console.WriteLine($"ThresholdRed: {information.AboutYou.FaceRecognition.FacialData.ThresholdRed}");
            Console.WriteLine($"ExampleCount: {information.AboutYou.FaceRecognition.FacialData.ExampleCount}");
            Console.WriteLine($"RawData: {information.AboutYou.FaceRecognition.FacialData.RawData}");

            Console.WriteLine();
            Console.WriteLine("Dumping about_you/friend_peer_group.json");
            Console.WriteLine($"PeerGroup: {information.AboutYou.FriendPeerGroup.PeerGroup}");

            Console.WriteLine();
            Console.WriteLine("Dumping about_you/notifications.json");
            IReadOnlyList<Notification> notifications = information.AboutYou.Notifications.All;
            Console.WriteLine($"{notifications.Count} Notifications");
            for (int i = 0; i < notifications.Count; i++)
            {
                Console.WriteLine($"\t[{i}] Date: {notifications[i].Date}");
                Console.WriteLine($"\t[{i}] Href: {notifications[i].Href}");
                Console.WriteLine($"\t[{i}] Text: {notifications[i].Text}");
                Console.WriteLine($"\t[{i}] Timestamp: {notifications[i].Timestamp}");
                Console.WriteLine($"\t[{i}] Unread: {notifications[i].Unread}");
            }

            Console.WriteLine();
            Console.WriteLine("Dumping about_you/preferences.json");
            IReadOnlyList<Preference> preferences = information.AboutYou.Preferences.All;
            Console.WriteLine($"{preferences.Count} preferences");
            for (int i = 0; i < preferences.Count; i++)
            {
                Console.WriteLine($"\t[{i}] Name: {preferences[i].Name}");
                Console.WriteLine($"\t[{i}] Description: {preferences[i].Description}");
                Console.WriteLine($"\t[{i}] Entries: {preferences[i].Entries.Count}");
            }

            Console.WriteLine();
            Console.WriteLine("Dumping about_you/viewed.json");
            IReadOnlyList<ViewedThing> viewed = information.AboutYou.Viewed.All;
            Console.WriteLine($"{viewed.Count} viewed");
            for (int i = 0; i < viewed.Count; i++)
            {
                Console.WriteLine($"\t[{i}] Name: {viewed[i].Name}");
                Console.WriteLine($"\t[{i}] Description: {viewed[i].Description}");
                Console.WriteLine($"\t[{i}] Children: {viewed[i].Children?.Count ?? 0}");
                Console.WriteLine($"\t[{i}] Entries: {viewed[i].Entries?.Count ?? 0}");
            }

            Console.WriteLine();
            Console.WriteLine("Dumping about_you/visited.json");
            IReadOnlyList<VisitedThing> visited = information.AboutYou.Visited.All;
            Console.WriteLine($"{visited.Count} visited");
            for (int i = 0; i < visited.Count; i++)
            {
                Console.WriteLine($"\t[{i}] Name: {visited[i].Name}");
                Console.WriteLine($"\t[{i}] Description: {visited[i].Description}");
                Console.WriteLine($"\t[{i}] Entries: {visited[i].Entries.Count}");
            }

            Console.WriteLine();
            Console.WriteLine("Dumping about_you/your_address_book.json");
            IReadOnlyList<AddressBookEntry> addressBook = information.AboutYou.AddressBook.AddressBook.All;
            Console.WriteLine($"{addressBook.Count} addressBook");
            for (int i = 0; i < addressBook.Count; i++)
            {
                Console.WriteLine($"\t[{i}] Name: {addressBook[i].Name}");
                Console.WriteLine($"\t[{i}] Details: {addressBook[i].Details.Count}");
                Console.WriteLine($"\t[{i}] CreatedDate: {addressBook[i].CreatedDate}");
                Console.WriteLine($"\t[{i}] UpdatedDate: {addressBook[i].UpdatedDate}");
            }

            Console.WriteLine();
            Console.WriteLine("Dumping ads_and_businesses/ads_interests.json");
            IReadOnlyList<string> topics = information.AdsAndBusinesses.AdsInterests.Topics;
            Console.WriteLine($"{topics.Count} topics");
            for (int i = 0; i < topics.Count; i++)
            {
                Console.WriteLine($"\t[{i}] {topics[i]}");
            }

            Console.WriteLine();
            Console.WriteLine("Dumping ads_and_businesses/advertisers_who_uploaded_a_contact_list_with_your_information.json");
            IReadOnlyList<string> audiences = information.AdsAndBusinesses.AdvertisersWhoUploadedContactListWithYouInformation.CustomAudiences;
            Console.WriteLine($"{audiences.Count} audiences");
            for (int i = 0; i < audiences.Count; i++)
            {
                Console.WriteLine($"\t[{i}] {audiences[i]}");
            }

            Console.WriteLine();
            Console.WriteLine("Dumping ads_and_businesses/advertisers_you've_interacted_with.json");
            IReadOnlyList<AdvertisersWhoYouInteractedWithHistoryEntry> adHistory = information.AdsAndBusinesses.AdvertisersWhoYouInteractedWith.History;
            Console.WriteLine($"{adHistory.Count} ad history");
            for (int i = 0; i < adHistory.Count; i++)
            {
                Console.WriteLine($"\t[{i}] Title: {adHistory[i].Title}");
                Console.WriteLine($"\t[{i}] Date: {adHistory[i].Date}");
                Console.WriteLine($"\t[{i}] Action: {adHistory[i].Action}");
            }

            Console.WriteLine();
            Console.WriteLine("Dumping ads_and_businesses/your_off-facebook_activity.json");
            IReadOnlyList<YourOffFacebookActivityEntry> offFacebookActivities = information.AdsAndBusinesses.YourOffFacebookActivity.All;
            Console.WriteLine($"{offFacebookActivities.Count} activity");
            for (int i = 0; i < offFacebookActivities.Count; i++)
            {
                Console.WriteLine($"\t[{i}] Name: {offFacebookActivities[i].Name}");
                Console.WriteLine($"\t[{i}] Events: {offFacebookActivities[i].Events.Count}");
            }

            Console.WriteLine();
            Console.WriteLine("Dumping apps_and_websites/apps_and_websites.json");
            IReadOnlyList<App> appsAndWebsites = information.AppsAndWebsites.AppsAndWebsites.InstalledApps;
            Console.WriteLine($"{appsAndWebsites.Count} apps and websites");
            for (int i = 0; i < appsAndWebsites.Count; i++)
            {
                Console.WriteLine($"\t[{i}] Name: {appsAndWebsites[i].Name}");
                Console.WriteLine($"\t[{i}] AddedDate: {appsAndWebsites[i].AddedDate}");
            }

            Console.WriteLine();
            Console.WriteLine("Dumping apps_and_websites/your_apps.json");
            IReadOnlyList<App> yourApps = information.AppsAndWebsites.YourApps.AdminedApps;
            Console.WriteLine($"{yourApps.Count} your apps");
            for (int i = 0; i < yourApps.Count; i++)
            {
                Console.WriteLine($"\t[{i}] Name: {yourApps[i].Name}");
                Console.WriteLine($"\t[{i}] AddedDate: {yourApps[i].AddedDate}");
            }

            Console.WriteLine();
            Console.WriteLine("Dumping comments/comments.json");
            IReadOnlyList<Comment> comments = information.Comments.All;
            Console.WriteLine($"{comments.Count} comments");
            for (int i = 0; i < comments.Count; i++)
            {
                Console.WriteLine($"\t[{i}] Title: {comments[i].Title}");
                Console.WriteLine($"\t[{i}] Date: {comments[i].Date}");
                Console.WriteLine($"\t[{i}] Data: {comments[i].Data?.Count ?? 0}");
            }

            Console.WriteLine();
            Console.WriteLine("Dumping events/event_invitations.json");
            IReadOnlyList<Event> invitations = information.Events.Invitations.All;
            Console.WriteLine($"{invitations.Count} event invitations");
            for (int i = 0; i < invitations.Count; i++)
            {
                Console.WriteLine($"\t[{i}] Name: {invitations[i].Name}");
                Console.WriteLine($"\t[{i}] StartDate: {invitations[i].StartDate}");
                Console.WriteLine($"\t[{i}] EndDate: {invitations[i].EndDate}");
            }

            Console.WriteLine();
            Console.WriteLine("Dumping events/your_event_responses.json");
            IReadOnlyList<Event> joinedEvents = information.Events.YourEventResponses.Responses.Joined;
            Console.WriteLine($"{joinedEvents.Count} joined events");
            for (int i = 0; i < joinedEvents.Count; i++)
            {
                Console.WriteLine($"\t[{i}] Name: {joinedEvents[i].Name}");
                Console.WriteLine($"\t[{i}] StartDate: {joinedEvents[i].StartDate}");
                Console.WriteLine($"\t[{i}] EndDate: {joinedEvents[i].EndDate}");
            }

            IReadOnlyList<Event> declinedEvents = information.Events.YourEventResponses.Responses.Declined;
            Console.WriteLine($"{declinedEvents.Count} declined events");
            for (int i = 0; i < declinedEvents.Count; i++)
            {
                Console.WriteLine($"\t[{i}] Name: {declinedEvents[i].Name}");
                Console.WriteLine($"\t[{i}] StartDate: {declinedEvents[i].StartDate}");
                Console.WriteLine($"\t[{i}] EndDate: {declinedEvents[i].EndDate}");
            }

            IReadOnlyList<Event> interestedEvents = information.Events.YourEventResponses.Responses.Interested;
            Console.WriteLine($"{interestedEvents.Count} interested events");
            for (int i = 0; i < interestedEvents.Count; i++)
            {
                Console.WriteLine($"\t[{i}] Name: {interestedEvents[i].Name}");
                Console.WriteLine($"\t[{i}] StartDate: {interestedEvents[i].StartDate}");
                Console.WriteLine($"\t[{i}] EndDate: {interestedEvents[i].EndDate}");
            }

            Console.WriteLine();
            Console.WriteLine("Dumping events/your_events.json");
            IReadOnlyList<YourEvent> yourEvents = information.Events.YourEvents.All;
            Console.WriteLine($"{yourEvents.Count} your events");
            for (int i = 0; i < yourEvents.Count; i++)
            {
                Console.WriteLine($"\t[{i}] Name: {yourEvents[i].Name}");
                Console.WriteLine($"\t[{i}] Place: {yourEvents[i].Place}");
                Console.WriteLine($"\t[{i}] CreateDate: {yourEvents[i].CreatedDate}");
                Console.WriteLine($"\t[{i}] StartDate: {yourEvents[i].StartDate}");
                Console.WriteLine($"\t[{i}] EndDate: {yourEvents[i].EndDate}");
            }

            Console.WriteLine();
            Console.WriteLine("Dumping facebook_gaming/instant_games.json");
            IReadOnlyList<InstantGame> instantGames = information.Gaming.InstantGames.Played;
            Console.WriteLine($"{instantGames.Count} your events");
            for (int i = 0; i < instantGames.Count; i++)
            {
                Console.WriteLine($"\t[{i}] Name: {instantGames[i].Name}");
                Console.WriteLine($"\t[{i}] AddedTimestamp: {instantGames[i].AddedTimestamp}");
            }

            Console.WriteLine();
            Console.WriteLine("Dumping files");
            IReadOnlyList<string> files = information.Files.Names;
            Console.WriteLine($"{files.Count} files");
            for (int i = 0; i < files.Count; i++)
            {
                Console.WriteLine($"\t[{i}] {files[i]}");
            }

            Console.WriteLine();
            Console.WriteLine("Dumping following_and_followers/unfollowed_pages.json");
            IReadOnlyList<UnfollowedPage> unfollowedPages = information.FollowingAndFollowers.UnfollowedPages.All;
            Console.WriteLine($"{unfollowedPages.Count} unfollowed pages");
            for (int i = 0; i < unfollowedPages.Count; i++)
            {
                Console.WriteLine($"\t[{i}] Title: {unfollowedPages[i].Title}");
                Console.WriteLine($"\t[{i}] Data: {unfollowedPages[i].Data.Count}");
                Console.WriteLine($"\t[{i}] Date: {unfollowedPages[i].Date}");
            }

            Console.WriteLine();
            Console.WriteLine("Dumping friends/friends.json");
            IReadOnlyList<Friend> friends = information.Friends.Friends.All;
            Console.WriteLine($"{friends.Count} friends");
            for (int i = 0; i < friends.Count; i++)
            {
                Console.WriteLine($"\t[{i}] Name: {friends[i].Name}");
                Console.WriteLine($"\t[{i}] Date: {friends[i].Date}");
            }

            Console.WriteLine();
            Console.WriteLine("Dumping friends/received_friend_requests.json");
            IReadOnlyList<Friend> receivedFriendRequests = information.Friends.ReceivedFriendRequests.All;
            Console.WriteLine($"{receivedFriendRequests.Count} received friend requests");
            for (int i = 0; i < receivedFriendRequests.Count; i++)
            {
                Console.WriteLine($"\t[{i}] Name: {receivedFriendRequests[i].Name}");
                Console.WriteLine($"\t[{i}] Date: {receivedFriendRequests[i].Date}");
            }

            Console.WriteLine();
            Console.WriteLine("Dumping friends/received_friend_requests.json");
            IReadOnlyList<RejectedFriendRequest> rejectedFriendRequests = information.Friends.RejectedFriendRequests.All;
            Console.WriteLine($"{rejectedFriendRequests.Count} rejected friend requests");
            for (int i = 0; i < rejectedFriendRequests.Count; i++)
            {
                Console.WriteLine($"\t[{i}] Name: {rejectedFriendRequests[i].Name}");
                Console.WriteLine($"\t[{i}] Date: {rejectedFriendRequests[i].Date}");
                Console.WriteLine($"\t[{i}] MarkedAsSpam: {rejectedFriendRequests[i].MarkedAsSpam}");
            }

            Console.WriteLine();
            Console.WriteLine("Dumping friends/removed_friends.json");
            IReadOnlyList<Friend> removedFriends = information.Friends.RemovedFriends.All;
            Console.WriteLine($"{removedFriends.Count} removed friends");
            for (int i = 0; i < removedFriends.Count; i++)
            {
                Console.WriteLine($"\t[{i}] Name: {removedFriends[i].Name}");
                Console.WriteLine($"\t[{i}] Date: {removedFriends[i].Date}");
            }

            Console.WriteLine();
            Console.WriteLine("Dumping friends/sent_friend_requests.json");
            IReadOnlyList<Friend> sentFriendRequests = information.Friends.SentFriendRequests.All;
            Console.WriteLine($"{sentFriendRequests.Count} sent friend requests");
            for (int i = 0; i < sentFriendRequests.Count; i++)
            {
                Console.WriteLine($"\t[{i}] Name: {sentFriendRequests[i].Name}");
                Console.WriteLine($"\t[{i}] Date: {sentFriendRequests[i].Date}");
            }

            Console.WriteLine();
            Console.WriteLine("Dumping groups/your_group_membership_activity.json");
            IReadOnlyList<GroupActivity> groupActivity = information.Groups.YourGroupMembershipActivity.Joined;
            Console.WriteLine($"{groupActivity.Count} group membership activity");
            for (int i = 0; i < groupActivity.Count; i++)
            {
                Console.WriteLine($"\t[{i}] Title: {groupActivity[i].Title}");
                Console.WriteLine($"\t[{i}] Date: {groupActivity[i].Date}");
            }

            Console.WriteLine();
            Console.WriteLine("Dumping groups/your_groups.json");
            IReadOnlyList<Group> yourAdminedGroups = information.Groups.YourGroups.Admined;
            Console.WriteLine($"{yourAdminedGroups.Count} your admined groups");
            for (int i = 0; i < yourAdminedGroups.Count; i++)
            {
                Console.WriteLine($"\t[{i}] Name: {yourAdminedGroups[i].Name}");
                Console.WriteLine($"\t[{i}] Date: {yourAdminedGroups[i].Date}");
            }

            Console.WriteLine();
            Console.WriteLine("Dumping groups/your_posts_and_comments_in_groups.json");
            IReadOnlyList<Post> yourPostsAndCommentsInGroups = information.Groups.YourPostsAndCommentsInGroups.Posts.ActivityLogData;
            Console.WriteLine($"{yourPostsAndCommentsInGroups.Count} your posts and comments in groups");
            for (int i = 0; i < yourPostsAndCommentsInGroups.Count; i++)
            {
                Console.WriteLine($"\t[{i}] Title: {yourPostsAndCommentsInGroups[i].Title}");
                Console.WriteLine($"\t[{i}] Date: {yourPostsAndCommentsInGroups[i].Date}");
            }

            Console.WriteLine();
            Console.WriteLine("Dumping information_used_for_recommendations/facebook_watch_topics_for_recommendations.json");
            IReadOnlyList<string> facebookWatchTopicsForRecommendation = information.InformationUsedForReccomendations.FacebookWatchTopicsForRecommendations.All;
            Console.WriteLine($"{facebookWatchTopicsForRecommendation.Count} facebook watch topics for recommendation");
            for (int i = 0; i < facebookWatchTopicsForRecommendation.Count; i++)
            {
                Console.WriteLine($"\t[{i}] {facebookWatchTopicsForRecommendation[i]}");
            }

            Console.WriteLine();
            Console.WriteLine("Dumping information_used_for_recommendations/news_feed_topics_for_recommendations.json");
            IReadOnlyList<string> newsFeedTopicsForRecommendation = information.InformationUsedForReccomendations.NewsFeedTopicsForRecommendations.All;
            Console.WriteLine($"{newsFeedTopicsForRecommendation.Count} facebook watch topics for recommendation");
            for (int i = 0; i < newsFeedTopicsForRecommendation.Count; i++)
            {
                Console.WriteLine($"\t[{i}] {newsFeedTopicsForRecommendation[i]}");
            }

            Console.WriteLine();
            Console.WriteLine("Dumping information_used_for_recommendations/news_topics_for_recommendations.json");
            IReadOnlyList<string> newsTopicsForRecommendation = information.InformationUsedForReccomendations.NewsTopicsForRecommendations.All;
            Console.WriteLine($"{newsTopicsForRecommendation.Count} facebook watch topics for recommendation");
            for (int i = 0; i < newsTopicsForRecommendation.Count; i++)
            {
                Console.WriteLine($"\t[{i}] {newsTopicsForRecommendation[i]}");
            }

            Console.WriteLine();
            Console.WriteLine("Dumping interactions/events.json");
            IReadOnlyList<Interaction> eventsInteractions = information.Interactions.Events.All;
            Console.WriteLine($"{eventsInteractions.Count} events interactions");
            for (int i = 0; i < eventsInteractions.Count; i++)
            {
                Console.WriteLine($"\t[{i}] Name: {eventsInteractions[i].Name}");
                Console.WriteLine($"\t[{i}] Description: {eventsInteractions[i].Description}");
                Console.WriteLine($"\t[{i}] Entries: {eventsInteractions[i].Entries.Count}");
            }

            Console.WriteLine();
            Console.WriteLine("Dumping interactions/menu_items.json");
            IReadOnlyList<Interaction> menuItemsInteractions = information.Interactions.Events.All;
            Console.WriteLine($"{menuItemsInteractions.Count} menu items interactions");
            for (int i = 0; i < menuItemsInteractions.Count; i++)
            {
                Console.WriteLine($"\t[{i}] Name: {menuItemsInteractions[i].Name}");
                Console.WriteLine($"\t[{i}] Description: {menuItemsInteractions[i].Description}");
                Console.WriteLine($"\t[{i}] Entries: {menuItemsInteractions[i].Entries.Count}");
            }

            Console.WriteLine();
            Console.WriteLine("Dumping interactions/people.json");
            IReadOnlyList<Interaction> peopleInteractions = information.Interactions.Events.All;
            Console.WriteLine($"{peopleInteractions.Count} people interactions");
            for (int i = 0; i < peopleInteractions.Count; i++)
            {
                Console.WriteLine($"\t[{i}] Name: {peopleInteractions[i].Name}");
                Console.WriteLine($"\t[{i}] Description: {peopleInteractions[i].Description}");
                Console.WriteLine($"\t[{i}] Entries: {peopleInteractions[i].Entries.Count}");
            }

            Console.WriteLine();
            Console.WriteLine("Dumping likes_and_reactions/likes_on_external_sites.json");
            IReadOnlyList<LikeOnExternalSite> likesOnExternalSites = information.LikesAndReactions.LikesOnExternalSites.All;
            Console.WriteLine($"{likesOnExternalSites.Count} likes on external sites");
            for (int i = 0; i < likesOnExternalSites.Count; i++)
            {
                Console.WriteLine($"\t[{i}] Title: {likesOnExternalSites[i].Title}");
                Console.WriteLine($"\t[{i}] Date: {likesOnExternalSites[i].Date}");
                Console.WriteLine($"\t[{i}] Attachments: {likesOnExternalSites[i].Attachments.Count}");
            }

            Console.WriteLine();
            Console.WriteLine("Dumping likes_and_reactions/pages.json");
            IReadOnlyList<PageLike> pageLikes = information.LikesAndReactions.PageLikes.All;
            Console.WriteLine($"{pageLikes.Count} page likes and reactions");
            for (int i = 0; i < pageLikes.Count; i++)
            {
                Console.WriteLine($"\t[{i}] Name: {pageLikes[i].Name}");
                Console.WriteLine($"\t[{i}] Date: {pageLikes[i].Date}");
            }

            Console.WriteLine();
            Console.WriteLine("Dumping likes_and_reactions/posts_and_comments.json");
            IReadOnlyList<Reaction> postsAndCommentsLikes = information.LikesAndReactions.PostsAndCommentsLikes.Reactions;
            Console.WriteLine($"{postsAndCommentsLikes.Count} page likes and reactions");
            for (int i = 0; i < postsAndCommentsLikes.Count; i++)
            {
                Console.WriteLine($"\t[{i}] Title: {postsAndCommentsLikes[i].Title}");
                Console.WriteLine($"\t[{i}] Date: {postsAndCommentsLikes[i].Date}");
                Console.WriteLine($"\t[{i}] Data: {postsAndCommentsLikes[i].Data.Count}");
            }

            Console.WriteLine();
            Console.WriteLine("Dumping location/location_history.json");
            IReadOnlyList<LocationHistoryEntry> locationHistory = information.Location.LocationHistory.All;
            Console.WriteLine($"{locationHistory.Count} location history");
            for (int i = 0; i < locationHistory.Count; i++)
            {
                Console.WriteLine($"\t[{i}] Name: {locationHistory[i].Name}");
                Console.WriteLine($"\t[{i}] CreationDate: {locationHistory[i].CreationDate}");
            }

            Console.WriteLine();
            Console.WriteLine("Dumping location/primary_location.json");
            IReadOnlyList<IReadOnlyList<string>> cityRegionPairs = information.Location.PrimaryLocation.PrimaryLocation.CityRegionPairs;
            Console.WriteLine($"{cityRegionPairs.Count} city region pairs");
            for (int i = 0; i < cityRegionPairs.Count; i++)
            {
                Console.WriteLine($"\t[{i}] {cityRegionPairs[i][0]}, {cityRegionPairs[i][1]}");
            }

            IReadOnlyList<string> zipcode = information.Location.PrimaryLocation.PrimaryLocation.Zipcode;
            Console.WriteLine($"{zipcode.Count} zipcode");
            for (int i = 0; i < zipcode.Count; i++)
            {
                Console.WriteLine($"\t[{i}] {zipcode[i]}");
            }

            Console.WriteLine();
            Console.WriteLine("Dumping marketplace/items_sold.json");
            IReadOnlyList<ForSaleItem> soldItems = information.Marketplace.ItemsSold.All;
            Console.WriteLine($"{soldItems.Count} sold items");
            for (int i = 0; i < soldItems.Count; i++)
            {
                Console.WriteLine($"\t[{i}] Title: {soldItems[i].Title}");
                Console.WriteLine($"\t[{i}] Price: {soldItems[i].Price}");
                Console.WriteLine($"\t[{i}] CreatedDate: {soldItems[i].CreatedDate}");
            }

            Console.WriteLine();
            Console.WriteLine("Dumping other_activity/pokes.json");
            IReadOnlyList<ActivityLogPoke> activityLogPokes = information.OtherActivity.Pokes.All.ActivityLogData;
            Console.WriteLine($"{activityLogPokes.Count} activity log pokes");
            for (int i = 0; i < activityLogPokes.Count; i++)
            {
                Console.WriteLine($"\t[{i}] Title: {activityLogPokes[i].Title}");
                Console.WriteLine($"\t[{i}] Date: {activityLogPokes[i].Date}");
            }

            IReadOnlyList<Poke> pokes = information.OtherActivity.Pokes.All.Data;
            Console.WriteLine($"{pokes.Count} activity log pokes");
            for (int i = 0; i < pokes.Count; i++)
            {
                Console.WriteLine($"\t[{i}] Poker: {pokes[i].Poker}");
                Console.WriteLine($"\t[{i}] Pokee: {pokes[i].Pokee}");
                Console.WriteLine($"\t[{i}] Rank: {pokes[i].Rank}");
                Console.WriteLine($"\t[{i}] Date: {pokes[i].Date}");
            }

            Console.WriteLine();
            Console.WriteLine("Dumping other_activity/polls_you_voted_on.json");
            IReadOnlyList<PollVote> pollVotes = information.OtherActivity.PollsYouVotedOn.All;
            Console.WriteLine($"{pollVotes.Count} poll votes");
            for (int i = 0; i < pollVotes.Count; i++)
            {
                Console.WriteLine($"\t[{i}] Title: {pollVotes[i].Title}");
                Console.WriteLine($"\t[{i}] Date: {pollVotes[i].Date}");
            }

            Console.WriteLine();
            Console.WriteLine("Dumping other_activity/rooms_joined.json");
            IReadOnlyList<RemotePresenceRoom> roomsJoined = information.OtherActivity.RoomsJoined.RemotePresenceRooms;
            Console.WriteLine($"{roomsJoined.Count} rooms joined");
            for (int i = 0; i < roomsJoined.Count; i++)
            {
                Console.WriteLine($"\t[{i}] Count: {roomsJoined[i].Calls.Count}");
            }

            Console.WriteLine();
            Console.WriteLine("Dumping other_activity/support_correspondences.json");
            IReadOnlyList<SupportCorrespondence> supportCorrespondences = information.OtherActivity.SupportCorrespondences.All;
            Console.WriteLine($"{supportCorrespondences.Count} support correspondences");
            for (int i = 0; i < supportCorrespondences.Count; i++)
            {
                Console.WriteLine($"\t[{i}] Subject: {supportCorrespondences[i].Subject}");
                Console.WriteLine($"\t[{i}] Date: {supportCorrespondences[i].Date}");
                Console.WriteLine($"\t[{i}] Messages: {supportCorrespondences[i].Messages.Count}");
            }

            Console.WriteLine();
            Console.WriteLine("Dumping payment_history/payment_history.json");
            Payments paymentHistory = information.PaymentHistory.All;
            Console.WriteLine($"{paymentHistory.All.Count} payment history");
            for (int i = 0; i < paymentHistory.All.Count; i++)
            {
                Console.WriteLine($"\t[{i}] {paymentHistory.All[i]}");
            }

            Console.WriteLine();
            Console.WriteLine("Dumping photos_and_videos/your_videos.json");
            YourVideos yourVideos = information.PhotosAndVideos.YourVideos;
            Console.WriteLine($"{yourVideos.All.Count} videos");
            for (int i = 0; i < yourVideos.All.Count; i++)
            {
                Console.WriteLine($"\t[{i}] Title: {yourVideos.All[i].Title}");
                Console.WriteLine($"\t[{i}] CreationDate: {yourVideos.All[i].CreationDate}");
                Console.WriteLine($"\t[{i}] Uri: {yourVideos.All[i].Uri}");
            }

            Console.WriteLine();
            Console.WriteLine("Dumping photos_and_videos/album/*.json");
            Albums albums = information.PhotosAndVideos.Albums;
            Console.WriteLine($"{albums.Ids.Length} videos");
            for (int i = 0; i < albums.Ids.Length; i++)
            {
                Album album = albums.GetAlbum(albums.Ids[i]);
                Console.WriteLine($"\t[{i}] Name: {album.Name}");
                Console.WriteLine($"\t[{i}] Description: {yourVideos.All[i].Description}");
                Console.WriteLine($"\t[{i}] CreationDate: {yourVideos.All[i].CreationDate}");
            }

            Console.WriteLine();
            Console.WriteLine("Dumping posts/your_posts_1.json");
            IReadOnlyList<Post> posts = information.Posts;
            Console.WriteLine($"{posts.Count} posts");
            for (int i = 0; i < posts.Count; i++)
            {
                Console.WriteLine($"\t[{i}] Title: {posts[i].Title}");
                Console.WriteLine($"\t[{i}] Date: {posts[i].Date}");
            }

            Console.WriteLine();
            Console.WriteLine("Dumping profile_information/profile_information.json");
            ProfileInformation profileInformation = information.ProfileInformation.ProfileInformation;
            Console.WriteLine($"Name: {profileInformation.Profile.Name}");
            Console.WriteLine($"Birthday: {profileInformation.Profile.Birthday}");
            Console.WriteLine($"Gender: {profileInformation.Profile.Gender}");

            Console.WriteLine();
            Console.WriteLine("Dumping profile_information/profile_update_history.json");
            IReadOnlyList<ProfileUpdate> profileUpdates = information.ProfileInformation.ProfileUpdateHistory.All;
            Console.WriteLine($"{profileUpdates.Count} profile updates");
            for (int i = 0; i < profileUpdates.Count; i++)
            {
                Console.WriteLine($"\t[{i}] Title: {profileUpdates[i].Title}");
                Console.WriteLine($"\t[{i}] Date: {profileUpdates[i].Date}");
            }

            Console.WriteLine();
            Console.WriteLine("Dumping saved_items_and_collections/saved_items_and_collections.json");
            IReadOnlyList<SavedItem> savedItemsAndCollections = information.SavedItemsAndCollections.All;
            Console.WriteLine($"{savedItemsAndCollections.Count} saved items");
            for (int i = 0; i < savedItemsAndCollections.Count; i++)
            {
                Console.WriteLine($"\t[{i}] Title: {savedItemsAndCollections[i].Title}");
                Console.WriteLine($"\t[{i}] Date: {savedItemsAndCollections[i].Date}");
            }

            Console.WriteLine();
            Console.WriteLine("Dumping your_search_history/your_search_history.json");
            IReadOnlyList<Search> searchHistory = information.SearchHistory.All;
            Console.WriteLine($"{searchHistory.Count} search history");
            for (int i = 0; i < searchHistory.Count; i++)
            {
                Console.WriteLine($"\t[{i}] Title: {searchHistory[i].Title}");
                Console.WriteLine($"\t[{i}] Date: {searchHistory[i].Date}");
            }

            Console.WriteLine();
            Console.WriteLine("Dumping security_and_login_information/account_activity.json");
            IReadOnlyList<AccountActivityEntry> accountActivities = information.SecurityAndLoginInformation.AccountActivity.All;
            Console.WriteLine($"{accountActivities.Count} account activity");
            for (int i = 0; i < accountActivities.Count; i++)
            {
                Console.WriteLine($"\t[{i}] Action: {accountActivities[i].Action}");
                Console.WriteLine($"\t[{i}] Date: {accountActivities[i].Date}");
            }

            Console.WriteLine();
            Console.WriteLine("Dumping security_and_login_information/account_status_changes.json");
            IReadOnlyList<AccountStatusChange> accountStatusChanges = information.SecurityAndLoginInformation.AccountStatusChanges.All;
            Console.WriteLine($"{accountStatusChanges.Count} account status changes");
            for (int i = 0; i < accountStatusChanges.Count; i++)
            {
                Console.WriteLine($"\t[{i}] Status: {accountStatusChanges[i].Status}");
                Console.WriteLine($"\t[{i}] Date: {accountStatusChanges[i].Date}");
            }

            Console.WriteLine();
            Console.WriteLine("Dumping security_and_login_information/administrative_records.json");
            IReadOnlyList<AdministrativeRecord> administrativeRecords = information.SecurityAndLoginInformation.AdministrativeRecords.All;
            Console.WriteLine($"{administrativeRecords.Count} administrative records");
            for (int i = 0; i < administrativeRecords.Count; i++)
            {
                Console.WriteLine($"\t[{i}] Event: {administrativeRecords[i].Event}");
            }

            Console.WriteLine();
            Console.WriteLine("Dumping security_and_login_information/datr_cookie_info.json");
            IReadOnlyDictionary<string, IReadOnlyList<int>> datrCookieInfo = information.SecurityAndLoginInformation.DatrCookieInformation.All;
            Console.WriteLine($"{datrCookieInfo.Count} datr cookie info");
            foreach (string key in datrCookieInfo.Keys)
            {
                Console.WriteLine($"\t{key}: {datrCookieInfo[key].Count}");
            }

            Console.WriteLine();
            Console.WriteLine("Dumping security_and_login_information/login_protection_data.json");
            IReadOnlyList<LoginProtectionDataEntry> loginProtectionData = information.SecurityAndLoginInformation.LoginProtectionData.All;
            Console.WriteLine($"{loginProtectionData.Count} login protection data");
            for (int i = 0; i < loginProtectionData.Count; i++)
            {
                Console.WriteLine($"\t[{i}] Name: {loginProtectionData[i].Name}");
            }

            Console.WriteLine();
            Console.WriteLine("Dumping security_and_login_information/login_protection_data.json");
            IReadOnlyList<AccountAccess> accountAccesses = information.SecurityAndLoginInformation.LoginsAndLogouts.All;
            Console.WriteLine($"{accountAccesses.Count} logins and logouts");
            for (int i = 0; i < accountAccesses.Count; i++)
            {
                Console.WriteLine($"\t[{i}] Action: {accountAccesses[i].Action}");
                Console.WriteLine($"\t[{i}] Date: {accountAccesses[i].Date}");
                Console.WriteLine($"\t[{i}] Site: {accountAccesses[i].Site}");
                Console.WriteLine($"\t[{i}] IpAddress: {accountAccesses[i].IpAddress}");
            }

            Console.WriteLine();
            Console.WriteLine("Dumping security_and_login_information/used_ip_addresses.json");
            IReadOnlyList<UsedIpAddress> usedIpAddresses = information.SecurityAndLoginInformation.UsedIpAddresses.All;
            Console.WriteLine($"{usedIpAddresses.Count} used ip addresses");
            for (int i = 0; i < usedIpAddresses.Count; i++)
            {
                Console.WriteLine($"\t[{i}] Action: {usedIpAddresses[i].Action}");
                Console.WriteLine($"\t[{i}] Ip: {usedIpAddresses[i].Ip}");
                Console.WriteLine($"\t[{i}] Date: {usedIpAddresses[i].Date}");
            }

            Console.WriteLine();
            Console.WriteLine("Dumping security_and_login_information/where_you're_logged_in.json");
            IReadOnlyList<ActiveSession> activeSessions = information.SecurityAndLoginInformation.ActiveSessions.All;
            Console.WriteLine($"{activeSessions.Count} used ip addresses");
            for (int i = 0; i < activeSessions.Count; i++)
            {
                Console.WriteLine($"\t[{i}] App: {activeSessions[i].App}");
                Console.WriteLine($"\t[{i}] IpAddress: {activeSessions[i].IpAddress}");
                Console.WriteLine($"\t[{i}] CreatedDate: {activeSessions[i].CreatedDate}");
                Console.WriteLine($"\t[{i}] UpdatedDate: {activeSessions[i].UpdatedDate}");
            }

            Console.WriteLine();
            Console.WriteLine("Dumping security_and_login_information/your_facebook_activity.json");
            IReadOnlyList<long> websiteActivity = information.SecurityAndLoginInformation.YourFacebookActivity.LastActivity.LastActivityTime.Website.ActivityByDay;
            Console.WriteLine($"{websiteActivity.Count} website activity");
            for (int i = 0; i < websiteActivity.Count; i++)
            {
                Console.WriteLine($"\t[{i}] {websiteActivity[i]}");
            }

            Console.WriteLine();
            Console.WriteLine("Dumping your_places/places_you've_created.json");
            IReadOnlyList<CreatedPlace> placesYouCreated = information.PlacesYouCreated.All;
            Console.WriteLine($"{placesYouCreated.Count} places you created");
            for (int i = 0; i < placesYouCreated.Count; i++)
            {
                Console.WriteLine($"\t[{i}] Name: {placesYouCreated[i].Name}");
                Console.WriteLine($"\t[{i}] Address: {placesYouCreated[i].Address}");
                Console.WriteLine($"\t[{i}] Url: {placesYouCreated[i].Url}");
                Console.WriteLine($"\t[{i}] CreationDate: {placesYouCreated[i].CreationDate}");
            }
        }

        static void Main(string[] args)
        {
            const string FolderPath = "/Users/hugh/Downloads/facebook-hughbellamy";
            var information = new FacebookInformation(FolderPath);
            DumpInformation(information);

            Console.WriteLine($"Reading messages from {FolderPath}");

            Console.WriteLine("Dumping messages/archived_threads");
            foreach (string id in information.Messages.ArchivedThreads.Ids)
            {
                Console.WriteLine(information.Messages.ArchivedThreads.GetMessage(id));
            }

            Console.WriteLine("Dumping messages/filtered_threads");
            foreach (string id in information.Messages.FilteredThreads.Ids)
            {
                Console.WriteLine(information.Messages.FilteredThreads.GetMessage(id));
            }

            Console.WriteLine("Dumping messages/inbox");
            foreach (string id in information.Messages.Inbox.Ids)
            {
                Console.WriteLine(information.Messages.Inbox.GetMessage(id));
            }

            Console.WriteLine("Dumping messages/message_requests");
            foreach (string id in information.Messages.MessageRequests.Ids)
            {
                Console.WriteLine(information.Messages.MessageRequests.GetMessage(id));
            }
        }

        private static void ImportThread(MessageThread thread)
        {
            int i = 0;
            var settings = new ConnectionSettings()
                .DefaultIndex("messages");
            var client = new ElasticClient(settings);
            foreach (Message message in thread.Messages)
            {
                Console.WriteLine($"Importing {i++}/{thread.Messages.Count}");
                client.IndexDocument(message);
            };
        }

        private static void GenerateRepliesCsv(MessageThread thread)
        {
            for (double withinHours = 1 / 60.0; withinHours <= 24; withinHours += 2 / 60.0)
            {
                Replies[] replies = AnalyzeResponseTimes(thread, withinHours).ToArray();
                Console.Write($"{(int)(withinHours * 60)}, ");
                for (int i = 0; i < replies.Length; i++)
                {
                    Console.Write((int)replies[i].AverageReplyTime.TotalSeconds);
                    if (i != replies.Length - 1)
                    {
                        Console.Write(", ");
                    }
                }

                Console.WriteLine();
            }
        }

        private class Replies
        {
            public MessageParticipant Participant { get; set; }

            public TimeSpan AverageReplyTime { get; set; }
        }

        private static IEnumerable<Replies> AnalyzeResponseTimes(MessageThread thread, double hours)
        {
            IList<Message> ascendingMessages = thread.Messages.Reverse().ToArray();
            foreach (MessageParticipant participant in thread.Participants)
            {
                int firstMessageToRespondToIndex = -1;
                for (int i = 0; i < ascendingMessages.Count; i++)
                {
                    Message currentMessage = ascendingMessages[i];
                    if (currentMessage.SenderName != participant.Name)
                    {
                        firstMessageToRespondToIndex = i;
                        break;
                    }
                }

                if (firstMessageToRespondToIndex == -1)
                {
                    Console.WriteLine($"{participant.Name}: never received a message");
                    break;
                }

                TimeSpan totalReplyTime = TimeSpan.Zero;
                int numberOfReplies = 0;
                for (int i = firstMessageToRespondToIndex; i < ascendingMessages.Count; i++)
                {
                    // Skip subsequent messages we received.
                    Message firstMessageReceivedIndex = ascendingMessages[i];
                    while (i + 1 < ascendingMessages.Count && firstMessageReceivedIndex.SenderName == ascendingMessages[i + 1].SenderName)
                    {
                        i++;
                    }

                    // We never sent a reply.
                    if (i + 1 >= ascendingMessages.Count)
                    {
                        break;
                    }

                    Message messageRespondingTo = ascendingMessages[i];
                    Message responseMessage = ascendingMessages[i + 1];
                    Debug.Assert(messageRespondingTo.SenderName != responseMessage.SenderName);

                    TimeSpan difference = responseMessage.Date - messageRespondingTo.Date;
                    if (difference < TimeSpan.FromHours(hours))
                    {
                        // Ignore replies that span nights etc.
                        totalReplyTime += difference;
                        numberOfReplies++;
                    }

                    // Skip subequent messages we sent.
                    while (i + 1 < ascendingMessages.Count && responseMessage.SenderName == ascendingMessages[i + 1].SenderName)
                    {
                        i++;
                    }
                }

                yield return new Replies
                {
                    Participant = participant,
                    AverageReplyTime = totalReplyTime / numberOfReplies
                };
            }
        }

        private static int CountWords(Message message)
        {
            if (message.Content == null)
            {
                return 0;
            }

            return message.Content.Count(char.IsWhiteSpace);
        }

        private static int CountCharacters(Message message)
        {
            if (message.Content == null)
            {
                return 0;
            }

            return message.Content.Length;
        }

        private static int CountPhotos(Message message)
        {
            if (message.Photos == null)
            {
                return 0;
            }

            return message.Photos.Count;
        }
    }
}
