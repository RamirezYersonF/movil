using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Net;
using System.Net.Http;
using Newtonsoft.Json;

namespace appventascp3
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class empleadosclientes2 : ContentPage
    {
        public empleadosclientes2()
        {
            InitializeComponent();
         
            
        }
        public class mostrarempleados
        {
            public int idempleados { get; set; }
            public string nombre { get; set; }
            public string transporte { get; set; }

            public string telefono { get; set; }
        }

        //public async  Task llamadoapi_Clicked()
        //{
            //var request = new HttpRequestMessage();
            //request.RequestUri = new Uri("https://192.168.20.30/api/mostrarempleado");
            //request.Method = HttpMethod.Get;
            //request.Headers.Add("Accetp", "application/json");
            //var client = new HttpClient();
            //HttpResponseMessage response = await client.SendAsync(request);
            //if (response.StatusCode == HttpStatusCode.OK)
            //{
            //    string content = await response.Content.ReadAsStringAsync();
            //    var resultado = JsonConvert.DeserializeObject<List<mostrarempleados>>(content);
            //    Listdemo.ItemsSource = resultado;
            //}
            //string url  = "https://192.168.20.30/api/mostrarempleado";
            //WSClient client = new WSClient();
            //List<mostrarempleados> response = await client.Get<List<mostrarempleados>>(url);
           
        }
    }
//}