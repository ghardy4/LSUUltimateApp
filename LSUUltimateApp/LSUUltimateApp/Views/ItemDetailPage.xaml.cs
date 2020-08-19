using System.ComponentModel;
using Xamarin.Forms;
using LSUUltimateApp.ViewModels;

namespace LSUUltimateApp.Views
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