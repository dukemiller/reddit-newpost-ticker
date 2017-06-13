using System;
using System.Linq;
using reddit_newpost_ticker.Service.Interface;
using RedditSharp;

namespace reddit_newpost_ticker.Service
{
    public class RedditService: IRedditService
    {
        private readonly Reddit _reddit;

        public RedditService()
        {
            _reddit = new Reddit(WebAgent.RateLimitMode.Pace);
        }
    }
}