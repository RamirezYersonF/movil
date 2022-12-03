using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace appventascp3
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class datospersonales : ContentPage
    {
        public datospersonales()
        {
            InitializeComponent();
        }

        private void contraseña_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new contraseña();
            Console.WriteLine("MainPage");
        }

        private async void actualizar_Clicked(object sender, EventArgs e)
        {
            string correo = correos.Text;
            string nombresanterior = nombreanterior.Text;
            string nombresnuevo = nombrenuevo.Text;
            string apellidosanterior = apellidoanterior.Text;
            string apellidosnuevo = apellidonuevo.Text;

            WSClient client = new WSClient();
            var result = await client.Get<Models.Cambiandocontraseñamodels2>("https://192.168.20.30/" +
                "api/Cambiardatos2?usuario=" + correo + "&nombre=" + nombresanterior + "&nuevonombre=" + nombresnuevo
                + "&apellido=" + apellidosanterior +  "&nuevoapellido=" + apellidosnuevo);
           
   
            if (result != null)
            {
                if (result.correo == correo)
                {
                    
                    App.Current.MainPage = new contraseña();
                    Console.WriteLine("MainPage");

                }

                else
                {
                    await DisplayAlert("Ok", "Si se actualizaron los datos correctamente", "OK");
                }
            }
        }

        private void cambiarcontraseña_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new contraseña();
            Console.WriteLine("MainPage");
        }
    }
}