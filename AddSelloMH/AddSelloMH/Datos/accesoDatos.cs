using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;

namespace AddSelloMH.Datos
{
    public class accesoDatos
    {
        private static accesoDatos _instancia;
        private NETDATAEntities db;
        public accesoDatos()
        {
        }
        public static accesoDatos instancia
        {
            get
            {
                if (_instancia == null)
                {
                    _instancia = new accesoDatos();
                }
                return _instancia;
            }
        }
        public List<vFELSV> getPendientes(DateTime desde, DateTime hasta) 
        {
            try
            {
                db = new NETDATAEntities();
                List<vFELSV> datos = new List<vFELSV>();
                datos = db.vFELSV.Where(a=>a.Fecha>= desde.Date && a.Fecha<= hasta.Date && a.SelloRecibido.Trim() == "").ToList();
                return datos;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener pendientes: " + ex.Message, ex.InnerException);
            }
        }
        public List<WSRequest> wsRequestList (string codpais, int dealer)
        {
            try
            {
                db = new NETDATAEntities();
                var datos = db.WSRequest.Where(a=>a.CodPais == codpais && a.Dealer == dealer).ToList();
                return datos;
            }
            catch (Exception ex)
            {

                throw new Exception("Error al obtener wsRequestList: " + ex.Message + " " +  ex.InnerException);
            }
        }
        public List<WebService> webServiceList(string codpais, int dealer)
        {
            try
            {
                db = new NETDATAEntities();
                var datos = db.WebService.Where(a => a.CodPais == codpais && a.Dealer == dealer).ToList();
                return datos;
            }
            catch (Exception ex)
            {

                throw new Exception("Error al obtener webServiceList: " + ex.Message + " " + ex.InnerException);
            }
        }
        public bool guardarFELSVResponse(FELSVResponse dato) 
        {
            try
            {
                db = new NETDATAEntities();


                var existe = db.FELSVResponse.Where(a => a.CodPais == dato.CodPais && a.Dealer == dato.Dealer && a.Tda == dato.Tda && a.Serie == dato.Serie && a.TipoDoc == dato.TipoDoc && a.DocNo == dato.DocNo).SingleOrDefault();
                if(existe == null)
                {
                    db.FELSVResponse.Add(dato);
                    db.SaveChanges();
                }
              
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener guardarFELSVResponse: " + ex.Message + " " + ex.InnerException);
            }
        
        }
        public bool actualizarSelloFELSV()
        {
            SqlConnection cn = new SqlConnection(Conexion.instancia.getCnString());
            try
            {
                SqlCommand cmd = new SqlCommand("Proc_ActualizaSelloFELSV", cn);
                cmd.CommandTimeout = 999;
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();
                return true;
            }
           
            catch (Exception ex)
            {
                throw new Exception("Error al obtener actualizarSelloFELSV: " + ex.Message + " " + ex.InnerException);
            }
            finally
            {
                if(cn.State == System.Data.ConnectionState.Open)
                {
                    cn.Close();
                }
            }
        }
    }
}
