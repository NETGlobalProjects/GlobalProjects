using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using AppWDS.Modelos;
using Xamarin.Forms.Platform.Android;
using Acr.UserDialogs;

namespace AppWDS.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CrearOrden : ContentPage
    {
        public CrearOrden()
        {
            InitializeComponent();
            cargarAreas();
            cargarPrioridades();
            cargarTiposOrden();
            cargarCentrosAtencion();

        }
        protected async void cargarAreas()
        {
            try {
                UserDialogs.Instance.ShowLoading("Cargando Areas...");
                var request = new HttpRequestMessage();
                request.RequestUri = new Uri(App.url_api + "Areas/" + App.pai_id + ";" + App.emp_id + ";" + App.pla_id);
                request.Method = HttpMethod.Get;
                request.Headers.Add("accept", "application/json");
                var client2 = new HttpClient();
                HttpResponseMessage response2 = await client2.SendAsync(request);
                if (response2.StatusCode == System.Net.HttpStatusCode.OK)
                {

                    string content = await response2.Content.ReadAsStringAsync();
                    var resultado = JsonConvert.DeserializeObject<List<Areas>>(content);
                    cbxAreas.ItemsSource = resultado;
                }
                UserDialogs.Instance.HideLoading();
            }
            catch(Exception ex)
            {
                UserDialogs.Instance.HideLoading();
                UserDialogs.Instance.Toast("Error al cargar areas");
            }
        }

        private async void cbxAreas_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string[] datos;
                datos = cbxAreas.Items[cbxAreas.SelectedIndex].ToString().Split(';');

                int are_id = Convert.ToInt32(datos[0]);
                cargarSubAreas(are_id);
            }
            catch(Exception ex)
            {
                UserDialogs.Instance.Toast("Error al cargar sub areas");
            }
           
        }

        protected async void cargarSubAreas(int are_id)
        {
            try
            {
                UserDialogs.Instance.ShowLoading("Cargando Sub Areas...");
                var request = new HttpRequestMessage();
                request.RequestUri = new Uri(App.url_api + "subAreas/" + App.pai_id + ";" + App.emp_id + ";" + are_id + ";"+ App.pla_id);
                request.Method = HttpMethod.Get;
                request.Headers.Add("accept", "application/json");
                var client2 = new HttpClient();
                HttpResponseMessage response2 = await client2.SendAsync(request);
                if (response2.StatusCode == System.Net.HttpStatusCode.OK)
                {

                    string content = await response2.Content.ReadAsStringAsync();
                    var resultado = JsonConvert.DeserializeObject<List<SubAreas>>(content);
                    cbxSubAreas.ItemsSource = resultado;
                }
                UserDialogs.Instance.HideLoading();
            }catch(Exception ex)
            {
                UserDialogs.Instance.HideLoading();
                UserDialogs.Instance.Toast(ex.Message.ToString());
            }
            
        }

        protected async void cargarMaquinas(int are_id, int sba_id)
        {
            UserDialogs.Instance.ShowLoading("Cargando Máquinas...");
            var request = new HttpRequestMessage();
            request.RequestUri = new Uri(App.url_api + "maquinas/" + App.pai_id + ";" + App.emp_id + ";" + are_id + ";" + sba_id + ";" + App.pla_id);
            request.Method = HttpMethod.Get;
            request.Headers.Add("accept", "application/json");
            var client2 = new HttpClient();
            HttpResponseMessage response2 = await client2.SendAsync(request);
            if (response2.StatusCode == System.Net.HttpStatusCode.OK)
            {

                string content = await response2.Content.ReadAsStringAsync();
                var resultado = JsonConvert.DeserializeObject<List<Maquinas>>(content);
                cbxMaquinas.ItemsSource = resultado;
            }
            UserDialogs.Instance.HideLoading();
        }

        private void cbxSubAreas_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string[] areas = cbxAreas.Items[cbxAreas.SelectedIndex].ToString().Split(';');
                string[] sub_areas = cbxSubAreas.Items[cbxSubAreas.SelectedIndex].ToString().Split(';');
                int are_id = Convert.ToInt32(areas[0]);
                int sba_id = Convert.ToInt32(sub_areas[0]);
                cargarMaquinas(are_id, sba_id);
            }
            catch(Exception ex)
            {
                UserDialogs.Instance.Toast(ex.Message.ToString());
            }
            
        }

        protected async void cargarPrioridades()
        {
            UserDialogs.Instance.ShowLoading("Cargando Prioridades...");
            var request = new HttpRequestMessage();
            request.RequestUri = new Uri(App.url_api + "prioridadesOrden/");
            request.Method = HttpMethod.Get;
            request.Headers.Add("accept", "application/json");
            var client2 = new HttpClient();
            HttpResponseMessage response2 = await client2.SendAsync(request);
            if (response2.StatusCode == System.Net.HttpStatusCode.OK)
            {

                string content = await response2.Content.ReadAsStringAsync();
                var resultado = JsonConvert.DeserializeObject<List<Prioridades>>(content);
                cbxProridad.ItemsSource = resultado;
            }
            UserDialogs.Instance.HideLoading();
        }

        protected async void cargarTiposOrden()
        {
            UserDialogs.Instance.ShowLoading("Cargando Tipos de Ordenes...");
            var request = new HttpRequestMessage();
            request.RequestUri = new Uri(App.url_api + "tiposOrdenes/");
            request.Method = HttpMethod.Get;
            request.Headers.Add("accept", "application/json");
            var client2 = new HttpClient();
            HttpResponseMessage response2 = await client2.SendAsync(request);
            if (response2.StatusCode == System.Net.HttpStatusCode.OK)
            {

                string content = await response2.Content.ReadAsStringAsync();
                var resultado = JsonConvert.DeserializeObject<List<TiposOrden>>(content);
                cbxTipoOrden.ItemsSource = resultado;
            }
            UserDialogs.Instance.HideLoading();
        }


        protected async void cargarCentrosAtencion()
        {
            UserDialogs.Instance.ShowLoading("Cargando Centros de atención...");
            var request = new HttpRequestMessage();
            request.RequestUri = new Uri(App.url_api + "centrosAtencion/" + App.pai_id + ";" + App.emp_id);
            request.Method = HttpMethod.Get;
            request.Headers.Add("accept", "application/json");
            var client2 = new HttpClient();
            HttpResponseMessage response2 = await client2.SendAsync(request);
            if (response2.StatusCode == System.Net.HttpStatusCode.OK)
            {

                string content = await response2.Content.ReadAsStringAsync();
                var resultado = JsonConvert.DeserializeObject<List<CentrosAtencion>>(content);
                cbxCentroAtencion.ItemsSource = resultado;
            }
            UserDialogs.Instance.HideLoading();
        }
       

        private async void ImageButton_Clicked(object sender, EventArgs e)
        {
            try
            {
               
                if (this.cbxAreas.SelectedIndex < 0)
                {
                    UserDialogs.Instance.Toast("Debe seleccionar el área");
                }else if(this.cbxSubAreas.SelectedIndex <0)
                {
                    UserDialogs.Instance.Toast("Debe seleccionar la sub área");
                }
                else if (this.cbxTipoOrden.SelectedIndex < 0)
                {
                    UserDialogs.Instance.Toast("Debe seleccionar el tipo de orden");
                }
                else if (this.cbxProridad.SelectedIndex < 0)
                {
                    UserDialogs.Instance.Toast("Debe seleccionar la prioridad");
                }
                else if (this.cbxCentroAtencion.SelectedIndex < 0)
                {
                    UserDialogs.Instance.Toast("Debe seleccionar el centro de atención");
                }
                else if (this.txtComentarios.Text == "")
                {
                    UserDialogs.Instance.Toast("Debe ingresar un comentario a la orden");
                }
                else
                {
                    int Correlativo = 0;
                    UserDialogs.Instance.ShowLoading("Obteniendo Corr. Doc....");
                    var request = new HttpRequestMessage();
                    request.RequestUri = new Uri(App.url_api + "corrDocumentos/" + App.pai_id + ";" + App.emp_id + ";OM");
                    request.Method = HttpMethod.Get;
                    request.Headers.Add("accept", "application/json");
                    var client2 = new HttpClient();
                    HttpResponseMessage response2 = await client2.SendAsync(request);
                    if (response2.StatusCode == System.Net.HttpStatusCode.OK)
                    {

                        string content = await response2.Content.ReadAsStringAsync();
                        var resultado = JsonConvert.DeserializeObject<corrDocumentos>(content);
                        Correlativo = resultado.doc_correlativo;
                    }

                    UserDialogs.Instance.ShowLoading("Creando Orden....");
                    DateTime fecha;

                    fecha = DateTime.Now;

                    if (Correlativo > 0)
                    {
                        int tio_id;
                        int are_id;
                        int sba_id;
                        int pri_id;
                        string maq_id;
                        int cda_id;

                        string[] tipo_orden = cbxTipoOrden.Items[cbxTipoOrden.SelectedIndex].ToString().Split(';');
                        string[] area = cbxAreas.Items[cbxAreas.SelectedIndex].ToString().Split(';');
                        string[] sub_area = cbxSubAreas.Items[cbxSubAreas.SelectedIndex].ToString().Split(';');
                        string[] prioridad = cbxProridad.Items[cbxProridad.SelectedIndex].ToString().Split(';');
                        if (cbxMaquinas.SelectedIndex < 0)
                        {
                            maq_id = null;
                        }
                        else
                        {
                            string[] maquina = cbxMaquinas.Items[cbxMaquinas.SelectedIndex].ToString().Split(';');
                            maq_id = maquina[0];
                        }
                        string[] centros_atencion = cbxCentroAtencion.Items[cbxCentroAtencion.SelectedIndex].ToString().Split(';');
                        tio_id = Convert.ToInt32(tipo_orden[0]);
                        are_id = Convert.ToInt32(area[0]);
                        sba_id = Convert.ToInt32(sub_area[0]);
                        pri_id = Convert.ToInt32(prioridad[0]);
                        cda_id = Convert.ToInt32(centros_atencion[0]);
                     
                        OrdenManttoEnc om = new OrdenManttoEnc
                        {
                            pai_id = App.pai_id,
                            emp_id = App.emp_id,
                            ord_id = Correlativo,
                            tio_id = tio_id,
                            pla_id = App.pla_id,
                            are_id = are_id,
                            sba_id = sba_id,
                            pri_id = pri_id,
                            maq_id = maq_id,
                            mec_id_responsable = null,
                            oes_id = 0,
                            usu_id_crea = App.usu_id,
                            usu_id_modifica = null,
                            ord_fecha_hora_creacion = fecha,
                            ord_fecha_hora_modificacion = null,
                            ord_fecha_programado = null,
                            ord_fecha_hora_inicio = null,
                            ord_fecha_hora_fin = null,
                            ord_descripcion = txtComentarios.Text,
                            ord_horas_hombre_estimada = 0,
                            ord_fecha_hora_cierre_orden = 0,
                            ord_calificacion = null,
                            ord_comentarios_cierre = null,
                            ord_id_padre = null,
                            ord_descripcion_falla = null,
                            ord_causa_falla = null,
                            ord_accion_correctiva = null,
                            ord_fecha_hora_peticion_materiales = null,
                            ord_fecha_hora_entrega_materiales = null,
                            cda_id = cda_id,
                            ord_comentarios_mecanico = null

                        };

                        Uri RequestUri = new Uri(App.url_api + "OrdenManttoEnc/");
                        var client = new HttpClient();
                        var json = JsonConvert.SerializeObject(om);
                        var contentJson = new StringContent(json, Encoding.UTF8, "application/json");
                        var response = await client.PostAsync(RequestUri, contentJson);

                        if (response.StatusCode == System.Net.HttpStatusCode.OK)
                        {
                            UserDialogs.Instance.HideLoading();
                            await DisplayAlert("Exito", "Orden de mantenimiento creada correctamente, correlativo asignado: " + Correlativo, "Ok");
                            await Navigation.PopAsync(false);
                        }
                        else
                        {
                            UserDialogs.Instance.HideLoading();
                            await DisplayAlert("Error al crear orden", "Se produjo un error al crear la orden de mantenimiento, intente nuevamente y si el problema persiste, contacte al administrador del sistema", "Ok");
                        }
                    }
                }
            }
            catch (Exception ex) {
                UserDialogs.Instance.HideLoading();
                await DisplayAlert("Error al guardar", ex.Message.ToString(), "Ok");
            }
        }

        protected override bool OnBackButtonPressed()
        {
            return true;
        }

    }
}