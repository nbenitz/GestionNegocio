Option Strict On
Option Explicit On
Imports MySql.Data.MySqlClient
Public Class CAcceso
    Private ObjCon As New CBaseDato()

    Public Function Insert(ByVal Id As Integer, ByVal Codigo As Integer, ByVal Nombre As String) As Boolean
        Dim inserto As Boolean = False
        Try
            ObjCon.Conectar()
            ObjCon.CrearComando("INSERT INTO Acceso VALUES(?id, ?codigo, ?nombre)")
            ObjCon.AsignarParametro("?id", MySqlDbType.Int32, Id)
            ObjCon.AsignarParametro("?codigo", MySqlDbType.Int32, Codigo)
            ObjCon.AsignarParametro("?nombre", MySqlDbType.String, Codigo)
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


    Public Function Update(ByVal Codigo As Integer,
                           ByVal Nombre As String,
                           ByVal Id As Integer) As Boolean
        Dim inserto As Boolean = False
        Try
            ObjCon.Conectar()
            ObjCon.CrearComando("UPDATE Acceso SET codigo = ?codigo, nombre = ?nombre " +
                                "WHERE id = ?id")
            ObjCon.AsignarParametro("?codigo", MySqlDbType.Int32, Codigo)
            ObjCon.AsignarParametro("?nombre", MySqlDbType.Int32, Codigo)
            ObjCon.AsignarParametro("?id", MySqlDbType.Int32, Id)
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


    Public Function Eliminar(ByVal Id As Integer) As Boolean
        Dim elimino As Boolean = False
        Try
            ObjCon.Conectar()
            ObjCon.CrearComando("DELETE FROM Acceso WHERE id = ?id")
            ObjCon.AsignarParametro("?id", MySqlDbType.String, Id)
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
        ObjCon.CrearComando("SELECT * FROM Acceso " + Condicion)
        Buscar = ObjCon.EjecutarDataTable()
        ObjCon.Desconectar()
    End Function

    Public Function BuscarHuellas(ByVal Codigo As String) As DataTable
        Try
            ObjCon.Conectar()
            ObjCon.CrearComando("SELECT * FROM view_finger_print WHERE employeeNo = '" + Codigo + "'")
            BuscarHuellas = ObjCon.EjecutarDataTable()
            ObjCon.Desconectar()
        Catch ex As Exception
            MessageBox.Show("Error: " + ex.Message)
        End Try

    End Function


    Public Function Listar() As DataTable
        ObjCon.Conectar()
        ObjCon.CrearComando("SELECT * FROM Acceso")
        Listar = ObjCon.EjecutarDataTable()
        ObjCon.Desconectar()
    End Function


    Public Function GetId(ByVal Codigo As String) As Integer
        GetId = -1
        ObjCon.Conectar()
        ObjCon.CrearComando("SELECT id FROM acceso WHERE codigo = " + Codigo)
        ObjCon.dr = ObjCon.EjecutarReader()
        If ObjCon.dr.Read() Then
            Try
                GetId = ObjCon.dr.GetInt32(0)
            Catch
            End Try
        End If
        ObjCon.dr.Close()
        ObjCon.Desconectar()
    End Function


    Public Function CargarId() As Int32
        CargarId = 0
        ObjCon.Conectar()
        ObjCon.CrearComando("SELECT MAX(id) FROM Acceso")
        ObjCon.dr = ObjCon.EjecutarReader()
        If ObjCon.dr.Read() Then
            Try
                CargarId = ObjCon.dr.GetInt32(0)
            Catch
            End Try
        Else
            CargarId = 0
        End If
        ObjCon.dr.Close()
        ObjCon.Desconectar()
        CargarId = CInt(CargarId + 1)
    End Function


    Public Function InsertClienteAcceso(ByVal ClienteCi As String,
                                        ByVal AccesoId As Integer) As Boolean
        Dim inserto As Boolean = False
        Dim Id As Int32 = IdClienteAcceso()
        Try
            ObjCon.Conectar()
            ObjCon.CrearComando("INSERT INTO cliente_acceso VALUES(?id, ?cliente_ci, ?acceso_id)")
            ObjCon.AsignarParametro("?id", MySqlDbType.Int32, Id)
            ObjCon.AsignarParametro("?cliente_ci", MySqlDbType.String, ClienteCi)
            ObjCon.AsignarParametro("?acceso_id", MySqlDbType.Int32, AccesoId)
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


    Public Function UpdateClienteAcceso(ByVal AccesoId As Integer, ByVal Id As Integer) As Boolean
        Dim inserto As Boolean = False
        Try
            ObjCon.Conectar()
            ObjCon.CrearComando("UPDATE cliente_acceso SET acceso_id = ?acceso_id " +
                                "WHERE id = ?id")
            ObjCon.AsignarParametro("?acceso_id", MySqlDbType.Int32, AccesoId)
            ObjCon.AsignarParametro("?id", MySqlDbType.Int32, Id)
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


    Public Function EliminarClienteAcceso(ByVal CI As String) As Boolean
        Dim elimino As Boolean = False
        Try
            ObjCon.Conectar()
            ObjCon.CrearComando("DELETE FROM cliente_acceso WHERE cliente_ci = ?ci")
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


    Public Function IdClienteAcceso(ByVal CI As String) As Integer
        IdClienteAcceso = -1
        ObjCon.Conectar()
        ObjCon.CrearComando("SELECT id FROM cliente_acceso WHERE cliente_ci = '" + CI + "'")
        ObjCon.dr = ObjCon.EjecutarReader()
        If ObjCon.dr.Read() Then
            Try
                IdClienteAcceso = ObjCon.dr.GetInt32(0)
            Catch
            End Try
        End If
        ObjCon.dr.Close()
        ObjCon.Desconectar()
    End Function


    Public Function CodigoAsignado(ByVal Codigo As Decimal) As Boolean
        CodigoAsignado = False
        Dim Count As Integer = 0   'Count es 0 si el codigo aun no se asignó
        ObjCon.Conectar()
        ObjCon.CrearComando("zacceso_asignado")
        ObjCon.CrearProcedimiento()
        ObjCon.AsignarParametro("@Cod", Codigo)
        ObjCon.dr = ObjCon.EjecutarReader()
        If ObjCon.dr.Read() Then
            'Try
            Count = ObjCon.dr.GetInt32(0)
            'Catch
            'End Try
        Else
            Count = 0
        End If
        If Count > 0 Then
            CodigoAsignado = True
        Else
            CodigoAsignado = False
        End If
        ObjCon.dr.Close()
        ObjCon.Desconectar()
    End Function


    Public Function DelFingers(ByVal Codigo As String) As Boolean
        Dim elimino As Boolean = False
        Try
            ObjCon.Conectar()
            ObjCon.CrearComando("zfinger_del")
            ObjCon.CrearProcedimiento()
            ObjCon.AsignarParametro("@CodigoAcceso", Codigo)
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



    Public Function IdClienteAcceso() As Int32
        IdClienteAcceso = 0
        ObjCon.Conectar()
        ObjCon.CrearComando("SELECT MAX(id) FROM cliente_acceso")
        ObjCon.dr = ObjCon.EjecutarReader()
        If ObjCon.dr.Read() Then
            Try
                IdClienteAcceso = ObjCon.dr.GetInt32(0)
            Catch
            End Try
        End If
        ObjCon.dr.Close()
        ObjCon.Desconectar()
        IdClienteAcceso += 1
    End Function


    Public Function InsertClienteAsistencia(ByVal ClienteCi As String,
                                            ByVal Fecha As DateTime,
                                            ByVal Obs As String) As Boolean
        Dim inserto As Boolean = False
        Dim Id As Int32 = IdClienteAsistencia()
        Try
            ObjCon.Conectar()
            ObjCon.CrearComando("INSERT INTO cliente_asistencia VALUES(?id, ?cliente_ci, ?fecha, ?obs)")
            ObjCon.AsignarParametro("?id", MySqlDbType.Int32, Id)
            ObjCon.AsignarParametro("?cliente_ci", MySqlDbType.String, ClienteCi)
            ObjCon.AsignarParametro("?fecha", MySqlDbType.DateTime, Fecha)
            ObjCon.AsignarParametro("?obs", MySqlDbType.String, Obs)
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


    Public Function InsertEmpleadoAsistencia(ByVal EmpleadoCI As String,
                                             ByVal Fecha As DateTime) As Boolean
        Dim inserto As Boolean = False
        Dim Id As Int32 = IdEmpleadoAsistencia()
        Try
            ObjCon.Conectar()
            ObjCon.CrearComando("INSERT INTO empleado_asistencia VALUES(?id, ?empleado_ci, ?fecha)")
            ObjCon.AsignarParametro("?id", MySqlDbType.Int32, Id)
            ObjCon.AsignarParametro("?empleado_ci", MySqlDbType.String, EmpleadoCI)
            ObjCon.AsignarParametro("?fecha", MySqlDbType.DateTime, Fecha)
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


    Public Function BuscarAsistencia(ByVal Condicion As String) As DataTable
        ObjCon.Conectar()
        ObjCon.CrearComando("SELECT * FROM view_asistencia " + Condicion)
        BuscarAsistencia = ObjCon.EjecutarDataTable()
        ObjCon.Desconectar()
    End Function

    Public Function CheckAsistencia(ByVal Fecha As Date, ByVal CI As String) As Boolean
        CheckAsistencia = False
        ObjCon.Conectar()
        ObjCon.CrearComando("SELECT * FROM cliente_asistencia WHERE cliente_ci = ?ci AND DATE(fecha) = DATE(?fecha) ")
        ObjCon.AsignarParametro("?ci", MySqlDbType.String, CI)
        ObjCon.AsignarParametro("?fecha", MySqlDbType.Date, Fecha)
        Dim Tabla As DataTable = ObjCon.EjecutarDataTable()
        If Tabla.Rows.Count > 0 Then
            CheckAsistencia = True
        End If
        ObjCon.Desconectar()
        Return CheckAsistencia
    End Function

    Public Function CantSocioAsistencia(ByVal Condicion As String) As Integer
        ObjCon.Conectar()
        ObjCon.CrearComando("SELECT count(DISTINCT(cedula)) FROM view_asistencia " + Condicion)
        ObjCon.dr = ObjCon.EjecutarReader()
        If ObjCon.dr.Read() Then
            Try
                CantSocioAsistencia = ObjCon.dr.GetInt32(0)
            Catch
            End Try
        End If
        ObjCon.dr.Close()
        ObjCon.Desconectar()
        Return CantSocioAsistencia
    End Function


    Public Function UltimaAsistencia(ByVal CI As String) As DateTime
        ObjCon.Conectar()
        ObjCon.CrearComando("SELECT MAX(fecha) FROM cliente_asistencia WHERE cliente_ci = '" + CI + "'")
        ObjCon.dr = ObjCon.EjecutarReader()
        If ObjCon.dr.Read() Then
            Try
                UltimaAsistencia = ObjCon.dr.GetDateTime(0)
            Catch
            End Try
        End If
        ObjCon.dr.Close()
        ObjCon.Desconectar()
        Return UltimaAsistencia
    End Function

    Public Function IdClienteAsistencia() As Int32
        IdClienteAsistencia = 0
        ObjCon.Conectar()
        ObjCon.CrearComando("SELECT MAX(id) FROM cliente_asistencia")
        ObjCon.dr = ObjCon.EjecutarReader()
        If ObjCon.dr.Read() Then
            Try
                IdClienteAsistencia = ObjCon.dr.GetInt32(0)
            Catch
            End Try
        End If
        ObjCon.dr.Close()
        ObjCon.Desconectar()
        IdClienteAsistencia += 1
    End Function


    Public Function IdEmpleadoAsistencia() As Int32
        IdEmpleadoAsistencia = 0
        ObjCon.Conectar()
        ObjCon.CrearComando("SELECT MAX(id) FROM empleado_asistencia")
        ObjCon.dr = ObjCon.EjecutarReader()
        If ObjCon.dr.Read() Then
            Try
                IdEmpleadoAsistencia = ObjCon.dr.GetInt32(0)
            Catch
            End Try
        End If
        ObjCon.dr.Close()
        ObjCon.Desconectar()
        IdEmpleadoAsistencia += 1
    End Function

    Public Function VerAjustes() As DataTable
        ObjCon.Conectar()
        ObjCon.CrearComando("zacceso_ajustes_view")
        ObjCon.CrearProcedimiento()
        VerAjustes = ObjCon.EjecutarDataTable()
        ObjCon.Desconectar()
    End Function

    Public Function Ajustes(ByVal Tolerancia As Integer) As Boolean
        Dim inserto As Boolean = False
        Try
            ObjCon.Conectar()
            ObjCon.CrearComando("zacceso_ajustes")
            ObjCon.CrearProcedimiento()
            ObjCon.AsignarParametro("@Tolerancia", Tolerancia)
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
