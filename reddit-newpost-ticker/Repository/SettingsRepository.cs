using System.IO;
using Newtonsoft.Json;
using reddit_newpost_ticker.Repository.Interface;
using reddit_newpost_ticker.ViewModel;

namespace reddit_newpost_ticker.Repository
{
    public class SettingsRepository: ISettingsRepository
    {
        private static readonly string SavePath = Path.Combine(MainViewModel.ApplicationPath, "settings.json");

        public string Subreddit { get; set; } = "all";

        public int Frequency { get; set; } = 5;

        public void Save()
        {
            using (var stream = new StreamWriter(SavePath))
                stream.Write(JsonConvert.SerializeObject(this, Formatting.Indented));
        }

        public static SettingsRepository Load()
        {
            if (!Directory.Exists(MainViewModel.ApplicationPath))
                Directory.CreateDirectory(MainViewModel.ApplicationPath);

            if (File.Exists(SavePath))
                using (var stream = new StreamReader(SavePath))
                    return JsonConvert.DeserializeObject<SettingsRepository>(stream.ReadToEnd());

            return new SettingsRepository();
        }
    }
}