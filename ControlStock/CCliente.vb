Imports MySql.Data.MySqlClient
Public Class CCliente
    Private ObjCon As New BaseDato()

    Public Function InserCliente(ByVal CI As String, ByVal Nombre As String, ByVal Telefono As String, ByVal Direccion As String) As Boolean
        Dim inserto As Boolean = False
        Try
            ObjCon.Conectar()
            ObjCon.CrearComando("INSERT INTO Cliente VALUES(?ci, ?nombre, ?telefono, ?direccion)")
            ObjCon.AsignarParametro("?ci", MySqlDbType.String, CI)
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

    Public Function BuscCli(ByVal Condicion As String) As DataTable
        ObjCon.Conectar()
        ObjCon.CrearComando("SELECT * FROM cliente " + Condicion)
        BuscCli = ObjCon.EjecutarDataTable()
        ObjCon.Desconectar()
    End Function

    Public Function Eliminar(ByVal CI As String) As Boolean
        Dim elimino As Boolean = False
        Try
            ObjCon.Conectar()
            ObjCon.CrearComando("DELETE FROM Cliente WHERE CI = ?ci")
            ObjCon.AsignarParametro("?ci", MySqlDbType.String, CI)
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

    Public Function Update(ByVal NewCI As String, ByVal Nombre As String, ByVal Telefono As String, ByVal Direccion As String, ByVal RUC As String) As Boolean
        Dim inserto As Boolean = False
        Try
            ObjCon.Conectar()
            ObjCon.CrearComando("UPDATE Cliente SET CI = ?newci, nombre = ?nombre, telefono = ?telefono, " +
                                " direccion = ?direccion WHERE CI = ?ci")
            ObjCon.AsignarParametro("?newci", MySqlDbType.String, NewCI)
            ObjCon.AsignarParametro("?nombre", MySqlDbType.String, Nombre)
            ObjCon.AsignarParametro("?telefono", MySqlDbType.String, Telefono)
            ObjCon.AsignarParametro("?direccion", MySqlDbType.String, Direccion)
            ObjCon.AsignarParametro("?ci", MySqlDbType.String, RUC)
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

End Class
