using System;
using System.Collections.Generic;
using System.Text;

namespace AppWDS.Modelos
{
   public class Usuarios
    {
        public int usu_id { get; set; }
        public int? dep_id { get; set; }
        public int? car_id { get; set; }
        public int? est_id { get; set; }
        public string usu_username { get; set; }
        public string usu_password { get; set; }
        public string usu_nombres { get; set; }
        public string usu_apellidos { get; set; }
        public string usu_genero { get; set; }
        public string usu_correo { get; set; }
        public string usu_telefono { get; set; }
        public string usu_id_nomina { get; set; }
        public string usu_direccion { get; set; }
        public DateTime? usu_fecha_registro { get; set; }
        public DateTime? usu_fecha_nacimiento { get; set; }
        public DateTime? usu_ultima_conexion { get; set; }
        public int? usu_cambiar_pass { get; set; }
        public bool? es_mecanico { get; set; }
    }
}
