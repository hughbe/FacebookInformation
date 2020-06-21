using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace FacebookInformation
{
    public class InformationUsedForReccomendationsInformation
    {
        public InformationUsedForReccomendationsInformation(string folderPath)
        {
            FolderPath = folderPath;
        }

        private string FolderPath { get; }

        public FacebookWatchTopicsForRecommendations FacebookWatchTopicsForRecommendations
            => Utilities.Read<FacebookWatchTopicsForRecommendations>(FolderPath, "facebook_watch_topics_for_recommendations");

        public NewsFeedTopicsForRecommendations NewsFeedTopicsForRecommendations
            => Utilities.Read<NewsFeedTopicsForRecommendations>(FolderPath, "news_feed_topics_for_recommendations");

        public NewsTopicsForRecommendations NewsTopicsForRecommendations
            => Utilities.Read<NewsTopicsForRecommendations>(FolderPath, "news_topics_for_recommendations");
    }
}
