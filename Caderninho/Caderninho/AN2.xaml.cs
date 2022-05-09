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
    public partial class AN2 : ContentPage
    {
        public AN2()
        {
            InitializeComponent();
        }

       

        private async void btport2_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new mt2ano.port2());

            }
            catch (Exception ex)
            {

                await DisplayAlert("deu erro", ex.Message, "ok :/");
            }

        }

        private async void btmat2_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new mt2ano.mat2());

            }
            catch (Exception ex)
            {

                await DisplayAlert("deu erro", ex.Message, "ok :/");
            }

        }

        private async void bting2_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new mt2ano.ing2());

            }
            catch (Exception ex)
            {

                await DisplayAlert("deu erro", ex.Message, "ok :/");
            }

        }

        private async void bthist2_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new mt2ano.hist2());

            }
            catch (Exception ex)
            {

                await DisplayAlert("deu erro", ex.Message, "ok :/");
            }

        }

        private async void btgeo2_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new mt2ano.geo2());

            }
            catch (Exception ex)
            {

                await DisplayAlert("deu erro", ex.Message, "ok :/");
            }

        }

        private async void btiqui2_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new mt2ano.qui2());

            }
            catch (Exception ex)
            {

                await DisplayAlert("deu erro", ex.Message, "ok :/");
            }

        }

        private async void btfis2_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new mt2ano.fis2());

            }
            catch (Exception ex)
            {

                await DisplayAlert("deu erro", ex.Message, "ok :/");
            }

        }

        private async void btfilo2_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new mt2ano.filo2());

            }
            catch (Exception ex)
            {

                await DisplayAlert("deu erro", ex.Message, "ok :/");
            }

        }

        private async void btisoci1_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new mt2ano.soci2());

            }
            catch (Exception ex)
            {

                await DisplayAlert("deu erro", ex.Message, "ok :/");
            }

        }

        
        private async void btcid_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new mt2ano.cid2());

            }
            catch (Exception ex)
            {

                await DisplayAlert("deu erro", ex.Message, "ok :/");
            }

        }

        private async void bted2_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new mt2ano.edfis2());

            }
            catch (Exception ex)
            {

                await DisplayAlert("deu erro", ex.Message, "ok :/");
            }

        }

        private async void btinproweb2_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new mt2ano.proweb2());

            }
            catch (Exception ex)
            {

                await DisplayAlert("deu erro", ex.Message, "ok :/");
            }

        }

       

        private async void btsis_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new mt2ano.sisemb2());

            }
            catch (Exception ex)
            {

                await DisplayAlert("deu erro", ex.Message, "ok :/");
            }

        }

        private async void btbd2_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new mt2ano.bd2());

            }
            catch (Exception ex)
            {

                await DisplayAlert("deu erro", ex.Message, "ok :/");
            }


        }

        private async void btprogmob2_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new mt2ano.promo2());

            }
            catch (Exception ex)
            {

                await DisplayAlert("deu erro", ex.Message, "ok :/");
            }

        }

        private async void btsis2_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new mt2ano.sisemb2());

            }
            catch (Exception ex)
            {

                await DisplayAlert("deu erro", ex.Message, "ok :/");
            }

        }

        private async void btbio2_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new mt2ano.bio2());

            }
            catch (Exception ex)
            {

                await DisplayAlert("deu erro", ex.Message, "ok :/");
            }

        }

        private async void btds2_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new mt2ano.ds2());

            }
            catch (Exception ex)
            {

                await DisplayAlert("deu erro", ex.Message, "ok :/");
            }

        }
    }
}