Imports MySql.Data.MySqlClient
Public Class CEmpleado
    Private ObjCon As New CBaseDato()

    Public Function Insert(ByVal CI As Integer, ByVal Nombre As String, ByVal Apellido As String, ByVal Telefono As String, _
                           ByVal Direccion As String, ByVal Comision As Integer, ByVal Estado As String) As Boolean
        Dim inserto As Boolean = False
        Try
            ObjCon.Conectar()
            ObjCon.CrearComando("INSERT INTO Empleado VALUES(?ci, ?nombre, ?apellido, ?telefono, ?direccion, ?comision, ?estado)")
            ObjCon.AsignarParametro("?ci", MySqlDbType.Int32, CI)
            ObjCon.AsignarParametro("?nombre", MySqlDbType.String, Nombre)
            ObjCon.AsignarParametro("?apellido", MySqlDbType.String, Apellido)
            ObjCon.AsignarParametro("?telefono", MySqlDbType.String, Telefono)
            ObjCon.AsignarParametro("?direccion", MySqlDbType.String, Direccion)
            ObjCon.AsignarParametro("?comision", MySqlDbType.Int32, Comision)
            ObjCon.AsignarParametro("?estado", MySqlDbType.String, Estado)
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

    Public Function Update(ByVal CI As Integer, ByVal Nombre As String, ByVal Apellido As String, ByVal Telefono As String, ByVal Direccion As String, ByVal Comision As Integer, ByVal OldCI As Integer) As Boolean
        Dim inserto As Boolean = False
        Try
            ObjCon.Conectar()
            ObjCon.CrearComando("UPDATE Empleado SET ci = ?ci, nombre = ?nombre, apellido = ?apellido, telefono = ?telefono, " + _
                                " direccion = ?direccion, comision = ?comision WHERE ci = ?oldci")
            ObjCon.AsignarParametro("?ci", MySqlDbType.Int32, CI)
            ObjCon.AsignarParametro("?nombre", MySqlDbType.String, Nombre)
            ObjCon.AsignarParametro("?apellido", MySqlDbType.String, Apellido)
            ObjCon.AsignarParametro("?telefono", MySqlDbType.String, Telefono)
            ObjCon.AsignarParametro("?direccion", MySqlDbType.String, Direccion)
            ObjCon.AsignarParametro("?comision", MySqlDbType.Int32, Comision)
            ObjCon.AsignarParametro("?oldci", MySqlDbType.Int32, OldCI)
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

    Public Function Baja(ByVal CI As Integer) As Boolean
        Dim inserto As Boolean = False
        Try
            ObjCon.Conectar()
            ObjCon.CrearComando("UPDATE Empleado SET estado = 'Inactivo' WHERE ci = ?ci")
            ObjCon.AsignarParametro("?ci", MySqlDbType.Int32, CI)
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

    Public Function CargarEmple(ByVal CIValue As String) As DataTable
        ObjCon.Conectar()
        ObjCon.CrearComando("SELECT * FROM Empleado WHERE CI =" + CIValue)
        CargarEmple = ObjCon.EjecutarDataTable()
        ObjCon.Desconectar()
    End Function

    Public Function Buscar(ByVal Condicion As String) As DataTable
        ObjCon.Conectar()
        ObjCon.CrearComando("SELECT * FROM Empleado " + Condicion)
        Buscar = ObjCon.EjecutarDataTable()
        ObjCon.Desconectar()
    End Function

    Public Function BuscViewVenta(ByVal Fecha1 As String, ByVal Fecha2 As String, ByVal CI As String) As DataTable
        ObjCon.Conectar()
        ObjCon.CrearComando("select v.CI, v.Vendedor, sum(v.total) as Total, (sum(v.Total) * e.Comision div 100) as Comision " + _
                            "from viewventa v, empleado e " + _
                            "where v.ci = e.ci and v.fecha > '" + Fecha1 + "' and v.fecha < '" + Fecha2 + "' and v.ci=" + CI)
        BuscViewVenta = ObjCon.EjecutarDataTable()
        ObjCon.Desconectar()
    End Function

    Public Function ListarEmple() As DataTable
        ObjCon.Conectar()
        ObjCon.CrearComando("SELECT * FROM empleado Where estado = 'Activo'")
        ListarEmple = ObjCon.EjecutarDataTable()
        ObjCon.Desconectar()
    End Function

End Class
