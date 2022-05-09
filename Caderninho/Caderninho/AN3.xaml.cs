using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Caderninho
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AN3 : ContentPage
    {
        public AN3()
        {
            InitializeComponent();
        }

        private async void btport3_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new mt3ano.port3());

            }
            catch (Exception ex)
            {

                await DisplayAlert("deu erro", ex.Message, "ok :/");
            }


        }

        private async void btmat3_Clicked(object sender, EventArgs e)
        {

            try
            {
                await Navigation.PushAsync(new mt3ano.mat3());

            }
            catch (Exception ex)
            {

                await DisplayAlert("deu erro", ex.Message, "ok :/");
            }


        }

        private async void bting3_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new mt3ano.ing3());

            }
            catch (Exception ex)
            {

                await DisplayAlert("deu erro", ex.Message, "ok :/");
            }



        }

        private async void bthist3_Clicked(object sender, EventArgs e)
        {

            try
            {
                await Navigation.PushAsync(new mt3ano.hist3());

            }
            catch (Exception ex)
            {

                await DisplayAlert("deu erro", ex.Message, "ok :/");
            }


        }

        private async void btgeo3_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new mt3ano.geo3());

            }
            catch (Exception ex)
            {

                await DisplayAlert("deu erro", ex.Message, "ok :/");
            }


        }

        private async void btiqui3_Clicked(object sender, EventArgs e)
        {

            try
            {
                await Navigation.PushAsync(new mt3ano.qui3());

            }
            catch (Exception ex)
            {

                await DisplayAlert("deu erro", ex.Message, "ok :/");
            }


        }

        private async void btfis3_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new mt3ano.fis3());

            }
            catch (Exception ex)
            {

                await DisplayAlert("deu erro", ex.Message, "ok :/");
            }


        }

        private async void btfilo3_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new mt3ano.filo3());

            }
            catch (Exception ex)
            {

                await DisplayAlert("deu erro", ex.Message, "ok :/");
            }


        }

        private async void btisoc3_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new mt3ano.soci3());

            }
            catch (Exception ex)
            {

                await DisplayAlert("deu erro", ex.Message, "ok :/");
            }


        }

        private async void bted3_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new mt3ano.edfis3());

            }
            catch (Exception ex)
            {

                await DisplayAlert("deu erro", ex.Message, "ok :/");
            }


        }

        

        

        private async void btinproweb3_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new mt3ano.proweb3());

            }
            catch (Exception ex)
            {

                await DisplayAlert("deu erro", ex.Message, "ok :/");
            }


        }

        

       

        

        private async void btbio3_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new mt3ano.bio3());

            }
            catch (Exception ex)
            {

                await DisplayAlert("deu erro", ex.Message, "ok :/");
            }


        }

        private async void btprogmob3_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new mt3ano.proweb3());

            }
            catch (Exception ex)
            {

                await DisplayAlert("deu erro", ex.Message, "ok :/");
            }


        }

        private async void btrede_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new mt3ano.rede3());

            }
            catch (Exception ex)
            {

                await DisplayAlert("deu erro", ex.Message, "ok :/");
            }


        }

        private async void bttcc_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new mt3ano.tcc3());

            }
            catch (Exception ex)
            {

                await DisplayAlert("deu erro", ex.Message, "ok :/");
            }


        }

        private async void btanalise_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new mt3ano.ansoft());

            }
            catch (Exception ex)
            {

                await DisplayAlert("deu erro", ex.Message, "ok :/");
            }


        }
    }
}