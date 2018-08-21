Imports MySql.Data.MySqlClient
Public Class CProveedor
    Private ObjCon As New BaseDato()

    Public Function Insert(ByVal RUC As String, ByVal Nombre As String, ByVal Telefono As String, ByVal Direccion As String) As Boolean
        Dim inserto As Boolean = False
        Try
            ObjCon.Conectar()
            ObjCon.CrearComando("INSERT INTO Proveedor VALUES(?RUC, ?nombre, ?telefono, ?direccion)")
            ObjCon.AsignarParametro("?RUC", MySqlDbType.String, RUC)
            ObjCon.AsignarParametro("?nombre", MySqlDbType.String, Nombre)
            ObjCon.AsignarParametro("?telefono", MySqlDbType.String, Telefono)
            ObjCon.AsignarParametro("?direccion", MySqlDbType.String, Direccion)
            If ObjCon.EjecutarConsulta() > 0 Then
                inserto = True
            Else
                inserto = False
            End If
            ObjCon.Desconectar()
        Catch mierror As MySqlException
            inserto = False
        End Try
        Return inserto
    End Function

    Public Function Update(ByVal NewRUC As String, ByVal Nombre As String, ByVal Telefono As String, ByVal Direccion As String, ByVal RUC As String) As Boolean
        Dim inserto As Boolean = False
        Try
            ObjCon.Conectar()
            ObjCon.CrearComando("UPDATE Proveedor SET RUC = ?newruc, nombre = ?nombre, telefono = ?telefono, " +
                                " direccion = ?direccion WHERE RUC = ?ruc")
            ObjCon.AsignarParametro("?newruc", MySqlDbType.String, NewRUC)
            ObjCon.AsignarParametro("?nombre", MySqlDbType.String, Nombre)
            ObjCon.AsignarParametro("?telefono", MySqlDbType.String, Telefono)
            ObjCon.AsignarParametro("?direccion", MySqlDbType.String, Direccion)
            ObjCon.AsignarParametro("?ruc", MySqlDbType.String, RUC)
            If ObjCon.EjecutarConsulta() > 0 Then
                inserto = True
            Else
                inserto = False
            End If
            ObjCon.Desconectar()
        Catch mierror As MySqlException
            inserto = False
        End Try
        Return inserto
    End Function

    Public Function Eliminar(ByVal RUC As String) As Boolean
        Dim elimino As Boolean = False
        Try
            ObjCon.Conectar()
            ObjCon.CrearComando("DELETE FROM Proveedor WHERE RUC = ?ruc")
            ObjCon.AsignarParametro("?ruc", MySqlDbType.String, RUC)
            If ObjCon.EjecutarConsulta() > 0 Then
                elimino = True
            Else
                elimino = False
            End If
            ObjCon.Desconectar()
        Catch
            elimino = False
        End Try
        Return elimino
    End Function

    Public Function Buscar(ByVal Condicion As String) As DataTable
        ObjCon.Conectar()
        ObjCon.CrearComando("SELECT * FROM Proveedor " + Condicion)
        Buscar = ObjCon.EjecutarDataTable()
        ObjCon.Desconectar()
    End Function

    Public Function ListarProveed() As DataTable
        ObjCon.Conectar()
        ObjCon.CrearComando("SELECT * FROM proveedor Order By nombre")
        ListarProveed = ObjCon.EjecutarDataTable()
        ObjCon.Desconectar()
    End Function

    Public Function CargarProveedores() As List(Of String)
        CargarProveedores = New List(Of String)
        ObjCon.Conectar()
        'ObjCon.CrearComando("SELECT RUC FROM proveedor")
        ObjCon.CrearComando("SELECT Nombre FROM proveedor")
        ObjCon.dr = ObjCon.EjecutarReader()
        While ObjCon.dr.Read()
            'CargarProveedores.Add(ObjCon.dr.GetInt32(0))
            CargarProveedores.Add(ObjCon.dr.GetString(0))
        End While
        ObjCon.dr.Close()
        ObjCon.Desconectar()
    End Function

End Class
