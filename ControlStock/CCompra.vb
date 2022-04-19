Imports MySql.Data.MySqlClient
Public Class CCompra

    Private ObjCon As New CBaseDato()

    Public Function InserCompra(ByVal idCompra As Integer, ByVal idProveedorFK As String, ByVal Fecha As String, ByVal Cancelado As String, ByVal Entregado? As Integer, ByVal Vto As String) As Boolean
        Dim inserto As Boolean = False
        Try
            ObjCon.Conectar()
            ObjCon.CrearComando("INSERT INTO compra VALUES(?idCompra, ?idProvFK, ?fecha, ?cancelado, ?entregado, ?Vto)")
            ObjCon.AsignarParametro("?idCompra", MySqlDbType.Int32, idCompra)
            ObjCon.AsignarParametro("?idProvFK", MySqlDbType.String, idProveedorFK)
            ObjCon.AsignarParametro("?fecha", MySqlDbType.DateTime, Fecha)
            ObjCon.AsignarParametro("?cancelado", MySqlDbType.String, Cancelado)
            ObjCon.AsignarParametro("?entregado", MySqlDbType.Int32, Entregado)
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

    Public Function InserDetalleCompra(ByVal idCompraFK As Integer, ByVal idProdFK As String, ByVal Cant As Double, ByVal Unidades As Integer,
                                       ByVal Precio As Integer, ByVal Obs As String) As Boolean
        Dim inserto As Boolean = False
        Try
            ObjCon.Conectar()
            ObjCon.CrearComando("INSERT INTO detallecompra VALUES(?idComprafk, ?idprodfk, ?cant, ?unid, ?precio, ?obs)")
            ObjCon.AsignarParametro("?idComprafk", MySqlDbType.Int32, idCompraFK)
            ObjCon.AsignarParametro("?idprodfk", MySqlDbType.String, idProdFK)
            ObjCon.AsignarParametro("?cant", MySqlDbType.Double, Cant)
            ObjCon.AsignarParametro("?unid", MySqlDbType.Int32, Unidades)
            ObjCon.AsignarParametro("?precio", MySqlDbType.Int32, Precio)
            ObjCon.AsignarParametro("?obs", MySqlDbType.String, Obs)
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

    Public Function InserNota(ByVal idNota As Integer, ByVal idCompra As Integer, ByVal Fecha As String) As Boolean
        Dim inserto As Boolean = False
        Try
            ObjCon.Conectar()
            ObjCon.CrearComando("INSERT INTO notaccompra VALUES(?idNota, ?idCompra, ?fecha)")
            ObjCon.AsignarParametro("?idNota", MySqlDbType.Int32, idNota)
            ObjCon.AsignarParametro("?idCompra", MySqlDbType.Int32, idCompra)
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

    Public Function InserDetalleNota(ByVal idNotaFK As Integer, ByVal idCompraFK As Integer, ByVal idProdFK As String, ByVal Cant As Double, ByVal Unidades As Integer) As Boolean
        Dim inserto As Boolean = False
        Try
            ObjCon.Conectar()
            ObjCon.CrearComando("INSERT INTO detnotaccompra VALUES(?idNotafk, ?idComprafk, ?idprodfk, ?cant, ?unid)")
            ObjCon.AsignarParametro("?idNotafk", MySqlDbType.Int32, idNotaFK)
            ObjCon.AsignarParametro("?idComprafk", MySqlDbType.Int32, idCompraFK)
            ObjCon.AsignarParametro("?idprodfk", MySqlDbType.String, idProdFK)
            ObjCon.AsignarParametro("?cant", MySqlDbType.Double, Cant)
            ObjCon.AsignarParametro("?unid", MySqlDbType.Int32, Unidades)
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
                ObjCon.Desconectar()
                inserto = False
            End If
        Catch mierror As MySqlException
            inserto = False
        End Try
        Return inserto
    End Function

    Public Function InserRecibo(ByVal idRecibo As Integer, ByVal idCompraFK As Integer, _
                            ByVal Fecha As String, ByVal Importe As Integer) As Boolean
        Dim inserto As Boolean = False
        Try
            ObjCon.Conectar()
            ObjCon.CrearComando("INSERT INTO recibopagocuenta VALUES(?idRecibo, ?idCompra, ?fecha, ?Importe)")
            ObjCon.AsignarParametro("?idRecibo", MySqlDbType.Int32, idRecibo)
            ObjCon.AsignarParametro("?idCompra", MySqlDbType.Int32, idCompraFK)
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

    Public Function UpdateCompra(ByVal idCompra As Integer) As Boolean
        Dim inserto As Boolean = False
        Try
            ObjCon.Conectar()
            ObjCon.CrearComando("UPDATE Compra SET cancelado = 'Si' WHERE idCompra = ?idCompra")
            ObjCon.AsignarParametro("?idCompra", MySqlDbType.Int32, idCompra)
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

    Public Function UpdateCompra(ByVal Entregado As Integer, ByVal idCompra As Integer) As Boolean
        Dim inserto As Boolean = False
        Try
            ObjCon.Conectar()
            ObjCon.CrearComando("UPDATE Compra SET entregado = entregado + ?entregado WHERE idCompra = ?idCompra")
            ObjCon.AsignarParametro("?entregado", MySqlDbType.Int32, Entregado)
            ObjCon.AsignarParametro("?idCompra", MySqlDbType.Int32, idCompra)
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

    Public Function BuscViewCompra(ByVal Condicion As String) As DataTable
        ObjCon.Conectar()
        ObjCon.CrearComando("SELECT * FROM viewcompra " + Condicion)
        BuscViewCompra = ObjCon.EjecutarDataTable()
        ObjCon.Desconectar()
    End Function

    Public Function BuscViewCompra(ByVal Fecha1 As String, ByVal Fecha2 As String) As DataTable
        ObjCon.Conectar()
        ObjCon.CrearComando("SELECT date(Fecha), sum(Total) FROM viewCompra WHERE Fecha > '" + Fecha1 + "' AND Fecha < '" + Fecha2 + "' AND Cancelado = 'Si' AND Entregado = 0 GROUP BY date(Fecha)")
        BuscViewCompra = ObjCon.EjecutarDataTable()
        ObjCon.Desconectar()
    End Function

    Public Function BuscViewDetCompra(ByVal idCompra As String) As DataTable
        ObjCon.Conectar()
        ObjCon.CrearComando("SELECT * FROM viewDetCompra WHERE idCompraFK =" + idCompra)
        BuscViewDetCompra = ObjCon.EjecutarDataTable()
        ObjCon.Desconectar()
    End Function

    Public Function BuscViewGasto(ByVal Condicion As String) As DataTable
        ObjCon.Conectar()
        ObjCon.CrearComando("SELECT * FROM viewGasto " + Condicion)
        BuscViewGasto = ObjCon.EjecutarDataTable()
        ObjCon.Desconectar()
    End Function

    Public Function BuscNota(ByVal Fecha1 As String, ByVal Fecha2 As String) As DataTable
        ObjCon.Conectar()
        ObjCon.CrearComando("SELECT date(Fecha), sum(Total) FROM viewnotaccompra WHERE Fecha > '" + Fecha1 + "' AND Fecha < '" + Fecha2 + "' GROUP BY date(Fecha)")
        BuscNota = ObjCon.EjecutarDataTable()
        ObjCon.Desconectar()
    End Function

    Public Function BuscGasto(ByVal Fecha1 As String, ByVal Fecha2 As String) As DataTable
        ObjCon.Conectar()
        ObjCon.CrearComando("SELECT date(Fecha), sum(Importe) FROM gasto WHERE Fecha > '" + Fecha1 + "' AND Fecha < '" + Fecha2 + "' GROUP BY date(Fecha)")
        BuscGasto = ObjCon.EjecutarDataTable()
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
        ObjCon.CrearComando("SELECT * FROM recibopagocuenta WHERE Fecha > '" + Fecha1 + "' AND Fecha < '" + Fecha2 + "'")
        BuscRecibo = ObjCon.EjecutarDataTable()
        ObjCon.Desconectar()
    End Function

    Public Function BuscRecibo() As DataTable
        ObjCon.Conectar()
        ObjCon.CrearComando("SELECT * FROM recibopagocuenta ORDER BY idRecibo DESC")
        BuscRecibo = ObjCon.EjecutarDataTable()
        ObjCon.Desconectar()
    End Function

    Public Function BuscRecibo(ByVal idVenta As Integer) As DataTable
        ObjCon.Conectar()
        ObjCon.CrearComando("SELECT * FROM recibopagocuenta WHERE idCompraFK = " + CStr(idVenta))
        BuscRecibo = ObjCon.EjecutarDataTable()
        ObjCon.Desconectar()
    End Function

    Public Function BuscRecibo2(ByVal Fecha1 As String, ByVal Fecha2 As String) As DataTable
        ObjCon.Conectar()
        ObjCon.CrearComando("SELECT date(Fecha), sum(Importe) FROM recibopagocuenta WHERE Fecha > '" + Fecha1 + "' AND Fecha < '" + Fecha2 + "' GROUP BY date(Fecha)")
        BuscRecibo2 = ObjCon.EjecutarDataTable()
        ObjCon.Desconectar()
    End Function

    Public Function BuscEgreso(ByVal Rutina As String, ByVal Anho As String) As DataTable
        ObjCon.Conectar()
        ObjCon.CrearComando("CALL " + Rutina + "('" + Anho + "')")
        BuscEgreso = ObjCon.EjecutarDataTable()
        ObjCon.Desconectar()
    End Function

    Public Function CargarNroFacCompra() As Integer
        CargarNroFacCompra = 0
        ObjCon.Conectar()
        ObjCon.CrearComando("SELECT MAX(idCompra) FROM compra")
        ObjCon.dr = ObjCon.EjecutarReader()
        If ObjCon.dr.Read() Then
            Try
                CargarNroFacCompra = ObjCon.dr.GetInt32(0)
            Catch
            End Try
        Else
            CargarNroFacCompra = 0
        End If
        ObjCon.dr.Close()
        ObjCon.Desconectar()
        CargarNroFacCompra += 1
    End Function

    Public Function CargarNroNota() As Integer
        CargarNroNota = 0
        ObjCon.Conectar()
        ObjCon.CrearComando("SELECT MAX(idNota) FROM notaccompra")
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
        ObjCon.CrearComando("SELECT MAX(idRecibo) FROM recibopagocuenta")
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

    Public Function CargarNroGasto() As Int32
        CargarNroGasto = 0
        ObjCon.Conectar()
        ObjCon.CrearComando("SELECT MAX(idGasto) FROM gasto")
        ObjCon.dr = ObjCon.EjecutarReader()
        If ObjCon.dr.Read() Then
            Try
                CargarNroGasto = ObjCon.dr.GetInt32(0)
            Catch
            End Try
        Else
            CargarNroGasto = 0
        End If
        ObjCon.dr.Close()
        ObjCon.Desconectar()
        CargarNroGasto += 1
    End Function

    Public Function CargarNroListaGasto() As Int32
        CargarNroListaGasto = 0
        ObjCon.Conectar()
        ObjCon.CrearComando("SELECT MAX(idGasto) FROM listagasto")
        ObjCon.dr = ObjCon.EjecutarReader()
        If ObjCon.dr.Read() Then
            Try
                CargarNroListaGasto = ObjCon.dr.GetInt32(0)
            Catch
            End Try
        Else
            CargarNroListaGasto = 0
        End If
        ObjCon.dr.Close()
        ObjCon.Desconectar()
        CargarNroListaGasto += 1
    End Function

    Public Function ListarGasto() As DataTable
        ObjCon.Conectar()
        ObjCon.CrearComando("SELECT * FROM listagasto")
        ListarGasto = ObjCon.EjecutarDataTable()
        ObjCon.Desconectar()
    End Function

    Public Function DeleteGasto(ByVal idGasto As UInt32) As Boolean
        Dim inserto As Boolean = False
        Try
            ObjCon.Conectar()
            ObjCon.CrearComando("DELETE FROM listagasto WHERE idGasto = ?idGasto")
            ObjCon.AsignarParametro("?idGasto", MySqlDbType.UInt32, idGasto)
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

    Public Function InsertListaGasto(ByVal idGasto As Int32, ByVal Descrip As String) As Boolean
        Dim inserto As Boolean = False
        Try
            ObjCon.Conectar()
            ObjCon.CrearComando("INSERT INTO listagasto VALUES(?idGasto, ?Descrip)")
            ObjCon.AsignarParametro("?idGasto", MySqlDbType.UInt16, idGasto)
            ObjCon.AsignarParametro("?Descrip", MySqlDbType.String, Descrip)
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

    Public Function UpdateListaGasto(ByVal idGasto As Int32, ByVal Descrip As String) As Boolean
        Dim inserto As Boolean = False
        Try
            ObjCon.Conectar()
            ObjCon.CrearComando("UPDATE listagasto SET Descripcion = ?Descrip WHERE idGasto = ?idGasto")
            ObjCon.AsignarParametro("?idGasto", MySqlDbType.Int32, idGasto)
            ObjCon.AsignarParametro("?Descrip", MySqlDbType.String, Descrip)
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

    Public Function InsertGasto(ByVal idGasto As Int32, ByVal DescripFK As UInt32, ByVal Fecha As String, ByVal Importe As UInt32) As Boolean
        Dim inserto As Boolean = False
        Try
            ObjCon.Conectar()
            ObjCon.CrearComando("INSERT INTO gasto VALUES(?idGasto, ?Descrip, ?Fecha, ?Importe)")
            ObjCon.AsignarParametro("?idGasto", MySqlDbType.UInt32, idGasto)
            ObjCon.AsignarParametro("?Descrip", MySqlDbType.UInt32, DescripFK)
            ObjCon.AsignarParametro("?Fecha", MySqlDbType.DateTime, Fecha)
            ObjCon.AsignarParametro("?Importe", MySqlDbType.UInt32, Importe)
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
