using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Net.Http;
using Newtonsoft.Json;

namespace appventascp3
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class empleadoadd : ContentPage
    {
        public empleadoadd()
        {
            InitializeComponent();
        }

        private async void agregarempleadobd_Clicked(object sender, EventArgs e)
        {
            string nombreempleado = empleadonombre.Text;
            string transporte = empleadotransporte.Text;
            string celular = empleadotelefono.Text;
           


            WSClient client = new WSClient();

            var result = await client.Get<Boolean>("https://192.168.20.30/" +
                "api/Registroempleado?nombre=" + nombreempleado + "&transporte=" + transporte + "&telefono=" + celular);


            if (result)
            {
                await DisplayAlert("Datos Guardados", "Registro Exitoso", "ok");


                //await Navigation.PushAsync(new login());
                App.Current.MainPage = new login();
                Console.WriteLine("MainPage");

            }



        }
        private void irlogin2_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new addproductos();
            Console.WriteLine("MainPage");
        }
    }
}