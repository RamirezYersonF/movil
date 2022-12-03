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
    public partial class addproductos : ContentPage
    {
        public addproductos()
        {
            InitializeComponent();
        }

        private void irlogin_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new login();
            Console.WriteLine("Registro");
        }
        private async void agregarproductos_Clicked(object sender, EventArgs e)
        {
            {
                string nombreproductos = nombreproducto.Text;
                int cantidadproductos = Int32.Parse(cantidadproducto.Text);
                double precios = Int32.Parse(precioproducto.Text);

                WSClient client = new WSClient();

                var result = await client.Get<Boolean>("https://192.168.20.30/" +
                 "api/Producto?nombreproducto=" + nombreproductos + "&cantidad=" + cantidadproductos + "&precio=" + precios);
            }
        }

        private void pasarempleado_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new empleadoadd();
            Console.WriteLine("MainPage");
        }
    }
}
