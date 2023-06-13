using System;
using System.Collections.Generic;
using System.Text;

namespace AppWDS.Modelos
{
    public class Inventarios
    {
        public string inv_id { get; set; }
        public string inv_descripcion { get; set; }
        public string inv_descripcion_larga { get; set; }
        public string inv_estado { get; set; }
        public bool inv_maneja_existencias { get; set; }
        public double inv_peso { get; set; }
        public int inv_unidad_presentacion { get; set; }
        public object inv_otros_datos { get; set; }
        public string uni_id { get; set; }
        public string uni_descripcion { get; set; }
    }
}
