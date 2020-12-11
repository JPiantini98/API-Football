﻿using FootballApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FootballApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TrophyPage : ContentPage
    {
        public TrophyPage()
        {
            InitializeComponent();
            BindingContext = new TrophyViewModel();
        }
    }
}