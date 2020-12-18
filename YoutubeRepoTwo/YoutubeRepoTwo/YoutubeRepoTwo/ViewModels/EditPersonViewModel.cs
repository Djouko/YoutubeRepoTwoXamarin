using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using YoutubeRepoTwo.Models;
using YoutubeRepoTwo.Services;
using YoutubeRepoTwo.Views.DynamicListView;

namespace YoutubeRepoTwo.ViewModels
{
    public class EditPersonViewModel : BaseViewModel
    {
        FirebaseHelper firebaseHelper = new FirebaseHelper();

        #region Attributes
        private Guid iD;
        private string name;
        private string age;
        #endregion

        #region Properties
        public Guid IDTxt
        {
            get { return this.iD; }
            set { SetValue(ref this.iD, value); }
        }
        public string NameTxt
        {
            get { return this.name; }
            set { SetValue(ref this.name, value); }
        }

        public string AgeTxt
        {
            get { return this.age; }
            set { SetValue(ref this.age, value); }
        }

        #endregion

        #region Commands
        public ICommand UpdateCommand
        {
            get
            {
                return new RelayCommand(UpdateMethod);
            }
        }
        public ICommand DeleteCommand
        {
            get
            {
                return new RelayCommand(DeleteMethod);
            }
        }
        #endregion

        #region Methods

        private async void UpdateMethod()
        {
            var person = new PersonModel
            {
                PersonId = IDTxt,
                NameField = NameTxt,
                AgeField = int.Parse(AgeTxt),
            };

            await firebaseHelper.UpdatePerson(person);

            await App.Current.MainPage.Navigation.PushAsync(new ListViewPage());
        }
        private async void DeleteMethod()
        {
            await firebaseHelper.DeletePerson(IDTxt);
            await App.Current.MainPage.Navigation.PushAsync(new ListViewPage());

        }
        #endregion

        #region Constructor
        public EditPersonViewModel(PersonModel _personModel)
        {
            IDTxt = _personModel.PersonId;
            NameTxt = _personModel.NameField;
            AgeTxt = _personModel.AgeField.ToString();
        }

        public EditPersonViewModel()
        {
                
        }
        #endregion
    }
}
