using System.Collections.Generic;
using Newtonsoft.Json;

namespace reddit_newpost_ticker.Models
{
    public class MediaEmbed
    {
    }

    public class SecureMediaEmbed
    {
    }

    public class Post
    {

        [JsonProperty("contest_mode")]
        public bool ContestMode { get; set; }

        [JsonProperty("subreddit_name_prefixed")]
        public string SubredditNamePrefixed { get; set; }

        [JsonProperty("banned_by")]
        public object BannedBy { get; set; }

        [JsonProperty("media_embed")]
        public MediaEmbed MediaEmbed { get; set; }

        [JsonProperty("thumbnail_width")]
        public object ThumbnailWidth { get; set; }

        [JsonProperty("subreddit")]
        public string Subreddit { get; set; }

        [JsonProperty("selftext_html")]
        public object SelftextHtml { get; set; }

        [JsonProperty("selftext")]
        public string Selftext { get; set; }

        [JsonProperty("likes")]
        public object Likes { get; set; }

        [JsonProperty("suggested_sort")]
        public object SuggestedSort { get; set; }

        [JsonProperty("user_reports")]
        public IList<object> UserReports { get; set; }

        [JsonProperty("secure_media")]
        public object SecureMedia { get; set; }

        [JsonProperty("link_flair_text")]
        public object LinkFlairText { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("view_count")]
        public object ViewCount { get; set; }

        [JsonProperty("secure_media_embed")]
        public SecureMediaEmbed SecureMediaEmbed { get; set; }

        [JsonProperty("clicked")]
        public bool Clicked { get; set; }

        [JsonProperty("report_reasons")]
        public object ReportReasons { get; set; }

        [JsonProperty("author")]
        public string Author { get; set; }

        [JsonProperty("saved")]
        public bool Saved { get; set; }

        [JsonProperty("mod_reports")]
        public IList<object> ModReports { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("score")]
        public int Score { get; set; }

        [JsonProperty("approved_by")]
        public object ApprovedBy { get; set; }

        [JsonProperty("over_18")]
        public bool Over18 { get; set; }

        [JsonProperty("domain")]
        public string Domain { get; set; }

        [JsonProperty("hidden")]
        public bool Hidden { get; set; }

        [JsonProperty("thumbnail")]
        public string Thumbnail { get; set; }

        [JsonProperty("subreddit_id")]
        public string SubredditId { get; set; }

        [JsonProperty("edited")]
        public bool Edited { get; set; }

        [JsonProperty("link_flair_css_class")]
        public object LinkFlairCssClass { get; set; }

        [JsonProperty("author_flair_css_class")]
        public object AuthorFlairCssClass { get; set; }

        [JsonProperty("gilded")]
        public int Gilded { get; set; }

        [JsonProperty("downs")]
        public int Downs { get; set; }

        [JsonProperty("brand_safe")]
        public bool BrandSafe { get; set; }

        [JsonProperty("archived")]
        public bool Archived { get; set; }

        [JsonProperty("removal_reason")]
        public object RemovalReason { get; set; }

        [JsonProperty("can_gild")]
        public bool CanGild { get; set; }

        [JsonProperty("thumbnail_height")]
        public object ThumbnailHeight { get; set; }

        [JsonProperty("hide_score")]
        public bool HideScore { get; set; }

        [JsonProperty("spoiler")]
        public bool Spoiler { get; set; }

        [JsonProperty("permalink")]
        public string Permalink { get; set; }

        [JsonProperty("num_reports")]
        public object NumReports { get; set; }

        [JsonProperty("locked")]
        public bool Locked { get; set; }

        [JsonProperty("stickied")]
        public bool Stickied { get; set; }

        [JsonProperty("created")]
        public double Created { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("author_flair_text")]
        public object AuthorFlairText { get; set; }

        [JsonProperty("quarantine")]
        public bool Quarantine { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("created_utc")]
        public double CreatedUtc { get; set; }

        [JsonProperty("distinguished")]
        public object Distinguished { get; set; }

        [JsonProperty("media")]
        public object Media { get; set; }

        [JsonProperty("num_comments")]
        public int NumComments { get; set; }

        [JsonProperty("is_self")]
        public bool IsSelf { get; set; }

        [JsonProperty("visited")]
        public bool Visited { get; set; }

        [JsonProperty("subreddit_type")]
        public string SubredditType { get; set; }

        [JsonProperty("is_video")]
        public bool IsVideo { get; set; }

        [JsonProperty("ups")]
        public int Ups { get; set; }
    }

    public class Child
    {

        [JsonProperty("kind")]
        public string Kind { get; set; }

        [JsonProperty("data")]
        public Post Post { get; set; }
    }

    public class Data
    {

        [JsonProperty("modhash")]
        public string Modhash { get; set; }

        [JsonProperty("children")]
        public IList<Child> Children { get; set; }

        [JsonProperty("after")]
        public string After { get; set; }

        [JsonProperty("before")]
        public object Before { get; set; }
    }

    public class Root
    {

        [JsonProperty("kind")]
        public string Kind { get; set; }

        [JsonProperty("data")]
        public Data Data { get; set; }
    }

}