using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FELCOM.Modelo
{
    public class responseProcesarTextoPlano
    {
        public string ReturnCode { get; set; }
        public string ReturnFolio { get; set; }
        public string ReturnMessage { get; set; }
        public string ReturnUUID { get; set; }
        public string ReturnNumValidacion { get; set; }
        public string ReturnDateTime { get; set; }
        public string PDF { get; set; }
    }
}
