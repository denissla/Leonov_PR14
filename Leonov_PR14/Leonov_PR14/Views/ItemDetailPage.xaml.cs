using Leonov_PR14.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace Leonov_PR14.Views
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