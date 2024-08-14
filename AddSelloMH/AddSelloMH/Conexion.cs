using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddSelloMH
{
    public class Conexion
    {
        public string cnString { get; set; }
        private static Conexion _instancia;
        public Conexion(){}
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
            return cnString;
        }
    }
}
