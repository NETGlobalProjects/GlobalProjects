using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ArchivadorFEL.Datos
{
    public class Conexion
    {
        public string Usuario { get; set; }
        private static Conexion _instancia = null;
        public Conexion() { }
        private string cnString = @"Data Source = 192.168.0.227\WMS; Initial Catalog=NETDATA; User Id=userNETApps; Password=Gum@2019;";
        private string cnStringInventario = @"Data Source = 192.168.0.227\WMS; Initial Catalog=INVENTARIO; User Id=userNETApps; Password=Gum@2019;";

        public static Conexion instancia 
        {
            get
            {
                if (_instancia == null)
                {
                    _instancia = new Conexion();

                }
                return _instancia;
            }
        }
        public string getCnString()
        {
            try
            {
                return cnString;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message + " " + ex.InnerException);
            }
        }
        public string getCnStringInventario()
        {
            try
            {
                return cnStringInventario;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message + " " + ex.InnerException);
            }
        }
    }
}
