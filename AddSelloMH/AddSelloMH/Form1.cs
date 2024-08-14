using AddSelloMH.Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using RestSharp;
using static AddSelloMH.Datos.accesoDatos;
using Newtonsoft.Json.Linq;
using System.IO;

namespace AddSelloMH
{
    public partial class Form1 : Form
    {
        List<WSRequest> wSRequests;
        List<WebService> webServices;
        List<rFELSV> rFELSVs;
        string tokenMH;
        public Form1()
        {
            InitializeComponent();
        }
        void mostrarProgreso()
        {
            this.progressBar1.Visible = true;
            this.label3.Visible = true;
            this.Cursor = Cursors.WaitCursor;
            progressBar1.Value = 0;
            this.button2.Enabled = false;
        }
        void ocultarProgreso()
        {
            if (this.documentosConRespuestalabel9.Text != "0")
            {
                accesoDatos.instancia.actualizarSelloFELSV();
            }
            this.progressBar1.Visible = false;
            this.label3.Visible = false;
            this.Cursor = Cursors.Arrow;

            if (this.documentosConRespuestalabel9.Text != "0" || this.documentosSinRespuestalabel11.Text != "0")
            {
                this.button2.Enabled = true;
            }
            else
            {
                this.button2.Enabled = false;
            }
        }
        void guardarRespuesta(vFELSV d, bool conRespuesta, string Json)
        {
            try
            {
                rFELSVs.Add(new rFELSV { Anulado = d.Anulado, CodigoGeneracion = d.CodigoGeneracion, CodigoGeneracionA = d.CodigoGeneracionA, CodPais = d.CodPais, Cola = d.Cola, conRespuesta = conRespuesta, Consolidado = d.Consolidado, Dealer = d.Dealer, DocNo = d.DocNo, EmailError = d.EmailError, Enviado = d.Enviado, Fecha = d.Fecha, FechaNatural = d.FechaNatural, Impreso = d.Impreso, NumeroControl = d.NumeroControl, Observaciones = d.Observaciones, ObservacionesA = d.ObservacionesA, Placa = d.Placa, Seleccionar = d.Seleccionar, SelloRecibido = d.SelloRecibido, SelloRecibidoA = d.SelloRecibidoA, Serie = d.Serie, Tda = d.Tda, TipoDoc = d.TipoDoc, Vendedor = d.Vendedor, Json = Json });
            }
            catch (Exception ex)
            {
                throw new Exception("Error al guardar respuesta: " + ex.Message + " " + ex.InnerException);
            }
        }
        private async void button1_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Confirma la operación?", "Notificación del sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                mostrarProgreso();
                rFELSVs = new List<rFELSV>();
                var datos = accesoDatos.instancia.getPendientes(this.desdeDateTimePicker1.Value, this.hastaDateTimePicker2.Value);
                List<empresasRecorrer> listaEmpresas = new List<empresasRecorrer>();
                foreach (var dato in datos)
                {

                    if (listaEmpresas.Where(a => a.Dealer == dato.Dealer).Count() == 0)
                    {
                        listaEmpresas.Add(new empresasRecorrer { Dealer = dato.Dealer, NIT = "", passwordPri = "", pwd = "" });
                    }
                }
                int conteo = listaEmpresas.Count();

                this.empresasConteolabel5.Text = conteo.ToString();
                this.documentosConteoLabel.Text = datos.Count.ToString();
                int conteoConRespuesta = 0;
                int conteoSinRespuesta = 0;

                foreach (var empresa in listaEmpresas)
                {
                    wSRequests = new List<WSRequest>();
                    wSRequests = accesoDatos.instancia.wsRequestList("SAL", empresa.Dealer);

                    webServices = new List<WebService>();
                    webServices = accesoDatos.instancia.webServiceList("SAL", empresa.Dealer);

                    tokenMH = convertStringToJson(getToken());
                    if (tokenMH.Contains("Bearer"))
                    {
                        this.progressBar1.Maximum = datos.Count();
                        foreach (var f in datos.Where(a => a.Dealer == empresa.Dealer).ToList())
                        {
                            string resultadoJson = consultarDTE(f.CodigoGeneracion, tokenMH);
                            if (!resultadoJson.Contains("\"estadoDoc\":\"Error\""))
                            {
                                responseConsultaDTE responseCons = JsonConvert.DeserializeObject<responseConsultaDTE>(resultadoJson);
                                progressBar1.Value += 1;
                                conteoConRespuesta += 1;
                                f.SelloRecibido = responseCons.selloVal;
                                guardarRespuesta(f, true, resultadoJson);

                                accesoDatos.instancia.guardarFELSVResponse(new FELSVResponse { DocNo = f.DocNo, JsonRespuesta = resultadoJson, CodigoGeneracion = f.CodigoGeneracion, CodigoGeneracionA = f.CodigoGeneracionA, CodPais = f.CodPais, conRespuesta = true, Dealer = f.Dealer, Fecha = f.Fecha, FechaCreacion = DateTime.Now, NumeroControl = f.NumeroControl, SelloRecibido = responseCons.selloVal, SelloRecibidoA = f.SelloRecibidoA, Serie = f.Serie, Tda = f.Tda, TipoDoc = f.TipoDoc });

                                JObject jsonObject = JObject.Parse(resultadoJson);
                                if (descargarJsonheckBox1.Checked == true)
                                {
                                    string rutaJson = @"\\pandora02\FelcomDTE\SAL\" + empresa.Dealer.ToString() + "\\" + responseCons.codGen + "_MH.json";
                                    //if (!Directory.Exists(@"\\pandora02\FelcomDTE\SAL\Test\" + empresa.Dealer.ToString() ))
                                    //{
                                    //    Directory.CreateDirectory(@"\\pandora02\FelcomDTE\SAL\Test\" + empresa.Dealer.ToString());
                                    //}
                                    //string rutaJson = @"\\pandora02\FelcomDTE\SAL\Test\" + empresa.Dealer.ToString() + "\\" + responseCons.codGen + "_MH.json";
                                    if (!File.Exists(rutaJson))
                                    {
                                        File.WriteAllText(rutaJson, jsonObject.ToString());
                                    }

                                }
                                this.label3.Text = String.Format("Consultando {0} de {1} documento(s), Dealer {2}", progressBar1.Value, datos.Count(), empresa.Dealer);
                            }
                            else
                            {
                                progressBar1.Value += 1;
                                conteoSinRespuesta += 1;

                                guardarRespuesta(f, false, resultadoJson);
                                this.label3.Text = String.Format("Consultando {0} de {1} documento(s), Dealer {2}", progressBar1.Value, datos.Count(), empresa.Dealer);
                            }
                            this.documentosConRespuestalabel9.Text = conteoConRespuesta.ToString();
                            this.documentosSinRespuestalabel11.Text = conteoSinRespuesta.ToString();
                        }
                    }
                }
                this.documentosConRespuestalabel9.Text = conteoConRespuesta.ToString();
                this.documentosSinRespuestalabel11.Text = conteoSinRespuesta.ToString();
                ocultarProgreso();
            }
        }
        private string consultarDTE(string codigoGeneracion, string token)
        {
            try
            {
                var options = new RestClientOptions("https://admin.factura.gob.sv")
                {
                    MaxTimeout = -1,
                    UserAgent = "NetDataRC",
                };
                var client = new RestClient(options);

                var request = new RestRequest("/prod/consulta/consulta-ssc/dte/" + codigoGeneracion + "", Method.Get);

                request.AddHeader("Authorization", token);
                RestResponse response = client.Execute(request);
                return response.Content;
            }
            catch (Exception ex)
            {
                throw new Exception("Error en consultarDTE: " + ex.Message + " " + ex.InnerException);
            }
        }
        private string getToken()
        {
            var c = Properties.Settings.Default;
            string salida = "";
            string user = wSRequests.Where(a => a.No == 1 && a.Propiedad.Trim() == "nit").SingleOrDefault().Valor.Replace("-", "").Trim();
            string pwd = wSRequests.Where(a => a.No == 2 && a.Propiedad.Trim() == "pwd").SingleOrDefault().Valor.Trim();
            Dictionary<string, string> di = new Dictionary<string, string>();
            di.Add("user", user); di.Add("pwd", pwd);

            string url = webServices.Where(a => a.No == 2).SingleOrDefault().URL;
            var Http = new HttpClient();

            var formData = new FormUrlEncodedContent(di);
            HttpResponseMessage response = new HttpResponseMessage();
            formData.Headers.ContentType = new MediaTypeHeaderValue("application/x-www-form-urlencoded");
            Http.DefaultRequestHeaders.UserAgent.ParseAdd("DteService-v1");
            Task.Run(async () => response = await Http.PostAsync(url, formData)).Wait();
            salida = response.Content.ReadAsStringAsync().Result;

            return salida;
        }
        private string convertStringToJson(string json)
        {
            try
            {
                Token member = JsonConvert.DeserializeObject<Token>(json);
                return member.body.token.Replace("bearer ", "Bearer ");
            }
            catch (Exception ex)
            {
                throw new Exception("Error al convertir cadena a json: " + ex.Message, ex.InnerException);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Conexion.instancia.cnString = Properties.Settings.Default.con;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            frmVerResultados frm = new frmVerResultados();
            frm.rFELSVs = rFELSVs;
            frm.Show();
        }
        private void desdeDateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            SendKeys.Send(".");
        }
        private void hastaDateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            SendKeys.Send(".");
        }
    }
}
