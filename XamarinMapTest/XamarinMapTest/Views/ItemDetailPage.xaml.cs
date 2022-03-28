using System.ComponentModel;
using Xamarin.Forms;
using XamarinMapTest.ViewModels;

namespace XamarinMapTest.Views
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