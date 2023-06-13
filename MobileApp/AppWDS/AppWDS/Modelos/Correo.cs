using System;
using System.Collections.Generic;
using System.Text;

namespace AppWDS.Modelos
{
    public class Correo
    {
        public string para { get; set; }
        public string copiar_a { get; set; }
        public string adjuntos { get; set; }
        public string asunto { get; set; }
        public string cuerpo { get; set; }
    }
}

