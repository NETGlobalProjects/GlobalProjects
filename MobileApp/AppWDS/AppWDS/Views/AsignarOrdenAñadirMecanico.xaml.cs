using Acr.UserDialogs;
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
	public partial class AsignarOrdenAñadirMecanico : ContentPage
	{
        int ord_id;
        int mec_id;
		public AsignarOrdenAñadirMecanico (int p_ord_id, int p_mec_id,string p_mec_nombre ,string foto_url)
		{
			InitializeComponent ();
            
            ord_id = p_ord_id;
            mec_id = p_mec_id;
            lblConfirma.Text = "¿Confirma que desea añadir el mecánico a la Orden: " + Convert.ToString(ord_id) + "?";
            lblNombre.Text = p_mec_nombre;
            if (foto_url == null || foto_url == "")
            {
                imgBtnFotoPerfil.Source = "sin_perfil";
            }
            else
            {
                imgBtnFotoPerfil.Source = foto_url;
            }
        }
        private async void btnSiConfirmar_Clicked(object sender, EventArgs e)
        {
            try
            {
                Uri RequestUri = new Uri(App.url_api + "OrdenManttoMecanicos/" + App.pai_id + ";" + App.emp_id + ";" + ord_id + ";" + mec_id + ";" + App.usu_id);
                var client = new HttpClient();
                //var json = JsonConvert.SerializeObject(om);
                //var contentJson = new StringContent(json, Encoding.UTF8, "application/json");
                var response = await client.PostAsync(RequestUri, null);
                string content = await response.Content.ReadAsStringAsync();
                if (content.Contains("Error"))
                {
                    UserDialogs.Instance.HideLoading();
                    await DisplayAlert("Error al añadir mecánico", content , "Ok");
                }
                else
                {
                    UserDialogs.Instance.HideLoading();
                    await DisplayAlert("Confirmación", content ,"Ok");
                    if(content.Contains("ya forma parte"))
                    {
                        await Navigation.PopAsync(false);
                    }
                    else
                    {
                        App.navegar = "MecanicosOrden";
                        await Navigation.PopAsync(false);
                    }
                   
                }
                
            }
            catch(Exception ex)
            {
                await DisplayAlert("Error", ex.InnerException.ToString(), "Ok"); 
            }
        }
        private void btnNoCancelar_Clicked(object sender, EventArgs e)
        {
            Navigation.PopAsync(true);
        }
    }
}