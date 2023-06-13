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
    public partial class LogOut : ContentPage
    {
        public LogOut()
        {
            InitializeComponent();
            lblEmpresa.Text = App.emp_nombre_corto;
            lblNombre.Text = App.usu_nombre;
            if (App.usu_fotografia == null || App.usu_fotografia == "")
            {
                imgBtnFotoPerfil.Source = "sin_perfil";
            }
            else
            {
                imgBtnFotoPerfil.Source = App.usu_fotografia;
            }
            //cargarFotoPerfil();
        }

        [Obsolete]
        private async void btnNoSalir_Clicked(object sender, EventArgs e)
        {
          
            await Navigation.PopAsync();

       

        }

        //private async void cargarFotoPerfil()
        //{
        //    try
        //    {
        //        UserDialogs.Instance.ShowLoading("Cargando Foto Perfil...");
        //        var request = new HttpRequestMessage();
        //        request.RequestUri = new Uri(App.url_api + "Nomina/" + App.usu_id_nomina);
        //        request.Method = HttpMethod.Get;
        //        request.Headers.Add("accept", "application/json");
        //        var client2 = new HttpClient();
        //        HttpResponseMessage response2 = await client2.SendAsync(request);
        //        if (response2.StatusCode == System.Net.HttpStatusCode.OK)
        //        {

        //            string content = await response2.Content.ReadAsStringAsync();
        //            var resultado = JsonConvert.DeserializeObject<Nomina>(content);

        //            imgBtnFotoPerfil.Source = resultado.usu_nomina_fotografia;

        //        }
        //        UserDialogs.Instance.HideLoading();
        //    }
        //    catch (Exception ex)
        //    {
        //        UserDialogs.Instance.HideLoading();
        //        UserDialogs.Instance.Toast(ex.Message.ToString());
        //    }

        //}

        [Obsolete]
        private async void btnSiSalir_Clicked(object sender, EventArgs e)
        {
            UserDialogs.Instance.ShowLoading("Limpiando valores...");
            App.emp_nombre_corto = "";
            App.emp_nombre_largo = "";
            App.emp_id = 0;
            App.usu_correo = "";
            App.usu_id = 0;
            App.usu_id_nomina = "";
            App.usu_nombre = "";
            App.usu_nombre_completo = "";
            App.es_mecanico = false;
            UserDialogs.Instance.ShowLoading("Saliendo...");
            await Navigation.PushAsync(new MainPage());
            UserDialogs.Instance.HideLoading();

        }
    }
}