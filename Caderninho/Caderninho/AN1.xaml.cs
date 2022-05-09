using Caderninho.mt1ano;
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
    public partial class AN1 : ContentPage
    {
        public AN1()
        {
            InitializeComponent();
        }

        private async void btport1_Clicked(object sender, EventArgs e)
        {//async pra n dar erro no metodo
            try
            {//evento do botao e ligando a página de dentro da pasta 
                await Navigation.PushAsync(new mt1ano.port());

            }
            catch (Exception ex)
           {
                //criando uma menssagem de erro
               await DisplayAlert("deu erro", ex.Message, "ok :/");
             }

        }

        private async void btmat1_Clicked(object sender, EventArgs e)
        {
            try
            {//evento do botao e ligando a página de dentro da pasta 
                await Navigation.PushAsync(new mt1ano.mat1());

            }
            catch (Exception ex)
            {
                //criando uma menssagem de erro
                await DisplayAlert("deu erro", ex.Message, "ok :/");
            }
        }

        private async void bting1_Clicked(object sender, EventArgs e)
        {
            try
            {//evento do botao e ligando a página de dentro da pasta 
                await Navigation.PushAsync(new mt1ano.ing1());

            }
            catch (Exception ex)
            {
                //criando uma menssagem de erro
                await DisplayAlert("deu erro", ex.Message, "ok :/");
            }



        }

        private async void bthist1_Clicked(object sender, EventArgs e)
        {
            try
            {//evento do botao e ligando a página de dentro da pasta 
                await Navigation.PushAsync(new mt1ano.hist1());

            }
            catch (Exception ex)
            {
                //criando uma menssagem de erro
                await DisplayAlert("deu erro", ex.Message, "ok :/");
            }

        }


        private async void btgeo1_Clicked(object sender, EventArgs e)
        {
            try
            {//evento do botao e ligando a página de dentro da pasta 
                await Navigation.PushAsync(new mt1ano.geo1());

            }
            catch (Exception ex)
            {
                //criando uma menssagem de erro
                await DisplayAlert("deu erro", ex.Message, "ok :/");
            }
        }

        private async void btiqui1_Clicked(object sender, EventArgs e)
        {
            try
            {//evento do botao e ligando a página de dentro da pasta 
                await Navigation.PushAsync(new mt1ano.qui1());

            }
            catch (Exception ex)
            {
                //criando uma menssagem de erro
                await DisplayAlert("deu erro", ex.Message, "ok :/");
            }
        }

        private async void btfis1_Clicked(object sender, EventArgs e)
        {
            try
            {//evento do botao e ligando a página de dentro da pasta 
                await Navigation.PushAsync(new mt1ano.fis1());

            }
            catch (Exception ex)
            {
                //criando uma menssagem de erro
                await DisplayAlert("deu erro", ex.Message, "ok :/");
            }

        }

        private async void btfilo1_Clicked(object sender, EventArgs e)
        {
            try
            {//evento do botao e ligando a página de dentro da pasta 
                await Navigation.PushAsync(new mt1ano.filo1());

            }
            catch (Exception ex)
            {
                //criando uma menssagem de erro
                await DisplayAlert("deu erro", ex.Message, "ok :/");
            }

        }

        private async void btiart_Clicked(object sender, EventArgs e)
        {
            try
            {//evento do botao e ligando a página de dentro da pasta 
                await Navigation.PushAsync(new mt1ano.artes1());

            }
            catch (Exception ex)
            {
                //criando uma menssagem de erro
                await DisplayAlert("deu erro", ex.Message, "ok :/");
            }

        }

        private async void bted1_Clicked(object sender, EventArgs e)
        {
            try
            {//evento do botao e ligando a página de dentro da pasta 
                await Navigation.PushAsync(new mt1ano.edfis1());

            }
            catch (Exception ex)
            {
                //criando uma menssagem de erro
                await DisplayAlert("deu erro", ex.Message, "ok :/");
            }

        }

        private async void btlogica_Clicked(object sender, EventArgs e)
        {
            try
            {//evento do botao e ligando a página de dentro da pasta 
                await Navigation.PushAsync(new mt1ano.logica1());

            }
            catch (Exception ex)
            {
                //criando uma menssagem de erro
                await DisplayAlert("deu erro", ex.Message, "ok :/");
            }

        }

        private async void btinproweb1_Clicked(object sender, EventArgs e)
        {
            try
            {//evento do botao e ligando a página de dentro da pasta 
                await Navigation.PushAsync(new mt1ano.proweb1());

            }
            catch (Exception ex)
            {
                //criando uma menssagem de erro
                await DisplayAlert("deu erro", ex.Message, "ok :/");
            }

        }

        private async void btdesi_Clicked(object sender, EventArgs e)
        {
            try
            {//evento do botao e ligando a página de dentro da pasta 
                await Navigation.PushAsync(new mt1ano.design1());

            }
            catch (Exception ex)
            {
                //criando uma menssagem de erro
                await DisplayAlert("deu erro", ex.Message, "ok :/");
            }

        }

        private async void btfund_Clicked(object sender, EventArgs e)
        {
            try
            {//evento do botao e ligando a página de dentro da pasta 
                await Navigation.PushAsync(new mt1ano.fundweb1());

            }
            catch (Exception ex)
            {
                //criando uma menssagem de erro
                await DisplayAlert("deu erro", ex.Message, "ok :/");
            }

        }

        

        

        private async void btbio1_Clicked(object sender, EventArgs e)
        {
            try
            {//evento do botao e ligando a página de dentro da pasta 
                await Navigation.PushAsync(new mt1ano.bio1());

            }
            catch (Exception ex)
            {
                //criando uma menssagem de erro
                await DisplayAlert("deu erro", ex.Message, "ok :/");
            }


        }

        private async void btiart1_Clicked(object sender, EventArgs e)
        {
            try
            {//evento do botao e ligando a página de dentro da pasta 
                await Navigation.PushAsync(new mt1ano.artes1());

            }
            catch (Exception ex)
            {
                //criando uma menssagem de erro
                await DisplayAlert("deu erro", ex.Message, "ok :/");
            }


        }

        private async void btlogica1_Clicked(object sender, EventArgs e)
        {
            try
            {//evento do botao e ligando a página de dentro da pasta 
                await Navigation.PushAsync(new mt1ano.logica1());

            }
            catch (Exception ex)
            {
                //criando uma menssagem de erro
                await DisplayAlert("deu erro", ex.Message, "ok :/");
            }


        }

        private async void tec_Clicked(object sender, EventArgs e)
        {
            try
            {//evento do botao e ligando a página de dentro da pasta 
                await Navigation.PushAsync(new mt1ano.tecprog1());

            }
            catch (Exception ex)
            {
                //criando uma menssagem de erro
                await DisplayAlert("deu erro", ex.Message, "ok :/");
            }


        }

        private async void btbd1_Clicked(object sender, EventArgs e)
        {
            try
            {//evento do botao e ligando a página de dentro da pasta 
                await Navigation.PushAsync(new mt1ano.bd1());

            }
            catch (Exception ex)
            {
                //criando uma menssagem de erro
                await DisplayAlert("deu erro", ex.Message, "ok :/");
            }


        }
    }
}