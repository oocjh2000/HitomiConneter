using Android.App;
using Android.Widget;
using Android.OS;
using Android.Support.V7.App;
using OpenQA.Selenium;
using System;
using Android.Util;
using System.Net.Http;

namespace HitomiConnector
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        Toast toast;
        string BaseUrl= "https://hitomi.la";
        string Korean= "https://hitomi.la/index-korean-1.html";
        string MangaUrl;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

        
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            Button button = FindViewById<Button>(Resource.Id.button1);
            button.Click += Button_ClickAsync;
        }

        private async void Button_ClickAsync(object sender, System.EventArgs e)
        {
            try
            {
                var request = new HttpRequestMessage();
                request.RequestUri = new Uri(Korean);
                request.Method = HttpMethod.Get;
               
                var client = new HttpClient();
                HttpResponseMessage responseMessage = await client.SendAsync(request);

                toast = Toast.MakeText(this, responseMessage.StatusCode.ToString(), ToastLength.Long);
                toast.Show();
            }
            catch (Exception ex)
            {
                Log.Debug("REST", ex.Message);
                toast=Toast.MakeText(this, ex.Message, ToastLength.Long);
                toast.Show();
            }
        }
    }
}

