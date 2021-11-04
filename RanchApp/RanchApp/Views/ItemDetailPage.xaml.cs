using RanchApp.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace RanchApp.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}