using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FELCOM.Modelo
{
    public class responseGetPDF
    {
        public string ReturnCode { get; set; }
        public string ReturnMessage { get; set; }
        public string ReturnURL { get; set; }
        public string ReturnBase64 { get; set; }
        public string ReturnDateTime { get; set; }
    }
}
