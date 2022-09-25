using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TP02
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        async void btnPadrao_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Padrao());
        }

        async void btnDinamico_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Dinamico());
        }

        async void btnTriggers_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Event());
        }

        void btnGlobal_Clicked(object sender, EventArgs e)
        {

        }

        async void btnHome_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Home());
        }

        void btnCenter_Clicked(object sender, EventArgs e)
        {

        }

        async void btnSimples_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Simples());
        }

        void btnComplexa_Clicked(object sender, EventArgs e)
        {

        }

        async void btnProduto_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Produto());
        }

        void btnCreditos_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Créditos", "Josuel João dos Santos     CB3005542          Liniker Vaz de Lima     CB3010881", "Ok");
        }
    }
}
