using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace IngresoPersonasBaseDatos
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NavigationPage(new Views.AgregarPersona()));
        }

        private async void btnListPersons_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NavigationPage(new Views.MostrarPersona()));
        }
    }
}

