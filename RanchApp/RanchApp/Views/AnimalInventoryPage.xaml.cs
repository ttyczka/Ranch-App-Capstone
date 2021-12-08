using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RanchApp
{
    public partial class AnimalInventoryPage : ContentPage
    {
     
        public AnimalInventoryPage()
        {
            InitializeComponent();
        }
        protected override async void OnAppearing()
        {
            base.OnAppearing();
            collectionView.ItemsSource = await App.Database.GetAnimalInventoryAsync();
        }

        async void OnButtonClicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(animalNameEntry.Text) && !string.IsNullOrWhiteSpace(animalTagEntry.Text))
            {
                await App.Database.SaveAnimalInventoryAsync(new AnimalInventory
                {
                    animalName = animalNameEntry.Text,
                    animalTag = animalTagEntry.Text
                });

                animalNameEntry.Text = animalTagEntry.Text = string.Empty;
                collectionView.ItemsSource = await
                App.Database.GetAnimalAsync();
            }
        }
    }
}