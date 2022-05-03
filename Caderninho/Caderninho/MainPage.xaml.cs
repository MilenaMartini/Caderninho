using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Caderninho
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void bt1_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new AN1());

            }catch(Exception ex) 
            {
                await DisplayAlert("deu erro", ex.Message, "ok :/");
            }
        }

        private async void bt2_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new AN2());
            }
            catch (Exception ex)
            {
                await DisplayAlert("deu erro", ex.Message, "ok");
            }
        }

        private async void bt3_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new AN3());
            }
            catch (Exception ex)
            {
                await DisplayAlert("deu erro", ex.Message, "ok");
            }
        }
    }
}
