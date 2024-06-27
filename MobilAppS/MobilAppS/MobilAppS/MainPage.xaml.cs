using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Newtonsoft.Json.Linq;

namespace MobilAppS
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            ShowItem();
        }

        private void ShowItem() 
        {
            itemsCollection.ItemsSource = App.Db.GetItems();
        }

        private async void AddItemButtom(object sender, EventArgs e) 
        {
            await Navigation.PushAsync(new AddItem());
        }
        /*
                const string API = "7eebefb90294686cdb5cc4f5b280a61b";

                public MainPage()
                {
                    InitializeComponent();
                }

                private async void getWeatherClicked(object sender, EventArgs e)
                {
                    string city = userInput.Text.Trim();
                    if (city.Length < 2) 
                    {
                        await DisplayAlert("Error", "City used to be bigger", "Okay");
                        return;
                    }

                    HttpClient client = new HttpClient();
                    string url = $"https://api.openweathermap.org/data/2.5/weather?q={city}&appid={API}&units=metric";
                    string response = await client.GetStringAsync(url);

                    var json = JObject.Parse(response);
                    string temp = json["main"]["temp"].ToString();
                    resultLable.Text = "Weather now: " + temp;
                }*/
    }
}
