using System;

namespace UrbanBlimp.Feed
{
    public class GetFeedResponse
    {
        public Template Template;
        public string FeedUrl;
        public bool BroadCast;
        public string Url;
        public string Id;
        public DateTime LastChecked;
    }
}