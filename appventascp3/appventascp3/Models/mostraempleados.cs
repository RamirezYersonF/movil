using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace appventascp3.Models
{
    public class mostrarempleados
    {
        public int idempleados { get; set; }
        public string nombre { get; set; }
        public string transporte { get; set; }
    }
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PosRestPage : ContentPage
    {
        private const string url = "https://192.168.105.246/api/mostrarempleado";
        public PosRestPage()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            throw new NotImplementedException();
        }
    }
}
