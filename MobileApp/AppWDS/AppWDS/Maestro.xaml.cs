using Acr.UserDialogs;
using AppWDS.Modelos;
using AppWDS.Views;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppWDS
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Maestro : ContentPage
    {
        public Maestro()
        {
            InitializeComponent();
            lblNombre.Text = App.usu_nombre;
            cargarFotoPerfil();
        }

        private async void cargarFotoPerfil()
        {
            try
            {
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
            }
            catch (Exception ex)
            {
                UserDialogs.Instance.HideLoading();
                UserDialogs.Instance.Toast(ex.Message.ToString());
            }

        }

        [Obsolete]
        private async void btnAddNew_Clicked(object sender, EventArgs e)
        {
            UserDialogs.Instance.ShowLoading("Cargando...");
            App.MaestroD.IsPresented = false;
            await App.MaestroD.Detail.Navigation.PushAsync(new CrearOrden());
            UserDialogs.Instance.HideLoading();
        }

        private async void btnSalir_Clicked(object sender, EventArgs e)
        {
            var result = await DisplayAlert("Confirme operación", "¿Confirma que desea salir del sistema?", "Si", "No");
            if (result) {

                
                await Navigation.PushAsync(new MainPage(), false);
            }
        }

        [Obsolete]
        private async void btnAsignadas_Clicked(object sender, EventArgs e)
        {
         
            UserDialogs.Instance.ShowLoading("Cargando...");
            App.MaestroD.IsPresented = false;
            await App.MaestroD.Detail.Navigation.PushAsync(new MisAsignadas());
            UserDialogs.Instance.HideLoading();
           
        }

        private void btnAsignar_Clicked(object sender, EventArgs e)
        {

        }

        private void btnHistorial_Clicked(object sender, EventArgs e)
        {

        }
    }
}