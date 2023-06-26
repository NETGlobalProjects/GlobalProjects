
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;




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
                                        FechaModificacion = @FechaModificacion,
                                        FechaRespuesta = @FechaRespuesta
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
                    cmd.Parameters.Add("@FechaRespuesta", System.Data.SqlDbType.DateTime).Value = modelo.FechaRespuesta;
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
        public void escribirRespuestaTablaFaInvalidacion(FacturaCorrFiscalModel modelo)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(ConexionDB.instancia.getString()))
                {
                    string q = @"UPDATE f
                                    set SelloInvalidacion = @SelloInvalidacion,
                                        FechaInvalidacion = @FechaInvalidacion
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
                    cmd.Parameters.Add("@SelloInvalidacion", System.Data.SqlDbType.NVarChar,100).Value = modelo.SelloInvalidacion;
                    cmd.Parameters.Add("@FechaInvalidacion", System.Data.SqlDbType.DateTime).Value = modelo.FechaInvalidacion ;
                    cn.Open();
                    cmd.ExecuteNonQuery();
                    cn.Close();
                }
            }
            catch (Exception ex)
            {

                throw new Exception("Error en PrincipalLogica(escribirRespuestaTablaFaInvalidacion): " + ex.Message, ex.InnerException);
            }
        }
        public void escribirRespuestaTablaNC(NotaCreditoCorrFiscalModel modelo)
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
                                        FechaModificacion = @FechaModificacion,
                                        FechaRespuesta = @FechaRespuesta
                                from NotaCreditoCorrFiscal f 
                                Where  f.CodPais = @CodPais and f.Dealer = @Dealer and f.Tda = @Tda and f.SerieNC = @SerieNC and f.No = @No and f.NotaAbono = @NotaAbono";
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
                    cmd.Parameters.Add("@FechaModificacion", System.Data.SqlDbType.DateTime).Value = DateTime.Now;
                    cmd.Parameters.Add("@FechaRespuesta", System.Data.SqlDbType.DateTime).Value = modelo.FechaRespuesta;
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
        public void escribirRespuestaTablaNCInvalidacion(NotaCreditoCorrFiscalModel modelo)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(ConexionDB.instancia.getString()))
                {
                    string q = @"UPDATE f
                                    set SelloInvalidacion = @SelloInvalidacion,
                                        FechaInvalidacion = @FechaInvalidacion
                                from NotaCreditoCorrFiscal f 
                                Where  f.CodPais = @CodPais and f.Dealer = @Dealer and f.Tda = @Tda  and f.SerieNC = @SerieNC and f.No = @No and f.NotaAbono = @NotaAbono";
                    SqlCommand cmd = new SqlCommand(q, cn);
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandTimeout = 9999;
                    cmd.Parameters.Add("@CodPais", System.Data.SqlDbType.Char, 3).Value = modelo.CodPais;
                    cmd.Parameters.Add("@Dealer", System.Data.SqlDbType.Int).Value = modelo.Dealer;
                    cmd.Parameters.Add("@Tda", System.Data.SqlDbType.Char, 3).Value = modelo.Tda;
                    cmd.Parameters.Add("@SerieNC", System.Data.SqlDbType.Char, 10).Value = modelo.SerieNC;
                    cmd.Parameters.Add("@No", System.Data.SqlDbType.Int).Value = modelo.No;
                    cmd.Parameters.Add("@NotaAbono", System.Data.SqlDbType.Bit).Value = modelo.NotaAbono;
                    cmd.Parameters.Add("@SelloInvalidacion", System.Data.SqlDbType.NVarChar,100).Value = modelo.SelloInvalidacion;
                    cmd.Parameters.Add("@FechaInvalidacion", System.Data.SqlDbType.DateTime).Value = modelo.FechaInvalidacion;

                    cn.Open();
                    cmd.ExecuteNonQuery();
                    cn.Close();
                }
            }
            catch (Exception ex)
            {

                throw new Exception("Error en PrincipalLogica(escribirRespuestaTablaNCInvalidacion): " + ex.Message, ex.InnerException);
            }
        }
        public void escribirRespuestaTablaNr(NotaRemisionCorrFiscalModel modelo)
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
                                        FechaModificacion = @FechaModificacion,
                                        FechaRespuesta = @FechaRespuesta
                                from NotaRemisionCorrFiscal f 
                                Where  f.CodPais = @CodPais and f.Dealer = @Dealer and f.Tda = @Tda  and  f.RemisionNo = @RemisionNo";
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
                    cmd.Parameters.Add("@FechaModificacion", System.Data.SqlDbType.DateTime).Value = DateTime.Now;
                    cmd.Parameters.Add("@FechaRespuesta", System.Data.SqlDbType.DateTime).Value = modelo.FechaRespuesta;
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
        public void escribirRespuestaTablaNrInvalidacion(NotaRemisionCorrFiscalModel modelo)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(ConexionDB.instancia.getString()))
                {
                    string q = @"UPDATE f
                                    set SelloInvalidacion = @SelloInvalidacion,
                                        FechaInvalidacion = @FechaInvalidacion
                                from NotaRemisionCorrFiscal f 
                                Where  f.CodPais = @CodPais and f.Dealer = @Dealer and f.Tda = @Tda  and  f.RemisionNo = @RemisionNo";
                    SqlCommand cmd = new SqlCommand(q, cn);
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandTimeout = 9999;
                    cmd.Parameters.Add("@CodPais", System.Data.SqlDbType.Char, 3).Value = modelo.CodPais;
                    cmd.Parameters.Add("@Dealer", System.Data.SqlDbType.Int).Value = modelo.Dealer;
                    cmd.Parameters.Add("@Tda", System.Data.SqlDbType.Char, 3).Value = modelo.Tda;
                    cmd.Parameters.Add("@RemisionNo", System.Data.SqlDbType.Int).Value = modelo.RemisionNo;
                    cmd.Parameters.Add("@SelloInvalidacion", System.Data.SqlDbType.NVarChar, 100).Value = modelo.SelloInvalidacion;
                    cmd.Parameters.Add("@FechaInvalidacion", System.Data.SqlDbType.DateTime).Value = modelo.FechaInvalidacion;
                    cn.Open();
                    cmd.ExecuteNonQuery();
                    cn.Close();
                }
            }
            catch (Exception ex)
            {

                throw new Exception("Error en PrincipalLogica(escribirRespuestaTablaNrInvalidacion): " + ex.Message, ex.InnerException);
            }
        }
        public void escribirRespuestaTablaRi(RetencionIvaCorrFiscalModel modelo)
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
                                        FechaModificacion = @FechaModificacion,
                                        FechaRespuesta = @FechaRespuesta
                                from RetencionIVACorrFiscal f 
                                Where  f.CodPais = @CodPais and f.Dealer = @Dealer and f.Tda = @Tda and f.Proveedor = @Proveedor and f.Serie = @Serie and  f.Comprobante = @Comprobante";
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
                    cmd.Parameters.Add("@FechaModificacion", System.Data.SqlDbType.DateTime).Value = DateTime.Now;
                    cmd.Parameters.Add("@FechaRespuesta", System.Data.SqlDbType.DateTime).Value = modelo.FechaRespuesta;
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
        public void escribirRespuestaTablaRiInvalidacion(RetencionIvaCorrFiscalModel modelo)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(ConexionDB.instancia.getString()))
                {
                    string q = @"UPDATE f
                                    set SelloInvalidacion = @SelloInvalidacion,
                                        FechaInvalidacion = @FechaInvalidacion
                                from RetencionIVACorrFiscal f 
                                Where  f.CodPais = @CodPais and f.Dealer = @Dealer and f.Tda = @Tda and f.Proveedor = @Proveedor and f.Serie = @Serie and  f.Comprobante = @Comprobante";
                    SqlCommand cmd = new SqlCommand(q, cn);
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandTimeout = 9999;
                    cmd.Parameters.Add("@CodPais", System.Data.SqlDbType.Char, 3).Value = modelo.CodPais;
                    cmd.Parameters.Add("@Dealer", System.Data.SqlDbType.Int).Value = modelo.Dealer;
                    cmd.Parameters.Add("@Tda", System.Data.SqlDbType.Char, 3).Value = modelo.Tda;
                    cmd.Parameters.Add("@Proveedor", System.Data.SqlDbType.Char, 14).Value = modelo.Proveedor;
                    cmd.Parameters.Add("@Serie", System.Data.SqlDbType.Char, 10).Value = modelo.Serie;
                    cmd.Parameters.Add("@Comprobante", System.Data.SqlDbType.Int).Value = modelo.Comprobante;
                    cmd.Parameters.Add("@SelloInvalidacion", System.Data.SqlDbType.NVarChar, 100).Value = modelo.SelloInvalidacion;
                    cmd.Parameters.Add("@FechaInvalidacion", System.Data.SqlDbType.DateTime).Value = modelo.FechaInvalidacion;
                    cn.Open();
                    cmd.ExecuteNonQuery();
                    cn.Close();
                }
            }
            catch (Exception ex)
            {

                throw new Exception("Error en PrincipalLogica(escribirRespuestaTablaRiInvalidacion): " + ex.Message, ex.InnerException);
            }
        }
        public void escribirRespuestaTablaCo(CompraCorrFiscalModel modelo)
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
                                        FechaModificacion = @FechaModificacion,
                                        FechaRespuesta = @FechaRespuesta
                                from CompraCorrFiscal f 
                                Where  f.CodPais = @CodPais and f.Dealer = @Dealer and f.Tda = @Tda and  f.CompraNo = @CompraNo";
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
                    cmd.Parameters.Add("@FechaModificacion", System.Data.SqlDbType.DateTime).Value = DateTime.Now;
                    cmd.Parameters.Add("@FechaRespuesta", System.Data.SqlDbType.DateTime).Value = modelo.FechaRespuesta;
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
        public void escribirRespuestaTablaCoInvalidacion(CompraCorrFiscalModel modelo)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(ConexionDB.instancia.getString()))
                {
                    string q = @"UPDATE f
                                    set SelloInvalidacion = @SelloInvalidacion,
                                        FechaInvalidacion = @FechaInvalidacion
                                from CompraCorrFiscal f 
                                Where  f.CodPais = @CodPais and f.Dealer = @Dealer and f.Tda = @Tda and  f.CompraNo = @CompraNo";
                    SqlCommand cmd = new SqlCommand(q, cn);
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandTimeout = 9999;
                    cmd.Parameters.Add("@CodPais", System.Data.SqlDbType.Char, 3).Value = modelo.CodPais;
                    cmd.Parameters.Add("@Dealer", System.Data.SqlDbType.Int).Value = modelo.Dealer;
                    cmd.Parameters.Add("@Tda", System.Data.SqlDbType.Char, 3).Value = modelo.Tda;
                    cmd.Parameters.Add("@CompraNo", System.Data.SqlDbType.Int).Value = modelo.CompraNo;
                    cmd.Parameters.Add("@SelloInvalidacion", System.Data.SqlDbType.NVarChar,100).Value = modelo.SelloInvalidacion;
                    cmd.Parameters.Add("@FechaInvalidacion", System.Data.SqlDbType.DateTime).Value = modelo.FechaInvalidacion;
                    
                    cn.Open();
                    cmd.ExecuteNonQuery();
                    cn.Close();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error en PrincipalLogica(escribirRespuestaTablaCoInvalidacion): " + ex.Message, ex.InnerException);
            }
        }
        public void escribirRespuestaTablaCoCC(ComprasChicaCorrFiscalModel modelo)
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
                                        FechaModificacion = @FechaModificacion,
                                        FechaRespuesta = @FechaRespuesta
                                from ComprasChicaCorrFiscal f 
                                Where  f.CodPais = @CodPais and f.Dealer = @Dealer and f.Tda = @Tda and  f.CompraNo = @CompraNo";
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
                    cmd.Parameters.Add("@FechaModificacion", System.Data.SqlDbType.DateTime).Value = DateTime.Now;
                    cmd.Parameters.Add("@FechaRespuesta", System.Data.SqlDbType.DateTime).Value = modelo.FechaRespuesta;
                    cn.Open();
                    cmd.ExecuteNonQuery();
                    cn.Close();
                }
            }
            catch (Exception ex)
            {

                throw new Exception("Error en PrincipalLogica(escribirRespuestaTablaCoCC): " + ex.Message, ex.InnerException);
            }
        }
        public void escribirRespuestaTablaCoCCInvalidacion(ComprasChicaCorrFiscalModel modelo)
        {
            try
            {

                using (SqlConnection cn = new SqlConnection(ConexionDB.instancia.getString()))
                {
                    string q = @"UPDATE f
                                     set SelloInvalidacion = @SelloInvalidacion,
                                         FechaInvalidacion = @FechaInvalidacion
                                from ComprasChicaCorrFiscal f 
                                Where  f.CodPais = @CodPais and f.Dealer = @Dealer and f.Tda = @Tda and  f.CompraNo = @CompraNo";
                    SqlCommand cmd = new SqlCommand(q, cn);
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandTimeout = 9999;
                    cmd.Parameters.Add("@CodPais", System.Data.SqlDbType.Char, 3).Value = modelo.CodPais;
                    cmd.Parameters.Add("@Dealer", System.Data.SqlDbType.Int).Value = modelo.Dealer;
                    cmd.Parameters.Add("@Tda", System.Data.SqlDbType.Char, 3).Value = modelo.Tda;
                    cmd.Parameters.Add("@CompraNo", System.Data.SqlDbType.Int).Value = modelo.CompraNo;
                    cmd.Parameters.Add("@SelloInvalidacion", System.Data.SqlDbType.NVarChar, 100).Value = modelo.SelloInvalidacion;
                    cmd.Parameters.Add("@FechaInvalidacion", System.Data.SqlDbType.DateTime).Value = modelo.FechaInvalidacion;

                    cn.Open();
                    cmd.ExecuteNonQuery();
                    cn.Close();
                }
            }
            catch (Exception ex)
            {

                throw new Exception("Error en PrincipalLogica(escribirRespuestaTablaCoCCInvalidacion): " + ex.Message, ex.InnerException);
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
                    string q = @"SELECT TOP 100 Id, Fecha, Tipo, Mensaje, XMLResponse FROM FELCOMLogs Order By Id desc";
                    SqlCommand cmd = new SqlCommand(q, cn);

                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandTimeout = 9999;
                    SqlDataReader leer;
                    cn.Open();
                    leer = cmd.ExecuteReader();
                    List<Logs> logs = new List<Logs>();
                    while (leer.Read())
                    {
                        logs.Add(new Logs { Id = Convert.ToInt32(leer[0]), Fecha = Convert.ToDateTime(leer[1]), Tipo = Convert.ToString(leer[2]), Mensaje = Convert.ToString(leer[3]), XMLResponse = Convert.ToString(leer[4]) });
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
                    string q = @"insert into  FELCOMLogs (Fecha, Tipo, Mensaje, XMLResponse) values(getdate(), @Tipo, @Mensaje, @XMLResponse) ";
                    SqlCommand cmd = new SqlCommand(q, cn);

                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.Parameters.Add("@Tipo", System.Data.SqlDbType.NVarChar, 10).Value = modelo.Tipo;
                    cmd.Parameters.Add("@Mensaje", System.Data.SqlDbType.NVarChar).Value = modelo.Mensaje;
                    cmd.Parameters.Add("@XMLResponse", System.Data.SqlDbType.NVarChar).Value = modelo.XMLResponse;
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
        //public dt xDevFac (string CodPais, int Dealer, string Tda, string TipoDoc, string Serie, int DocNo)
        //{
        //    SqlConnection cn = new SqlConnection(Properties.Settings.Default.cString);
        //    try
        //    {
        //        dtDevolucionFacturaDataTable dato = new dtDevolucionFacturaDataTable();
               
        //        string q = @"select CONCAT(rtrim(f.ClienteNo), ', ', rtrim(f.FactNombre)) eCliente, rtrim(upper(f.FactDireccion)) eDireccion, rtrim(upper(f.FactDepartamento)) eDepartamento, rtrim(upper(f.FactMunicipio)) eMunicipio,
        //                        rtrim(s.Nombre) eSucursal, f.FactDUI eDUI, f.FactNIT eNIT, f.FactNoRegistro eNRC, rtrim(upper(f.FactGiro))  eGiroNegocio, 
        //                        case when (f.FormaPago = 1 and f.Dias = 0) then 'CONTRA ENTREGA' when (f.FormaPago = 1 and f.Dias > 0) then CONCAT('CRÉDITO ', F.Dias, ' DÍA(S)')  when (f.FormaPago = 0) then 'CONTADO' end eCondicionPago,
        //                        format(f.Fecha,'dd/MM/yyyy') eFechaEmision, f.PedidoNo ePedido, concat(rtrim(f.Bodega),' ', rtrim(b.Descripcion)) eBodega, rtrim(v.Nombre) eVendedor, f.MotivoDevolucion eMotivoAnulacion, CONCAT(f.TipoDoc, ' ', rtrim(f.Serie), ' ', f.DocNo ) eDocAfectado, 
        //                        f.IdTrans eIdTrans, CONCAT( rtrim(f.Serie), ' ', f.DocNo ) eDocumento, f.TipoDoc eTipoDoc, dbo.NumerosALetras(f.Total) eValorLetras, f.Subtotal eSumas, f.Descuento eDescuento, f.Gravadas eSubTotal,  f.NoSujetas eVentaNoSujeta,
        //                        f.Exentas eVentasExentas, f.Total eVentaTotal, f.FactDUI eDUI, d.Cantidad dCantidad, d.Codigo dCodigo, d.Descripción dDescripcion, d.PrecioUnitario dPrecioUnitario, 0 dVentasNoSujetas, 0 dVentaExentas, d.Importe dVentasGravadas, de.Nombre deNombreEmpresa, 
        //                        de.Giro deGiro, de.Direccion deDireccion, replace(de.Logo,'C:\MagicXPA25\ArchivosL\','\\192.168.0.149\MagicXPA25\ARCHIVOSL\') deLogo, de.NIT deNIT, de.NRC deNRC 
        //                        from FacturaDevolucion f inner join DetFacturaDevolucion d on f.CodPais = d.CodPais and f.Dealer = d.Dealer and f.Tda = d.Tda and f.Serie = d.Serie and f.TipoDoc = d.Tipodoc and f.DocNo = d.DocNo
						  //                               inner join Dealer de on de.CodPais = f.CodPais and de.Codigo = f.Dealer
						  //                               inner join Cliente cl on cl.CodPais = f.CodPais and cl.Dealer = f.Dealer and cl.ClienteNo = f.ClienteNo
						  //                               left join Sucursal s on s.CodPais = f.CodPais and s.Dealer = f.Dealer and s.Sucursal = f.Tda 
						  //                               left join Bodega b on b.CodPais = f.CodPais and b.Dealer = f.Dealer and b.Bodega = f.Bodega
						  //                               left join Vendedor v on v.CodPais = f.CodPais and v.Dealer = f.Dealer and v.Vendedor = f.Vendedor
        //                        where f.CodPais = @CodPais and f.Dealer = @Dealer and f.Tda = @Tda and f.Serie = @Serie and f.TipoDoc =@TipoDoc and f.DocNo = @DocNo";
        //        SqlCommand cmd = new SqlCommand(q, cn);
        //        cmd.CommandType = CommandType.Text;
        //        cmd.Parameters.Add("@CodPais", SqlDbType.Char, 3).Value = CodPais;
        //        cmd.Parameters.Add("@Dealer", SqlDbType.Int).Value = Dealer;
        //        cmd.Parameters.Add("@Tda", SqlDbType.Char, 7).Value = Tda;
        //        cmd.Parameters.Add("@Serie", SqlDbType.Char, 15).Value = Serie;
        //        cmd.Parameters.Add("@TipoDoc", SqlDbType.Char, 2).Value = TipoDoc;
        //        cmd.Parameters.Add("@DocNo", SqlDbType.Int).Value = DocNo;

        //        SqlDataReader leer;
        //        if(cn.State == ConnectionState.Closed)
        //        {
        //            cn.Open();
        //        }
        //        DataRow dr;
        //        leer = cmd.ExecuteReader();
        //        while (leer.Read())
        //        {
        //            dr = dato.NewRow();
        //            dr[0] = Convert.ToString(leer[0]);
        //            dr[1] = Convert.ToString(leer[1]);
        //            dr[2] = Convert.ToString(leer[2]);
        //            dr[3] = Convert.ToString(leer[3]);
        //            dr[4] = Convert.ToString(leer[4]);
        //            dr[5] = Convert.ToString(leer[5]);
        //            dr[6] = Convert.ToString(leer[6]);
        //            dr[7] = Convert.ToString(leer[7]);
        //            dr[8] = Convert.ToString(leer[8]);
        //            dr[9] = Convert.ToString(leer[9]);
        //            dr[10] = Convert.ToDateTime(leer[10]);
        //            dr[11] = Convert.ToString(leer[11]);
        //            dr[12] = Convert.ToString(leer[12]);
        //            dr[13] = Convert.ToString(leer[13]);
        //            dr[14] = Convert.ToString(leer[14]);
        //            dr[15] = Convert.ToString(leer[15]);
        //            dr[16] = Convert.ToString(leer[16]);
        //            dr[17] = Convert.ToString(leer[17]);
        //            dr[18] = Convert.ToString(leer[18]);
        //            dr[19] = Convert.ToString(leer[19]);
        //            dr[20] = Convert.ToDouble(leer[20]);
        //            dr[21] = Convert.ToDouble(leer[21]);
        //            dr[22] = Convert.ToDouble(leer[22]);
        //            dr[23] = Convert.ToDouble(leer[23]);
        //            dr[24] = Convert.ToDouble(leer[24]);
        //            dr[25] = Convert.ToDouble(leer[25]);
        //            //dr[26] = Convert.ToDouble(leer[26]);
        //            dr[27] = Convert.ToString(leer[27]);
        //            dr[28] = Convert.ToString(leer[28]);
        //            //dr[29] = Convert.ToDouble(leer[29]);
        //            dr[30] = Convert.ToDouble(leer[30]);
        //            dr[31] = Convert.ToDouble(leer[31]);
        //            dr[32] = Convert.ToDouble(leer[32]);
        //            dr[33] = Convert.ToString(leer[33]);
        //            dr[34] = Convert.ToString(leer[34]);
        //            dr[35] = Convert.ToString(leer[35]);
        //            dr[36] = Convert.ToString(leer[36]);
        //            dr[37] = Convert.ToString(leer[37]);
        //            dr[38] = Convert.ToString(leer[38]);
        //            dr[39] = Convert.ToString(leer[39]);
        //            dato.Rows.Add(dr);
        //        }

        //        if (cn.State == ConnectionState.Open)
        //        {
        //            cn.Close();
        //        }
        //        return dato;
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception(ex.Message, ex.InnerException);
        //    }
        //    finally 
        //    { 
        //        if(cn.State == ConnectionState.Open)
        //        {
        //            cn.Close();
        //        }
              
        //    }
        //}
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
            public DateTime? FechaRespuesta { get; set; }
            public string SelloInvalidacion { get; set; }
            public DateTime? FechaInvalidacion { get; set; }
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
            public DateTime? FechaRespuesta { get; set; }
            public string SelloInvalidacion { get; set; }
            public DateTime? FechaInvalidacion { get; set; }
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
            public DateTime? FechaRespuesta { get; set; }
            public string SelloInvalidacion { get; set; }
            public DateTime? FechaInvalidacion { get; set; }
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
            public DateTime? FechaRespuesta { get; set; }
            public string SelloInvalidacion { get; set; }
            public DateTime? FechaInvalidacion { get; set; }
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
            public DateTime? FechaRespuesta { get; set; }
            public string SelloInvalidacion { get; set; }
            public DateTime? FechaInvalidacion { get; set; }
        }
        public class ComprasChicaCorrFiscalModel
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
            public DateTime? FechaRespuesta { get; set; }
            public string SelloInvalidacion { get; set; }
            public DateTime? FechaInvalidacion { get; set; }
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
            public string XMLResponse { get; set; }
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
