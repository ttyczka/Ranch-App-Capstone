using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RanchApp
{
    public partial class WorkWithAnimalsPage : ContentPage
    {
        public WorkWithAnimalsPage()
        {
            InitializeComponent();
        }
        protected override async void OnAppearing()
        {
            base.OnAppearing();
            collectionView.ItemsSource = await App.Database.GetWorkWithAnimalsAsync();
        }

        async void OnButtonClicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(workActionEntry.Text) && !string.IsNullOrWhiteSpace(workDateEntry.Text))
            {
                await App.Database.SaveWorkWithAnimalsAsync(new WorkWithAnimals
                {
                    workAction = workActionEntry.Text,
                    workDate = workDateEntry.Text
                });

                workActionEntry.Text = workDateEntry.Text = string.Empty;
                collectionView.ItemsSource = await App.Database.GetWorkWithAnimalsAsync();
            }
        }
    }
}