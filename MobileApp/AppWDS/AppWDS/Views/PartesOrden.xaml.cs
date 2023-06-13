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
    public partial class PartesOrden : ContentPage
    {
        private static string accion { get; set; }
        public static int no_partes { get; set; }

        public static int dor_estado { get; set; }
        int ord_id;
        //int no_partes;
        int dor_id_next;
        bool existe_codigo;
        int current_dor_id;
        public PartesOrden(int p_ord_id, int p_no_partes)
        {
            InitializeComponent();
            ord_id = p_ord_id;
            no_partes = p_no_partes;
            actualizarNoPartes();
            //cargarInventarios();
            cargarItemsOrden();
        }
        private void actualizarNoPartes()
        {
            lblPartesRepuestos.Text = "Partes/Repuestos solicitados (" + Convert.ToString(no_partes) + ")";
        }

        private async void Aceptar_Clicked(object sender, EventArgs e)
        {

        }
      
        private async void cargarItemsOrden()
        {
            var request = new HttpRequestMessage();
            request.RequestUri = new Uri(App.url_api + "OrdenManttoItems/" + App.pai_id + ";" + App.emp_id + ";" + ord_id);
            request.Method = HttpMethod.Get;
            request.Headers.Add("accept", "application/json");
            var cliente = new HttpClient();
            HttpResponseMessage response = await cliente.SendAsync(request);
            string contenido = await response.Content.ReadAsStringAsync();
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                var resultado = JsonConvert.DeserializeObject<List<OrdenManttoItems>>(contenido);
                cvOrdenItems.ItemsSource = resultado;
            }
        }

        private void rvOrdenItems_Refreshing(object sender, EventArgs e)
        {

            cargarItemsOrden();
            rvOrdenItems.IsRefreshing = false;
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new BuscarMaterial(ord_id, no_partes));
        }
        protected override bool OnBackButtonPressed()
        {
            return true;
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            cargarItemsOrden();
            actualizarNoPartes();
            RevisarOrdenAsig.no_partes = no_partes;
        }

        private async void cvOrdenItems_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int dor_id = (e.CurrentSelection.FirstOrDefault() as OrdenManttoItems).dor_id;

            var request = new HttpRequestMessage();
            request.RequestUri = new Uri(App.url_api + "OrdenManttoItemsEstado/" + App.pai_id + ";" + App.emp_id + ";" + ord_id + ";" + dor_id);
            request.Method = HttpMethod.Get;
            request.Headers.Add("accept", "application/json");
            var cliente = new HttpClient();
            HttpResponseMessage response = await cliente.SendAsync(request);
            string contenido = await response.Content.ReadAsStringAsync();
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                dor_estado = Convert.ToInt32( contenido);
            }
            else if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
            {
               
                UserDialogs.Instance.Toast(contenido);
            }

            if (dor_estado == 0)
            {

                string inv_id = (e.CurrentSelection.FirstOrDefault() as OrdenManttoItems).inv_id;
                string inv_descripcion = (e.CurrentSelection.FirstOrDefault() as OrdenManttoItems).dor_descripcion;
                string uni_descripcion = "";
                string inv_descripcion_larga = "";
                double? dor_cantidad = (e.CurrentSelection.FirstOrDefault() as OrdenManttoItems)?.dor_cantidad;

                try
                {
                    UserDialogs.Instance.ShowLoading("Cargando Inventarios...");

                    var request2 = new HttpRequestMessage();
                    request2.RequestUri = new Uri(App.url_api + "Inventarios/" + App.pai_id + ";" + inv_id);
                    request2.Method = HttpMethod.Get;
                    request2.Headers.Add("accept", "application/json");
                    var cliente2 = new HttpClient();
                    HttpResponseMessage response2 = await cliente2.SendAsync(request2);
                    string contenido2 = await response2.Content.ReadAsStringAsync();
                    if (response2.StatusCode == System.Net.HttpStatusCode.OK)
                    {

                        var resultado2 = JsonConvert.DeserializeObject<List<Inventarios>>(contenido2);
                        uni_descripcion = resultado2.ElementAtOrDefault(0).uni_descripcion;
                        inv_descripcion_larga = resultado2.ElementAtOrDefault(0).inv_descripcion_larga;
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

                await Navigation.PushAsync(new AñadirModificarMaterial(ord_id, inv_id, inv_descripcion, inv_descripcion_larga, uni_descripcion, "editar", no_partes, dor_id, dor_cantidad));
            }
            else
            {
                UserDialogs.Instance.Toast("Ya no se puede editar la linea seleccionada");
            }
        }
    }
}