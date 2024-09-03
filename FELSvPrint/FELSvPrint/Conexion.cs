using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FELSvPrint
{
    public class Conexion
    {
        private static Conexion _instancia = null;
        private string cnString = @"Data Source= 192.168.0.227\WMS; Initial Catalog=NETDATA; User Id=userNETApps; Password=Gum@2019;";
        public Conexion() { }
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
        public string getCnsString()
        {
            return cnString;
        }
    }
}
