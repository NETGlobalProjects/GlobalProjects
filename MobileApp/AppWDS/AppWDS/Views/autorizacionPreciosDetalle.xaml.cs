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
	public partial class autorizacionPreciosDetalle : ContentPage
	{
        int cot_id;
        int doc_decimales;
        bool change_buscar = false;
        public autorizacionPreciosDetalle (int _cot_id, int _doc_decimales)
		{
			InitializeComponent ();
            cot_id = _cot_id;
            doc_decimales = _doc_decimales;
            cargarListado(cot_id);
		}

        private void scBuscar_SearchButtonPressed(object sender, EventArgs e)
        {
            change_buscar = true;
            cargarListado(cot_id);
        }

        private void scBuscar_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (change_buscar == true)
            {
                if (scBuscar.Text == "")
                {
                    cargarListado(cot_id);
                }
            }
        }

        private void cvAutorizacionDet_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int cot_correlativo = (e.CurrentSelection.SingleOrDefault() as autorizacionPreciosDet).Cot_correlativo;
            string inv_id = (e.CurrentSelection.SingleOrDefault() as autorizacionPreciosDet).Inv_id;
            string cot_descripcion = (e.CurrentSelection.SingleOrDefault() as autorizacionPreciosDet).Cot_descripcion;
            string cliente = (e.CurrentSelection.SingleOrDefault() as autorizacionPreciosDet).Cliente;
            double cot_precio_sugerido = (e.CurrentSelection.SingleOrDefault() as autorizacionPreciosDet).Cot_precio_sugerido;
            double cot_cantidad = (e.CurrentSelection.SingleOrDefault() as autorizacionPreciosDet).Cot_cantidad;
            double cot_preciosiva = (e.CurrentSelection.SingleOrDefault() as autorizacionPreciosDet).Cot_preciosiva;
            double cot_preciociva = (e.CurrentSelection.SingleOrDefault() as autorizacionPreciosDet).Cot_preciociva;
            Navigation.PushAsync(new autorizacionPreciosDetalleXProd(inv_id, cot_descripcion, cliente, cot_id, cot_correlativo, cot_precio_sugerido, cot_preciosiva, cot_preciociva ,cot_cantidad, doc_decimales));
        }

        private void rvAutorizacionDet_Refreshing(object sender, EventArgs e)
        {
            cargarListado(cot_id);
            rvAutorizacionDet.IsRefreshing = false;
        }
        private async void cargarListado(int cot_id)
        {
            UserDialogs.Instance.ShowLoading("Cargando Lista de Productos...");
            var request = new HttpRequestMessage();
            request.RequestUri = new Uri(App.url_api + "autorizacionPreciosDet/" + cot_id);
            request.Method = HttpMethod.Get;
            request.Headers.Add("accept", "application/json");
            var client = new HttpClient();
            HttpResponseMessage response = await client.SendAsync(request);
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                string content = await response.Content.ReadAsStringAsync();
                var resultado = JsonConvert.DeserializeObject<List<autorizacionPreciosDet>>(content);
                cvAutorizacionDet.ItemsSource = resultado;
            }
            UserDialogs.Instance.HideLoading();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            cargarListado(cot_id);
            if (App.navegar == "autorizacionPrecios")
            {
                App.navegar = "";
                Navigation.PopAsync(true);
            }
        }
    }
}