
using System;
using System.Linq;
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

        #region Test

        void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {
            var _container = BindingContext as PersonViewModels;
            ListViewName.BeginRefresh();

            if (string.IsNullOrWhiteSpace(e.NewTextValue))
            {
                ListViewName.ItemsSource = _container.IngredientsCollection;
            }
            else
            {
                ListViewName.ItemsSource = _container.IngredientsCollection.Where(i => i.NameField.Contains(e.NewTextValue));
            }

            ListViewName.EndRefresh();
        }
        #endregion
    }
}