Imports MySql.Data.MySqlClient
Public Class CProducto
    Private ObjCon As New BaseDato()

    Public Function InserProducto(ByVal idProd As UInt64, ByVal idProv As String, ByVal Descrip As String, ByVal Costo As Integer,
                                  ByVal Precio1 As Integer, ByVal Precio2 As Integer, ByVal Precio3 As Integer, ByVal PrecioPack? As Integer,
                                  ByVal CantUnit As Double, ByVal UnidXpack? As Integer,
                                  ByVal PorPack As String, ByVal Foto As Byte(), ByVal Iva As Int16) As Boolean
        Dim inserto As Boolean = False
        Try
            ObjCon.Conectar()
            ObjCon.CrearComando("zproducto_insert")
            ObjCon.CrearProcedimiento()
            ObjCon.AsignarParametro("@idprod", idProd)
            ObjCon.AsignarParametro("@idprov", idProv)
            ObjCon.AsignarParametro("@descrip", Descrip)
            ObjCon.AsignarParametro("@costo", Costo)
            ObjCon.AsignarParametro("@precio1", Precio1)
            ObjCon.AsignarParametro("@precio2", Precio2)
            ObjCon.AsignarParametro("@precio3", Precio3)
            ObjCon.AsignarParametro("@preciopack", PrecioPack)
            ObjCon.AsignarParametro("@stock", CantUnit)
            ObjCon.AsignarParametro("@unidxpack", UnidXpack)
            ObjCon.AsignarParametro("@porpack", PorPack)
            ObjCon.AsignarParametro("@foto", Foto)
            ObjCon.AsignarParametro("@iva", Iva)
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

    Public Function InsertBaja(ByVal idBaja As UInt32, ByVal idProd As UInt64, ByVal Fecha As String, ByVal Cant As Double, ByVal idMotivo As UInt16) As Boolean
        Dim inserto As Boolean = False
        Try
            ObjCon.Conectar()
            ObjCon.CrearComando("INSERT INTO bajaprod VALUES(?idBaja, ?idProd, ?Fecha, ?Cant, ?idMotivo)")
            ObjCon.AsignarParametro("?idBaja", MySqlDbType.UInt32, idBaja)
            ObjCon.AsignarParametro("?idProd", MySqlDbType.UInt64, idProd)
            ObjCon.AsignarParametro("?Fecha", MySqlDbType.DateTime, Fecha)
            ObjCon.AsignarParametro("?Cant", MySqlDbType.Double, Cant)
            ObjCon.AsignarParametro("?idMotivo", MySqlDbType.UInt16, idMotivo)
            If ObjCon.EjecutarConsulta() = 0 Then
                ObjCon.Desconectar()
                Exit Try
            End If
            ObjCon.CrearComando("UPDATE producto SET Stock = Stock - ?cant where idproducto = ?idprodfk")
            ObjCon.AsignarParametro("?cant", MySqlDbType.Double, Cant)
            ObjCon.AsignarParametro("?idprodfk", MySqlDbType.UInt64, idProd)
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

    Public Function InsertAlta(ByVal idAlta As UInt32, ByVal idProd As UInt64, ByVal Fecha As String, ByVal Cant As Double, ByVal idMotivo As UInt16) As Boolean
        Dim inserto As Boolean = False
        Try
            ObjCon.Conectar()
            ObjCon.CrearComando("INSERT INTO altaprod VALUES(?idAlta, ?idProd, ?Fecha, ?Cant, ?idMotivo)")
            ObjCon.AsignarParametro("?idAlta", MySqlDbType.UInt32, idAlta)
            ObjCon.AsignarParametro("?idProd", MySqlDbType.UInt64, idProd)
            ObjCon.AsignarParametro("?Fecha", MySqlDbType.DateTime, Fecha)
            ObjCon.AsignarParametro("?cant", MySqlDbType.Double, Cant)
            ObjCon.AsignarParametro("?idMotivo", MySqlDbType.UInt16, idMotivo)
            If ObjCon.EjecutarConsulta() = 0 Then
                ObjCon.Desconectar()
                Exit Try
            End If
            ObjCon.CrearComando("UPDATE producto SET Stock = Stock + ?cant where idproducto = ?idprodfk")
            ObjCon.AsignarParametro("?cant", MySqlDbType.Double, Cant)
            ObjCon.AsignarParametro("?idprodfk", MySqlDbType.UInt64, idProd)
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

    Public Function InsertMotivoBaja(ByVal idMotivo As UInt16, ByVal Motivo As String) As Boolean
        Dim inserto As Boolean = False
        Try
            ObjCon.Conectar()
            ObjCon.CrearComando("INSERT INTO bajaprodmotivo VALUES(?idMotivo, ?Motivo)")
            ObjCon.AsignarParametro("?idMotivo", MySqlDbType.UInt16, idMotivo)
            ObjCon.AsignarParametro("?Motivo", MySqlDbType.String, Motivo)
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

    Public Function InsertMotivoAlta(ByVal idMotivo As UInt16, ByVal Motivo As String) As Boolean
        Dim inserto As Boolean = False
        Try
            ObjCon.Conectar()
            ObjCon.CrearComando("INSERT INTO altaprodmotivo VALUES(?idMotivo, ?Motivo)")
            ObjCon.AsignarParametro("?idMotivo", MySqlDbType.UInt16, idMotivo)
            ObjCon.AsignarParametro("?Motivo", MySqlDbType.String, Motivo)
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

    Public Function DeleteMotivoBaja(ByVal idMotivo As UInt16) As Boolean
        Dim inserto As Boolean = False
        Try
            ObjCon.Conectar()
            ObjCon.CrearComando("DELETE FROM bajaprodmotivo WHERE idMotivo = ?idMotivo")
            ObjCon.AsignarParametro("?idMotivo", MySqlDbType.UInt16, idMotivo)
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

    Public Function DeleteMotivoAlta(ByVal idMotivo As UInt16) As Boolean
        Dim inserto As Boolean = False
        Try
            ObjCon.Conectar()
            ObjCon.CrearComando("DELETE FROM altaprodmotivo WHERE idMotivo = ?idMotivo")
            ObjCon.AsignarParametro("?idMotivo", MySqlDbType.UInt16, idMotivo)
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

    Public Function UpdateMotivoBaja(ByVal idMotivo As UInt16, ByVal Motivo As String) As Boolean
        Dim inserto As Boolean = False
        Try
            ObjCon.Conectar()
            ObjCon.CrearComando("UPDATE bajaprodmotivo SET Motivo = ?Motivo WHERE idMotivo = ?idMotivo")
            ObjCon.AsignarParametro("?idMotivo", MySqlDbType.UInt16, idMotivo)
            ObjCon.AsignarParametro("?Motivo", MySqlDbType.String, Motivo)
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

    Public Function UpdateMotivoAlta(ByVal idMotivo As UInt16, ByVal Motivo As String) As Boolean
        Dim inserto As Boolean = False
        Try
            ObjCon.Conectar()
            ObjCon.CrearComando("UPDATE altaprodmotivo SET Motivo = ?Motivo WHERE idMotivo = ?idMotivo")
            ObjCon.AsignarParametro("?idMotivo", MySqlDbType.UInt16, idMotivo)
            ObjCon.AsignarParametro("?Motivo", MySqlDbType.String, Motivo)
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

    Public Function Update(ByVal idProd As UInt64, ByVal idProv As String, ByVal Descrip As String, ByVal Costo As Integer,
                              ByVal Precio1 As Integer, ByVal Precio2 As Integer, ByVal Precio3 As Integer, ByVal PrecioPack? As Integer,
                              ByVal CantUnit As Double, ByVal UnidXpack? As Integer,
                              ByVal PorPack As String, ByVal Foto As Byte(), ByVal Iva_ As Int16, ByVal OldidProd As UInt64) As Boolean
        Dim inserto As Boolean = False
        Try
            ObjCon.Conectar()
            ObjCon.CrearComando("zproducto_update")
            ObjCon.CrearProcedimiento()
            ObjCon.AsignarParametro("@idprod", idProd)
            ObjCon.AsignarParametro("@idprov", idProv)
            ObjCon.AsignarParametro("@descrip", Descrip)
            ObjCon.AsignarParametro("@Cost", Costo)
            ObjCon.AsignarParametro("@Prec1", Precio1)
            ObjCon.AsignarParametro("@Prec2", Precio2)
            ObjCon.AsignarParametro("@Prec3", Precio3)
            ObjCon.AsignarParametro("@PrecPack", PrecioPack)
            ObjCon.AsignarParametro("@cantunit", CantUnit)
            ObjCon.AsignarParametro("@unidxpak", UnidXpack)
            ObjCon.AsignarParametro("@porpak", PorPack)
            ObjCon.AsignarParametro("@foti", Foto)
            ObjCon.AsignarParametro("@Iva_", Iva_)
            ObjCon.AsignarParametro("@oldidProd", OldidProd)
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

    Public Function Eliminar(ByVal idProd As String) As Boolean
        Dim elimino As Boolean = False
        Dim NewIdProd = 1111111
        Try
            ObjCon.Conectar()
            ActualizarTabla("detalleventa", idProd, NewIdProd)
            ActualizarTabla("detallecompra", idProd, NewIdProd)
            ActualizarTabla("detnotacventa", idProd, NewIdProd)
            ActualizarTabla("detnotaccompra", idProd, NewIdProd)
            ActualizarTabla("altaprod", idProd, NewIdProd)
            ActualizarTabla("bajaprod", idProd, NewIdProd)

            ObjCon.CrearComando("DELETE FROM Producto WHERE idProducto = ?idProd")
            ObjCon.AsignarParametro("?idProd", MySqlDbType.UInt64, idProd)
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

    Private Sub ActualizarTabla(ByVal Tabla As String, ByVal idProd As String, ByVal NewIdProd As UInt64)
        Try
            ObjCon.CrearComando("UPDATE " + Tabla + " SET idproductofk = " + NewIdProd.ToString + " WHERE idproductofk = " + idProd)
            ObjCon.EjecutarConsulta()
        Catch
            If NewIdProd < 111130 Then
                ActualizarTabla(Tabla, idProd, NewIdProd + 1)
            End If
        End Try
    End Sub

    Public Function UpdatePrecio(ByVal idProd As UInt64, ByVal Costo As Integer, ByVal idProv As String) As Boolean
        Dim inserto As Boolean = False
        Try
            ObjCon.Conectar()
            ObjCon.CrearComando("UPDATE Producto SET Costo = ?Costo, idProveedorFK = ?idprov WHERE idProducto = ?idProd")
            ObjCon.AsignarParametro("?idprod", MySqlDbType.UInt64, idProd)
            ObjCon.AsignarParametro("?Costo", MySqlDbType.Int32, Costo)
            ObjCon.AsignarParametro("?idprov", MySqlDbType.String, idProv)
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

    Public Function BuscProdDesc(ByVal Descrip As String) As DataTable
        ObjCon.Conectar()
        ObjCon.CrearComando("SELECT * FROM Producto WHERE Descripcion like '%" + Descrip + "%'")
        BuscProdDesc = ObjCon.EjecutarDataTable()
        ObjCon.Desconectar()
    End Function

    Public Function BuscProdCod(ByVal Cod As String) As DataTable
        ObjCon.Conectar()
        ObjCon.CrearComando("SELECT * FROM Producto WHERE idProducto =" + Cod)
        BuscProdCod = ObjCon.EjecutarDataTable()
        ObjCon.Desconectar()
    End Function

    Public Function BuscProd(ByVal Condicion As String) As DataTable
        ObjCon.Conectar()
        ObjCon.CrearComando("SELECT * FROM viewProducto " + Condicion)
        BuscProd = ObjCon.EjecutarDataTable()
        ObjCon.Desconectar()
    End Function

    Public Function BuscProd(ByVal Campo As String, ByVal Operador As String, ByVal Parametro As String, ByVal Condicion As String) As DataTable
        ObjCon.Conectar()
        ObjCon.CrearComando("SELECT * FROM viewProducto WHERE " + Campo + Operador + "'" + Parametro + "'" + Condicion)
        BuscProd = ObjCon.EjecutarDataTable()
        ObjCon.Desconectar()
    End Function

    Public Function BuscProd(ByVal Campo1 As String, ByVal Parametro1 As String, ByVal Campo2 As String, ByVal Operador As String, ByVal Parametro2 As String) As DataTable
        ObjCon.Conectar()
        ObjCon.CrearComando("SELECT * FROM viewProducto WHERE " + Campo1 + "='" + Parametro1 + "' And " + Campo2 + Operador + Parametro2)
        BuscProd = ObjCon.EjecutarDataTable()
        ObjCon.Desconectar()
    End Function

    Public Function BuscViewBaja(ByVal Condicion As String) As DataTable
        ObjCon.Conectar()
        ObjCon.CrearComando("SELECT * FROM viewBajaProd " + Condicion)
        BuscViewBaja = ObjCon.EjecutarDataTable()
        ObjCon.Desconectar()
    End Function

    Public Function BuscViewAlta(ByVal Condicion As String) As DataTable
        ObjCon.Conectar()
        ObjCon.CrearComando("SELECT * FROM viewAltaProd " + Condicion)
        BuscViewAlta = ObjCon.EjecutarDataTable()
        ObjCon.Desconectar()
    End Function

    Public Function CargarNroProd() As UInt64
        Dim Menor As UInt64 = 1
        CargarNroProd = 1
        ObjCon.Conectar()
        ObjCon.CrearComando("SELECT idProducto FROM Producto ORDER BY idProducto ASC")
        ObjCon.dr = ObjCon.EjecutarReader()
        While ObjCon.dr.Read()
            CargarNroProd = ObjCon.dr.GetUInt64(0)
            If CargarNroProd = Menor Then
                Menor += 1
            End If
        End While
        ObjCon.dr.Close()
        ObjCon.Desconectar()
        CargarNroProd = Menor
    End Function

    Public Function CargarNroBaja() As UInt32
        CargarNroBaja = 0
        ObjCon.Conectar()
        ObjCon.CrearComando("SELECT MAX(idBaja) FROM bajaprod")
        ObjCon.dr = ObjCon.EjecutarReader()
        If ObjCon.dr.Read() Then
            Try
                CargarNroBaja = ObjCon.dr.GetInt32(0)
            Catch
            End Try
        Else
            CargarNroBaja = 0
        End If
        ObjCon.dr.Close()
        ObjCon.Desconectar()
        CargarNroBaja += 1
    End Function

    Public Function CargarNroBajaMotivo() As UInt16
        CargarNroBajaMotivo = 0
        ObjCon.Conectar()
        ObjCon.CrearComando("SELECT MAX(idMotivo) FROM bajaprodmotivo")
        ObjCon.dr = ObjCon.EjecutarReader()
        If ObjCon.dr.Read() Then
            Try
                CargarNroBajaMotivo = ObjCon.dr.GetInt32(0)
            Catch
            End Try
        Else
            CargarNroBajaMotivo = 0
        End If
        ObjCon.dr.Close()
        ObjCon.Desconectar()
        CargarNroBajaMotivo += 1
    End Function

    Public Function CargarNroAltaMotivo() As UInt16
        CargarNroAltaMotivo = 0
        ObjCon.Conectar()
        ObjCon.CrearComando("SELECT MAX(idMotivo) FROM altaprodmotivo")
        ObjCon.dr = ObjCon.EjecutarReader()
        If ObjCon.dr.Read() Then
            Try
                CargarNroAltaMotivo = ObjCon.dr.GetInt32(0)
            Catch
            End Try
        Else
            CargarNroAltaMotivo = 0
        End If
        ObjCon.dr.Close()
        ObjCon.Desconectar()
        CargarNroAltaMotivo += 1
    End Function

    Public Function CargarNroAlta() As UInt32
        CargarNroAlta = 0
        ObjCon.Conectar()
        ObjCon.CrearComando("SELECT MAX(idAlta) FROM altaprod")
        ObjCon.dr = ObjCon.EjecutarReader()
        If ObjCon.dr.Read() Then
            Try
                CargarNroAlta = ObjCon.dr.GetInt32(0)
            Catch
            End Try
        Else
            CargarNroAlta = 0
        End If
        ObjCon.dr.Close()
        ObjCon.Desconectar()
        CargarNroAlta += 1
    End Function

    Public Function ListarMotivoBaja() As DataTable
        ObjCon.Conectar()
        ObjCon.CrearComando("SELECT * FROM BajaProdMotivo")
        ListarMotivoBaja = ObjCon.EjecutarDataTable()
        ObjCon.Desconectar()
    End Function

    Public Function ListarMotivoAlta() As DataTable
        ObjCon.Conectar()
        ObjCon.CrearComando("SELECT * FROM AltaProdMotivo")
        ListarMotivoAlta = ObjCon.EjecutarDataTable()
        ObjCon.Desconectar()
    End Function

End Class
