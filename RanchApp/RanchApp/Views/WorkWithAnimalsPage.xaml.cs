using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RanchApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WorkWithAnimals : ContentPage
    {
        public static Page GetWorkWithAnimalsPage()
        {
            return new ContentPage
            {
               
            };
        }

        
    }
}