using System;
using System.Collections.Generic;
using System.Text;

namespace AppWDS.Modelos
{
 public   class OrdenManttoEnc
    {
        public int pai_id { get; set; }
        public int emp_id { get; set; }
        public int ord_id { get; set; }
        public int tio_id { get; set; }
        public object pla_id { get; set; }
        public int are_id { get; set; }
        public int sba_id { get; set; }
        public int pri_id { get; set; }
        public string maq_id { get; set; }
        public object mec_id_responsable { get; set; }
        public int oes_id { get; set; }
        public int usu_id_crea { get; set; }
        public object usu_id_modifica { get; set; }
        public DateTime? ord_fecha_hora_creacion { get; set; }
        public object ord_fecha_hora_modificacion { get; set; }
        public object ord_fecha_programado { get; set; }
        public DateTime? ord_fecha_hora_inicio { get; set; }
        public DateTime? ord_fecha_hora_fin { get; set; }
        public string ord_descripcion { get; set; }
        public object ord_horas_hombre_estimada { get; set; }
        public object ord_fecha_hora_cierre_orden { get; set; }
        public object ord_calificacion { get; set; }
        public string ord_comentarios_cierre { get; set; }
        public object ord_id_padre { get; set; }
        public object ord_descripcion_falla { get; set; }
        public object ord_causa_falla { get; set; }
        public object ord_accion_correctiva { get; set; }
        public object ord_fecha_hora_peticion_materiales { get; set; }
        public DateTime? ord_fecha_hora_entrega_materiales { get; set; }
        public int cda_id { get; set; }
        public string ord_comentarios_mecanico { get; set; }
    }
}
