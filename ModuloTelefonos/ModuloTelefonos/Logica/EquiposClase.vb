Public Class EquiposClase
    Shared ctx As ModuloTelefonosEntities
    Shared Function getListado(buscar As String) As List(Of v_ModuloTelefonos_Equipos)
        ctx = New ModuloTelefonosEntities
        Dim datos = (From a In ctx.v_ModuloTelefonos_Equipos
                     Where a.descripcion.Contains(buscar) Or a.serie.Contains(buscar) Or a.modelo.Contains(buscar) Or a.marca.Contains(buscar)
                     Select a).ToList()
        Return datos
    End Function
    Shared Function getListadoDisponibles(buscar As String) As List(Of v_ModuloTelefonos_Equipos)
        ctx = New ModuloTelefonosEntities
        Dim datos = (From a In ctx.v_ModuloTelefonos_Equipos
                     Where (a.descripcion.Contains(buscar) Or a.serie.Contains(buscar) Or a.modelo.Contains(buscar) Or a.marca.Contains(buscar)) And a.disponible = True
                     Select a).ToList()
        Return datos
    End Function
    Shared Function getInfoEquipo(id_equipo As Integer) As ModuloTelefonos_Equipos
        ctx = New ModuloTelefonosEntities
        Dim dato As New ModuloTelefonos_Equipos
        dato = (From a In ctx.ModuloTelefonos_Equipos
                Where a.id_equipo = id_equipo
                Select a).SingleOrDefault()
        Return dato
    End Function
    Shared Function getMarcas() As List(Of marcas)
        ctx = New ModuloTelefonosEntities
        Dim datos = (From a In ctx.marcas
                     Select a).ToList()
        Return datos
    End Function
    Shared Function getEstados() As List(Of estados)
        ctx = New ModuloTelefonosEntities
        Dim datos = (From a In ctx.estados
                     Select a).ToList()
        Return datos
    End Function
    Shared Function getTipos() As List(Of ModuloTelefonos_Equipos_Tipos)
        ctx = New ModuloTelefonosEntities
        Dim datos = (From a In ctx.ModuloTelefonos_Equipos_Tipos
                     Select a).ToList()
        Return datos
    End Function
    Shared Function nuevoEquipo(modelo As ModuloTelefonos_Equipos) As String
        Dim r As String = ""
        Try
            ctx = New ModuloTelefonosEntities
            ctx.ModuloTelefonos_Equipos.Add(modelo)
            ctx.SaveChanges()
            r = "Equipo creado exitosamente"
        Catch ex As Exception
            r = "Error: " & ex.InnerException.ToString()
        End Try

        Return r
    End Function
    Shared Function editarEquipo(modelo As ModuloTelefonos_Equipos, id_equipo As Integer) As String
        Dim r As String = ""
        Try
            ctx = New ModuloTelefonosEntities
            Dim dato = (From a In ctx.ModuloTelefonos_Equipos
                        Where a.id_equipo = id_equipo
                        Select a).SingleOrDefault()
            With dato
                .id_marca = modelo.id_marca
                .id_tipo = modelo.id_tipo
                .serie = modelo.serie
                .modelo = modelo.modelo
                .descripcion = modelo.descripcion
                .estado = modelo.estado
                .fecha_compra = modelo.fecha_compra
                .proveedor = modelo.proveedor
                .tiempo_garantia_meses = modelo.tiempo_garantia_meses
            End With
            ctx.SaveChanges()
            r = "Equipo modificado exitosamente"
        Catch ex As Exception
            r = "Error: " & ex.InnerException.ToString()
        End Try

        Return r
    End Function
    Shared Function elimininarEquipo(id_equipo As Integer) As String
        Dim r As String = ""
        Try
            ctx = New ModuloTelefonosEntities
            Dim dato As New ModuloTelefonos_Equipos
            dato = (From a In ctx.ModuloTelefonos_Equipos
                    Where a.id_equipo = id_equipo
                    Select a).SingleOrDefault()

            ctx.ModuloTelefonos_Equipos.Remove(dato)
            ctx.SaveChanges()
            r = "Equipo eliminiado exitosamente"
        Catch ex As Exception
            r = "Error: " & ex.InnerException.ToString()
        End Try


        Return r
    End Function
End Class
