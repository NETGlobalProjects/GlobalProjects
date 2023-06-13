using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Acr.UserDialogs;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppWDS.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class autorizacionPreciosDetalleXProd : ContentPage
	{
		string inv_id, cot_descripcion, cliente ;
		int cot_id, cot_correlativo, doc_decimales;
		double cot_precio_sugerido, cot_cantidad, cot_preciosiva, cot_preciociva;
		public autorizacionPreciosDetalleXProd(string _inv_id, string _cot_descripcion, string _cliente, int _cot_id, int _cot_correlativo, double _cot_precio_sugerido, double _cot_preciosiva, double _cot_preciociva, double _cot_cantidad, int _doc_decimales)
		{
			InitializeComponent();
			inv_id = _inv_id;
			cot_descripcion = _cot_descripcion;
			cliente = _cliente;
			cot_id = _cot_id;
			cot_correlativo = _cot_correlativo;
			cot_precio_sugerido = _cot_precio_sugerido;
			cot_preciosiva = _cot_preciosiva;
			cot_cantidad = _cot_cantidad;
			doc_decimales = _doc_decimales;
			cot_preciociva = _cot_preciociva;

			this.lblIDProducto.Text = inv_id;
			this.lblDescripcion.Text = cot_descripcion;
			this.lblNombreCliente.Text = cliente;
			this.lblCantidad.Text = Convert.ToString(cot_cantidad);
			this.lblPrecioSugeridoCIVA.Text = "$ " + Convert.ToString(cot_precio_sugerido);
			this.lblPrecioSugeridoSIVA.Text = "$ " + Convert.ToString(Math.Round( cot_precio_sugerido/1.13, doc_decimales));
			this.txtPrecioAutorizado.Text = Convert.ToString(cot_preciosiva);
			this.lblPrecioSolicitadoSIVA.Text = "$ " + Convert.ToString(cot_preciosiva);
			this.lblPrecioSolicitadoCIVA.Text = "$ " + Convert.ToString(cot_preciociva);
			if (App.autoriza_precios_update == 1)
			{
				this.btnAutorizar.IsEnabled = true;
				this.btnDenegar.IsEnabled = true;
			}
			else
			{
				this.btnAutorizar.IsEnabled = false;
				this.btnDenegar.IsEnabled = false;
			}
		}
		private void btnCancelar_Clicked(object sender, EventArgs e)
        {
			Navigation.PopAsync();
        }

        private async void btnDenegar_Clicked(object sender, EventArgs e)
        {
			var result = await DisplayAlert("Confirme operación", "¿Confirma que se DENIEGA el precio del producto: " + lblIDProducto.Text + " de la cotización: " + cot_id + "?", "Si", "No");
			if (result)
			{
				if (Convert.ToDouble(this.txtPrecioAutorizado.Text) > 0 && this.txtPrecioAutorizado.Text != "")
				{
					UserDialogs.Instance.ShowLoading("Denegando precio...");
					Uri RequestUri = new Uri(App.url_api + "autorizacionPreciosDet/" + cot_id + ";" + cot_correlativo + ";" + App.usu_id + ";DEN;" + txtPrecioAutorizado.Text.Replace('.','P') + ";" + doc_decimales);
					
					var client = new HttpClient();
					var response = await client.PutAsync(RequestUri, null);
					if (response.StatusCode == System.Net.HttpStatusCode.OK)
					{
						await Navigation.PopAsync(true);

						UserDialogs.Instance.HideLoading();
						UserDialogs.Instance.Toast("Se ha denegado el precio exitosamente");

					}
					else
					{
						UserDialogs.Instance.HideLoading();
						await DisplayAlert("Se presento el siguiente error: ", response.RequestMessage.ToString(), "Ok");
					}
				}
				else
				{
					UserDialogs.Instance.Alert("El precio debe ser mayor a 0");
					this.txtPrecioAutorizado.Focus();
				}

			}
		}

        private async void btnAutorizar_Clicked(object sender, EventArgs e)
        {
			var result = await DisplayAlert("Confirme operación", "¿Confirma que se AUTORIZA el precio del producto: " + lblIDProducto.Text + " de la cotización: " + cot_id + "?", "Si", "No");
			if (result)
			{
				if (Convert.ToDouble(this.txtPrecioAutorizado.Text) > 0 && this.txtPrecioAutorizado.Text != "")
                {
					UserDialogs.Instance.ShowLoading("Autorizando precio...");
					Uri RequestUri = new Uri(App.url_api + "autorizacionPreciosDet/" + cot_id + ";" + cot_correlativo + ";" + App.usu_id + ";APR;" + txtPrecioAutorizado.Text.Replace('.', 'P') + ";" + doc_decimales);
					var client = new HttpClient();
					var response = await client.PutAsync(RequestUri, null);
					if (response.StatusCode == System.Net.HttpStatusCode.OK)
					{
						await Navigation.PopAsync(true);

						UserDialogs.Instance.HideLoading();
						UserDialogs.Instance.Toast("Se ha autorizado el precio exitosamente");

					}
					else
					{
						UserDialogs.Instance.HideLoading();
						await DisplayAlert("Se presento el siguiente error: ", response.RequestMessage.ToString(), "Ok");
					}
                }
                else
                {
					UserDialogs.Instance.Alert("El precio debe ser mayor a 0");
					this.txtPrecioAutorizado.Focus();
                }
				
			}
				
		}
		
	}
}