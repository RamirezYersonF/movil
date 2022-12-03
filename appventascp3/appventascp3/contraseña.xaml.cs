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
    public partial class contraseña : ContentPage
    {
        public contraseña()
        {
            InitializeComponent();
        }

        private async void Contraseñaactualizada_Clicked(object sender, EventArgs e)
        {
            {
                string correo = correos.Text;
                string contraseñasanterior = Contraseñaanterior.Text;
                string contraseñasnuevo = contraseñanueva.Text;
            

                WSClient client = new WSClient();
                var result = await client.Get<Models.Cambiandocontraseñamodels>("https://192.168.20.30/" +
                    "api/Cambiardatos?usuario=" + correo + "&contraseña=" + contraseñasanterior + "&nuevacontraseña=" + contraseñasnuevo);




                if (result != null)
                {
                    if (result.correo == correo)
                    {

                        App.Current.MainPage = new login();
                        Console.WriteLine("MainPage");

                    }

                    else
                    {
                        await DisplayAlert("Ok", "Si se actualizaron los datos correctamente", "OK");
                        App.Current.MainPage = new login();
                        Console.WriteLine("MainPage");
                    }
                }
            }
        }
    }
}