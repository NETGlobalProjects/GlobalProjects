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
    public partial class BuscarMaterial : ContentPage
    {
        int ord_id;
        int no_partes;
        public BuscarMaterial(int p_ord_id, int p_no_partes)
        {
            InitializeComponent();
            ord_id = p_ord_id;
            no_partes = p_no_partes;
        }

        private async void cargarInventarios()
        {
            try
            {
                UserDialogs.Instance.ShowLoading("Cargando Inventarios...");

                var request = new HttpRequestMessage();
                request.RequestUri = new Uri(App.url_api + "Inventarios/" + App.pai_id + ";" + scBuscar.Text);
                request.Method = HttpMethod.Get;
                request.Headers.Add("accept", "application/json");
                var cliente = new HttpClient();
                HttpResponseMessage response = await cliente.SendAsync(request);
                string contenido = await response.Content.ReadAsStringAsync();
                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {

                    var resultado = JsonConvert.DeserializeObject<List<Inventarios>>(contenido);
                    cvInventarios.ItemsSource = resultado;
                    UserDialogs.Instance.HideLoading();
                }
                else if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
                {
                    UserDialogs.Instance.HideLoading();
                   
                    UserDialogs.Instance.Toast(contenido);
                }

            }
            catch (Exception ex)
            {
                UserDialogs.Instance.HideLoading();
                UserDialogs.Instance.Toast(ex.Message.ToString());
            }
        }

        private void scBuscar_SearchButtonPressed(object sender, EventArgs e)
        {
            cargarInventarios();
        }

        private void scBuscar_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (scBuscar.Text == "")
            {
                cargarInventarios();
            }
        }

        private void rvInventarios_Refreshing(object sender, EventArgs e)
        {
            cargarInventarios();
            rvInventarios.IsRefreshing = false;
        }

        private async void cvInventarios_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string inv_id = (e.CurrentSelection.FirstOrDefault() as Inventarios)?.inv_id;
            string inv_descripcion = (e.CurrentSelection.FirstOrDefault() as Inventarios)?.inv_descripcion;
            string inv_descripcion_larga = (e.CurrentSelection.FirstOrDefault() as Inventarios)?.inv_descripcion_larga;
            string uni_descripcion = (e.CurrentSelection.FirstOrDefault() as Inventarios)?.uni_descripcion;

            await Navigation.PushAsync(new AñadirModificarMaterial(ord_id, inv_id, inv_descripcion, inv_descripcion_larga, uni_descripcion, "añadir", no_partes, 0, 1));
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
           if (App.navegar == "PartesOrden")
            {
                App.navegar ="";
                Navigation.PopAsync();
            }

        }
    }
}