using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Acr.UserDialogs;
using AppWDS.Modelos;
using Newtonsoft.Json;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppWDS.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AutorizacionPrecios : ContentPage
    {
        bool change_buscar = false;
        public AutorizacionPrecios()
        {
            InitializeComponent();
            cargarListado();
        }

        private void rvAutorizacion_Refreshing(object sender, EventArgs e)
        {
            cargarListado();
            rvAutorizacion.IsRefreshing = false;
        }

        private void cvAutorizacion_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int cot_id = (e.CurrentSelection.SingleOrDefault() as autorizacionPrecios).Cot_id;
            int doc_decimales = (e.CurrentSelection.SingleOrDefault() as autorizacionPrecios).Doc_decimales;
            Navigation.PushAsync(new autorizacionPreciosDetalle(cot_id, doc_decimales));
        }
        private async void cargarListado()
        {
            UserDialogs.Instance.ShowLoading("Cargando Lista de Autorizaciones...");
            var request = new HttpRequestMessage();
            request.RequestUri = new Uri(App.url_api + "autorizacionPrecios/0;" + scBuscar.Text);
            request.Method = HttpMethod.Get;
            request.Headers.Add("accept", "application/json");
            var client = new HttpClient();
            HttpResponseMessage response = await client.SendAsync(request);
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                string content = await response.Content.ReadAsStringAsync();
                var resultado = JsonConvert.DeserializeObject<List<autorizacionPrecios>>(content);
                cvAutorizacion.ItemsSource = resultado;
            }
            UserDialogs.Instance.HideLoading();
        }

        private void scBuscar_SearchButtonPressed(object sender, EventArgs e)
        {
            change_buscar = true;
            cargarListado();
        }

        private void scBuscar_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (change_buscar == true)
            {
                if (scBuscar.Text == "")
                {
                    cargarListado();
                }
            }
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            cargarListado();
           
        }
    }
}