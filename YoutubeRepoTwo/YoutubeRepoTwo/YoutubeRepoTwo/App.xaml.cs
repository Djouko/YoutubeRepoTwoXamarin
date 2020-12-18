using Xamarin.Forms;
using YoutubeRepoTwo.Views.MasterDetail;
using System.IO;
using YoutubeRepoTwo.Database;
using System;
using YoutubeRepoTwo.Views.AccessApp;
using YoutubeRepoTwo.Views.DynamicListView;

namespace YoutubeRepoTwo
{
    public partial class App : Application
    {

        #region Database
        static DatabaseQuerys database;

        public static DatabaseQuerys Database
        {
            get
            {
                if (database == null)
                {
                    database = new DatabaseQuerys(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "DBname.db"));
                }
                return database;
            }
        }
        #endregion

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new ListViewPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
