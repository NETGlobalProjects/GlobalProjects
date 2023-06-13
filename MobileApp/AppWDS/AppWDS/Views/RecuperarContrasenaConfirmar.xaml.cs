using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Acr.UserDialogs;
using AppWDS.Modelos;
using Newtonsoft.Json;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppWDS.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RecuperarContrasenaConfirmar : ContentPage
    {
        string _usu_username;
        string _usu_correo;
        public RecuperarContrasenaConfirmar(string p_usu_username, string p_usu_correo)
        {
            InitializeComponent();
            _usu_username = p_usu_username;
            _usu_correo = p_usu_correo;
        }

        private async void btnCambiar_Clicked(object sender, EventArgs e)
        {
            if (contrasenaTxt.Text.Trim() == "")
            {
                UserDialogs.Instance.Toast("Debe ingresar la nueva contraseña");
                contrasenaTxt.Focus();
            }
            else if (repContrasenaTxt.Text.Trim() == "")
            {
                UserDialogs.Instance.Toast("Debe repertir nueva contraseña");
                repContrasenaTxt.Focus();
            } else if (contrasenaTxt.Text.Trim() != repContrasenaTxt.Text.Trim()) 
            {
                UserDialogs.Instance.Toast("Las contraseñas no coinciden, favor verificar");
            }
            else
            {
               
                UserDialogs.Instance.ShowLoading("Cambiando contraseña...");
                CambiarContrasena nc = new CambiarContrasena { usu_username = _usu_username, usu_correo = _usu_correo, usu_nuevacontrasena = contrasenaTxt.Text };
                Uri RequestUri = new Uri(App.url_api + "CambiarContrasena");
                var client = new HttpClient();
                var json = JsonConvert.SerializeObject(nc);
                var contentJson = new StringContent(json, Encoding.UTF8, "application/json");
                var response = await client.PostAsync(RequestUri, contentJson);
                string content = await response.Content.ReadAsStringAsync();
                UserDialogs.Instance.HideLoading();
                if (content.Contains("Error:"))
                {
                    await DisplayAlert("Error", content, "Ok");
                }
                else
                {
                    UserDialogs.Instance.Toast(content);
                    App.navegar = "Login";
                    await Navigation.PopAsync(true);
                }
            }
        }
       
    }
}