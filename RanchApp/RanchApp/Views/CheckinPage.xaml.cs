using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RanchApp
{
    
    public partial class CheckinPage : ContentPage
    {
        public CheckinPage()
            {
                InitializeComponent();
            }
            protected override async void OnAppearing()
            {
                base.OnAppearing();
                collectionView.ItemsSource = await App.Database.GetCheckInAsync();
            }

            async void OnButtonClicked(object sender, EventArgs e)
            {
                if (!string.IsNullOrWhiteSpace(empNameEntry.Text) && !string.IsNullOrWhiteSpace(empDateEntry.Text))
                {
                    await App.Database.SaveCheckInAsync(new CheckIn
                    {
                        empName = empNameEntry.Text,
                        empDate = empDateEntry.Text
                    });

                empNameEntry.Text = empDateEntry.Text = string.Empty;
                    collectionView.ItemsSource = await
                    App.Database.GetCheckInAsync();
                }
            }
        }
    }
