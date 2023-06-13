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
    public partial class AñadirModificarMaterial : ContentPage
    {
        int ord_id;
        string inv_id;
        string inv_descripcion;
        string inv_descripcion_larga;
        string uni_descripcion;
        string accion;
        int dor_id_next;
        int no_partes;
        int dor_id;
        double? cantidad;
        public AñadirModificarMaterial(int p_ord_id, string p_inv_id, string p_inv_descripcion, string p_inv_descripcion_larga, string p_uni_descripcion, string p_accion, int p_no_partes, int p_dor_id, double? p_cantidad)
        {
            InitializeComponent();
            ord_id = p_ord_id;
            inv_id = p_inv_id;
            inv_descripcion = p_inv_descripcion;
            inv_descripcion_larga = p_inv_descripcion_larga;
            uni_descripcion = p_uni_descripcion;
            cantidad = p_cantidad;
            dor_id = p_dor_id;
            accion = p_accion;
            no_partes = p_no_partes;
            if (accion == "añadir")
            {
                this.Title = "Añadir Materiales";
                btnEliminar.IsEnabled = false;

            }
            else if (accion == "editar")
            {
                this.Title = "Modificar Materiales";
                btnEliminar.IsEnabled = true;
                txtCantidad.Text = Convert.ToString( cantidad);

            }

            lblSKU.Text = inv_id;
            lblDescripcion.Text = inv_descripcion;
            lblDescripcionLarga.Text = inv_descripcion_larga;
            lblUnidadMedida.Text = uni_descripcion;

        }

        private void btnDisminuir_Clicked(object sender, EventArgs e)
        {
            if (txtCantidad.Text != "")
            {
                int numericValue;
                bool isNumber = int.TryParse(txtCantidad.Text, out numericValue);
                if (isNumber)
                {
                    if (Convert.ToDouble(txtCantidad.Text) > 0)
                    {
                        txtCantidad.Text = Convert.ToString(Convert.ToDouble(txtCantidad.Text) - 1);
                    }
                    else
                    {
                        UserDialogs.Instance.Toast("La cantidad no puede ser menor a 0");
                    }
                }
            }
            else
            {
                UserDialogs.Instance.Toast("Debe ingresar una cantidad correcta");
            }
        }

        private void btnAumentar_Clicked(object sender, EventArgs e)
        {
            if (txtCantidad.Text != "")
            {
                int numericValue;
                bool isNumber = int.TryParse(txtCantidad.Text, out numericValue);
                if (isNumber)
                {
                    if (Convert.ToDouble(txtCantidad.Text) >= 0)
                    {
                        txtCantidad.Text = Convert.ToString(Convert.ToDouble(txtCantidad.Text) + 1);
                    }
                    else
                    {
                        UserDialogs.Instance.Toast("La cantidad no puede ser menor a 0");
                    }
                }
            }
            else
            {
                UserDialogs.Instance.Toast("Debe ingresar una cantidad correcta");
            }
        }

        private async void btnGuardar_Clicked(object sender, EventArgs e)
        {


            if (txtCantidad.Text != "")
            {
                int numericValue;
                bool isNumber = int.TryParse(txtCantidad.Text, out numericValue);
                if (isNumber)
                {
                    if (Convert.ToDouble(txtCantidad.Text) > 0)
                    {

                        if (accion == "añadir")
                        {
                            var request = new HttpRequestMessage();
                            request.RequestUri = new Uri(App.url_api + "OrdenManttoItemsCount/" + App.pai_id + ";" + App.emp_id + ";" + ord_id);
                            request.Method = HttpMethod.Get;
                            request.Headers.Add("accept", "application/json");
                            var cliente = new HttpClient();
                            HttpResponseMessage response = await cliente.SendAsync(request);
                            string contenido = await response.Content.ReadAsStringAsync();
                            if (response.StatusCode == System.Net.HttpStatusCode.OK)
                            {

                                dor_id_next = Convert.ToInt32(contenido);
                            }


                            OrdenManttoItems oi = new OrdenManttoItems()
                            {
                                pai_id = App.pai_id,
                                emp_id = App.emp_id,
                                ord_id = ord_id,
                                dor_id = dor_id_next + 1,
                                inv_id = lblSKU.Text,
                                dor_descripcion = lblDescripcion.Text,
                                dor_cantidad = Convert.ToDouble(txtCantidad.Text),
                                dor_unitario = 0,
                                dor_costo = 0,
                                dor_importe = 0,
                                usu_id_crea = App.usu_id,
                                usu_id_modifica = null,
                                dor_fecha_hora_creacion = DateTime.Now,
                                dor_fecha_hora_modificacion = null,
                                dor_tipo = null,
                                dor_estado = null,
                                dor_descripcion_larga = null

                            };


                            Uri RequestUri = new Uri(App.url_api + "OrdenManttoItems/");
                            var client = new HttpClient();
                            var json = JsonConvert.SerializeObject(oi);
                            var contentJson = new StringContent(json, Encoding.UTF8, "application/json");
                            var response2 = await client.PostAsync(RequestUri, contentJson);

                            if (response2.StatusCode == System.Net.HttpStatusCode.OK)
                            {
                                UserDialogs.Instance.HideLoading();
                                UserDialogs.Instance.Toast("Item añadido correctamente");
                                App.navegar = "PartesOrden";
                                PartesOrden.no_partes = no_partes + 1;
                                await Navigation.PopAsync();

                                //txtSKU.Text = "";
                                //txtDescripcion.Text = "";
                                //txtCantidad.Text = "1";
                                //existe_codigo = false;
                                //accion = "";
                                //no_partes += 1;
                                //actualizarNoPartes();
                                //cargarItemsOrden();
                            }
                            else
                            {
                                UserDialogs.Instance.HideLoading();
                                string resultado = await response2.Content.ReadAsStringAsync();
                                await DisplayAlert("Error al guardar item", resultado, "Ok");
                            }

                        }
                        else if (accion == "editar")
                        {

                            int dor_estado = 0;
                            var request2 = new HttpRequestMessage();
                            request2.RequestUri = new Uri(App.url_api + "OrdenManttoItemsEstado/" + App.pai_id + ";" + App.emp_id + ";" + ord_id + ";" + dor_id);
                            request2.Method = HttpMethod.Get;
                            request2.Headers.Add("accept", "application/json");
                            var cliente2 = new HttpClient();
                            HttpResponseMessage response2 = await cliente2.SendAsync(request2);
                            string contenido2 = await response2.Content.ReadAsStringAsync();
                            if (response2.StatusCode == System.Net.HttpStatusCode.OK)
                            {
                                dor_estado = Convert.ToInt32(contenido2);
                            }
                            else if (response2.StatusCode == System.Net.HttpStatusCode.NotFound)
                            {

                                UserDialogs.Instance.Toast(contenido2);
                            }

                            if(dor_estado == 0)
                            {

                                UserDialogs.Instance.ShowLoading("Modificando línea...");
                                Uri RequestUri = new Uri(App.url_api + "OrdenManttoItems/" + App.pai_id + ";" + App.emp_id + ";" + ord_id + ";" + dor_id + ";" + lblSKU.Text + ";" + txtCantidad.Text);
                                var client = new HttpClient();
                                var response = await client.PutAsync(RequestUri, null);
                                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                                {

                                    accion = "";

                                    await Navigation.PopAsync(true);

                                    UserDialogs.Instance.HideLoading();
                                    UserDialogs.Instance.Toast("Línea modificada correctamente");

                                }
                                else
                                {
                                    UserDialogs.Instance.HideLoading();
                                    await DisplayAlert("Error al modificar línea", response.RequestMessage.ToString(), "Ok");
                                }


                            }
                            else
                            {
                                UserDialogs.Instance.Toast("La línea ha cambiado de estado, edición no permitida");
                            }

                            
                        }

                    }

                }
                else
                {
                    UserDialogs.Instance.Toast("La cantidad no puede ser menor o igual a 0");
                }
            }
          

        }

        private async void btnEliminar_Clicked(object sender, EventArgs e)
        {
            int dor_estado = 0;
            var request2 = new HttpRequestMessage();
            request2.RequestUri = new Uri(App.url_api + "OrdenManttoItemsEstado/" + App.pai_id + ";" + App.emp_id + ";" + ord_id + ";" + dor_id);
            request2.Method = HttpMethod.Get;
            request2.Headers.Add("accept", "application/json");
            var cliente2 = new HttpClient();
            HttpResponseMessage response2 = await cliente2.SendAsync(request2);
            string contenido2 = await response2.Content.ReadAsStringAsync();
            if (response2.StatusCode == System.Net.HttpStatusCode.OK)
            {
                dor_estado = Convert.ToInt32(contenido2);
            }
            else if (response2.StatusCode == System.Net.HttpStatusCode.NotFound)
            {

                UserDialogs.Instance.Toast(contenido2);
            }

            if(dor_estado  == 0)
            {
                var result = await DisplayAlert("Confirme operación", "¿Confirma que desea eliminar el material: " + lblSKU.Text + " de la orden: " + ord_id + "?", "Si", "No");
                if (result)
                {
                    UserDialogs.Instance.ShowLoading("Borrando línea...");
                    Uri RequestUri = new Uri(App.url_api + "OrdenManttoItems/" + App.pai_id + ";" + App.emp_id + ";" + ord_id + ";" + dor_id);
                    var client = new HttpClient();
                    var response = await client.DeleteAsync(RequestUri);
                    if (response.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        UserDialogs.Instance.HideLoading();
                        UserDialogs.Instance.Toast("Línea eliminada correctamente");
                        PartesOrden.no_partes = no_partes - 1;
                        await Navigation.PopAsync(true);
                    }
                    else
                    {
                        UserDialogs.Instance.HideLoading();
                        await DisplayAlert("Error al borrar línea", response.RequestMessage.ToString(), "Ok");
                    }
                }
            }
            else
            {
                UserDialogs.Instance.Toast("La línea ha cambiado de estado, eliminación no permitida");
            }



           
        }
    }
            
        

}