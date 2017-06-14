namespace reddit_newpost_ticker.Repository.Interface
{
    public interface ISettingsRepository
    {
        string Subreddit { get; set; }
        int Frequency { get; set; }
        bool Notify { get; set; }
        void Save();
    }
}