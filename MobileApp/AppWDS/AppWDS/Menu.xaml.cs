using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using AppWDS.Views;
using Acr.UserDialogs;
using System.Net.Http;
using AppWDS.Modelos;
using Newtonsoft.Json;

namespace AppWDS
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Menu : ContentPage
    {
        public Menu()
        {
            InitializeComponent();
            lblBienvenido.Text = App.usu_nombre;
            lblEmpresa.Text = App.emp_nombre_corto;
            cargarFotoPerfil();
            actualizarTablero();
        }

        private async void btnCrearOrden_Clicked(object sender, EventArgs e)
        {
            UserDialogs.Instance.ShowLoading("Cargando...");
            await Navigation.PushAsync(new CrearOrden());
            UserDialogs.Instance.HideLoading();
        }
        private async void actualizarTablero()
        {
            try
            {
                UserDialogs.Instance.ShowLoading("Cargando Tablero...");
                var request = new HttpRequestMessage();
                request.RequestUri = new Uri(App.url_api + "Tablero/" + App.usu_id);
                request.Method = HttpMethod.Get;
                request.Headers.Add("accept", "application/json");
                var client2 = new HttpClient();
                HttpResponseMessage response2 = await client2.SendAsync(request);
                if (response2.StatusCode == System.Net.HttpStatusCode.OK)
                {

                    string content = await response2.Content.ReadAsStringAsync();
                    var resultado = JsonConvert.DeserializeObject<Tablero>(content);

                    lblOrdenesEjecusion.Text = resultado.t_ord_ejecusion.ToString();
                    lblCreadasHoy.Text = resultado.t_creadas_hoy.ToString();
                    lblCreadasHoyTotal.Text = resultado.t_creadas_anio.ToString();
                    lblAsingadasHoy.Text = resultado.t_asignadas_hoy.ToString();
                    lblAsingadasHoyTotal.Text = resultado.t_asingadas_anio.ToString();
                    lblAsingarHoy.Text = resultado.t_asignar_hoy.ToString();
                    lblAsingarHoyTotal.Text = resultado.t_asignar_anio.ToString();
                    lblHistorialHoy.Text = resultado.t_historial_hoy.ToString();
                    lblHistorialHoyTotal.Text = resultado.t_historial_anio.ToString();

                }
                UserDialogs.Instance.HideLoading();
            }
            catch(Exception ex)
            {
                UserDialogs.Instance.HideLoading();
                UserDialogs.Instance.Toast(ex.Message.ToString());
            }

           
        }

        private async void imgBtnSalir_Clicked(object sender, EventArgs e)
        {
            var result = await DisplayAlert("Salir", "¿Confirma que desar salir del sistema?", "Yes", "No");
            if (result)
            {
                await Navigation.PushAsync(new MainPage(), true);
            }
        }

        private async void cargarFotoPerfil()
        {
            try {
                UserDialogs.Instance.ShowLoading("Cargando Foto Perfil...");
                var request = new HttpRequestMessage();
                request.RequestUri = new Uri(App.url_api + "Nomina/" + App.usu_id_nomina);
                request.Method = HttpMethod.Get;
                request.Headers.Add("accept", "application/json");
                var client2 = new HttpClient();
                HttpResponseMessage response2 = await client2.SendAsync(request);
                if (response2.StatusCode == System.Net.HttpStatusCode.OK)
                {

                    string content = await response2.Content.ReadAsStringAsync();
                    var resultado = JsonConvert.DeserializeObject<Nomina>(content);

                    imgBtnFotoPerfil.Source = resultado.usu_nomina_fotografia;

                }
                UserDialogs.Instance.HideLoading();
            } catch(Exception ex)
            {
                UserDialogs.Instance.HideLoading();
                UserDialogs.Instance.Toast(ex.Message.ToString());
            }
            
        }
    }
}