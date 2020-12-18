using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using YoutubeRepoTwo.Models;
using YoutubeRepoTwo.ViewModels;

namespace YoutubeRepoTwo.Views.DynamicListView
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListViewPage : ContentPage
    {
        public ListViewPage()
        {
            InitializeComponent();
            BindingContext = new PersonViewModels();
        }
        public async void ListViewName_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            await Navigation.PushAsync(new EditPersonPage(e.SelectedItem as PersonModel));
        }
    }
}