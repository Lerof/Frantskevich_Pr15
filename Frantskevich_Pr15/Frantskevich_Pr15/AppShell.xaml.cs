using Frantskevich_Pr15.ViewModels;
using Frantskevich_Pr15.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace Frantskevich_Pr15
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(HomePage), typeof(HomePage));
            Routing.RegisterRoute(nameof(HistoryPage), typeof(HistoryPage));
        }

    }
}
