using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using YoutubeRepoTwo.ViewModels;

namespace YoutubeRepoTwo.Views.AccessApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegisterPage : ContentPage
    {
        public RegisterPage()
        {
            InitializeComponent();
            BindingContext = new RegisterViewModel();
        }

        private async void NavToLogin_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new LoginPage());
        }
    }
}