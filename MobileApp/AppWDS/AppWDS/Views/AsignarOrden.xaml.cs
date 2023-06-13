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
    public partial class AsignarOrden : ContentPage
    {
        bool change_estado = false;
        bool change_buscar = false;
        public AsignarOrden()
        {
            InitializeComponent();
            cargarEstados();
            cargarOrdenes();
        }

        private void cbxEstados_SelectedIndexChanged(object sender, EventArgs e)
        {
            change_estado = true;
            cargarOrdenes();
        }
        private async void cargarEstados()
        {
            UserDialogs.Instance.ShowLoading("Cargando Estados...");
            var request = new HttpRequestMessage();
            request.RequestUri = new Uri(App.url_api + "estadosOrdenes");
            request.Method = HttpMethod.Get;
            request.Headers.Add("accept", "application/json");
            var client = new HttpClient();
            HttpResponseMessage response = await client.SendAsync(request);
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                string content = await response.Content.ReadAsStringAsync();
                var resultado = JsonConvert.DeserializeObject<List<EstadosOrdenes>>(content);
                cbxEstados.ItemsSource = resultado;
            }
            UserDialogs.Instance.HideLoading();
            this.cbxEstados.SelectedIndex = 5;
        }

        private async void cargarOrdenes()
        {
            int oes_id = 0;
            if(this.cbxEstados.SelectedIndex < 0)
            {
                oes_id = -1;
            }
            else
            {
                string[] estado_orden = cbxEstados.Items[cbxEstados.SelectedIndex].ToString().Split(';');
                oes_id = Convert.ToInt32(estado_orden[0]);
            }
            if (change_estado == false)
            {
                oes_id = 4;
            }
            string buscar = "";
            if(scBuscar.Text != null)
            {
                buscar = scBuscar.Text;
            }
            UserDialogs.Instance.ShowLoading("Cargando Ordenes...");
            var request = new HttpRequestMessage();
            request.RequestUri = new Uri(App.url_api + "OrdenManttoAll/" + App.pai_id + ";" + App.emp_id + ";" + App.pla_id + ";" + oes_id + ";" +  buscar);
            request.Method = HttpMethod.Get;
            request.Headers.Add("accept", "application/json");
            var client = new HttpClient();
            HttpResponseMessage response = await client.SendAsync(request);
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                string content = await response.Content.ReadAsStringAsync();
                var resultado = JsonConvert.DeserializeObject<List<OrdenManttoAll>>(content);
                cvOrdenesAsig.ItemsSource = resultado;
            }
            UserDialogs.Instance.HideLoading();
        }

        private void scBuscar_SearchButtonPressed(object sender, EventArgs e)
        {
            change_buscar = true;
            cargarOrdenes();
        }

        private void scBuscar_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (change_buscar == true)
            {
                if(scBuscar.Text == "")
                {
                    cargarOrdenes();
                }
            }
        }

        private void rvPanel_Refreshing(object sender, EventArgs e)
        {
            cargarOrdenes();
            rvPanel.IsRefreshing = false;
        }

        private async void cvOrdenesAsig_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int ord_id = (e.CurrentSelection.FirstOrDefault() as OrdenManttoAll).ord_id;
            await Navigation.PushAsync(new AsignarOrdenDetalle(ord_id));
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            cargarOrdenes();
        }
    }
}