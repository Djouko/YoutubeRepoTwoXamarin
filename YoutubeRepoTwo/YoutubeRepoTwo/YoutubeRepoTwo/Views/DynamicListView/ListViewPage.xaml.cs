using Xamarin.Forms;
using Xamarin.Forms.Xaml;
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
    }
}