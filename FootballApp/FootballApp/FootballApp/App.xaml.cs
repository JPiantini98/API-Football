using System;
using Xamarin.Forms;
using FootballApp.Services;
using Xamarin.Forms.Xaml;

namespace FootballApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new TrophyPage();
        }

        protected override async void OnStart()
        {
            var apiService = new TrophyApiService();
            var player = await apiService.GetTrophiesAsync();
           
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
