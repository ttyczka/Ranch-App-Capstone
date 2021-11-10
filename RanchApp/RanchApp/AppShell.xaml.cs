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
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
            Routing.RegisterRoute(nameof(LoginPage), typeof(LoginPage));
            Routing.RegisterRoute(nameof(WorkWithAnimalsPage), typeof(WorkWithAnimalsPage));
        }

        private async void OnLoginMenuItemClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(LoginPage));
        }
        private async void OnWorkWithAnimalsMenuItemClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(WorkWithAnimalsPage));
        }
        private async void OnAnimalsClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(ItemDetailPage));
        }
        private async void OnBeddingClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(WorkWithAnimalsPage));
        }
        private async void OnMineralsClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(WorkWithAnimalsPage));
        }
        private async void OnWhoHasBeenFedClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(WorkWithAnimalsPage));
        }
    }
}
