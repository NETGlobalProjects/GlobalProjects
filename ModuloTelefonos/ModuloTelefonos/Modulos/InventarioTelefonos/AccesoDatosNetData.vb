Imports System.Data.SqlClient

Public Class AccesoDatosNetData


    Private connectionString As String = "tu_cadena_de_conexion_aquí"

    Public Function ListarNominaEmpleados(
        Optional ByVal filtroDUI As String = "",
        Optional ByVal filtroNombre As String = "",
        Optional ByVal filtroPrimerApellido As String = "",
        Optional ByVal filtroSegundoApellido As String = ""
        ) As List(Of NominaEmpleadoModel)

        Dim empleados As New List(Of NominaEmpleadoModel)()

        Using connection As New SqlConnection(connectionString)
            connection.Open()

            Dim query As String = "SELECT * FROM NominaEmpleado WHERE (DUI LIKE @DUI OR @DUI = '') " &
                                  "AND (Nombre LIKE @Nombre OR @Nombre = '') " &
                                  "AND (PrimerApellido LIKE @PrimerApellido OR @PrimerApellido = '') " &
                                  "AND (SegundoApellido LIKE @SegundoApellido OR @SegundoApellido = '')"

            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@DUI", "%" & filtroDUI & "%")
                command.Parameters.AddWithValue("@Nombre", "%" & filtroNombre & "%")
                command.Parameters.AddWithValue("@PrimerApellido", "%" & filtroPrimerApellido & "%")
                command.Parameters.AddWithValue("@SegundoApellido", "%" & filtroSegundoApellido & "%")

                Using reader As SqlDataReader = command.ExecuteReader()
                    While reader.Read()
                        Dim empleado As New NominaEmpleadoModel With {
                            .CodPais = reader("CodPais").ToString(),
                            .Dealer = Convert.ToInt32(reader("Dealer")),
                            .Numero = Convert.ToInt32(reader("Numero")),
                            .Estatus = Convert.ToChar(reader("Estatus")),
                            .Nombre = reader("Nombre").ToString(),
                            .PrimerApellido = reader("PrimerApellido").ToString(),
                            .SegundoApellido = reader("SegundoApellido").ToString(),
                            .ApellidoCasada = reader("ApellidoCasada").ToString(),
                            .Departamento = reader("Departamento").ToString(),
                            .Direccion = reader("Direccion").ToString(),
                            .Telefono = reader("Telefono").ToString(),
                            .DUI = reader("DUI").ToString(),
                            .CargoDesempeñado = reader("CargoDesempeñado").ToString(),
                            .FechaIngreso = Convert.ToDateTime(reader("FechaIngreso")),
                            .CdCosto = reader("CdCosto").ToString(),
                            .CodMunicipio = If(IsDBNull(reader("CodMunicipio")), Nothing, Convert.ToInt16(reader("CodMunicipio"))),
                            .TelefonoCorporativo = reader("TelefonoCorporativo").ToString()
                        }
                        empleados.Add(empleado)
                    End While
                End Using
            End Using
        End Using

        Return empleados
    End Function
End Class
