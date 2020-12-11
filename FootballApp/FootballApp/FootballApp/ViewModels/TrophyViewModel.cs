using System;
using System.Collections.Generic;
using System.ComponentModel;
using FootballApp.Services;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using FootballApp.Models;

namespace FootballApp.ViewModels
{
    public class TrophyViewModel : INotifyPropertyChanged
    {
        public ICommand GetTrophiesListCommand { get; }
        ITrophyApiService trophyApiService;

        Trophy trophy = new Trophy();

        public TrophyViewModel()
        {
            trophyApiService = new TrophyApiService();

        }

        public string league { get => trophy.league;}
        public string country { get => trophy.country; }
        public string season { get => trophy.season; }
        public string place { get => trophy.place; }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
