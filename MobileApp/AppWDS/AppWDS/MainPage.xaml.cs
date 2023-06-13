using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using AppWDS.Modelos;
using System.Net.Http;
using Newtonsoft.Json;
using Acr.UserDialogs;
using AppWDS.Views;
namespace AppWDS
{
    public partial class MainPage : ContentPage
    {
        [Obsolete]
        public MainPage()
        {
            InitializeComponent();
            if (App.usu_nombre == "")
            {
                if (App.emp_nombre_corto == "")
                {
                    Navigation.PushAsync(new SelecionePaisEmpresa());
                }
                else
                {
                    Navigation.PushAsync(new Principal());
                }
            }
        }
        private async void btnIngresar_Clicked(object sender, EventArgs e)
        {
            if (UsuarioTxt.Text == "")
            {
                UserDialogs.Instance.Toast("Debe ingresar su usuario");
                UsuarioTxt.Focus();
            }else if(ContraseñaTxt.Text == "")
            {
                UserDialogs.Instance.Toast("Debe ingresar su contraseña");
                ContraseñaTxt.Focus();
            }
            else
            {
                UserDialogs.Instance.ShowLoading("Validando acceso...");
                Login log = new Login
                {
                    usuario = UsuarioTxt.Text,
                    contraseña = ContraseñaTxt.Text
                };
                try
                {
                    Uri RequestUri = new Uri(App.url_api + "Login/");
                    var client = new HttpClient();
                    var json = JsonConvert.SerializeObject(log);
                    var contentJson = new StringContent(json, Encoding.UTF8, "application/json");
                    var response = await client.PostAsync(RequestUri, contentJson);


                    if (response.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        var request = new HttpRequestMessage();
                        request.RequestUri = new Uri(App.url_api + "Login/" + log.usuario.Trim() + ";" + log.contraseña.Trim());
                        request.Method = HttpMethod.Get;
                        request.Headers.Add("accept", "application/json");
                        var client2 = new HttpClient();
                        HttpResponseMessage response2 = await client2.SendAsync(request);
                        if (response2.StatusCode == System.Net.HttpStatusCode.OK)
                        {

                            string content = await response2.Content.ReadAsStringAsync();
                            var resultado = JsonConvert.DeserializeObject<Usuarios>(content);
                            //foreach (var item in resultado.) {
                            App.usu_nombre = resultado.usu_nombres;
                            App.usu_nombre_completo = resultado.usu_nombres + " " + resultado.usu_apellidos;
                            App.usu_correo = resultado.usu_correo;
                            App.usu_id = resultado.usu_id;
                            App.usu_id_nomina = resultado.usu_id_nomina;
                            App.es_mecanico = resultado.es_mecanico;

                            //}
                        }
                        cargarFotoPerfil();
                        cargarMenuAsigancion(App.usu_id, "autorizacionPrecio");
                        //cargarPlantel();
                        await Navigation.PushAsync(new SelecionePaisEmpresa(), false);
                        UserDialogs.Instance.HideLoading();
                    }
                    else
                    {
                        UserDialogs.Instance.HideLoading();
                        await DisplayAlert("Error en login", "Usuario o contraseña incorrecta", "Ok");
                    }
                }
                catch (Exception ex)
                {
                    UserDialogs.Instance.HideLoading();
                    await DisplayAlert("Error", ex.ToString(), "Ok");
                }
            }
        }
        private async void cargarMenuAsigancion(int usu_id,string funcion)
        {
            try
            {
                var request = new HttpRequestMessage();
                request.RequestUri = new Uri(App.url_api + "menuAsignaciones/" + usu_id + ";" + funcion);
                request.Method = HttpMethod.Get;
                request.Headers.Add("accept", "application/json");
                var cliente = new HttpClient();
                HttpResponseMessage response = await cliente.SendAsync(request);
                string contenido = await response.Content.ReadAsStringAsync();
                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    var resultado = JsonConvert.DeserializeObject<menuAsignaciones>(contenido);
                    if (resultado.usu_id  != 0)
                    {
                        App.autoriza_precios = true;
                        App.autoriza_precios_delete = resultado.asi_borrar;
                        App.autoriza_precios_insert = resultado.asi_insertar;
                        App.autoriza_precios_update = resultado.asi_modificar;
                    }
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
                await DisplayAlert("Error", ex.Message, "Ok");
                
            }
        }
        private async void cargarFotoPerfil()
        {
            try
            {
                UserDialogs.Instance.ShowLoading("Cargando Foto Perfil...");
                var request3 = new HttpRequestMessage();
                request3.RequestUri = new Uri(App.url_api + "Nomina/" + App.usu_id_nomina);
                request3.Method = HttpMethod.Get;
                request3.Headers.Add("accept", "application/json");
                var client3 = new HttpClient();
                HttpResponseMessage response3 = await client3.SendAsync(request3);
                if (response3.StatusCode == System.Net.HttpStatusCode.OK)
                {

                    string content = await response3.Content.ReadAsStringAsync();
                    var resultado = JsonConvert.DeserializeObject<Nomina>(content);

                   App.usu_fotografia = resultado.usu_nomina_fotografia;

                }
                UserDialogs.Instance.HideLoading();
            }
            catch (Exception ex)
            {
                UserDialogs.Instance.HideLoading();
              await  DisplayAlert("Error",  ex.Message.ToString(), "Ok");
                //UserDialogs.Instance.Toast(ex.Message.ToString());
            }
        }
        protected override bool OnBackButtonPressed()
        {
            return true;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new RecuperarContrasena());
        }
    }
}
