using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FELCOM
{
    public class ConexionDB
    {
        private static ConexionDB _instancia = null;
        public ConexionDB() { 
        
        }
        public static ConexionDB instancia
        {
            get {
                if(_instancia == null)
                {
                    _instancia= new ConexionDB();
                }
                return _instancia;
            }

        }
        SqlConnection cn = new SqlConnection(Properties.Settings.Default.cString);
        public string getString()
        {
            return cn.ConnectionString;
        }
      

    }
}
