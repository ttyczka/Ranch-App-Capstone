using RanchApp.Services;
using RanchApp.Views;
using System;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: ExportFont("times_new_roman.ttf")]
[assembly: ExportFont("times_new_roman_bold.ttf")]

namespace RanchApp
{
    public partial class App : Application
    {
        static RanchDatabase database;
        public static RanchDatabase Database
        {
            get
            {
                if (database == null)
                {
                    database = new RanchDatabase(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "animal.db3"));
                }
                return database;
            }
        }

        public App()
        {
            InitializeComponent();
            //MainPage = new AppShell();
            MainPage = new AppShell();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
