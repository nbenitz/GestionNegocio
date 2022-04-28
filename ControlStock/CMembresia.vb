Option Strict On
Option Explicit On

Imports MySql.Data.MySqlClient
Public Class CMembresia
    Private ObjCon As New CBaseDato()

    Public Function Insert(ByVal Nombre As String,
                           ByVal Descripcion As String,
                           ByVal Costo As Integer) As Boolean
        Dim inserto As Boolean = False
        Dim Id As Int32 = CargarNro()
        Try
            ObjCon.Conectar()
            ObjCon.CrearComando("INSERT INTO Membresia VALUES(?id, ?nombre, ?descripcion, ?costo)")
            ObjCon.AsignarParametro("?id", MySqlDbType.Int32, Id)
            ObjCon.AsignarParametro("?nombre", MySqlDbType.String, Descripcion)
            ObjCon.AsignarParametro("?descripcion", MySqlDbType.String, Descripcion)
            ObjCon.AsignarParametro("?costo", MySqlDbType.Int32, Costo)
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


    Public Function Update(ByVal Nombre As String,
                           ByVal Descripcion As String,
                           ByVal Costo As Integer,
                           ByVal Id As Integer) As Boolean
        Dim inserto As Boolean = False
        Try
            ObjCon.Conectar()
            ObjCon.CrearComando("UPDATE Membresia SET nombre = ?nombre, descripcion = ?descripcion, costo = ?costo " +
                                "WHERE id = ?id")
            ObjCon.AsignarParametro("?nombre", MySqlDbType.String, Nombre)
            ObjCon.AsignarParametro("?descripcion", MySqlDbType.String, Descripcion)
            ObjCon.AsignarParametro("?costo", MySqlDbType.Int32, Costo)
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
            ObjCon.CrearComando("DELETE FROM Membresia WHERE id = ?id")
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
        ObjCon.CrearComando("SELECT * FROM Membresia " + Condicion)
        Buscar = ObjCon.EjecutarDataTable()
        ObjCon.Desconectar()
    End Function


    Public Function BuscViewMembresia(ByVal Condicion As String) As DataTable
        ObjCon.Conectar()
        ObjCon.CrearComando("SELECT * FROM view_cliente_membresia " + Condicion)
        BuscViewMembresia = ObjCon.EjecutarDataTable()
        ObjCon.Desconectar()
    End Function


    Public Function Listar() As DataTable
        ObjCon.Conectar()
        ObjCon.CrearComando("SELECT * FROM Membresia")
        Listar = ObjCon.EjecutarDataTable()
        ObjCon.Desconectar()
    End Function


    Public Function CargarNro() As Int32
        CargarNro = 0
        ObjCon.Conectar()
        ObjCon.CrearComando("SELECT MAX(id) FROM Membresia")
        ObjCon.dr = ObjCon.EjecutarReader()
        If ObjCon.dr.Read() Then
            Try
                CargarNro = ObjCon.dr.GetInt32(0)
            Catch
            End Try
        Else
            CargarNro = 0
        End If
        ObjCon.dr.Close()
        ObjCon.Desconectar()
        CargarNro = CInt(CargarNro + 1)
    End Function


    Public Function InsertClienteMembresia(ByVal ClienteCi As String,
                                           ByVal MembresiaId As Integer,
                                           ByVal FechaInicio As Date,
                                           ByVal Precio As Integer) As Boolean
        Dim inserto As Boolean = False
        Dim Id As Int32 = IdClienteMembresia()
        Try
            ObjCon.Conectar()
            ObjCon.CrearComando("INSERT INTO cliente_membresia VALUES(?id, ?cliente_ci, ?membresia_id, " +
                                "?fecha_inicio, ?precio, 0)")
            ObjCon.AsignarParametro("?id", MySqlDbType.Int32, Id)
            ObjCon.AsignarParametro("?cliente_ci", MySqlDbType.String, ClienteCi)
            ObjCon.AsignarParametro("?membresia_id", MySqlDbType.Int32, MembresiaId)
            ObjCon.AsignarParametro("?fecha_inicio", MySqlDbType.Date, FechaInicio)
            ObjCon.AsignarParametro("?precio", MySqlDbType.Int32, Precio)
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


    Public Function UpdateClienteMembresia(ByVal MembresiaId As Integer,
                                           ByVal Id As Integer,
                                           ByVal FechaInicio As Date) As Boolean
        Dim inserto As Boolean = False
        Try
            ObjCon.Conectar()
            ObjCon.CrearComando("UPDATE cliente_membresia SET membresia_id = ?membresia_id, " +
                                "fecha_inicio = ?fecha_inicio WHERE id = ?id")
            ObjCon.AsignarParametro("?membresia_id", MySqlDbType.Int32, MembresiaId)
            ObjCon.AsignarParametro("?id", MySqlDbType.Int32, Id)
            ObjCon.AsignarParametro("?fecha_inicio", MySqlDbType.Date, FechaInicio)
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


    Public Function EliminarClienteMembresia(ByVal CI As String) As Boolean
        Dim elimino As Boolean = False
        Try
            ObjCon.Conectar()
            ObjCon.CrearComando("DELETE FROM cliente_membresia WHERE cliente_ci = ?ci")
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


    Public Function IdClienteMembresia(ByVal CI As String) As Integer
        IdClienteMembresia = -1
        ObjCon.Conectar()
        ObjCon.CrearComando("SELECT id FROM cliente_membresia WHERE cliente_ci = '" + CI + "' ORDER BY id DESC")
        ObjCon.dr = ObjCon.EjecutarReader()
        If ObjCon.dr.Read() Then
            Try
                IdClienteMembresia = ObjCon.dr.GetInt32(0)
            Catch
            End Try
        End If
        ObjCon.dr.Close()
        ObjCon.Desconectar()
    End Function


    Public Function IdClienteMembresia() As Int32
        IdClienteMembresia = 0
        ObjCon.Conectar()
        ObjCon.CrearComando("SELECT MAX(id) FROM cliente_membresia")
        ObjCon.dr = ObjCon.EjecutarReader()
        If ObjCon.dr.Read() Then
            Try
                IdClienteMembresia = ObjCon.dr.GetInt32(0)
            Catch
            End Try
        End If
        ObjCon.dr.Close()
        ObjCon.Desconectar()
        IdClienteMembresia += 1
    End Function


    Public Function IdPagoMembresia() As Int32
        IdPagoMembresia = 0
        ObjCon.Conectar()
        ObjCon.CrearComando("SELECT MAX(id) FROM pago_membresia")
        ObjCon.dr = ObjCon.EjecutarReader()
        If ObjCon.dr.Read() Then
            Try
                IdPagoMembresia = ObjCon.dr.GetInt32(0)
            Catch
            End Try
        End If
        ObjCon.dr.Close()
        ObjCon.Desconectar()
        IdPagoMembresia += 1
    End Function


    Public Function Pagar(ByVal IdClienteMembresia As Integer,
                          ByVal Fecha As DateTime,
                          ByVal Monto As Integer) As Boolean

        Dim inserto As Boolean = False
        Dim Id As Int32 = IdPagoMembresia()
        Try
            ObjCon.Conectar()
            ObjCon.CrearComando("INSERT INTO pago_membresia VALUES(?id, ?cliente_membresia_id, " +
                                "?fecha, ?monto)")
            ObjCon.AsignarParametro("?id", MySqlDbType.Int32, Id)
            ObjCon.AsignarParametro("?cliente_membresia_id", MySqlDbType.String, IdClienteMembresia)
            ObjCon.AsignarParametro("?fecha", MySqlDbType.DateTime, Fecha)
            ObjCon.AsignarParametro("?monto", MySqlDbType.Int32, Monto)
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


    Public Function Descuento(ByVal IdMembresiaCliente As Integer,
                              ByVal Desc As Integer) As Boolean
        Dim inserto As Boolean = False
        Try
            ObjCon.Conectar()
            ObjCon.CrearComando("UPDATE cliente_membresia SET descuento = ?descuento WHERE id = ?id")
            ObjCon.AsignarParametro("?id", MySqlDbType.Int32, IdMembresiaCliente)
            ObjCon.AsignarParametro("?descuento", MySqlDbType.Int32, Desc)
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


    Public Function BuscarPagoPeriodo(ByVal CI As String) As DataTable
        ObjCon.Conectar()
        ObjCon.CrearComando("SELECT * FROM view_cliente_membresia " +
                            "WHERE CI = '" + CI + "' ")
        BuscarPagoPeriodo = ObjCon.EjecutarDataTable()
        ObjCon.Desconectar()
    End Function

End Class
