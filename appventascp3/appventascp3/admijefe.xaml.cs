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
    public partial class admijefe : ContentPage
    {
        public admijefe()
        {
            InitializeComponent();
        }
        private void administrador_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new inicio();
            Console.WriteLine("MainPage");
        }

        private async void add_Clicked(object sender, EventArgs e)
        {
            string correo = correos.Text;
            string contraseña = contraseñas.Text;

            WSClient client = new WSClient();
            var result = await client.Get<Models.jefemodels>("https://192.168.20.30/" +
                "api/jefe?usuario=" + correo + "&contraseña=" + contraseña);
       

            if (result != null)
            {
                if (result.contraseña == contraseña)
                {
                    App.Current.MainPage = new addproductos();
                    Console.WriteLine("MainPage");

                }

                else
                {
                    await DisplayAlert("Error", "Datos incorrectos", "OK");
                }
            }
        }
    }
}