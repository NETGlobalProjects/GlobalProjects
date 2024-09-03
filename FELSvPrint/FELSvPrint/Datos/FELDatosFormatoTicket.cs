using FELSvPrint.Modelos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;


namespace FELSvPrint.Datos
{
    public class FELDatosFormatoTicket
    {
        private static FELDatosFormatoTicket _instancia = null;
        public FELDatosFormatoTicket() { }

        public static FELDatosFormatoTicket instancia
        {
            get
            {
                if (_instancia == null)
                {
                    _instancia = new FELDatosFormatoTicket();
                }
                return _instancia;
            }
        }

        public List<FELDatosFormatoTicketDetModel> getFELDatosFormatoTicketDet(string CodPais, int Dealer, string Tda, string TipoDoc, string Serie, int DocNo)
        {
            var productos = new List<FELDatosFormatoTicketDetModel>();

            string query = @"
            SELECT 
                CodPais,
                Dealer,
                Tda,
                TipoDoc,
                Serie,
                DocNo,
                tipo,
                Codigo,
                Cantidad,
                PrecioUnitario,
                Importe,
                Descripción,
                Unidad
            FROM 
                vFELDatosFormatoTicketDet
            where
                 CodPais = @CodPais
                 and Dealer = @Dealer
                 and Tda = @Tda
                 and TipoDoc = @TipoDoc
                 and Serie = @Serie
                 and DocNo = @DocNo";

            using (SqlConnection connection = new SqlConnection(Conexion.instancia.getCnsString()))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.CommandType = System.Data.CommandType.Text;
                command.CommandTimeout = 999;
                command.Parameters.Add("@CodPais", System.Data.SqlDbType.Char, 3).Value = CodPais;
                command.Parameters.Add("@Dealer", System.Data.SqlDbType.Int).Value = Dealer;
                command.Parameters.Add("@Tda", System.Data.SqlDbType.Char, 7).Value = Tda;
                command.Parameters.Add("@TipoDoc", System.Data.SqlDbType.Char, 2).Value = TipoDoc;
                command.Parameters.Add("@Serie", System.Data.SqlDbType.Char, 15).Value = Serie;
                command.Parameters.Add("@DocNo", System.Data.SqlDbType.Int).Value = DocNo;
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    var producto = new FELDatosFormatoTicketDetModel
                    {
                        CodPais = reader["CodPais"].ToString(),
                        Dealer = Convert.ToInt32(reader["Dealer"]),
                        Tda = reader["Tda"].ToString(),
                        TipoDoc = reader["TipoDoc"].ToString(),
                        Serie = reader["Serie"].ToString(),
                        DocNo = Convert.ToInt32(reader["DocNo"]),
                        Tipo = reader["tipo"].ToString(),
                        Codigo = reader["Codigo"].ToString(),
                        Cantidad = Convert.ToDecimal(reader["Cantidad"]),
                        PrecioUnitario = Convert.ToDecimal(reader["PrecioUnitario"]),
                        Importe = Convert.ToDecimal(reader["Importe"]),
                        Descripcion = reader["Descripción"].ToString(),
                        Unidad = reader["Unidad"].ToString(),
                        impresa = false
                    };

                    productos.Add(producto);
                }

                reader.Close();
            }

            return productos;
        }

        public List<FELDatosFormatoTicketModel> getFELDatosFormatoTicket(string filtradoPor, string placa = null, string consolidado = null, DateTime? fecha = null, string codigoGeneracion = null, string vendedor = null)
        {
            try
            {


                var tickets = new List<FELDatosFormatoTicketModel>();

                string query = @"
            SELECT 
                CodPais,
                Dealer,
                Tda,
                TipoDoc,
                Serie,
                DocNo,
                CodigoGeneracion,
                NumeroControl,
                SelloRecibido,
                documento,
                cajero,
                codigoQR,
                nombreTipoDoc,
                Fecha,
                IdTrans,
                emisorNombreRasonSocial,
                emisorSucursal,
                emisorNIT,
                emisorNRC,
                emisorGiroActividadEconomica,
                emisorDireccion,
                emisorTelefono,
                emisorCorreo,
                Departamento,
                Municipio,
                emisorVendedor,
                emisorBodega,
                emisorNotas,
                emisorFormaPago,
                emisorPedidoVta,
                receptorNombre,
                receptoRazonSocial,
                receptorNIT,
                receptorDUI,
                receptorNRC,
                receptorActivadEconomica,
                receptorDireccion,
                receptorTelefono,
                receptorCorreo,
                Placa,
                Consolidado,
                Orden,
                Gravadas,
                Subtotal,
                IVA,
                Descuento,
                Retencion,
                Percepcion,
                Total,
                NoSujetas,
                Exentas,
                totalLetras,
                PesoNeto,
                PesoBruto,
                OrdenCompra,
                Vendedor
            FROM 
                vFELDatosFormatoTicket
             WHERE ";

                if (filtradoPor == "LP")
                {
                    query += " Placa =  '" + placa + "' and Fecha = '" + fecha.Value.ToString("dd/MM/yyyy") + "' Order By Orden asc";
                }
                else if (filtradoPor == "LC")
                {
                    query += " Consolidado =  '" + consolidado + "' Order By Orden asc";
                }
                else if (filtradoPor == "LR")
                {
                    query += " Vendedor =  '" + vendedor + "' and Fecha = '" + fecha.Value.ToString("dd/MM/yyyy") + "' Order By Orden asc";
                }
                else if (filtradoPor == "I")
                {
                    query += " CodigoGeneracion = '" + codigoGeneracion + "'";
                }

                using (SqlConnection connection = new SqlConnection(Conexion.instancia.getCnsString()))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        var ticket = new FELDatosFormatoTicketModel();

                        ticket.CodPais = reader["CodPais"] != DBNull.Value ? reader["CodPais"].ToString() : string.Empty;
                        ticket.Dealer = reader["Dealer"] != DBNull.Value ? Convert.ToInt32(reader["Dealer"]) : 0;
                        ticket.Tda = reader["Tda"] != DBNull.Value ? reader["Tda"].ToString() : string.Empty;
                        ticket.TipoDoc = reader["TipoDoc"] != DBNull.Value ? reader["TipoDoc"].ToString() : string.Empty;
                        ticket.Serie = reader["Serie"] != DBNull.Value ? reader["Serie"].ToString() : string.Empty;
                        ticket.DocNo = reader["DocNo"] != DBNull.Value ? Convert.ToInt32(reader["DocNo"]) : 0;
                        ticket.CodigoGeneracion = reader["CodigoGeneracion"] != DBNull.Value ? reader["CodigoGeneracion"].ToString() : string.Empty;
                        ticket.NumeroControl = reader["NumeroControl"] != DBNull.Value ? reader["NumeroControl"].ToString() : string.Empty;
                        ticket.SelloRecibido = reader["SelloRecibido"] != DBNull.Value ? reader["SelloRecibido"].ToString() : string.Empty;
                        ticket.Documento = reader["documento"] != DBNull.Value ? reader["documento"].ToString() : string.Empty;
                        ticket.Cajero = reader["cajero"] != DBNull.Value ? reader["cajero"].ToString() : string.Empty;
                        ticket.CodigoQR = reader["codigoQR"] != DBNull.Value ? reader["codigoQR"].ToString() : string.Empty;
                        ticket.NombreTipoDoc = reader["nombreTipoDoc"] != DBNull.Value ? reader["nombreTipoDoc"].ToString() : string.Empty;
                        ticket.Fecha = reader["Fecha"] != DBNull.Value ? (DateTime)reader["Fecha"] : DateTime.MinValue;
                        ticket.IdTrans = reader["IdTrans"] != DBNull.Value ? reader["IdTrans"].ToString() : string.Empty;
                        ticket.EmisorNombreRazonSocial = reader["emisorNombreRasonSocial"] != DBNull.Value ? reader["emisorNombreRasonSocial"].ToString() : string.Empty;
                        ticket.EmisorSucursal = reader["emisorSucursal"] != DBNull.Value ? reader["emisorSucursal"].ToString() : string.Empty;
                        ticket.EmisorNIT = reader["emisorNIT"] != DBNull.Value ? reader["emisorNIT"].ToString() : string.Empty;
                        ticket.EmisorNRC = reader["emisorNRC"] != DBNull.Value ? reader["emisorNRC"].ToString() : string.Empty;
                        ticket.EmisorGiroActividadEconomica = reader["emisorGiroActividadEconomica"] != DBNull.Value ? reader["emisorGiroActividadEconomica"].ToString() : string.Empty;
                        ticket.EmisorDireccion = reader["emisorDireccion"] != DBNull.Value ? reader["emisorDireccion"].ToString() : string.Empty;
                        ticket.EmisorTelefono = reader["emisorTelefono"] != DBNull.Value ? reader["emisorTelefono"].ToString() : string.Empty;
                        ticket.EmisorCorreo = reader["emisorCorreo"] != DBNull.Value ? reader["emisorCorreo"].ToString() : string.Empty;
                        ticket.Departamento = reader["Departamento"] != DBNull.Value ? reader["Departamento"].ToString() : string.Empty;
                        ticket.Municipio = reader["Municipio"] != DBNull.Value ? reader["Municipio"].ToString() : string.Empty;
                        ticket.EmisorVendedor = reader["emisorVendedor"] != DBNull.Value ? reader["emisorVendedor"].ToString() : string.Empty;
                        ticket.EmisorBodega = reader["emisorBodega"] != DBNull.Value ? reader["emisorBodega"].ToString() : string.Empty;
                        ticket.EmisorNotas = reader["emisorNotas"] != DBNull.Value ? reader["emisorNotas"].ToString() : string.Empty;
                        ticket.EmisorFormaPago = reader["emisorFormaPago"] != DBNull.Value ? reader["emisorFormaPago"].ToString() : string.Empty;
                        ticket.EmisorPedidoVta = reader["emisorPedidoVta"] != DBNull.Value ? reader["emisorPedidoVta"].ToString() : string.Empty;
                        ticket.ReceptorNombre = reader["receptorNombre"] != DBNull.Value ? reader["receptorNombre"].ToString() : string.Empty;
                        ticket.ReceptorRazonSocial = reader["receptoRazonSocial"] != DBNull.Value ? reader["receptoRazonSocial"].ToString() : string.Empty;
                        ticket.ReceptorNIT = reader["receptorNIT"] != DBNull.Value ? reader["receptorNIT"].ToString() : string.Empty;
                        ticket.ReceptorDUI = reader["receptorDUI"] != DBNull.Value ? reader["receptorDUI"].ToString() : string.Empty;
                        ticket.ReceptorNRC = reader["receptorNRC"] != DBNull.Value ? reader["receptorNRC"].ToString() : string.Empty;
                        ticket.ReceptorActividadEconomica = reader["receptorActivadEconomica"] != DBNull.Value ? reader["receptorActivadEconomica"].ToString() : string.Empty;
                        ticket.ReceptorDireccion = reader["receptorDireccion"] != DBNull.Value ? reader["receptorDireccion"].ToString() : string.Empty;
                        ticket.ReceptorTelefono = reader["receptorTelefono"] != DBNull.Value ? reader["receptorTelefono"].ToString() : string.Empty;
                        ticket.ReceptorCorreo = reader["receptorCorreo"] != DBNull.Value ? reader["receptorCorreo"].ToString() : string.Empty;
                        ticket.Placa = reader["Placa"] != DBNull.Value ? reader["Placa"].ToString() : string.Empty;
                        ticket.Consolidado = reader["Consolidado"] != DBNull.Value ? reader["Consolidado"].ToString() : string.Empty;
                        ticket.Orden = reader["Orden"] != DBNull.Value ? Convert.ToInt32(reader["Orden"]) : 0;
                        ticket.Gravadas = reader["Gravadas"] != DBNull.Value ? (decimal)reader["Gravadas"] : 0;
                        ticket.Subtotal = reader["Subtotal"] != DBNull.Value ? (decimal)reader["Subtotal"] : 0;
                        ticket.IVA = reader["IVA"] != DBNull.Value ? (decimal)reader["IVA"] : 0;
                        ticket.Descuento = reader["Descuento"] != DBNull.Value ? (decimal)reader["Descuento"] : 0;
                        ticket.Retencion = reader["Retencion"] != DBNull.Value ? (decimal)reader["Retencion"] : 0;
                        ticket.Percepcion = reader["Percepcion"] != DBNull.Value ? (decimal)reader["Percepcion"] : 0;
                        ticket.Total = reader["Total"] != DBNull.Value ? (decimal)reader["Total"] : 0;
                        ticket.NoSujetas = reader["NoSujetas"] != DBNull.Value ? (decimal)reader["NoSujetas"] : 0;
                        ticket.Exentas = reader["Exentas"] != DBNull.Value ? (decimal)reader["Exentas"] : 0;
                        ticket.TotalLetras = reader["totalLetras"] != DBNull.Value ? reader["totalLetras"].ToString() : string.Empty;
                        ticket.PesoNeto = reader["PesoNeto"] != DBNull.Value ? (decimal)reader["PesoNeto"] : 0;
                        ticket.PesoBruto = reader["PesoBruto"] != DBNull.Value ? (decimal)reader["PesoBruto"] : 0;
                        ticket.OrdenCompra = reader["OrdenCompra"] != DBNull.Value ? Convert.ToString(reader["OrdenCompra"]) : string.Empty;

                        tickets.Add(ticket);
                    }

                    reader.Close();
                }

                return tickets;
            }
            catch (InvalidCastException ix)
            {

                throw new Exception(ix.Message + " " + ix.Data + " " + ix.Source);
            }
        }
        public List<DatosFormatoTicketDevModel> getDatosFormatoTicketDev(string ConsolidadoNo, string ControlNo = null)
        {
            try
            {
                var datos = new List<DatosFormatoTicketDevModel>();

                string query = @"Proc_DatosFormatoTicketDev";
                using (SqlConnection cn = new SqlConnection(Conexion.instancia.getCnsString()))
                {
                    SqlCommand cmd = new SqlCommand(query, cn);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandTimeout = 999;
                    cmd.Parameters.Add("@ConsolidadNo", System.Data.SqlDbType.NVarChar, 20).Value = ConsolidadoNo;
                    if (!string.IsNullOrEmpty(ControlNo))
                    {
                        cmd.Parameters.Add("@Control_No", System.Data.SqlDbType.NVarChar, 20).Value = ControlNo;
                    }
                    SqlDataReader leer;
                    cn.Open();
                    leer = cmd.ExecuteReader();
                    while (leer.Read())
                    {
                        var dato = new DatosFormatoTicketDevModel();
                        dato.Dealer = (int)leer["Dealer"];
                        dato.NoConsolidado = Convert.ToString(leer["NoConsolidado"]);
                        dato.Bodega = Convert.ToString(leer["Bodega"]);
                        dato.FechaCreacion = Convert.ToDateTime(leer["FechaCreacion"]);
                        dato.PedidoNo = (int)leer["PedidoNo"];
                        dato.DocumentoVta = Convert.ToString(leer["DocumentoVta"]);
                        dato.ClienteNo = Convert.ToString(leer["ClienteNo"]);
                        dato.DescripcionBodega = Convert.ToString(leer["DescripcionBodega"]);
                        dato.NombreCliente = Convert.ToString(leer["NombreCliente"]);
                        dato.NombreMotorista = Convert.ToString(leer["NombreMotorista"]);
                        dato.MotivoDevolucion = Convert.ToString(leer["MotivoDevolucion"]);
                        dato.Placa = Convert.ToString(leer["Placa"]);
                        dato.DespachoNo = Convert.ToInt32(leer["DespachoNo"]);
                        dato.TipoCuadro = Convert.ToString(leer["TIPO_CUADRO"]);
                        dato.Justificacion = Convert.ToString(leer["Justificacion"]);
                        dato.NombreEmpresa = Convert.ToString(leer["NombreEmpresa"]);
                        dato.TotalINC = Convert.ToDecimal(leer["TotalNC"]);
                        dato.SaldoDocVta = Convert.ToDecimal(leer["SaldoDocVta"]);
                        dato.NoProductos = Convert.ToInt32(leer["NoProductos"]);
                        dato.IngresoBodega = Convert.ToInt32(leer["INGRESO_BODEGA"]);
                        datos.Add(dato);
                    }
                    cn.Close();
                }
                return datos;

            }
            catch (Exception ex)
            {

                throw new Exception("Error en getDatosFormatoTicketDev: " + ex.Message + " " + ex.Message);
            }
        }
        public List<DatosFormatoTicketDevDetModel> getDatosFormatoTicketDevDet(string ConsolidadoNo, string ControlNo)
        {
            try
            {
                var datos = new List<DatosFormatoTicketDevDetModel>();

                string query = @"select [CIA_ID], [CONSOLIDADO_NO], [CONTROL_NO], [ITE_ID], [descripción], [QTY_PRE], [QTY_DEV], [PrecioUnitario], [Importe], [ERPKEY], [CodPais], [Dealer], [Tda], [TipoDoc], [Serie], [DocNo], [Descuento], [Exentas] 
                                from vFELDatosFormatoTicketDevDet 
                                where CONSOLIDADO_NO = @ConsolidadoNo and CONTROL_NO = @ControlNo";
                using (SqlConnection cn = new SqlConnection(Conexion.instancia.getCnsString()))
                {
                    SqlCommand cmd = new SqlCommand(query, cn);
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandTimeout = 999;
                    cmd.Parameters.Add("@ConsolidadoNo", System.Data.SqlDbType.NVarChar, 20).Value = ConsolidadoNo;
                    cmd.Parameters.Add("@ControlNo", System.Data.SqlDbType.NVarChar, 20).Value = ControlNo;

                    SqlDataReader leer;
                    cn.Open();
                    leer = cmd.ExecuteReader();
                    while (leer.Read())
                    {
                        var dato = new DatosFormatoTicketDevDetModel();
                        dato.CIA_ID = Convert.ToString(leer["CIA_ID"]);
                        dato.CONSOLIDADO_NO = Convert.ToString(leer["CONSOLIDADO_NO"]);
                        dato.CONTROL_NO = Convert.ToString(leer["CONTROL_NO"]);
                        dato.ITE_ID = Convert.ToString(leer["ITE_ID"]);
                        dato.Descripción = Convert.ToString(leer["descripción"]);
                        dato.QTY_PRE = Convert.ToDecimal(leer["QTY_PRE"]);
                        dato.QTY_DEV = Convert.ToDecimal(leer["QTY_DEV"]);
                        dato.PrecioUnitario = Convert.ToDecimal(leer["PrecioUnitario"]);
                        dato.Importe = Convert.ToDecimal(leer["Importe"]);
                        dato.ERPKEY = Convert.ToString(leer["ERPKEY"]);
                        dato.CodPais = Convert.ToString(leer["CodPais"]);
                        dato.Dealer = Convert.ToInt32(leer["Dealer"]);
                        dato.Tda = Convert.ToString(leer["Tda"]);
                        dato.TipoDoc = Convert.ToString(leer["TipoDoc"]);
                        dato.Serie = Convert.ToString(leer["Serie"]);
                        dato.DocNo = Convert.ToInt32(leer["DocNo"]);
                        dato.Descuento = Convert.ToDecimal(leer["Descuento"]);
                        dato.Exentas = Convert.ToDecimal(leer["Exentas"]);
                        datos.Add(dato);
                    }
                    cn.Close();
                }
                return datos;

            }
            catch (Exception ex)
            {

                throw new Exception("Error en getDatosFormatoTicketDevDet: " + ex.Message + " " + ex.Message);
            }
        }
    }
}
