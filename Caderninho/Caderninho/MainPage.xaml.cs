using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Caderninho
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        //criando o evento do botão
        private async void bt1_Clicked(object sender, EventArgs e)
        {
            //criando o evento de que quando clikar no botão ele leve para a página indicada
            try
            {
                await Navigation.PushAsync(new AN1());

            }catch(Exception ex) 
            {
                //criando uma menssagem de erro
                await DisplayAlert("deu erro", ex.Message, "ok :/");
            }
        }

        //criando o evento do botão
        private async void bt2_Clicked(object sender, EventArgs e)
        {
            //criando o evento de que quando clikar no botão ele leve para a página indicada
            try
            {
                await Navigation.PushAsync(new AN2());
            }
            catch (Exception ex)
            {
                //criando uma menssagem de erro
                await DisplayAlert("deu erro", ex.Message, "ok");
            }
        }

        //criando o evento do botão
        private async void bt3_Clicked(object sender, EventArgs e)
        {
            //criando o evento de que quando clikar no botão ele leve para a página indicada
            try
            {
                await Navigation.PushAsync(new AN3());
            }
            catch (Exception ex)
            {
                //criando uma menssagem de erro
                await DisplayAlert("deu erro", ex.Message, "ok");
            }
        }
    }
}
