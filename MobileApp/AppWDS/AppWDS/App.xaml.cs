
using Android;
using Android.Media;
using AppWDS.Modelos;
using Newtonsoft.Json;
using Plugin.LocalNotification;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Reflection;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Essentials;
namespace AppWDS
{
   
    public partial class App : Application
    {
        public static string usu_nombre { get; set; }
        public static string usu_nombre_completo { get; set; }
        public static string usu_correo { get; set; }
        public static int usu_id { get; set; }
        public static string usu_id_nomina { get; set; }
        public static string usu_fotografia { get; set; }
        public static string url_api { get; set; }
        public static int pai_id { get; set; }
        public static int emp_id { get; set; }
        public static string emp_nombre_corto { get; set; }
        public static string emp_nombre_largo { get; set; }
        public static string valor_retornado { get; set; }
        public static int pla_id { get; set; }
        public static string pla_descripcion { get; set; }
        public static string navegar { get; set; }
        public static bool? es_mecanico { get; set; }
        public static bool? autoriza_precios { get; set; }
        public static int? autoriza_precios_insert { get; set; }
        public static int? autoriza_precios_delete { get; set; }
        public static int? autoriza_precios_update { get; set; }

        [Obsolete]
        public static MasterDetailPage MaestroD { get; set; }

        [Obsolete]
        public App()
        {
            InitializeComponent();
            url_api = "http://aplicativos.agroalim.com.sv/net/webapi_test/api/";
            //url_api = "http://aplicativos.agroalim.com.sv/net/webapi/api/";
            MainPage = new NavigationPage(new MainPage());

            Device.StartTimer(TimeSpan.FromSeconds(15), () =>
            {

                validarNotificacionesPush();

                return true; // return true to repeat counting, false to stop timer
            });
        }

        protected async void validarNotificacionesPush()
        {
            try
            {
                var request = new HttpRequestMessage();
                request.RequestUri = new Uri(App.url_api + "PushNotificaciones/" + App.usu_id);
                request.Method = HttpMethod.Get;
                request.Headers.Add("accept", "application/json");
                var client = new HttpClient();
                HttpResponseMessage response = await client.SendAsync(request);
                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    string content = await response.Content.ReadAsStringAsync();
                    var resultado = JsonConvert.DeserializeObject<List<PushNotificaciones>>(content);

                    for (int i = 0; i <= resultado.Count; i++)
                    {
                        
                        var notificacion = new NotificationRequest
                        {
                            BadgeNumber = 1,
                            Description = resultado.ElementAtOrDefault(i).pus_descripcion,
                            Title = resultado.ElementAtOrDefault(i).pus_title,
                            NotificationId = resultado.ElementAtOrDefault(i).pus_id
                        
                            };
                       
                        await NotificationCenter.Current.Show(notificacion);

                        //var audio = Plugin.SimpleAudioPlayer.CrossSimpleAudioPlayer.Current;
                        //audio.Load("neworder.mp3");
                        //audio.Play();
                        string cadena_a_voz = App.usu_nombre + resultado.ElementAtOrDefault(i).pus_descripcion;
                        await TextToSpeech.SpeakAsync(cadena_a_voz);
                    }

                }
            }
            catch (Exception ex)
            {

            }
        }
       
        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
        
       
    }
}
