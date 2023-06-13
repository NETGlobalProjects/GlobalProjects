using System;
using System.Collections.Generic;
using System.Text;

namespace AppWDS.Modelos
{
    public class Tablero
    {
        public int usu_id { get; set; }
        public int t_ord_ejecusion { get; set; }
        public int t_creadas_hoy { get; set; }
        public int t_creadas_anio { get; set; }
        public int t_asignadas_hoy { get; set; }
        public int t_asingadas_anio { get; set; }
        public int t_asignar_hoy { get; set; }
        public int t_asignar_anio { get; set; }
        public int t_historial_hoy { get; set; }
        public int t_historial_anio { get; set; }
    }
}
