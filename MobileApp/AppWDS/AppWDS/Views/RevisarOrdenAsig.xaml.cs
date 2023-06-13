
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
    public partial class RevisarOrdenAsig : ContentPage
    {
        public static int no_partes { get; set; }
        int ord_id;
        //int no_partes;
        public RevisarOrdenAsig(int p_ord_id, string are_descripcion, string sba_descripcion, string maq_id, string maq_nombre, string ord_descripcion, string oes_descripcion,  string estado_color, string tio_descripcion, string pri_descripcion, string color_prioridad, double? avance, int? no_repuestos,int? no_mecanicos, int p_no_partes, string p_comentario_mec)
        {
            InitializeComponent();
            ord_id = p_ord_id;
            no_partes = p_no_partes;
            this.Title = "Orden #" + Convert.ToString(ord_id);
            lblMaquina.Text = maq_id + " - "  + maq_nombre;
            lblArea.Text = are_descripcion;
            lblSubArea.Text = sba_descripcion;
            lblTipoOrden.Text = tio_descripcion;
            lblPrioridad.Text = pri_descripcion;
            fPrioridad.BackgroundColor = Color.FromHex(color_prioridad);
            lblEstado.Text = oes_descripcion;
            fEstado.BackgroundColor = Color.FromHex(estado_color);
            lblDescripcion.Text = ord_descripcion;
            if (oes_descripcion.Contains("Finaliz"))
            {
                txtComentariosMecanico.IsEnabled = false;
            }
            else
            {
                txtComentariosMecanico.IsEnabled = true;
            }
            txtComentariosMecanico.Text = p_comentario_mec;
            if (avance > 0 && avance <= 0.30) {
                pbAvance.ProgressColor = Color.FromHex("#EABE0E") ;
            }
            else if(avance > 0.30 && avance <= 0.60) {
                pbAvance.ProgressColor = Color.FromHex("#96EA0E");
            }
            else if (avance > 0.60 && avance <= 0.85)
            {
                pbAvance.ProgressColor = Color.FromHex("#68EA0E");
            }
            else if (avance > 0.85 )
            {
                pbAvance.ProgressColor = Color.FromHex("#2F6B06");
            }
            pbAvance.Progress = Convert.ToDouble(avance);
            lblAvance.Text = "Avance (" + Convert.ToString(avance * 100) + "%)";
            actualizarNoPartes();

        }
        protected void actualizarNoPartes()
        {
            lblNoRepuestos.Text = "No. Partes/Repuestos (" + Convert.ToString(no_partes) + ")";
        }
        
        protected override void OnAppearing()
        {
            base.OnAppearing();
            actualizarNoPartes();
            actualizarEstadoOrdenBtns();
            actualizarEstadoOrdenLabel();
        }

        private async void btnAñadirMateriales_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PartesOrden(ord_id, no_partes));
        }

        private async void imgBtnIniciar_Clicked(object sender, EventArgs e)
        {
            int oes_id = 0;
            var request2 = new HttpRequestMessage();
            request2.RequestUri = new Uri(App.url_api + "OrdenManttoEncEstado/" + App.pai_id + ";" + App.emp_id + ";" + ord_id);
            request2.Method = HttpMethod.Get;
            request2.Headers.Add("accept", "application/json");
            var cliente2 = new HttpClient();
            HttpResponseMessage response2 = await cliente2.SendAsync(request2);
            string contenido2 = await response2.Content.ReadAsStringAsync();
            if (response2.StatusCode == System.Net.HttpStatusCode.OK)
            {
                oes_id = Convert.ToInt32(contenido2);
            }
            else if (response2.StatusCode == System.Net.HttpStatusCode.NotFound)
            {
                UserDialogs.Instance.Toast(contenido2);
            }

            int estado_orden = oes_id;
            if (estado_orden < 4 | estado_orden == 7)
            {
                var result = await DisplayAlert("Confirme operación", "¿Confirma que desea iniciar la orden?", "Si", "No");
                if (result)
                {
                    string comentario_mec ="";
                    if (!string.IsNullOrEmpty(txtComentariosMecanico.Text))
                    {
                        foreach (char x in txtComentariosMecanico.Text.ToString())
                        {
                            if (x != '/' && x != '.')
                            {
                                comentario_mec += x;
                            }
                        }
                    }

                  
                    UserDialogs.Instance.ShowLoading("Iniciando Orden Mantto...");
                    Uri RequestUri = new Uri(App.url_api + "OrdenManttoEncEstado/" + App.pai_id + ";" + App.emp_id + ";" + ord_id + ";1;" + comentario_mec + ";" + App.usu_id);
                    var client = new HttpClient();
                    var response = await client.PostAsync(RequestUri, null);
                    if (response.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        actualizarEstadoOrdenBtns();
                        actualizarEstadoOrdenLabel();
                        UserDialogs.Instance.HideLoading();
                        UserDialogs.Instance.Toast("Se ha iniciado la orden exitosamente");
                    }
                    else
                    {
                        UserDialogs.Instance.HideLoading();
                        await DisplayAlert("Error al iniciar orden", response.RequestMessage.ToString(), "Ok");
                    }
                }
            }
            else
            {
                UserDialogs.Instance.Toast("La orden ha cambiado de estado, proceso no permitido");
                actualizarEstadoOrdenBtns();
                actualizarEstadoOrdenLabel();
            }
        }
       
        private async void imgBtnPausar_Clicked(object sender, EventArgs e)
        {
            int oes_id = 0;
            var request2 = new HttpRequestMessage();
            request2.RequestUri = new Uri(App.url_api + "OrdenManttoEncEstado/" + App.pai_id + ";" + App.emp_id + ";" + ord_id );
            request2.Method = HttpMethod.Get;
            request2.Headers.Add("accept", "application/json");
            var cliente2 = new HttpClient();
            HttpResponseMessage response2 = await cliente2.SendAsync(request2);
            string contenido2 = await response2.Content.ReadAsStringAsync();
            if (response2.StatusCode == System.Net.HttpStatusCode.OK)
            {
                oes_id = Convert.ToInt32(contenido2);
            }
            else if (response2.StatusCode == System.Net.HttpStatusCode.NotFound)
            {

                UserDialogs.Instance.Toast(contenido2);
            }

            int estado_orden = oes_id;
            if (estado_orden == 4)
            {
                var result = await DisplayAlert("Confirme operación", "¿Confirma que desea pausar la orden?", "Si", "No");
                if (result)
                {
                    string comentario_mec = "";
                    if (!string.IsNullOrEmpty(txtComentariosMecanico.Text))
                    {
                        foreach (char x in txtComentariosMecanico.Text.ToString())
                        {
                            if (x != '/' && x != '.')
                            {
                                comentario_mec += x;
                            }
                        }
                    }

                    UserDialogs.Instance.ShowLoading("Pausando Orden Mantto...");
                    Uri RequestUri = new Uri(App.url_api + "OrdenManttoEncEstado/" + App.pai_id + ";" + App.emp_id + ";" + ord_id + ";2;" + comentario_mec + ";" + App.usu_id);
                    var client = new HttpClient();
                    var response = await client.PostAsync(RequestUri, null);
                    if (response.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        actualizarEstadoOrdenBtns();
                        actualizarEstadoOrdenLabel();
                        UserDialogs.Instance.HideLoading();
                        UserDialogs.Instance.Toast("Se ha pausado la orden exitosamente");

                    }
                    else
                    {
                        UserDialogs.Instance.HideLoading();
                        await DisplayAlert("Error al pausar orden", response.RequestMessage.ToString(), "Ok");
                    }
                }
            }
            else
            {
                UserDialogs.Instance.Toast("La orden ha cambiado de estado, proceso no permitido");
                actualizarEstadoOrdenBtns();
                actualizarEstadoOrdenLabel();
            }
        }

        private async void imgBtnFinalizar_Clicked(object sender, EventArgs e)
        {

            int oes_id = 0;
            var request2 = new HttpRequestMessage();
            request2.RequestUri = new Uri(App.url_api + "OrdenManttoEncEstado/" + App.pai_id + ";" + App.emp_id + ";" + ord_id);
            request2.Method = HttpMethod.Get;
            request2.Headers.Add("accept", "application/json");
            var cliente2 = new HttpClient();
            HttpResponseMessage response2 = await cliente2.SendAsync(request2);
            string contenido2 = await response2.Content.ReadAsStringAsync();
            if (response2.StatusCode == System.Net.HttpStatusCode.OK)
            {
                oes_id = Convert.ToInt32(contenido2);
            }
            else if (response2.StatusCode == System.Net.HttpStatusCode.NotFound)
            {

                UserDialogs.Instance.Toast(contenido2);
            }

            int estado_orden = oes_id;
            if (estado_orden == 4 | estado_orden == 7)
            {

                var result = await DisplayAlert("Confirme operación", "¿Confirma que desea finalizar la orden?", "Si", "No");
                if (result)
                {
                    string comentario_mec = "";
                    if (!string.IsNullOrEmpty(txtComentariosMecanico.Text))
                    {
                        foreach (char x in txtComentariosMecanico.Text.ToString())
                        {
                            if (x != '/' && x != '.')
                            {
                                comentario_mec += x;
                            }
                        }
                    }

                    UserDialogs.Instance.ShowLoading("Finalizando Orden Mantto...");
                    Uri RequestUri = new Uri(App.url_api + "OrdenManttoEncEstado/" + App.pai_id + ";" + App.emp_id + ";" + ord_id + ";3;" + comentario_mec + ";" + App.usu_id);
                    var client = new HttpClient();
                    var response = await client.PostAsync(RequestUri, null);
                    if (response.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        actualizarEstadoOrdenBtns();
                        actualizarEstadoOrdenLabel();
                        UserDialogs.Instance.HideLoading();
                        txtComentariosMecanico.IsEnabled = false;
                        UserDialogs.Instance.Toast("Se ha finalizado la orden exitosamente");

                    }
                    else
                    {
                        UserDialogs.Instance.HideLoading();
                        await DisplayAlert("Error al finalizar orden", response.RequestMessage.ToString(), "Ok");
                    }
                }
            }
            else
            {
                UserDialogs.Instance.Toast("La orden ha cambiado de estado, proceso no permitido");
                actualizarEstadoOrdenBtns();
                actualizarEstadoOrdenLabel();
            }
        }
        private async void actualizarEstadoOrdenBtns()
        {
            int oes_id = 0;
            var request2 = new HttpRequestMessage();
            request2.RequestUri = new Uri(App.url_api + "OrdenManttoEncEstado/" + App.pai_id + ";" + App.emp_id + ";" + ord_id);
            request2.Method = HttpMethod.Get;
            request2.Headers.Add("accept", "application/json");
            var cliente2 = new HttpClient();
            HttpResponseMessage response2 = await cliente2.SendAsync(request2);
            string contenido2 = await response2.Content.ReadAsStringAsync();
            if (response2.StatusCode == System.Net.HttpStatusCode.OK)
            {
                oes_id = Convert.ToInt32(contenido2);
            }
            else if (response2.StatusCode == System.Net.HttpStatusCode.NotFound)
            {

                UserDialogs.Instance.Toast(contenido2);
            }

            int estado_orden = oes_id;
            if (estado_orden < 4 | estado_orden == 7)
            {
                imgBtnIniciar.IsEnabled = true;
                imgBtnPausar.IsEnabled = false;
                btnAñadirMateriales.IsEnabled = true;
            }
            else
            {
                imgBtnIniciar.IsEnabled = false;
            }

            if (estado_orden == 4)
            {
                imgBtnIniciar.IsEnabled = false;
                imgBtnPausar.IsEnabled = true;
                imgBtnFinalizar.IsEnabled = true;
                btnAñadirMateriales.IsEnabled = true;
            }
            if (estado_orden == 5)
            {
                imgBtnIniciar.IsEnabled = false;
                imgBtnPausar.IsEnabled = false;
                imgBtnFinalizar.IsEnabled = false;
                btnAñadirMateriales.IsEnabled = false;
            }
        }

        protected async void actualizarEstadoOrdenLabel()
        {

            int oes_id = 0;
            var request2 = new HttpRequestMessage();
            request2.RequestUri = new Uri(App.url_api + "OrdenManttoEncEstado/" + App.pai_id + ";" + App.emp_id + ";" + ord_id);
            request2.Method = HttpMethod.Get;
            request2.Headers.Add("accept", "application/json");
            var cliente2 = new HttpClient();
            HttpResponseMessage response2 = await cliente2.SendAsync(request2);
            string contenido2 = await response2.Content.ReadAsStringAsync();
            if (response2.StatusCode == System.Net.HttpStatusCode.OK)
            {
                oes_id = Convert.ToInt32(contenido2);
            }
            else if (response2.StatusCode == System.Net.HttpStatusCode.NotFound)
            {

                UserDialogs.Instance.Toast(contenido2);
            }


            var request = new HttpRequestMessage();
            request.RequestUri = new Uri(App.url_api + "estadosOrdenes/" + oes_id);
            request.Method = HttpMethod.Get;
            request.Headers.Add("accept", "application/json");
            var cliente = new HttpClient();
            HttpResponseMessage response = await cliente.SendAsync(request);
            string contenido = await response.Content.ReadAsStringAsync();
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                var resultado = JsonConvert.DeserializeObject<EstadosOrdenes>(contenido);

                lblEstado.Text = resultado.oes_descripcion;
                fEstado.BackgroundColor = Color.FromHex(resultado.estado_color);
            }
            else if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
            {
               
                UserDialogs.Instance.Toast(contenido);
            }



        } 
    }
}