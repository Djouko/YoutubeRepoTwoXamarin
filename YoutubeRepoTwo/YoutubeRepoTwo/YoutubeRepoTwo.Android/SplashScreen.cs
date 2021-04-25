using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.OS;
using Android.Runtime;
using Android.Support.V7.App;
using Android.Views;
using Android.Widget;
using Felipecsl.GifImageViewLibrary;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Timers;

namespace YoutubeRepoTwo.Droid { 

    [Activity(
    Label = "YoutubeRepoTwo",
    Icon = "@mipmap/icon", 
    MainLauncher = true,
    Theme = "@style/splashTheme",
    NoHistory = true,
    ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]

    public class SplashScreen : AppCompatActivity //using Android.Support.V7.App;
    {
        private GifImageView gifImageView; //using Felipecsl.GifImageViewLibrary;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.SplashScreen);

            gifImageView = FindViewById<GifImageView>(Resource.Id.gifImageView);

            Stream input = Assets.Open("google-gif-logo.gif"); // en la carpeta assets esta el archivo "google-gif-logo.gif"
            byte[] bytes = ConvertFileToByteArray(input);
            gifImageView.SetBytes(bytes);
            gifImageView.StartAnimation();

            Timer timer = new Timer(); //using System.Timers;
            timer.Interval = 5000;
            timer.AutoReset = false;
            timer.Elapsed += Timer_Elapsed;
            timer.Start();
        }
        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            StartActivity(new Intent(this, typeof(MainActivity)));
        }

        private byte[] ConvertFileToByteArray(Stream input)
        {
            byte[] buffer = new byte[16 * 1024];
            using (MemoryStream ms = new MemoryStream())
            {
                int read;
                while ((read = input.Read(buffer, 0, buffer.Length)) > 0)
                    ms.Write(buffer, 0, read);

                return ms.ToArray();
            }
        }
    }
}