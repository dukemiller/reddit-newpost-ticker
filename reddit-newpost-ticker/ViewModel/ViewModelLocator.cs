using GalaSoft.MvvmLight.Ioc;
using Microsoft.Practices.ServiceLocation;
using reddit_newpost_ticker.Service.Interface;
using reddit_newpost_ticker.Service;

namespace reddit_newpost_ticker.ViewModel
{
    public class ViewModelLocator
    {
        public ViewModelLocator()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);
            SimpleIoc.Default.Register<IRedditService, RedditService>();
            SimpleIoc.Default.Register<MainViewModel>();
        }

        public MainViewModel Main => ServiceLocator.Current.GetInstance<MainViewModel>();

        public IRedditService RedditService => ServiceLocator.Current.GetInstance<IRedditService>();
        
    }
}