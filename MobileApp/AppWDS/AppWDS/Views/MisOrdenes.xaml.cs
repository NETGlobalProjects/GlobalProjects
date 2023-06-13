using Acr.UserDialogs;
using AppWDS.Modelos;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppWDS.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MisOrdenes : ContentPage
	{
        bool busqueda_realizada;
        public MisOrdenes ()
		{
			InitializeComponent ();
            cargarOrdenes();
           
		}
        private async void cargarOrdenes()
        {
            UserDialogs.Instance.ShowLoading("Cargando Ordenes...");
            var request = new HttpRequestMessage();
            request.RequestUri = new Uri(App.url_api + "OrdenManttoGen/" + App.pai_id + ";" + App.emp_id + ";" + App.usu_id + ";" + App.pla_id + ";-1" + ";" + scBuscar.Text);
            request.Method = HttpMethod.Get;
            request.Headers.Add("accept", "application/json");
            var client = new HttpClient();
            HttpResponseMessage response = await client.SendAsync(request);
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                string content = await response.Content.ReadAsStringAsync();
                var resultado = JsonConvert.DeserializeObject<List<OrdenManttoGen>>(content);
                cvOrdenesGen.ItemsSource = resultado;
            }
            UserDialogs.Instance.HideLoading();
        }

        private void scBuscar_SearchButtonPressed(object sender, EventArgs e)
        {
            cargarOrdenes();
            busqueda_realizada = true;
        }

        private void rvPanel_Refreshing(object sender, EventArgs e)
        {
            cargarOrdenes();
            rvPanel.IsRefreshing = false;
        }

        private void scBuscar_TextChanged(object sender, TextChangedEventArgs e)
        {
            if(scBuscar.Text == "" && busqueda_realizada == true) 
            {
                cargarOrdenes();
            }
        }
    }
}