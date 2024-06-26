using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MobilAppS
{
    public partial class MainPage : ContentPage
    {
        Button button;
        public MainPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            /*StackLayout stack = new StackLayout();

            Label lable = new Label();
            lable.Text = "Hi,g!";
            lable.TextTransform = TextTransform.Uppercase;
            lable.FontSize = 25;

            button = new Button();
            button.Text = "push me";
            button.FontSize = 25;
            button.TextColor = Color.Red;
            button.Clicked += ButtonClick;


            stack.Children.Add(lable);
            stack.Children.Add(button);

            Content = stack;*/
        }

        private async void ButtonClick(object sender, EventArgs e)
        {
            /* button.Text = "Clicked";
             button.TextColor = Color.Green;*/
            if (string.IsNullOrEmpty(nameField.Text))
                errorText.Text = "No name";
            else if (string.IsNullOrEmpty(emailField.Text))              
                errorText.Text = "Where email?";
            else if (string.IsNullOrEmpty(passField.Text))              
                errorText.Text = "Forgot pass...";
            else if (!chekField.IsChecked)
                errorText.Text = "Why did not clicked?";
            else
            {
                errorText.Text = "";
                buttonSend.Text = "Send";
                buttonSend.BackgroundColor = Color.Aqua;
                buttonSend.TextColor = Color.Green;

                await DisplayAlert("Data from form", "All data received", "Nice");
            }
            
        }
    }
}
