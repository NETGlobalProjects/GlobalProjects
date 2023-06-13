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
	public partial class AsignarOrdenBuscarMecanicos : ContentPage
	{
        int ord_id;
        bool change_buscar = false;
		public AsignarOrdenBuscarMecanicos (int p_ord_id)
		{
			InitializeComponent ();
            ord_id = p_ord_id;
            cargarMecanicos();
		}
        private async void cargarMecanicos()
        {
            UserDialogs.Instance.ShowLoading("Cargando Lista de Mecánicos...");
            var request = new HttpRequestMessage();
            request.RequestUri = new Uri(App.url_api + "ListaMecanicos/" + scBuscar.Text);
            request.Method = HttpMethod.Get;
            request.Headers.Add("accept", "application/json");
            var client = new HttpClient();
            HttpResponseMessage response = await client.SendAsync(request);
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                string content = await response.Content.ReadAsStringAsync();
                var resultado = JsonConvert.DeserializeObject<List<ListaMecanicos>>(content);
                cvMecanicos.ItemsSource = resultado;
            }
            UserDialogs.Instance.HideLoading();
        }

        private void rvMecanicos_Refreshing(object sender, EventArgs e)
        {
            cargarMecanicos();
            rvMecanicos.IsRefreshing = false;
        }

        private void scBuscar_SearchButtonPressed(object sender, EventArgs e)
        {
            change_buscar = true;
            cargarMecanicos();
        }

        private void scBuscar_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (change_buscar == true)
            {
                if (scBuscar.Text == "")
                {
                    cargarMecanicos();
                }
            }
        }
        private void cvMecanicos_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int mec_id = (e.CurrentSelection.SingleOrDefault() as ListaMecanicos).mec_id;
            string mec_nombre = (e.CurrentSelection.SingleOrDefault() as ListaMecanicos).mec_nombre;
            string mec_fotor_url = (e.CurrentSelection.SingleOrDefault() as ListaMecanicos).usu_nomina_fotografia;
            Navigation.PushAsync(new AsignarOrdenAñadirMecanico(ord_id, mec_id, mec_nombre, mec_fotor_url));
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            cargarMecanicos();
            if(App.navegar == "MecanicosOrden")
            {
                App.navegar = "";
                Navigation.PopAsync(true);
            }
        }
    }
}