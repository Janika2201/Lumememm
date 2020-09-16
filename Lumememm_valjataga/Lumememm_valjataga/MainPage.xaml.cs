using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Lumememm_valjataga
{
    public partial class MainPage : ContentPage
    {
        protected override void OnAppearing()
        {
            base.OnAppearing();
        }
        public MainPage()
        {
            InitializeComponent();
            var tap = new TapGestureRecognizer();
            tap.Tapped += Tap_Tapped;
            head.GestureRecognizers.Add(tap);
            keha.GestureRecognizers.Add(tap);
            jalad.GestureRecognizers.Add(tap);


        }
        Random rnd = new Random();
        private void Tap_Tapped(object sender, EventArgs e)
        {
            Frame fr = sender as Frame;
            if (fr == head)
            {
                int Red = rnd.Next(0, 255);
                int Green = rnd.Next(0, 255);
                int Blue = rnd.Next(0, 255);
                head.BackgroundColor = Color.FromRgb(Red, Green, Blue);
            }
            else if (fr == keha)
            {
                int Red = rnd.Next(0, 255);
                int Green = rnd.Next(0, 255);
                int Blue = rnd.Next(0, 255);
                keha.BackgroundColor = Color.FromRgb(Red, Green, Blue);


            }
            else if (fr == jalad)
            {
                int Red = rnd.Next(0, 255);
                int Green = rnd.Next(0, 255);
                int Blue = rnd.Next(0, 255);
                jalad.BackgroundColor = Color.FromRgb(Red, Green,Blue);
            }
        }

        private void AletrButton_Clicked()
        {
            {
               DisplayAlert("Уведомление!", "У тебя красивый снеговик","Жми");
            }
        }
    }
}
         
