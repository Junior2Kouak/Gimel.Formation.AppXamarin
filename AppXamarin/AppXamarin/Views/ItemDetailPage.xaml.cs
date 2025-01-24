using System.ComponentModel;
using AppXamarin.ViewModels;
using Xamarin.Forms;

namespace AppXamarin.Views
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