using Acr.UserDialogs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppWDS
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Dashboard : ContentPage
    {
        public Dashboard()
        {
            
            InitializeComponent();
            cargarDashboard();
        }
        private  void cargarDashboard() 
        {
            UserDialogs.Instance.ShowLoading("Cargando dashboard...");
            wvNavegador.Source = "http://aplicativos.agroalim.com.sv/net/wdsnet/DashboardMovil.aspx";
            //wvNavegador.Source = "https://technext.github.io/fruitkha/shop.html";
            UserDialogs.Instance.HideLoading();
        }

        private void rvPanel_Refreshing(object sender, EventArgs e)
        {
            cargarDashboard();
            rvPanel.IsRefreshing = false;
        }
    }
}