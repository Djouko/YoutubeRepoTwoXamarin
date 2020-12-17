using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using YoutubeRepoTwo.ViewModels;

namespace YoutubeRepoTwo.Views.AccessApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
            BindingContext = new LoginViewModel();

        }

        private async void SignUp_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RegisterPage());
        }
    }
}