using System;
using reddit_newpost_ticker.Service.Interface;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using reddit_newpost_ticker.Models;

namespace reddit_newpost_ticker.Service
{
    public class RedditService : IRedditService
    {
        private readonly HttpClient _client;

        private const string Endpoint = "https://www.reddit.com/r/all/new/.json?limit=1";

        public RedditService()
        {
            _client = new HttpClient();
        }

        public async Task<Post> LatestPost()
        {
            try
            {
                var response = await _client.GetStringAsync(Endpoint);
                var json = JsonConvert.DeserializeObject<Root>(response);
                var post = json.Data.Children.First().Post;
                return post;
            }

            catch (JsonSerializationException e)
            {
                throw e;
            }
        }
    }
}