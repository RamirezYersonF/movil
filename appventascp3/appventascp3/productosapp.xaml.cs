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
    public partial class productosapp : ContentPage
    {
        public productosapp()
        {
            InitializeComponent();
        }

        private async void dineropagos_Clicked(object sender, EventArgs e)
        {
            {
                string nombreproductos1 = nombreproducto1.Text;
                double precios1 = Int32.Parse(precio1.Text);
                int canitdades1 = Int32.Parse(cantidad1.Text);
                WSClient client = new WSClient();


                var result = await client.Get<Boolean>("https://192.168.20.30/" +
                     "api/ProductoCliente?nombreproducto=" + nombreproductos1 + "&precio=" + precios1 + "&cantidad=" + canitdades1);
            }
        }
        private async void dineropagos2_Clicked(object sender, EventArgs e)
        {
            {

                string nombreproductos2 = nombreproducto2.Text;
                double precios2 = Int32.Parse(precio2.Text);
                int canitdades2 = Int32.Parse(cantidad2.Text);

                WSClient client = new WSClient();

                var result = await client.Get<Boolean>("https://192.168.20.30/" +
                     "api/ProductoCliente?nombreproducto=" + nombreproductos2 + "&precio=" + precios2 + "&cantidad=" + canitdades2);



            }
        }
        //private async void dineropagos3_Clicked(object sender, EventArgs e)
        //{
        //    {

        //        string nombreproductos3 = nombreproducto3.Text;
        //        double precios3 = Int32.Parse(precio3.Text);
        //        int canitdades3 = Int32.Parse(cantidad3.Text);

        //        WSClient client = new WSClient();

        //        var result = await client.Get<Boolean>("https://192.168.20.30/" +
        //             "api/ProductoCliente?nombreproducto=" + nombreproductos3 + "&precio=" + precios3 + "&cantidad=" + canitdades3);



        //    }
        //}
        private void continuarpagos_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new metodopago();
            Console.WriteLine("MainPage");
        }

        private void perfil_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new datospersonales();
            Console.WriteLine("MainPage");
        }

        private async void dineropagos3_Clicked_1(object sender, EventArgs e)
        {
            {

                string nombreproductos3 = nombreproducto3.Text;
                double precios3 = Int32.Parse(precio3.Text);
                int canitdades3 = Int32.Parse(cantidad3.Text);

                WSClient client = new WSClient();

                var result = await client.Get<Boolean>("https://192.168.20.30/" +
                     "api/ProductoCliente?nombreproducto=" + nombreproductos3 + "&precio=" + precios3 + "&cantidad=" + canitdades3);



            }
        }

        private async void dineropagos1_Clicked(object sender, EventArgs e)
        {
            {
                string nombreproductos1 = nombreproducto1.Text;
                double precios1 = Int32.Parse(precio1.Text);
                int canitdades1 = Int32.Parse(cantidad1.Text);
                WSClient client = new WSClient();


                var result = await client.Get<Boolean>("https://192.168.20.30/" +
                     "api/ProductoCliente?nombreproducto=" + nombreproductos1 + "&precio=" + precios1 + "&cantidad=" + canitdades1);
            }
        }

        private async void dineropagos2_Clicked_1(object sender, EventArgs e)
        {
            {

                string nombreproductos2 = nombreproducto2.Text;
                double precios2 = Int32.Parse(precio2.Text);
                int canitdades2 = Int32.Parse(cantidad2.Text);

                WSClient client = new WSClient();

                var result = await client.Get<Boolean>("https://192.168.20.30/" +
                     "api/ProductoCliente?nombreproducto=" + nombreproductos2 + "&precio=" + precios2 + "&cantidad=" + canitdades2);



            }
        }
    }

}