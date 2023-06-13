using System;
using System.Collections.Generic;
using System.Text;

namespace AppWDS.Modelos
{
   public class UsuarioEmpresa
    {
        public int pai_id { get; set; }
        public int emp_id { get; set; }
        public int usu_id { get; set; }
        public string suc_id { get; set; }
        public string suc_nombre { get; set; }
        public string bod_id { get; set; }
        public string bod_descripcion { get; set; }
        public int pla_id { get; set; }
        public string pla_descripcion { get; set; }
    }
}
