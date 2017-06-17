using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using reddit_newpost_ticker.Classes;
using reddit_newpost_ticker.Models;
using reddit_newpost_ticker.Repository.Interface;
using reddit_newpost_ticker.Service.Interface;

namespace reddit_newpost_ticker.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        public static string ApplicationPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "reddit_newpost_ticker");

        private readonly IRedditService _reddit;

        public ISettingsRepository Settings { get; set; }

        public static List<int> Frequencies { get; set; } = new List<int> {3, 5, 10, 30, 60};

        private Post _currentPost;

        private bool _isShowingMenu;

        // 

        public MainViewModel(IRedditService reddit, ISettingsRepository settings)
        {
            _reddit = reddit;
            Settings = settings;
            LoadedCommand = new RelayCommand(Loaded);
            ToggleMenuCommand = new RelayCommand(() =>
            {
                IsShowingMenu ^= true;
                Settings.Save();
            });
            OpenSubredditCommand = new RelayCommand(OpenSubreddit);
            OpenUserCommand = new RelayCommand(OpenUser);
            OpenPostCommand = new RelayCommand(OpenPost);
            OpenLinkCommand = new RelayCommand(OpenLink);
        }

        // 

        public bool IsShowingMenu
        {
            get => _isShowingMenu;
            set => Set(() => IsShowingMenu, ref _isShowingMenu, value);
        }

        public Post CurrentPost
        {
            get => _currentPost;
            set => Set(() => CurrentPost, ref _currentPost, value);
        }

        public RelayCommand LoadedCommand { get; set; }

        public RelayCommand ToggleMenuCommand { get; set; }

        public RelayCommand OpenSubredditCommand { get; set; }

        public RelayCommand OpenUserCommand { get; set; }

        public RelayCommand OpenPostCommand { get; set; }

        public RelayCommand OpenLinkCommand { get; set; }

        // 

        private void OpenSubreddit()
        {
            if (CurrentPost != null)
                Process.Start($"https://reddit.com/{CurrentPost.SubredditNamePrefixed}");
        }

        private void OpenUser()
        {
            if (CurrentPost != null)
                Process.Start($"https://reddit.com/u/{CurrentPost.Author}");
        }

        private void OpenPost()
        {
            if (CurrentPost != null)
                Process.Start($"https://reddit.com{CurrentPost.Permalink}");
        }

        private void OpenLink()
        {
            if (CurrentPost != null)
                Process.Start(CurrentPost.Url);
        }

        private async void Loaded()
        {
            while (true)
            {
                var latest = await _reddit.LatestPost();

                if (latest == null)
                    CurrentPost = null;

                else if (CurrentPost?.Id != latest.Id)
                {
                    CurrentPost = latest;
                    if (Settings.Notify)
                        FlashWindow.Flash();
                }

                await Task.Delay(Settings.Frequency * 1000);
            }
        }
    }
}