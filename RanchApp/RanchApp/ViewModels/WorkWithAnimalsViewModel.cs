using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace RanchApp.ViewModels
{
    public class WorkWithAnimalsViewModel : ContentPage
    {
        public Command LoginCommand { get; }

        public WorkWithAnimalsViewModel()
        {
            LoginCommand = new Command(OnLoginClicked);
        }

        private async void OnLoginClicked(object obj)
        {
            // Prefixing with `//` switches to a different navigation stack instead of pushing to the active one
            await Shell.Current.GoToAsync(("WorkWithAnimalsPage"));
        }
    }
}