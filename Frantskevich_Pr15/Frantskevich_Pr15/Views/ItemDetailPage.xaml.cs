using Frantskevich_Pr15.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace Frantskevich_Pr15.Views
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