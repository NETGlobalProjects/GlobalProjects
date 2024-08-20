Imports System.Data.SqlClient

Public Class AccesoDatosNetData
    Dim connectionString As String = "Data Source=ZEUS\WMS;Initial Catalog=NETDATA;Persist Security Info=True;User ID=userNETApps;Password=Gum@2019;TrustServerCertificate=True"

    Public Function ListarNominaEmpleados(Optional ByVal busqueda As String = "", Optional ByVal filtro As Integer = 0) As List(Of NominaEmpleadoModel)
        Dim empleados As New List(Of NominaEmpleadoModel)()

        Using connection As New SqlConnection(connectionString)
            connection.Open()

            Dim query As String = "SELECT TOP(300) ISNULL(n.CodPais, '') AS CodPais,
                RTRIM(ISNULL(n.Dealer, '')) AS Dealer,
                RTRIM(ISNULL(n.Numero, '')) AS Numero,
                RTRIM(ISNULL(n.Estatus, '')) AS Estatus,
                RTRIM(ISNULL(n.Nombre, '')) AS Nombre,
                RTRIM(ISNULL(n.PrimerApellido, '')) AS PrimerApellido,
                RTRIM(ISNULL(n.SegundoApellido, '')) AS SegundoApellido,
                RTRIM(ISNULL(n.Departamento, '')) AS Departamento,
                RTRIM(ISNULL(n.Direccion, '')) AS Direccion,
                RTRIM(ISNULL(n.Telefono, '00000000')) AS Telefono,
                RTRIM(ISNULL(n.DUI, '')) AS DUI,
                RTRIM(ISNULL(n.CargoDesempeñado, '')) AS CargoDesempeñado,
                ISNULL(n.FechaIngreso, '1901/01/01') AS FechaIngreso,
                RTRIM(ISNULL(n.CCosto, '')) AS CCosto,
                RTRIM(ISNULL(n.CodMunicipio, '')) AS CodMunicipio,
		            RTRIM(ISNULL(n.Nombre, '')) + ' ' +
		            RTRIM(ISNULL(n.PrimerApellido, '')) + ' ' +
		            RTRIM(ISNULL(n.SegundoApellido, '')) AS NombreCompleto,
                    RTRIM(ISNULL(n.PrimerApellido, '')) + ' ' +
                    RTRIM(ISNULL(n.SegundoApellido, '')) AS Apellidos,
                RTRIM(ISNULL(d.Nombre, '')) AS DealerNombre,
                RTRIM(ISNULL(c.Descripcion, '')) AS CargoNombre,
                RTRIM(ISNULL(e.Servicio, '')) AS DepartamentoNombre
            FROM NETDATA.dbo.NominaEmpleado n
            LEFT JOIN NETDATA.dbo.Dealer d ON n.Dealer = d.Codigo
            LEFT JOIN NETDATA.dbo.Cargo c ON n.CargoDesempeñado = c.Cargo AND n.Dealer = c.Dealer
            LEFT JOIN NETDATA.dbo.CentroCosto e ON n.Departamento = e.CentroCosto AND n.Dealer = e.Dealer
            WHERE n.Estatus = 'A' "

            Select Case filtro
                Case 0
                    query &= " AND (n.DUI LIKE @BUSQUEDA OR n.Numero LIKE @BUSQUEDA OR n.Nombre LIKE @BUSQUEDA OR n.PrimerApellido LIKE @BUSQUEDA OR n.SegundoApellido LIKE @BUSQUEDA)"
                Case 1
                    query &= " AND n.DUI LIKE @BUSQUEDA"
                Case 2
                    query &= " AND n.Numero LIKE @BUSQUEDA"
                Case 3
                    query &= " AND n.Nombre LIKE @BUSQUEDA"
                Case 4
                    query &= " AND (n.PrimerApellido LIKE @BUSQUEDA OR n.SegundoApellido LIKE @BUSQUEDA)"
            End Select

            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@BUSQUEDA", "%" & busqueda & "%")

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
                            .Departamento = reader("Departamento").ToString(),
                            .Direccion = reader("Direccion").ToString(),
                            .Telefono = reader("Telefono").ToString(),
                            .DUI = reader("DUI").ToString(),
                            .CargoDesempeñado = reader("CargoDesempeñado").ToString(),
                            .FechaIngreso = Convert.ToDateTime(reader("FechaIngreso")),
                            .CCosto = reader("CCosto").ToString(),
                            .CodMunicipio = If(IsDBNull(reader("CodMunicipio")), CType(Nothing, Nullable(Of Int16)), Convert.ToInt16(reader("CodMunicipio"))),
                            .NombreCompleto = reader("NombreCompleto").ToString(),
                            .Apellidos = reader("Apellidos").ToString(),
                            .DealerNombre = reader("DealerNombre").ToString(),
                            .CargoNombre = reader("CargoNombre").ToString(),
                            .DepartamentoNombre = reader("DepartamentoNombre").ToString()
                        }
                        empleados.Add(empleado)
                    End While
                End Using
            End Using
        End Using

        Return empleados
    End Function

    Public Function ObtenerNominaEmpleado(ByVal Numero As Integer) As NominaEmpleadoModel
        Dim empleado As NominaEmpleadoModel = Nothing

        Using connection As New SqlConnection(connectionString)
            connection.Open()

            Dim query As String = "SELECT ISNULL(n.CodPais, '') AS CodPais,
                ISNULL(n.Dealer, 0) AS Dealer,
                ISNULL(n.Numero, 0) AS Numero,
                ISNULL(n.Estatus, '') AS Estatus,
                ISNULL(n.Nombre, '') AS Nombre,
                ISNULL(n.PrimerApellido, '') AS PrimerApellido,
                ISNULL(n.SegundoApellido, '') AS SegundoApellido,
                ISNULL(n.Departamento, '') AS Departamento,
                ISNULL(n.Direccion, '') AS Direccion,
                ISNULL(n.Telefono, '00000000') AS Telefono,
                ISNULL(n.DUI, '') AS DUI,
                ISNULL(n.CargoDesempeñado, '') AS CargoDesempeñado,
                ISNULL(n.FechaIngreso, '') AS FechaIngreso,
                ISNULL(n.CCosto, '') AS CCosto,
                ISNULL(n.CodMunicipio, 0) AS CodMunicipio,
                RTRIM(ISNULL(n.Nombre, '')) + ' ' +
                RTRIM(ISNULL(n.PrimerApellido, '')) + ' ' +
                RTRIM(ISNULL(n.SegundoApellido, '')) AS NombreCompleto,
                ISNULL(d.Nombre, '') AS DealerNombre,
                ISNULL(c.Descripcion, '') AS CargoNombre,
                ISNULL(e.Servicio, '') AS DepartamentoNombre
            FROM NETDATA.dbo.NominaEmpleado n
            LEFT JOIN NETDATA.dbo.Dealer d ON n.Dealer = d.Codigo
            LEFT JOIN NETDATA.dbo.Cargo c ON n.CargoDesempeñado = c.Cargo AND n.Dealer = c.Dealer
            LEFT JOIN NETDATA.dbo.CentroCosto e ON n.Departamento = e.CentroCosto AND n.Dealer = e.Dealer
            WHERE n.Numero = @Numero AND n.Estatus = 'A'"

            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@Numero", Numero)

                Using reader As SqlDataReader = command.ExecuteReader()
                    If reader.Read() Then
                        empleado = New NominaEmpleadoModel With {
                            .CodPais = reader("CodPais").ToString(),
                            .Dealer = Convert.ToInt32(reader("Dealer")),
                            .Numero = Convert.ToInt32(reader("Numero")),
                            .Estatus = Convert.ToChar(reader("Estatus")),
                            .Nombre = reader("Nombre").ToString(),
                            .PrimerApellido = reader("PrimerApellido").ToString(),
                            .SegundoApellido = reader("SegundoApellido").ToString(),
                            .Departamento = reader("Departamento").ToString(),
                            .Direccion = reader("Direccion").ToString(),
                            .Telefono = reader("Telefono").ToString(),
                            .DUI = reader("DUI").ToString(),
                            .CargoDesempeñado = reader("CargoDesempeñado").ToString(),
                            .FechaIngreso = Convert.ToDateTime(reader("FechaIngreso")),
                            .CCosto = reader("CCosto").ToString(),
                            .CodMunicipio = If(IsDBNull(reader("CodMunicipio")), CType(Nothing, Nullable(Of Int16)), Convert.ToInt16(reader("CodMunicipio"))),
                            .NombreCompleto = reader("NombreCompleto").ToString(),
                            .DealerNombre = reader("DealerNombre").ToString(),
                            .CargoNombre = reader("CargoNombre").ToString(),
                            .DepartamentoNombre = reader("DepartamentoNombre").ToString()
                        }
                    End If
                End Using
            End Using
        End Using

        Return empleado
    End Function

End Class
