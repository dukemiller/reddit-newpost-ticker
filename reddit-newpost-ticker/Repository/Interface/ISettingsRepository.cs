namespace reddit_newpost_ticker.Repository.Interface
{
    public interface ISettingsRepository
    {
        string Subreddit { get; set; }
        int Frequency { get; set; }
        void Save();
    }
}