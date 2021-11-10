using RanchApp.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace RanchApp.Views
{
    public partial class WorkWithAnimalsPage : ContentPage
    {
        public WorkWithAnimalsPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}