using System;
using System.Collections.Generic;
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
        public void escribirRespuestaTabla(FacturaCorrFiscalModel modelo)
        {
            try
            {

                using (SqlConnection cn = new SqlConnection(ConexionDB.instancia.getString()))
                {
                    string q = @"INSERT INTO FacturaCorrFiscal ([CodPais], [Dealer], [Tda], [Serie], [TipoDoc], [DocNo], [TDocF], [SDocF], [NDocF], [Resolucion], [IdTrans], [FechaCreacion], [Origen], Archivo)
                                 VALUES(@CodPais, @Dealer, @Tda, @Serie, @TipoDoc, @DocNo, @TDocF, @SDocF, @NDocF, @Resolucion, @IdTrans, @FechaCreacion, @Origen, @Archivo)";
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
                    cn.Open();
                    cmd.ExecuteNonQuery();
                    cn.Close();

                }
            }
            catch (Exception ex)
            {

                throw new Exception("Error en PrincipalLogica(escribirRespuestaTabla): " + ex.Message, ex.InnerException);
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
                        modelo.CodPais = Convert.ToString( leer[0]);
                        modelo.Dealer = Convert.ToInt16( leer[1]);
                        modelo.Tda = Convert.ToString( leer[2]);
                        modelo.Serie = Convert.ToString( leer[3]);
                        modelo.TipoDoc = Convert.ToString( leer[4]);
                        modelo.DocNo = Convert.ToInt32( leer[5]);
                        modelo.IdTrans = Convert.ToString( leer[6]);
                    }
                    cn.Close();

                    return modelo;
                }
            }
            catch (Exception ex)
            {

                throw new Exception("Errror en PrincipalLogica(getFacturaInfo): " + ex.Message, ex.InnerException);
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

    }
}
