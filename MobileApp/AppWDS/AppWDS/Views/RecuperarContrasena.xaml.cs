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
    public partial class RecuperarContrasena : ContentPage
    {
        string token;
        string estado_scp="PEN";
        bool respuesta = false;
        public RecuperarContrasena()
        {
            InitializeComponent();
        }

        private async void btnRecuperar_Clicked(object sender, EventArgs e)
        {
            if (UsuarioTxt.Text == "")
            {
                UserDialogs.Instance.Toast("Debe ingresar su usuario");
            }
            else
            {
                scp scp = new scp
                {
                    User_name = UsuarioTxt.Text,
                    Correo = CorreoTxt.Text
                };
                UserDialogs.Instance.ShowLoading("Enviando solicitud...");
                Uri RequestUri = new Uri(App.url_api + "scp");
                var client = new HttpClient();
                var json = JsonConvert.SerializeObject(scp);
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
                    token = content;

                    UserDialogs.Instance.ShowLoading("Esperando autorización, revise su correo...");
                    Device.StartTimer(TimeSpan.FromSeconds(5), () =>
                    {
                        consultarEstadoSolicitud();
                       if (estado_scp.Contains("APR"))
                        {
                            return false;
                        }
                        else
                        {
                            return true;
                        }
                       
                    });
                }

            }
        }
        private async void consultarEstadoSolicitud()
        {
            if (respuesta == false)
            {
                var request = new HttpRequestMessage();

                string tkn = "";
                foreach (char x in token)
                {
                    if (x != '"')
                    {
                        tkn += x;
                    }
                }

                request.RequestUri = new Uri(App.url_api + "scp/" + tkn);
                request.Method = HttpMethod.Get;
                request.Headers.Add("accept", "application/json");
                var client = new HttpClient();
                HttpResponseMessage response = await client.SendAsync(request);
                string content = await response.Content.ReadAsStringAsync();
                estado_scp = content;

                if (estado_scp.Contains("APR"))
                {
                    respuesta = true;
                    UserDialogs.Instance.HideLoading();
                    await Navigation.PushAsync(new RecuperarContrasenaConfirmar(UsuarioTxt.Text, CorreoTxt.Text));
                }
            }
            

        }
        private async void CorreoTxt_Unfocused(object sender, FocusEventArgs e)
        {
            if(CorreoTxt.Text!= "")
            {
                ValidarMail mail = new ValidarMail
                {
                    mail = this.CorreoTxt.Text
                };
                UserDialogs.Instance.ShowLoading("Verificando correo...");
                Uri RequestUri = new Uri(App.url_api + "ValidarMail");
                var client = new HttpClient();
                var json = JsonConvert.SerializeObject(mail);
                var contentJson = new StringContent(json, Encoding.UTF8, "application/json");
                var response = await client.PostAsync(RequestUri, contentJson);
                string content = await response.Content.ReadAsStringAsync();
                UserDialogs.Instance.HideLoading();
                if (content.Contains("Error"))
                {
                    await DisplayAlert("Error", content, "Ok");
                }
                else
                {
                    if(content.Contains( "OK"))
                    {
                        btnRecuperar.IsEnabled = true;
                    }
                    else
                    {
                        UserDialogs.Instance.Toast("El correo ingresado no tiene el formato correcto");
                        btnRecuperar.IsEnabled = false;
                    }
                }
                UserDialogs.Instance.HideLoading();
            }
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            if (App.navegar == "Login")
            {
                App.navegar = "";
                Navigation.PopAsync();
            }
        }


    }
}