using Frantskevich_Pr15.Models;
using Frantskevich_Pr15.Services;
using Frantskevich_Pr15.Views;
using System;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Frantskevich_Pr15
{
    public partial class App : Application
    {
        static TimeDataBase dataBase;

        internal static TimeDataBase DataBase
        {
            get
            {
                if (dataBase == null)
                {
                    dataBase = new TimeDataBase(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Times.db3"));
                }
                return dataBase;
            }
        }
        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
