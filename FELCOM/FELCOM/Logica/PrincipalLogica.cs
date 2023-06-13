using DevComponents.DotNetBar;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FELCOM.Logica
{
    internal class PrincipalLogica
    {
        private static PrincipalLogica _instancia = null;
        public PrincipalLogica()
        {
        }
        public static PrincipalLogica Instancia
        {
            get
            {
                if (_instancia == null)
                {
                    _instancia = new PrincipalLogica();
                }
                return _instancia;
            }
        }
        public void escribirRespuestaTablaFa(FacturaCorrFiscalModel modelo)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(ConexionDB.instancia.getString()))
                {
                    string q = @"UPDATE f
                                    set TDocF = @TDocF, 
                                        SDocF = @SDocF, 
                                        NDocF = @NDocF, 
                                        Resolucion = @Resolucion, 
                                        Origen = @Origen, 
                                        Archivo = @Archivo, 
                                        PDF = @PDF,
                                        FechaModificacion = @FechaModificacion
                                from FacturaCorrFiscal f 
                                Where  f.CodPais = @CodPais and f.Dealer = @Dealer and f.Tda = @Tda and f.TipoDoc = @TipoDoc and f.Serie = @Serie and f.DocNo = @DocNo";
                    SqlCommand cmd = new SqlCommand(q, cn);
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandTimeout = 9999;
                    cmd.Parameters.Add("@CodPais", System.Data.SqlDbType.Char, 3).Value = modelo.CodPais;
                    cmd.Parameters.Add("@Dealer", System.Data.SqlDbType.Int).Value = modelo.Dealer;
                    cmd.Parameters.Add("@Tda", System.Data.SqlDbType.Char, 3).Value = modelo.Tda;
                    cmd.Parameters.Add("@Serie", System.Data.SqlDbType.Char, 10).Value = modelo.Serie;
                    cmd.Parameters.Add("@TipoDoc", System.Data.SqlDbType.Char, 2).Value = modelo.TipoDoc;
                    cmd.Parameters.Add("@DocNo", System.Data.SqlDbType.Int).Value = modelo.DocNo;
                    cmd.Parameters.Add("@TDocF", System.Data.SqlDbType.NVarChar, 30).Value = modelo.TDocF;
                    cmd.Parameters.Add("@SDocF", System.Data.SqlDbType.NVarChar, 100).Value = modelo.SDocF;
                    cmd.Parameters.Add("@NDocF", System.Data.SqlDbType.NVarChar, 100).Value = modelo.NDocF;
                    cmd.Parameters.Add("@Resolucion", System.Data.SqlDbType.NVarChar, 200).Value = modelo.Resolucion;
                    cmd.Parameters.Add("@IdTrans", System.Data.SqlDbType.NVarChar, 50).Value = modelo.IdTrans;
                    cmd.Parameters.Add("@FechaCreacion", System.Data.SqlDbType.DateTime).Value = modelo.FechaCreacion;
                    cmd.Parameters.Add("@Origen", System.Data.SqlDbType.NVarChar, 50).Value = modelo.Origen;
                    cmd.Parameters.Add("@Archivo", System.Data.SqlDbType.NVarChar, 250).Value = modelo.Archivo;
                    cmd.Parameters.Add("@PDF", System.Data.SqlDbType.NVarChar).Value = modelo.PDF;
                    cmd.Parameters.Add("@FechaModificacion", System.Data.SqlDbType.DateTime).Value = DateTime.Now;
                    cn.Open();
                    cmd.ExecuteNonQuery();
                    cn.Close();

                }
            }
            catch (Exception ex)
            {

                throw new Exception("Error en PrincipalLogica(escribirRespuestaTablaFa): " + ex.Message, ex.InnerException);
            }
        }
        public void escribirRespuestaTablaNC(NotaCreditoCorrFiscalModel modelo)
        {
            try
            {

                using (SqlConnection cn = new SqlConnection(ConexionDB.instancia.getString()))
                {
                    string q = @"INSERT INTO NotaCreditoCorrFiscal ([CodPais], [Dealer], [Tda], [SerieNC], [No],[NotaAbono], [TDocF], [SDocF], [NDocF], [Resolucion], [IdTrans], [FechaCreacion], [Origen], Archivo, PDF)
                                 VALUES(@CodPais, @Dealer, @Tda, @SerieNC,  @No,@NotaAbono, @TDocF, @SDocF, @NDocF, @Resolucion, @IdTrans, @FechaCreacion, @Origen, @Archivo, @PDF)";
                    SqlCommand cmd = new SqlCommand(q, cn);
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandTimeout = 9999;
                    cmd.Parameters.Add("@CodPais", System.Data.SqlDbType.Char, 3).Value = modelo.CodPais;
                    cmd.Parameters.Add("@Dealer", System.Data.SqlDbType.Int).Value = modelo.Dealer;
                    cmd.Parameters.Add("@Tda", System.Data.SqlDbType.Char, 3).Value = modelo.Tda;
                    cmd.Parameters.Add("@SerieNC", System.Data.SqlDbType.Char, 10).Value = modelo.SerieNC;
                    cmd.Parameters.Add("@No", System.Data.SqlDbType.Int).Value = modelo.No;
                    cmd.Parameters.Add("@NotaAbono", System.Data.SqlDbType.Bit).Value = modelo.NotaAbono;
                    cmd.Parameters.Add("@TDocF", System.Data.SqlDbType.NVarChar, 30).Value = modelo.TDocF;
                    cmd.Parameters.Add("@SDocF", System.Data.SqlDbType.NVarChar, 100).Value = modelo.SDocF;
                    cmd.Parameters.Add("@NDocF", System.Data.SqlDbType.NVarChar, 100).Value = modelo.NDocF;
                    cmd.Parameters.Add("@Resolucion", System.Data.SqlDbType.NVarChar, 200).Value = modelo.Resolucion;
                    cmd.Parameters.Add("@IdTrans", System.Data.SqlDbType.NVarChar, 50).Value = modelo.IdTrans;
                    cmd.Parameters.Add("@FechaCreacion", System.Data.SqlDbType.DateTime).Value = modelo.FechaCreacion;
                    cmd.Parameters.Add("@Origen", System.Data.SqlDbType.NVarChar, 50).Value = modelo.Origen;
                    cmd.Parameters.Add("@Archivo", System.Data.SqlDbType.NVarChar, 250).Value = modelo.Archivo;
                    cmd.Parameters.Add("@PDF", System.Data.SqlDbType.NVarChar).Value = modelo.PDF;
                    cn.Open();
                    cmd.ExecuteNonQuery();
                    cn.Close();
                }
            }
            catch (Exception ex)
            {

                throw new Exception("Error en PrincipalLogica(escribirRespuestaTablaNC): " + ex.Message, ex.InnerException);
            }
        }
        public void escribirRespuestaTablaNr(NotaRemisionCorrFiscalModel modelo)
        {
            try
            {

                using (SqlConnection cn = new SqlConnection(ConexionDB.instancia.getString()))
                {
                    string q = @"INSERT INTO NotaRemisionCorrFiscal ([CodPais], [Dealer], [Tda], [RemisionNo],[TDocF], [SDocF], [NDocF], [Resolucion], [IdTrans], [FechaCreacion], [Origen], Archivo, PDF)
                                 VALUES(@CodPais, @Dealer, @Tda,  @RemisionNo, @TDocF, @SDocF, @NDocF, @Resolucion, @IdTrans, @FechaCreacion, @Origen, @Archivo, @PDF)";
                    SqlCommand cmd = new SqlCommand(q, cn);
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandTimeout = 9999;
                    cmd.Parameters.Add("@CodPais", System.Data.SqlDbType.Char, 3).Value = modelo.CodPais;
                    cmd.Parameters.Add("@Dealer", System.Data.SqlDbType.Int).Value = modelo.Dealer;
                    cmd.Parameters.Add("@Tda", System.Data.SqlDbType.Char, 3).Value = modelo.Tda;
                    cmd.Parameters.Add("@RemisionNo", System.Data.SqlDbType.Int).Value = modelo.RemisionNo;
                    cmd.Parameters.Add("@TDocF", System.Data.SqlDbType.NVarChar, 30).Value = modelo.TDocF;
                    cmd.Parameters.Add("@SDocF", System.Data.SqlDbType.NVarChar, 100).Value = modelo.SDocF;
                    cmd.Parameters.Add("@NDocF", System.Data.SqlDbType.NVarChar, 100).Value = modelo.NDocF;
                    cmd.Parameters.Add("@Resolucion", System.Data.SqlDbType.NVarChar, 200).Value = modelo.Resolucion;
                    cmd.Parameters.Add("@IdTrans", System.Data.SqlDbType.NVarChar, 50).Value = modelo.IdTrans;
                    cmd.Parameters.Add("@FechaCreacion", System.Data.SqlDbType.DateTime).Value = modelo.FechaCreacion;
                    cmd.Parameters.Add("@Origen", System.Data.SqlDbType.NVarChar, 50).Value = modelo.Origen;
                    cmd.Parameters.Add("@Archivo", System.Data.SqlDbType.NVarChar, 250).Value = modelo.Archivo;
                    cmd.Parameters.Add("@PDF", System.Data.SqlDbType.NVarChar).Value = modelo.PDF;
                    cn.Open();
                    cmd.ExecuteNonQuery();
                    cn.Close();
                }
            }
            catch (Exception ex)
            {

                throw new Exception("Error en PrincipalLogica(escribirRespuestaTablaNr): " + ex.Message, ex.InnerException);
            }
        }
        public void escribirRespuestaTablaRi(RetencionIvaCorrFiscalModel modelo)
        {
            try
            {

                using (SqlConnection cn = new SqlConnection(ConexionDB.instancia.getString()))
                {
                    string q = @"INSERT INTO RetencionIvaCorrFiscal ([CodPais], [Dealer], [Tda],Proveedor,Serie, [Comprobante],[TDocF], [SDocF], [NDocF], [Resolucion], [IdTrans], [FechaCreacion], [Origen], Archivo, PDF)
                                 VALUES(@CodPais, @Dealer, @Tda, @Proveedor , @Serie ,@Comprobante, @TDocF, @SDocF, @NDocF, @Resolucion, @IdTrans, @FechaCreacion, @Origen, @Archivo, @PDF)";
                    SqlCommand cmd = new SqlCommand(q, cn);
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandTimeout = 9999;
                    cmd.Parameters.Add("@CodPais", System.Data.SqlDbType.Char, 3).Value = modelo.CodPais;
                    cmd.Parameters.Add("@Dealer", System.Data.SqlDbType.Int).Value = modelo.Dealer;
                    cmd.Parameters.Add("@Tda", System.Data.SqlDbType.Char, 3).Value = modelo.Tda;
                    cmd.Parameters.Add("@Proveedor", System.Data.SqlDbType.Char, 14).Value = modelo.Proveedor;
                    cmd.Parameters.Add("@Serie", System.Data.SqlDbType.Char, 10).Value = modelo.Serie;
                    cmd.Parameters.Add("@Comprobante", System.Data.SqlDbType.Int).Value = modelo.Comprobante;
                    cmd.Parameters.Add("@TDocF", System.Data.SqlDbType.NVarChar, 30).Value = modelo.TDocF;
                    cmd.Parameters.Add("@SDocF", System.Data.SqlDbType.NVarChar, 100).Value = modelo.SDocF;
                    cmd.Parameters.Add("@NDocF", System.Data.SqlDbType.NVarChar, 100).Value = modelo.NDocF;
                    cmd.Parameters.Add("@Resolucion", System.Data.SqlDbType.NVarChar, 200).Value = modelo.Resolucion;
                    cmd.Parameters.Add("@IdTrans", System.Data.SqlDbType.NVarChar, 50).Value = modelo.IdTrans;
                    cmd.Parameters.Add("@FechaCreacion", System.Data.SqlDbType.DateTime).Value = modelo.FechaCreacion;
                    cmd.Parameters.Add("@Origen", System.Data.SqlDbType.NVarChar, 50).Value = modelo.Origen;
                    cmd.Parameters.Add("@Archivo", System.Data.SqlDbType.NVarChar, 250).Value = modelo.Archivo;
                    cmd.Parameters.Add("@PDF", System.Data.SqlDbType.NVarChar).Value = modelo.PDF;
                    cn.Open();
                    cmd.ExecuteNonQuery();
                    cn.Close();
                }
            }
            catch (Exception ex)
            {

                throw new Exception("Error en PrincipalLogica(escribirRespuestaTablaRi): " + ex.Message, ex.InnerException);
            }
        }
        public void escribirRespuestaTablaCo(CompraCorrFiscalModel modelo)
        {
            try
            {

                using (SqlConnection cn = new SqlConnection(ConexionDB.instancia.getString()))
                {
                    string q = @"INSERT INTO CompraCorrFiscal ([CodPais], [Dealer], [Tda],[CompraNo],[TDocF], [SDocF], [NDocF], [Resolucion], [IdTrans], [FechaCreacion], [Origen], Archivo, PDF)
                                 VALUES(@CodPais, @Dealer, @Tda,  ,@CompraNo, @TDocF, @SDocF, @NDocF, @Resolucion, @IdTrans, @FechaCreacion, @Origen, @Archivo, @PDF)";
                    SqlCommand cmd = new SqlCommand(q, cn);
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandTimeout = 9999;
                    cmd.Parameters.Add("@CodPais", System.Data.SqlDbType.Char, 3).Value = modelo.CodPais;
                    cmd.Parameters.Add("@Dealer", System.Data.SqlDbType.Int).Value = modelo.Dealer;
                    cmd.Parameters.Add("@Tda", System.Data.SqlDbType.Char, 3).Value = modelo.Tda;
                    cmd.Parameters.Add("@CompraNo", System.Data.SqlDbType.Int).Value = modelo.CompraNo;
                    cmd.Parameters.Add("@TDocF", System.Data.SqlDbType.NVarChar, 30).Value = modelo.TDocF;
                    cmd.Parameters.Add("@SDocF", System.Data.SqlDbType.NVarChar, 100).Value = modelo.SDocF;
                    cmd.Parameters.Add("@NDocF", System.Data.SqlDbType.NVarChar, 100).Value = modelo.NDocF;
                    cmd.Parameters.Add("@Resolucion", System.Data.SqlDbType.NVarChar, 200).Value = modelo.Resolucion;
                    cmd.Parameters.Add("@IdTrans", System.Data.SqlDbType.NVarChar, 50).Value = modelo.IdTrans;
                    cmd.Parameters.Add("@FechaCreacion", System.Data.SqlDbType.DateTime).Value = modelo.FechaCreacion;
                    cmd.Parameters.Add("@Origen", System.Data.SqlDbType.NVarChar, 50).Value = modelo.Origen;
                    cmd.Parameters.Add("@Archivo", System.Data.SqlDbType.NVarChar, 250).Value = modelo.Archivo;
                    cmd.Parameters.Add("@PDF", System.Data.SqlDbType.NVarChar).Value = modelo.PDF;
                    cn.Open();
                    cmd.ExecuteNonQuery();
                    cn.Close();
                }
            }
            catch (Exception ex)
            {

                throw new Exception("Error en PrincipalLogica(escribirRespuestaTablaCo): " + ex.Message, ex.InnerException);
            }
        }
        public FacturaModel getFacturaInfo(string idTrans)
        {
            try
            {
                FacturaModel modelo = new FacturaModel();
                using (SqlConnection cn = new SqlConnection(ConexionDB.instancia.getString()))
                {
                    string q = @"SELECT [CodPais], [Dealer], [Tda], [Serie], [TipoDoc], [DocNo], IdTrans FROM Factura F where F.IdTrans = @idTrans";
                    SqlCommand cmd = new SqlCommand(q, cn);
                    cmd.Parameters.Add("@idTrans", System.Data.SqlDbType.NVarChar, 50).Value = idTrans;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandTimeout = 9999;
                    SqlDataReader leer;
                    cn.Open();
                    leer = cmd.ExecuteReader();
                    while (leer.Read())
                    {
                        modelo.CodPais = Convert.ToString(leer[0]);
                        modelo.Dealer = Convert.ToInt16(leer[1]);
                        modelo.Tda = Convert.ToString(leer[2]);
                        modelo.Serie = Convert.ToString(leer[3]);
                        modelo.TipoDoc = Convert.ToString(leer[4]);
                        modelo.DocNo = Convert.ToInt32(leer[5]);
                        modelo.IdTrans = Convert.ToString(leer[6]);
                    }
                    cn.Close();

                    return modelo;
                }
            }
            catch (Exception ex)
            {

                throw new Exception("Error en PrincipalLogica(getFacturaInfo): " + ex.Message, ex.InnerException);
            }
        }
        public List<Logs> getLogs()
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(ConexionDB.instancia.getString()))
                {
                    string q = @"SELECT TOP 100 Id, Fecha, Tipo, Mensaje FROM FELCOMLogs Order By Id desc";
                    SqlCommand cmd = new SqlCommand(q, cn);

                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandTimeout = 9999;
                    SqlDataReader leer;
                    cn.Open();
                    leer = cmd.ExecuteReader();
                    List<Logs> logs = new List<Logs>();
                    while (leer.Read())
                    {
                        logs.Add(new Logs { Id = Convert.ToInt32(leer[0]), Fecha = Convert.ToDateTime(leer[1]), Tipo = Convert.ToString(leer[2]), Mensaje = Convert.ToString(leer[3]) });
                    }
                    cn.Close();

                    return logs;
                }
            }
            catch (Exception ex)
            {

                throw new Exception("Error en PrincipalLogica(getLogs): " + ex.Message, ex.InnerException);
            }
        }
        public void escribirLog(Logs modelo)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(ConexionDB.instancia.getString()))
                {
                    string q = @"insert into  FELCOMLogs (Fecha, Tipo, Mensaje) values(getdate(), @Tipo, @Mensaje) ";
                    SqlCommand cmd = new SqlCommand(q, cn);

                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.Parameters.Add("@Tipo", System.Data.SqlDbType.NVarChar, 10).Value = modelo.Tipo;
                    cmd.Parameters.Add("@Mensaje", System.Data.SqlDbType.NVarChar).Value = modelo.Mensaje;
                    cmd.CommandTimeout = 9999;

                    cn.Open();
                    cmd.ExecuteNonQuery();
                    cn.Close();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error en PrincipalLogica(getLogs): " + ex.Message, ex.InnerException);
            }
        }
        public static List<T> ConvertToList<T>(DataTable dt)
        {
            var columnNames = dt.Columns.Cast<DataColumn>().Select(c => c.ColumnName.ToLower()).ToList();
            var properties = typeof(T).GetProperties();
            return dt.AsEnumerable().Select(row =>
            {
                var objT = Activator.CreateInstance<T>();
                foreach (var pro in properties)
                {
                    if (columnNames.Contains(pro.Name.ToLower()))
                    {
                        try
                        {
                            pro.SetValue(objT, row[pro.Name]);
                        }
                        catch (Exception ex) { }
                    }
                }
                return objT;
            }).ToList();
        }
        public List<TipoDocumentoFE> listadoTiposDocs()
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(ConexionDB.instancia.getString()))
                {
                    string q = @"SELECT TipoDoc, upper(Nombre) Nombre, TipoDocFE, TablaRespuesta FROM TipoDocumentoFE  where TipoDoc <> 'Ti'";
                    SqlCommand cmd = new SqlCommand(q, cn);

                    cmd.CommandType = CommandType.Text;
                    cmd.CommandTimeout = 9999;

                    cn.Open();
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter();
                    da.SelectCommand = cmd;
                    da.Fill(dt);
                    cn.Close();

                    List<TipoDocumentoFE> tiposDocs = new List<TipoDocumentoFE>();
                    tiposDocs = ConvertToList<TipoDocumentoFE>(dt);

                    return tiposDocs;
                }
            }
            catch (Exception ex)
            {

                throw new Exception("Error en PrincipalLogica(listadoTiposDocs): " + ex.Message, ex.InnerException);
            }
        }
        public List<anioMesModel>  getAnioMes()
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(ConexionDB.instancia.getString()))
                {
                    string q = @"SELECT DATENAME(YEAR, GETDATE() ) anio, upper(DATENAME(MONTH, GETDATE())) mes";
                    SqlCommand cmd = new SqlCommand(q, cn);

                    cmd.CommandType = CommandType.Text;
                    cmd.CommandTimeout = 9999;

                    cn.Open();
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter();
                    da.SelectCommand = cmd;
                    da.Fill(dt);
                    cn.Close();

                    List<anioMesModel> anioMesList = new List<anioMesModel>();
                    anioMesList = ConvertToList<anioMesModel>(dt);

                    return anioMesList;
                }
            }
            catch (Exception ex)
            {

                throw new Exception("Error en PrincipalLogica(listadoTiposDocs): " + ex.Message, ex.InnerException);
            }
        }
        public class FacturaCorrFiscalModel
        {
            public string CodPais { get; set; }
            public int Dealer { get; set; }
            public string Tda { get; set; }
            public string Serie { get; set; }
            public string TipoDoc { get; set; }
            public int DocNo { get; set; }
            public string TDocF { get; set; }
            public string SDocF { get; set; }
            public string NDocF { get; set; }
            public string Resolucion { get; set; }
            public string IdTrans { get; set; }
            public DateTime FechaCreacion { get; set; }
            public string Origen { get; set; }
            public string Archivo { get; set; }
            public string PDF { get; set; }
        }

        public class NotaCreditoCorrFiscalModel
        {
            public string CodPais { get; set; }
            public int Dealer { get; set; }
            public string Tda { get; set; }
            public string SerieNC { get; set; }
            public int No { get; set; }
            public bool NotaAbono { get; set; }
            public string TDocF { get; set; }
            public string SDocF { get; set; }
            public string NDocF { get; set; }
            public string Resolucion { get; set; }
            public string IdTrans { get; set; }
            public DateTime FechaCreacion { get; set; }
            public string Origen { get; set; }
            public string Archivo { get; set; }
            public string PDF { get; set; }
        }
        public class NotaRemisionCorrFiscalModel
        {
            public string CodPais { get; set; }
            public int Dealer { get; set; }
            public string Tda { get; set; }
            public int RemisionNo { get; set; }
            public string TDocF { get; set; }
            public string SDocF { get; set; }
            public string NDocF { get; set; }
            public string Resolucion { get; set; }
            public string IdTrans { get; set; }
            public DateTime FechaCreacion { get; set; }
            public string Origen { get; set; }
            public string Archivo { get; set; }
            public string PDF { get; set; }
        }
        public class RetencionIvaCorrFiscalModel
        {
            public string CodPais { get; set; }
            public int Dealer { get; set; }
            public string Tda { get; set; }
            public string Proveedor { get; set; }
            public string Serie { get; set; }
            public int Comprobante { get; set; }
            public string TDocF { get; set; }
            public string SDocF { get; set; }
            public string NDocF { get; set; }
            public string Resolucion { get; set; }
            public string IdTrans { get; set; }
            public DateTime FechaCreacion { get; set; }
            public string Origen { get; set; }
            public string Archivo { get; set; }
            public string PDF { get; set; }
        }
        public class CompraCorrFiscalModel
        {
            public string CodPais { get; set; }
            public int Dealer { get; set; }
            public string Tda { get; set; }
            public int CompraNo { get; set; }
            public string TDocF { get; set; }
            public string SDocF { get; set; }
            public string NDocF { get; set; }
            public string Resolucion { get; set; }
            public string IdTrans { get; set; }
            public DateTime FechaCreacion { get; set; }
            public string Origen { get; set; }
            public string Archivo { get; set; }
            public string PDF { get; set; }
        }
        public class FacturaModel
        {
            public string CodPais { get; set; }
            public int Dealer { get; set; }
            public string Tda { get; set; }
            public string Serie { get; set; }
            public string TipoDoc { get; set; }
            public int DocNo { get; set; }
            public string IdTrans { get; set; }
        }
        public class Logs
        {
            public int Id { get; set; }
            public DateTime Fecha { get; set; }
            public string Tipo { get; set; }
            public string Mensaje { get; set; }
        }
        public class TipoDocumentoFE
        {
            public string TipoDoc { get; set; }
            public string Nombre { get; set; }
            public string TipoDocFE { get; set; }
            public string TablaRespuesta { get; set; }
        }
        public class anioMesModel
        {
            public string Anio { get; set; }
            public string Mes { get; set; }
            
        }

    }
}
