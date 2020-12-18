using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using YoutubeRepoTwo.Models;
using YoutubeRepoTwo.ViewModels;

namespace YoutubeRepoTwo.Views.DynamicListView
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EditPersonPage : ContentPage
    {
        public EditPersonPage()
        {
            InitializeComponent();
            BindingContext = new EditPersonViewModel();
        }

        public EditPersonPage(PersonModel _personModel)
        {
            InitializeComponent();
            BindingContext = new EditPersonViewModel(_personModel);
        }

    }
}