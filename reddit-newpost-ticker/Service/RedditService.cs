using System;
using reddit_newpost_ticker.Service.Interface;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using reddit_newpost_ticker.Models;
using reddit_newpost_ticker.Repository.Interface;

namespace reddit_newpost_ticker.Service
{
    public class RedditService : IRedditService
    {
        private readonly ISettingsRepository _settings;
        private readonly HttpClient _client;

        private const string Endpoint = "https://www.reddit.com/r/{0}/new/.json?limit=1";

        public RedditService(ISettingsRepository settings)
        {
            _settings = settings;
            _client = new HttpClient();
        }

        public async Task<Post> LatestPost()
        {
            try
            {
                var response = await _client.GetStringAsync(string.Format(Endpoint, _settings.Subreddit));
                var json = JsonConvert.DeserializeObject<Root>(response);
                var post = json.Data.Children.FirstOrDefault()?.Post;
                return post;
            }

            catch 
            {
                return null;
            }
        }
    }
}