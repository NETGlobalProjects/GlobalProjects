using Acr.UserDialogs;
using AppWDS.Modelos;
using AppWDS.Views;
using Newtonsoft.Json;
using Plugin.LocalNotification;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppWDS
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    [Obsolete]
    public partial class Principal : MasterDetailPage
    {
        public List<MasterPageItem> menuList
        {
            get;
            set;
        }
        public Principal()
        {
            InitializeComponent();


            lblEmpresa.Text = App.emp_nombre_corto + " - " + App.pla_descripcion;
            lblNombre.Text = App.usu_nombre;
            if (App.usu_fotografia == null || App.usu_fotografia == "")
            {
                imgBtnFotoPerfil.Source = "sin_perfil";
            }
            else
            {
                imgBtnFotoPerfil.Source = App.usu_fotografia;
            }

            cargarMenu();
        }
        private void cargarMenu() {


            menuList = new List<MasterPageItem>();

            menuList.Add(new MasterPageItem()
            {
                Title = "Nueva Orden",
                Icon = "ic_add_circle.png",
                TargetType = typeof(CrearOrden)
            });
            menuList.Add(new MasterPageItem()
            {
                Title = "Asignadas",
                Icon = "ic_assignment_ind.png",
                TargetType = typeof(MisAsignadas)
            });

            menuList.Add(new MasterPageItem()
            {
                Title = "Ordenes",
                Icon = "ic_list_alt.png",
                TargetType = typeof(MisOrdenes)
            });
            if(App.es_mecanico == true)
            {
                menuList.Add(new MasterPageItem()
                {
                    Title = "Asignar",
                    Icon = "ic_attach_file.png",
                    TargetType = typeof(AsignarOrden)
                });
            }
            if (App.autoriza_precios == true)
            {
                menuList.Add(new MasterPageItem()
                {
                    Title = "Autorización Precios",
                    Icon = "ic_monetization_on.png",
                    TargetType = typeof(AutorizacionPrecios)
                });
            }
            menuList.Add(new MasterPageItem()
            {
                Title = "Cambiar de Empresa",
                Icon = "ic_business_verde.png",
                TargetType = typeof(SelecionePaisEmpresa)
            });
            menuList.Add(new MasterPageItem()
            {
                Title = "Salir",
                Icon = "ic_logout.png",
                TargetType = typeof(LogOut)
            });

            navigationDrawerList.ItemsSource = menuList;

            Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(Dashboard)));
            App.MaestroD = this;

        }
        private async void OnMenuItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = (MasterPageItem)e.SelectedItem;
            Type page = item.TargetType;
            IsPresented = false;
            cargarMenu();
            await Navigation.PushAsync((Page)Activator.CreateInstance(page));
           
        }
       protected override bool OnBackButtonPressed()
        {
            return true;
        }

        
    }
}