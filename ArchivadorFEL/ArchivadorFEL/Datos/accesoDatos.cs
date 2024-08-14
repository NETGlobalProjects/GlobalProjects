using ArchivadorFEL.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Drawing.Imaging;
using System.ComponentModel;
using System.Data;
namespace ArchivadorFEL.Datos
{
    public class accesoDatos
    {
        private static accesoDatos _instancia = null;
        public accesoDatos() { }
        public static accesoDatos instancia
        {
            get
            {
                if (_instancia == null)
                {
                    _instancia = new accesoDatos();
                }
                return _instancia;
            }
        }
        public List<DealersModel> getDealers()
        {
            SqlConnection cn = new SqlConnection(Conexion.instancia.getCnString());
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT CodPais, Codigo, Nombre FROM Dealer", cn);
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandTimeout = 999;
                SqlDataReader leer;
                List<DealersModel> listaEmpresas = new List<DealersModel>();
                cn.Open();
                leer = cmd.ExecuteReader();
                while (leer.Read()) 
                {
                    listaEmpresas.Add(new DealersModel { CodPais = Convert.ToString(leer["CodPais"]), Dealer = Convert.ToInt32(leer["Codigo"]), Nombre = Convert.ToString(leer["Nombre"])});
                }
                cn.Close();
                return listaEmpresas;
            
            }
            catch (Exception ex)
            {

                throw new Exception("Error al obtener dealers: " + ex.Message + " " + ex.InnerException);
            }
            finally
            {
                if(cn.State == System.Data.ConnectionState.Open)
                {
                    cn.Close();
                }
            }
        }
        public List<SucursalesModel> getSucursales(string CodPais, int Dealer)
        {
            SqlConnection cn = new SqlConnection(Conexion.instancia.getCnString());
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT CodPais, Dealer,Sucursal, Nombre FROM Sucursal where CodPais = '"+CodPais+"' and Dealer = "+ Dealer.ToString()+"", cn);
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandTimeout = 999;
                SqlDataReader leer;
                List<SucursalesModel> lista = new List<SucursalesModel>();
                cn.Open();
                leer = cmd.ExecuteReader();
                while (leer.Read())
                {
                    lista.Add(new SucursalesModel { CodPais = Convert.ToString(leer["CodPais"]), Dealer = Convert.ToInt32(leer["Dealer"]),Sucursal = Convert.ToString(leer["Sucursal"]), Nombre = Convert.ToString(leer["Nombre"]) });
                }
                cn.Close();

                return lista;

            }
            catch (Exception ex)
            {

                throw new Exception("Error al obtener sucursales: " + ex.Message + " " + ex.InnerException);
            }
            finally
            {
                if (cn.State == System.Data.ConnectionState.Open)
                {
                    cn.Close();
                }
            }
        }
        public List<datosFELArchivadorModel> getDatosFElArchivador(DateTime desde, DateTime hasta, bool porEmpresa,bool porSucursal, int? empresa = null, string sucursal = null)
        {
            SqlConnection cn = new SqlConnection(Conexion.instancia.getCnString());
            try
            {
                string cmdString = @"select [CodPais], [Dealer], rtrim([nombreCortoEmpresa]) nombreCortoEmpresa, [Sucursal], [Anio], [Mes], [Fecha], [CodigoGeneracion], [TipoDoc], [Tipo], [dia], [completoRutaDestino], [Serie], [DocNo]
                                    from vDatosFELArchivador f
                                    where f.Fecha between @desde and @hasta";
                if (porEmpresa)
                {
                    cmdString += " and Dealer = @dealer";
                }
                if (porSucursal)
                {
                    cmdString += " and Tda = @tda";
                }

                SqlCommand cmd = new SqlCommand(cmdString, cn);
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandTimeout = 999;
                cmd.Parameters.Add("@desde", System.Data.SqlDbType.DateTime).Value = desde;
                cmd.Parameters.Add("@hasta", System.Data.SqlDbType.DateTime).Value = hasta;
                if (porEmpresa)
                {
                    cmd.Parameters.Add("@dealer", System.Data.SqlDbType.Int).Value = empresa;
                }
                if (porSucursal)
                {
                    cmd.Parameters.Add("@tda", System.Data.SqlDbType.Char, 7).Value = sucursal;
                }
                List<datosFELArchivadorModel> datos = new List<datosFELArchivadorModel>();
                SqlDataReader leer;
                cn.Open();
                leer = cmd.ExecuteReader();
                while (leer.Read())
                {
                    datos.Add(new datosFELArchivadorModel
                    {
                    CodPais = Convert.ToString( leer["CodPais"]),
                    Dealer = Convert.ToInt32(leer["Dealer"]),
                    nombreCortoEmpresa = Convert.ToString(leer["nombreCortoEmpresa"]),
                    Surursal  = Convert.ToString(leer["Sucursal"]),
                    Anio = Convert.ToInt32(leer["Anio"]),
                    Mes = Convert.ToString(leer["Mes"]),
                    Fecha = Convert.ToDateTime(leer["Fecha"]),
                    CodigoGeneracion  = Convert.ToString(leer["CodigoGeneracion"]),
                    TipoDoc = Convert.ToString(leer["TipoDoc"]),
                    Tipo = Convert.ToString(leer["Tipo"]),
                    dia = Convert.ToString(leer["dia"]),
                    completoRutaDestino = Convert.ToString(leer["completoRutaDestino"]),
                    Serie = Convert.ToString(leer["Serie"]),
                    DocNo = Convert.ToInt32(leer["DocNo"])
                    });
                }
                cn.Close();

                return datos;

            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener datos FEL: " + ex.Message + " "+ ex.InnerException);
            }
            finally
            {
                if (cn.State == System.Data.ConnectionState.Open)
                {
                    cn.Close();
                }
            }
        }
        public int validarLogin(string Usuario, string Contraseña)
        {
            SqlConnection cn = new SqlConnection(Conexion.instancia.getCnStringInventario());
            try
            {
                SqlCommand cmd = new SqlCommand(@"select (select count(*) from tbSeguridad s where s.Usuario = @Usuario and s.Contraseña = @Contraseña and s.accesoArchivador = 1) tieneAcceso", cn);
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandTimeout = 999;
                cmd.Parameters.Add("@Usuario", System.Data.SqlDbType.VarChar, 50).Value = Usuario;
                cmd.Parameters.Add("@Contraseña", System.Data.SqlDbType.VarChar, 50).Value = Contraseña;
                int resultado = 0;
                SqlDataReader leer;
                cn.Open();
                leer = cmd.ExecuteReader();
                while (leer.Read())
                {
                    resultado = (int)leer["tieneAcceso"];
                }
                cn.Close();

                return resultado;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al validar login: " + ex.Message + " " + ex.InnerException);
            }
            finally
            {
                if (cn.State == System.Data.ConnectionState.Open)
                {
                    cn.Close();
                }
            }
        }
        public bool registrarAuditoriaTabla(string Usuario, string Accion, string Detalle)
        {
            SqlConnection cn = new SqlConnection(Conexion.instancia.getCnString());
            try
            {
                SqlCommand cmd = new SqlCommand(@"insert into LogsAdminTool([Fecha], [Hora], [Usuario], [Accion], [Detalle], [Dealer], [CodPais]) values(convert(date, GETDATE()), convert(time, GETDATE()), @Usuario, @Accion, @Detalle, 0, 'SAL')", cn);
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandTimeout = 999;
                cmd.Parameters.Add("@Usuario", System.Data.SqlDbType.Char, 20).Value = Usuario;
                cmd.Parameters.Add("@Accion", System.Data.SqlDbType.Char, 50).Value = Accion;
                cmd.Parameters.Add("@Detalle", System.Data.SqlDbType.Char, 1000).Value = Detalle;
                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();
                return true;
            
            }
            catch (Exception ex)
            {

                throw new Exception("Error al registrar auditoria: " + ex.Message + " " + ex.InnerException);
            }
            finally
            {
                if (cn.State == System.Data.ConnectionState.Open)
                {
                    cn.Close();
                }
            }
        }
        public DataTable ToDataTable<T>(IList<T> data)
        {
            PropertyDescriptorCollection props =
                TypeDescriptor.GetProperties(typeof(T));
            DataTable table = new DataTable();
            for (int i = 0; i < props.Count; i++)
            {
                PropertyDescriptor prop = props[i];
                table.Columns.Add(prop.Name, prop.PropertyType);
            }
            object[] values = new object[props.Count];
            foreach (T item in data)
            {
                for (int i = 0; i < values.Length; i++)
                {
                    values[i] = props[i].GetValue(item);
                }
                table.Rows.Add(values);
            }
            return table;
        }
    }
}
