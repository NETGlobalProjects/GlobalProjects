using Acr.UserDialogs;
using AppWDS.Modelos;
using Newtonsoft.Json;
using Prism.Navigation;
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
	public partial class MisAsignadas : ContentPage
	{
		public MisAsignadas ()
		{
			InitializeComponent ();
            cargarAsignadas();
		}

		private async void cargarAsignadas()
        {
            UserDialogs.Instance.ShowLoading("Cargando Ordenes...");
            var request = new HttpRequestMessage();
            request.RequestUri = new Uri(App.url_api + "OrdenManttoAsig/" + App.pai_id + ";" + App.emp_id + ";" + App.usu_id + ";" + scBuscar.Text + ";" + App.pla_id);
            request.Method = HttpMethod.Get;
            request.Headers.Add("accept", "application/json");
            var client = new HttpClient();
            HttpResponseMessage response = await client.SendAsync(request);
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                string content = await response.Content.ReadAsStringAsync();
                var resultado = JsonConvert.DeserializeObject<List<OrdenManttoAsig>>(content);
                cvOrdenesAsig.ItemsSource = resultado;
            }
            UserDialogs.Instance.HideLoading();
        }
        private void scBuscar_SearchButtonPressed(object sender, EventArgs e)
        {
            cargarAsignadas();
        }
        private void scBuscar_TextChanged(object sender, TextChangedEventArgs e)
        {
            if(scBuscar.Text == "") {

                cargarAsignadas();
            }
        }
        private async void cvOrdenesAsig_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string[] ord_descripcion = (e.CurrentSelection.FirstOrDefault() as OrdenManttoAsig)?.ord_descripcion.Split('|');
            int current = (e.CurrentSelection.FirstOrDefault() as OrdenManttoAsig).ord_id;
            string are_descripcion = (e.CurrentSelection.FirstOrDefault() as OrdenManttoAsig)?.are_descripcion;
            string sba_descripcion = (e.CurrentSelection.FirstOrDefault() as OrdenManttoAsig)?.sba_descripcion;
            string maq_id = (e.CurrentSelection.FirstOrDefault() as OrdenManttoAsig)?.maq_id;
            string maq_nombre = (e.CurrentSelection.FirstOrDefault() as OrdenManttoAsig)?.maq_nombre;
            string estado_color = (e.CurrentSelection.FirstOrDefault() as OrdenManttoAsig)?.estado_color;
            string oes_descripcion = (e.CurrentSelection.FirstOrDefault() as OrdenManttoAsig)?.oes_descripcion;
            string tio_descripcion = (e.CurrentSelection.FirstOrDefault() as OrdenManttoAsig)?.tio_descripcion;
            string pri_descripcion = (e.CurrentSelection.FirstOrDefault() as OrdenManttoAsig)?.pri_descripcion;
            string color_prioridad = (e.CurrentSelection.FirstOrDefault() as OrdenManttoAsig)?.color_prioridad;
            string comnetario_mec = (e.CurrentSelection.FirstOrDefault() as OrdenManttoAsig)?.ord_comentarios_mecanico;
            int? no_repuestos = 0;
            no_repuestos = (e.CurrentSelection.FirstOrDefault() as OrdenManttoAsig)?.no_materiales;
            int? no_mecanicos = 0;
            no_mecanicos = (e.CurrentSelection.FirstOrDefault() as OrdenManttoAsig)?.no_mecanicos;
            double? avance = 0;
            avance = (e.CurrentSelection.FirstOrDefault() as OrdenManttoAsig)?.avance;
            int no_partes = 0;
            no_partes = (e.CurrentSelection.FirstOrDefault() as OrdenManttoAsig).no_materiales;


            await Navigation.PushAsync(new RevisarOrdenAsig(current, are_descripcion, sba_descripcion, maq_id, maq_nombre, ord_descripcion[1].Trim(), oes_descripcion, estado_color, tio_descripcion, pri_descripcion, color_prioridad, avance, no_repuestos, no_mecanicos, no_partes, comnetario_mec));
            
        }

        private void RefreshView_Refreshing(object sender, EventArgs e)
        {
            cargarAsignadas();
            rvPanel.IsRefreshing = false;
               
        }

        protected override void OnAppearing()
        {
            cargarAsignadas();

            base.OnAppearing();
        }
    }
}