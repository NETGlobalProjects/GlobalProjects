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
    public partial class AsignarOrdenDetalle : ContentPage
    {
        int ord_id;
        public AsignarOrdenDetalle(int p_ord_id)
        {
            InitializeComponent();
            ord_id = p_ord_id;
            cargarMecanicosManoObra();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AsignarOrdenBuscarMecanicos(ord_id));
        }
        private async void cargarMecanicosManoObra()
        {
            UserDialogs.Instance.ShowLoading("Cargando Mecánicos...");
            var request = new HttpRequestMessage();
            request.RequestUri = new Uri(App.url_api + "OrdenManttoMecanicos/" + App.pai_id + ";" + App.emp_id + ";" + ord_id);
            request.Method = HttpMethod.Get;
            request.Headers.Add("accept", "application/json");
            var client = new HttpClient();
            HttpResponseMessage response = await client.SendAsync(request);
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                string content = await response.Content.ReadAsStringAsync();
                var resultado = JsonConvert.DeserializeObject<List<OrdenManttoMecanicos>>(content);
                cvOrdenMecanicos.ItemsSource = resultado;
            }
            UserDialogs.Instance.HideLoading();
        }

        private void rvOrdenItems_Refreshing(object sender, EventArgs e)
        {
            cargarMecanicosManoObra();
            rvOrdenItems.IsRefreshing = false;
        }

        private void cvOrdenMecanicos_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            cargarMecanicosManoObra();
        }
    }
}