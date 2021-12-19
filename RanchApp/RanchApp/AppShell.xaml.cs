using RanchApp.ViewModels;
using RanchApp.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace RanchApp
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
           
            
            Routing.RegisterRoute(nameof(AnimalInventoryPage), typeof(AnimalInventoryPage));
            Routing.RegisterRoute(nameof(WorkWithAnimalsPage), typeof(WorkWithAnimalsPage));
            Routing.RegisterRoute(nameof(CheckinPage), typeof(CheckinPage));
            Routing.RegisterRoute(nameof(LoginPage), typeof(LoginPage));
            
            Routing.RegisterRoute(nameof(MainPage), typeof(MainPage));
        }

        private async void OnAnimalInventoryClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(AnimalInventoryPage));
        }
        private async void OnWorkWithAnimalsClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(WorkWithAnimalsPage));
        }
        private async void OnCheckinClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(CheckinPage));
        }
       
                
    }
}
