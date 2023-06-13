using Acr.UserDialogs;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using AppWDS.Views;
using AppWDS.Modelos;
namespace AppWDS.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SelecionePaisEmpresa : ContentPage
	{
		public SelecionePaisEmpresa ()
		{
			InitializeComponent ();
            cargarPaises();
		}
        [Obsolete]
        private async void btnSeleccionar_Clicked(object sender, EventArgs e)
        {
            try
            {
                UserDialogs.Instance.ShowLoading("Cargando...");
                string[] paises = cbxPaises.Items[cbxPaises.SelectedIndex].ToString().Split(';');
                string[] empresas = cbxEmpresas.Items[cbxEmpresas.SelectedIndex].ToString().Split(';');
                string[] planteles = cbxPlantel.Items[cbxPlantel.SelectedIndex].ToString().Split(';');
                App.pai_id = Convert.ToInt32(paises[0]);
                App.emp_id = Convert.ToInt32(empresas[0]);
                App.emp_nombre_corto = empresas[1].Trim();

                if(App.pla_id != Convert.ToInt32( planteles[0]))
                {

                    App.pla_id = Convert.ToInt32(planteles[0]);
                    App.pla_descripcion = planteles[1].Trim();

                    Uri RequestUri = new Uri(App.url_api + "UsuarioEmpresa/" + App.pai_id + ";" +App.emp_id + ";"+ App.usu_id + ";" + App.pla_id);
                    var client = new HttpClient();
                    var response = await client.PutAsync(RequestUri, null);
                    if (response.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        
                    }
                    else
                    {
                        UserDialogs.Instance.Toast(response.RequestMessage.ToString());
                    }    
                }
                await Navigation.PushAsync(new Principal(), false);
                UserDialogs.Instance.HideLoading();
            }
            catch(Exception ex)
            {
                UserDialogs.Instance.HideLoading();
                UserDialogs.Instance.Toast(ex.Message.ToString());
            }
            
        }
        protected async void cargarPaises()
        {
            UserDialogs.Instance.ShowLoading("Cargando Paises...");
            var request = new HttpRequestMessage();
            request.RequestUri = new Uri(App.url_api + "paises/");
            request.Method = HttpMethod.Get;
            request.Headers.Add("accept", "application/json");
            var client2 = new HttpClient();
            HttpResponseMessage response2 = await client2.SendAsync(request);
            if (response2.StatusCode == System.Net.HttpStatusCode.OK)
            {

                string content = await response2.Content.ReadAsStringAsync();
                var resultado = JsonConvert.DeserializeObject<List<Paises>>(content);
                cbxPaises.ItemsSource = resultado;
                cbxPaises.SelectedIndex = 0;

               

               
            }
            UserDialogs.Instance.HideLoading();

        }
        private async void cargarPlantelUsuario(int p_pai_id, int p_emp_id)
        {
            try
            {
                //UserDialogs.Instance.ShowLoading("Cargando Plantel...");
                var request = new HttpRequestMessage();
                request.RequestUri = new Uri(App.url_api + "UsuarioEmpresa/" + p_pai_id + ";" + p_emp_id + ";" + App.usu_id);
                request.Method = HttpMethod.Get;
                request.Headers.Add("accept", "application/json");
                var client = new HttpClient();
                HttpResponseMessage response = await client.SendAsync(request);
                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {

                    string content = await response.Content.ReadAsStringAsync();
                    var resultado = JsonConvert.DeserializeObject<UsuarioEmpresa>(content);

                    App.pla_id = resultado.pla_id;
                    App.pla_descripcion = resultado.pla_descripcion;
                }
                UserDialogs.Instance.HideLoading();
                cargarPlanteles(p_pai_id, p_emp_id);
            }
            catch (Exception ex)
            {
                UserDialogs.Instance.HideLoading();
                UserDialogs.Instance.Toast(ex.Message.ToString());
            }
        }
        protected async void cargarPlanteles(int p_pai_id, int p_emp_id)
        {
            UserDialogs.Instance.ShowLoading("Cargando Planteles...");
            var request = new HttpRequestMessage();
            request.RequestUri = new Uri(App.url_api + "Planteles/" + p_pai_id + ";" + p_emp_id);
            request.Method = HttpMethod.Get;
            request.Headers.Add("accept", "application/json");
            var client = new HttpClient();
            HttpResponseMessage response = await client.SendAsync(request);
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {

                string content = await response.Content.ReadAsStringAsync();
                var resultado = JsonConvert.DeserializeObject<List<Planteles>>(content);
                cbxPlantel.ItemsSource = resultado;

                for (int x = 0; x < cbxPlantel.Items.Count; x++)
                {
                    if (cbxPlantel.Items[x].ToString().Trim() == Convert.ToString(App.pla_id) + "; " + App.pla_descripcion)
                    {
                        cbxPlantel.SelectedIndex = x;
                    }
                }
            }
            UserDialogs.Instance.HideLoading();
        }
        private void cbxEmpresas_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] paises;
            string[] empresas;
            int pai_id;
            int emp_id;

            paises = cbxPaises.Items[cbxPaises.SelectedIndex].ToString().Split(';');
            pai_id = Convert.ToInt32(paises[0]);
            empresas = cbxEmpresas.Items[cbxEmpresas.SelectedIndex].ToString().Split(';');
            emp_id = Convert.ToInt32(empresas[0]);

            cargarPlantelUsuario(pai_id, emp_id);
        }
        private  void cbxPaises_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] datos;
            int pai_id;
           // emp_id = Convert.ToInt32(cbxPaises.Items[cbxPaises.SelectedIndex]);
            datos = cbxPaises.Items[cbxPaises.SelectedIndex].ToString().Split(';');
            pai_id = Convert.ToInt32( datos[0]);
            cargarEmpresas(pai_id, App.usu_id);
        }


        protected async void cargarEmpresas(int pai_id, int usu_id )
        {

            UserDialogs.Instance.ShowLoading("Cargando Empresas...");
            var request = new HttpRequestMessage();
            request.RequestUri = new Uri(App.url_api + "empresas/" + pai_id + ";" + usu_id);
            request.Method = HttpMethod.Get;
            request.Headers.Add("accept", "application/json");
            var client2 = new HttpClient();
            HttpResponseMessage response2 = await client2.SendAsync(request);
            if (response2.StatusCode == System.Net.HttpStatusCode.OK)
            {

                string content = await response2.Content.ReadAsStringAsync();
                var resultado = JsonConvert.DeserializeObject<List<Empresas>>(content);
                cbxEmpresas.ItemsSource = resultado;
            }
            UserDialogs.Instance.HideLoading();
        }
    }
}