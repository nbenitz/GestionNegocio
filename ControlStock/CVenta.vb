Imports MySql.Data.MySqlClient
Public Class CVenta
    Private ObjCon As New CBaseDato()

    Public Function InserVenta(ByVal idVenta As Integer, ByVal idEmpleFK As Integer, ByVal idClienteFK As String, ByVal Fecha As String, ByVal Cancelado As String, ByVal Entregado? As Integer, ByVal Vto As String) As Boolean
        Dim inserto As Boolean = False
        Try
            ObjCon.Conectar()
            ObjCon.CrearComando("INSERT INTO Venta VALUES(?idVenta, ?idEmpleFK, ?idClienteFK, ?fecha, ?Cancelado, ?Entregado, ?Vto, 'No')")
            ObjCon.AsignarParametro("?idVenta", MySqlDbType.UInt32, idVenta)
            ObjCon.AsignarParametro("?idEmpleFK", MySqlDbType.Int32, idEmpleFK)
            ObjCon.AsignarParametro("?idClienteFK", MySqlDbType.String, idClienteFK)
            ObjCon.AsignarParametro("?fecha", MySqlDbType.DateTime, Fecha)
            ObjCon.AsignarParametro("?Cancelado", MySqlDbType.String, Cancelado)
            ObjCon.AsignarParametro("?Entregado", MySqlDbType.Int32, Entregado)
            ObjCon.AsignarParametro("?Vto", MySqlDbType.Date, Vto)
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

    Public Function InserDetalleVenta(ByVal idVentaFK As Integer, ByVal idProdFK As String, ByVal Cant As Double, ByVal Unidades As Double,
                                      ByVal Precio As Integer, ByVal Obs As String, ByVal Desc As Integer) As Boolean
        Dim inserto As Boolean = False
        Try
            ObjCon.Conectar()
            ObjCon.CrearComando("INSERT INTO detalleventa VALUES(?idVentafk, ?idprodfk, ?cant, ?unid, ?precio, ?obs, ?desc)")
            ObjCon.AsignarParametro("?idVentafk", MySqlDbType.UInt32, idVentaFK)
            ObjCon.AsignarParametro("?idprodfk", MySqlDbType.String, idProdFK)
            ObjCon.AsignarParametro("?cant", MySqlDbType.Double, Cant)
            ObjCon.AsignarParametro("?unid", MySqlDbType.Double, Unidades)
            ObjCon.AsignarParametro("?precio", MySqlDbType.Int32, Precio)
            ObjCon.AsignarParametro("?obs", MySqlDbType.String, Obs)
            ObjCon.AsignarParametro("?desc", MySqlDbType.Int32, Desc)
            If ObjCon.EjecutarConsulta() = 0 Then
                ObjCon.Desconectar()
                Exit Try
            End If
            Cant = Cant * Unidades
            ObjCon.CrearComando("UPDATE producto SET Stock = Stock - ?cant where idproducto = ?idprodfk")
            ObjCon.AsignarParametro("?cant", MySqlDbType.Double, Cant)
            ObjCon.AsignarParametro("?idprodfk", MySqlDbType.String, idProdFK)
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

    Public Function InserNota(ByVal idNota As Integer, ByVal idVenta As Integer, ByVal Fecha As String) As Boolean
        Dim inserto As Boolean = False
        Try
            ObjCon.Conectar()
            ObjCon.CrearComando("INSERT INTO notacventa VALUES(?idNota, ?idVenta, ?fecha)")
            ObjCon.AsignarParametro("?idNota", MySqlDbType.Int32, idNota)
            ObjCon.AsignarParametro("?idVenta", MySqlDbType.Int32, idVenta)
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

    Public Function InserDetalleNota(ByVal idNotaFK As Integer, ByVal idVentaFK As Integer, ByVal idProdFK As String, ByVal Cant As Double, ByVal Unidades As Integer) As Boolean
        Dim inserto As Boolean = False
        Try
            ObjCon.Conectar()
            ObjCon.CrearComando("INSERT INTO detnotacventa VALUES(?idNotafk, ?idVentafk, ?idprodfk, ?cant, ?unid)")
            ObjCon.AsignarParametro("?idNotafk", MySqlDbType.Int32, idNotaFK)
            ObjCon.AsignarParametro("?idVentafk", MySqlDbType.Int32, idVentaFK)
            ObjCon.AsignarParametro("?idprodfk", MySqlDbType.String, idProdFK)
            ObjCon.AsignarParametro("?cant", MySqlDbType.Double, Cant)
            ObjCon.AsignarParametro("?unid", MySqlDbType.Int32, Unidades)
            If ObjCon.EjecutarConsulta() = 0 Then
                ObjCon.Desconectar()
                Exit Try
            End If
            Cant = Cant * Unidades
            ObjCon.CrearComando("UPDATE producto SET Stock = Stock + ?cant where idproducto = ?idprodfk")
            ObjCon.AsignarParametro("?cant", MySqlDbType.Double, Cant)
            ObjCon.AsignarParametro("?idprodfk", MySqlDbType.String, idProdFK)
            If ObjCon.EjecutarConsulta() > 0 Then
                inserto = True
            Else
                ObjCon.Desconectar()
                inserto = False
            End If
        Catch mierror As MySqlException
            inserto = False
        End Try
        Return inserto
    End Function

    Public Function InserRecibo(ByVal idRecibo As Integer, ByVal idVentaFK As Integer,
                            ByVal Fecha As String, ByVal Importe As Integer) As Boolean
        Dim inserto As Boolean = False
        Try
            ObjCon.Conectar()
            ObjCon.CrearComando("INSERT INTO recibocobrocuenta VALUES(?idRecibo, ?idVenta, ?fecha, ?Importe)")
            ObjCon.AsignarParametro("?idRecibo", MySqlDbType.Int32, idRecibo)
            ObjCon.AsignarParametro("?idVenta", MySqlDbType.UInt32, idVentaFK)
            ObjCon.AsignarParametro("?fecha", MySqlDbType.DateTime, Fecha)
            ObjCon.AsignarParametro("?Importe", MySqlDbType.Int32, Importe)
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

    Public Function SetCancelado(ByVal idVenta As Integer) As Boolean
        Dim inserto As Boolean = False
        Try
            ObjCon.Conectar()
            ObjCon.CrearComando("UPDATE Venta SET cancelado = 'Si' WHERE idVenta = ?idVenta")
            ObjCon.AsignarParametro("?idVenta", MySqlDbType.Int32, idVenta)
            If ObjCon.EjecutarConsulta() > 0 Then
                inserto = True
            Else
                ObjCon.Desconectar()
                inserto = False
            End If
        Catch mierror As MySqlException
            inserto = False
        End Try
        Return inserto
    End Function

    Public Function UpdateVenta(ByVal Entregado As Integer, ByVal idVenta As Integer) As Boolean
        Dim inserto As Boolean = False
        Try
            ObjCon.Conectar()
            ObjCon.CrearComando("UPDATE Venta SET entregado = entregado + ?entregado WHERE idVenta = ?idVenta")
            ObjCon.AsignarParametro("?entregado", MySqlDbType.Int32, Entregado)
            ObjCon.AsignarParametro("?idVenta", MySqlDbType.UInt32, idVenta)
            If ObjCon.EjecutarConsulta() > 0 Then
                inserto = True
            Else
                ObjCon.Desconectar()
                inserto = False
            End If
        Catch mierror As MySqlException
            inserto = False
        End Try
        Return inserto
    End Function

    Public Function BuscViewVenta(ByVal Condicion As String) As DataTable
        ObjCon.Conectar()
        ObjCon.CrearComando("SELECT * FROM viewVenta " + Condicion)
        BuscViewVenta = ObjCon.EjecutarDataTable()
        ObjCon.Desconectar()
    End Function

    Public Function BuscViewCuentas(ByVal Condicion As String) As DataTable
        ObjCon.Conectar()
        ObjCon.CrearComando("SELECT * FROM view_cuentas_cobrar " + Condicion)
        BuscViewCuentas = ObjCon.EjecutarDataTable()
        ObjCon.Desconectar()
    End Function

    Public Function BuscViewVenta(ByVal Fecha1 As String, ByVal Fecha2 As String) As DataTable
        ObjCon.Conectar()
        ObjCon.CrearComando("SELECT date(Fecha), sum(Total) FROM viewVenta WHERE Fecha > '" + Fecha1 + "' AND Fecha < '" + Fecha2 + "' AND Cancelado = 'Si' AND Entregado = 0 GROUP BY date(Fecha)")
        BuscViewVenta = ObjCon.EjecutarDataTable()
        ObjCon.Desconectar()
    End Function

    Public Function BuscViewIngreso(ByVal Fecha1 As String, ByVal Fecha2 As String) As DataTable
        ObjCon.Conectar()
        ObjCon.CrearComando("SELECT * FROM view_ingreso_mes WHERE Fecha >= '" + Fecha1 + "' AND Fecha < '" + Fecha2 + "'")
        BuscViewIngreso = ObjCon.EjecutarDataTable()
        ObjCon.Desconectar()
    End Function

    Public Function BuscIngreso(ByVal Rutina As String, ByVal Anho As String) As DataTable
        ObjCon.Conectar()
        ObjCon.CrearComando("CALL " + Rutina + "('" + Anho + "')")
        BuscIngreso = ObjCon.EjecutarDataTable()
        ObjCon.Desconectar()
    End Function

    Public Function BuscNota(ByVal Fecha1 As String, ByVal Fecha2 As String) As DataTable
        ObjCon.Conectar()
        ObjCon.CrearComando("SELECT date(Fecha), sum(Total) FROM viewnotacventa WHERE Fecha > '" + Fecha1 + "' AND Fecha < '" + Fecha2 + "' GROUP BY date(Fecha)")
        BuscNota = ObjCon.EjecutarDataTable()
        ObjCon.Desconectar()
    End Function

    Public Function BuscRecibo(ByVal Fecha As String) As DataTable
        ObjCon.Conectar()
        Dim Fecha2 As String = CStr(DateAdd(DateInterval.Day, 1, CDate(Fecha)))
        ObjCon.CrearComando("SELECT * FROM recibocobrocuenta WHERE Fecha > '" + Fecha + "' AND Fecha < '" + Fecha2 + "'")
        BuscRecibo = ObjCon.EjecutarDataTable()
        ObjCon.Desconectar()
    End Function

    Public Function BuscRecibo(ByVal Fecha1 As String, ByVal Fecha2 As String) As DataTable
        ObjCon.Conectar()
        ObjCon.CrearComando("SELECT * FROM recibocobrocuenta WHERE Fecha > '" + Fecha1 + "' AND Fecha < '" + Fecha2 + "'")
        BuscRecibo = ObjCon.EjecutarDataTable()
        ObjCon.Desconectar()
    End Function

    Public Function BuscRecibo() As DataTable
        ObjCon.Conectar()
        ObjCon.CrearComando("SELECT * FROM recibocobrocuenta ORDER BY idRecibo DESC")
        BuscRecibo = ObjCon.EjecutarDataTable()
        ObjCon.Desconectar()
    End Function

    Public Function BuscRecibo2(ByVal Fecha1 As String, ByVal Fecha2 As String) As DataTable
        ObjCon.Conectar()
        ObjCon.CrearComando("SELECT date(Fecha), sum(Importe) FROM recibocobrocuenta WHERE Fecha > '" + Fecha1 + "' AND Fecha < '" + Fecha2 + "' GROUP BY date(Fecha)")
        BuscRecibo2 = ObjCon.EjecutarDataTable()
        ObjCon.Desconectar()
    End Function

    Public Function BuscRecibo(ByVal idVenta As Integer) As DataTable
        ObjCon.Conectar()
        ObjCon.CrearComando("SELECT * FROM recibocobrocuenta WHERE idVentaFK = " + CStr(idVenta))
        BuscRecibo = ObjCon.EjecutarDataTable()
        ObjCon.Desconectar()
    End Function

    Public Function BuscViewDetVenta(ByVal idVenta As String) As DataTable
        ObjCon.Conectar()
        ObjCon.CrearComando("SELECT * FROM viewDetVenta WHERE idVentaFK =" + idVenta)
        BuscViewDetVenta = ObjCon.EjecutarDataTable()
        ObjCon.Desconectar()
    End Function

    Public Function BuscViewDetOcup(ByVal idVenta As String) As DataTable
        ObjCon.Conectar()
        ObjCon.CrearComando("SELECT * FROM viewDetOcupacion WHERE idVentaFK =" + idVenta)
        BuscViewDetOcup = ObjCon.EjecutarDataTable()
        ObjCon.Desconectar()
    End Function

    Public Function CargarNroFac() As Integer
        CargarNroFac = 0
        ObjCon.Conectar()
        ObjCon.CrearComando("SELECT MAX(idVenta) FROM Venta")
        ObjCon.dr = ObjCon.EjecutarReader()
        If ObjCon.dr.Read() Then
            Try
                CargarNroFac = ObjCon.dr.GetInt32(0)
            Catch
            End Try
        Else
            CargarNroFac = 0
        End If
        ObjCon.dr.Close()
        ObjCon.Desconectar()
        CargarNroFac += 1
    End Function

    Public Function CargarNroNota() As Integer
        CargarNroNota = 0
        ObjCon.Conectar()
        ObjCon.CrearComando("SELECT MAX(idNota) FROM notacventa")
        ObjCon.dr = ObjCon.EjecutarReader()
        If ObjCon.dr.Read() Then
            Try
                CargarNroNota = ObjCon.dr.GetInt32(0)
            Catch
            End Try
        Else
            CargarNroNota = 0
        End If
        ObjCon.dr.Close()
        ObjCon.Desconectar()
        CargarNroNota += 1
    End Function

    Public Function CargarNroRecib() As Integer
        CargarNroRecib = 0
        ObjCon.Conectar()
        ObjCon.CrearComando("SELECT MAX(idRecibo) FROM recibocobrocuenta")
        ObjCon.dr = ObjCon.EjecutarReader()
        If ObjCon.dr.Read() Then
            Try
                CargarNroRecib = ObjCon.dr.GetInt32(0)
            Catch
            End Try
        Else
            CargarNroRecib = 0
        End If
        ObjCon.dr.Close()
        ObjCon.Desconectar()
        CargarNroRecib += 1
    End Function

End Class
