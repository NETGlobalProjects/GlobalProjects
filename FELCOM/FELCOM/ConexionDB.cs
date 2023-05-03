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
        SqlConnection cn = new SqlConnection("Data Source=192.168.0.148\\NETDATASQL;Initial Catalog=NDTEST;User ID=sa;Password=Fresasc0ncrema;MultipleActiveResultSets=True;Connect Timeout=100;Encrypt=False;Application Name=FELCOM;Current Language=spanish");
        public string getString()
        {
            return cn.ConnectionString;
        }
      

    }
}
