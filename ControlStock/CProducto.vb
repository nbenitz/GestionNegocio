Option Strict On

Imports MySql.Data.MySqlClient
Public Class CProducto
    Private ObjCon As New CBaseDato()

    Public Function InserProducto(ByVal idProd As String, ByVal idProv As String, ByVal idCateg As String, ByVal Descrip As String, ByVal Costo As Integer,
                                  ByVal Precio1 As Integer, ByVal Precio2 As Integer, ByVal Precio3 As Integer, ByVal PrecioPack? As Integer,
                                  ByVal CantUnit As Double, ByVal UnidXpack? As Double, ByVal PorPack As String,
                                  ByVal Foto As Byte(), ByVal Iva As Int16,
                                  ByVal Lado1? As Double, ByVal Lado2? As Double, ByVal MxCaja? As Double, ByVal Favorito As Integer) As Boolean
        Dim inserto As Boolean = False
        Try
            ObjCon.Conectar()
            ObjCon.CrearComando("zproducto_insert")
            ObjCon.CrearProcedimiento()
            ObjCon.AsignarParametro("@idprod", idProd)
            ObjCon.AsignarParametro("@idprov", idProv)
            ObjCon.AsignarParametro("@idcateg", idCateg)
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
            ObjCon.AsignarParametro("@lado1", Lado1)
            ObjCon.AsignarParametro("@lado2", Lado2)
            ObjCon.AsignarParametro("@mxcaja", MxCaja)
            ObjCon.AsignarParametro("@favorito", Favorito)
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

    Public Function InsertCategoria(ByVal idCateg As UInt32, ByVal Descrip As String) As Boolean
        Dim inserto As Boolean = False
        Try
            ObjCon.Conectar()
            ObjCon.CrearComando("INSERT INTO categoria_prod VALUES(?idCateg, ?Descrip)")
            ObjCon.AsignarParametro("?idCateg", MySqlDbType.UInt32, idCateg)
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

    Public Function InsertBaja(ByVal idBaja As UInt32, ByVal idProd As String, ByVal Fecha As String, ByVal Cant As Double, ByVal idMotivo As UInt16) As Boolean
        Dim inserto As Boolean = False
        Try
            ObjCon.Conectar()
            ObjCon.CrearComando("INSERT INTO bajaprod VALUES(?idBaja, ?idProd, ?Fecha, ?Cant, ?idMotivo)")
            ObjCon.AsignarParametro("?idBaja", MySqlDbType.UInt32, idBaja)
            ObjCon.AsignarParametro("?idProd", MySqlDbType.String, idProd)
            ObjCon.AsignarParametro("?Fecha", MySqlDbType.DateTime, Fecha)
            ObjCon.AsignarParametro("?Cant", MySqlDbType.Double, Cant)
            ObjCon.AsignarParametro("?idMotivo", MySqlDbType.UInt16, idMotivo)
            If ObjCon.EjecutarConsulta() = 0 Then
                ObjCon.Desconectar()
                Exit Try
            End If
            ObjCon.CrearComando("UPDATE producto SET Stock = Stock - ?cant where idproducto = ?idprodfk")
            ObjCon.AsignarParametro("?cant", MySqlDbType.Double, Cant)
            ObjCon.AsignarParametro("?idprodfk", MySqlDbType.String, idProd)
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

    Public Function InsertAlta(ByVal idAlta As UInt32, ByVal idProd As String, ByVal Fecha As String, ByVal Cant As Double, ByVal idMotivo As UInt16) As Boolean
        Dim inserto As Boolean = False
        Try
            ObjCon.Conectar()
            ObjCon.CrearComando("INSERT INTO altaprod VALUES(?idAlta, ?idProd, ?Fecha, ?Cant, ?idMotivo)")
            ObjCon.AsignarParametro("?idAlta", MySqlDbType.UInt32, idAlta)
            ObjCon.AsignarParametro("?idProd", MySqlDbType.String, idProd)
            ObjCon.AsignarParametro("?Fecha", MySqlDbType.DateTime, Fecha)
            ObjCon.AsignarParametro("?cant", MySqlDbType.Double, Cant)
            ObjCon.AsignarParametro("?idMotivo", MySqlDbType.UInt16, idMotivo)
            If ObjCon.EjecutarConsulta() = 0 Then
                ObjCon.Desconectar()
                Exit Try
            End If
            ObjCon.CrearComando("UPDATE producto SET Stock = Stock + ?cant where idproducto = ?idprodfk")
            ObjCon.AsignarParametro("?cant", MySqlDbType.Double, Cant)
            ObjCon.AsignarParametro("?idprodfk", MySqlDbType.String, idProd)
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

    Public Function DeleteCategoria(ByVal idCateg As UInt32) As Boolean
        Dim inserto As Boolean = False
        Try
            ObjCon.Conectar()
            ObjCon.CrearComando("DELETE FROM categoria_prod WHERE id_categoria = ?idCateg")
            ObjCon.AsignarParametro("?idCateg", MySqlDbType.UInt32, idCateg)
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

    Public Function UpdateCategoria(ByVal idCateg As UInt32, ByVal Descrip As String) As Boolean
        Dim inserto As Boolean = False
        Try
            ObjCon.Conectar()
            ObjCon.CrearComando("UPDATE categoria_prod SET Descripcion = ?Descrip WHERE id_categoria = ?idCateg")
            ObjCon.AsignarParametro("?idCateg", MySqlDbType.UInt32, idCateg)
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

    Public Function Update(ByVal idProd As String, ByVal idProv As String, ByVal idCateg As String, ByVal Descrip As String, ByVal Costo As Integer,
                              ByVal Precio1 As Integer, ByVal Precio2 As Integer, ByVal Precio3 As Integer, ByVal PrecioPack? As Integer,
                              ByVal CantUnit As Double, ByVal UnidXpack? As Double, ByVal PorPack As String,
                           ByVal Foto As Byte(), ByVal Iva_ As Int16, ByVal OldidProd As String,
                           ByVal Lado1? As Double, ByVal Lado2? As Double, ByVal MxCaja? As Double, ByVal Favorito As Integer) As Boolean
        Dim inserto As Boolean = False
        Try
            ObjCon.Conectar()
            ObjCon.CrearComando("zproducto_update")
            ObjCon.CrearProcedimiento()
            ObjCon.AsignarParametro("@idprod", idProd)
            ObjCon.AsignarParametro("@idprov", idProv)
            ObjCon.AsignarParametro("@idcateg", idCateg)
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
            ObjCon.AsignarParametro("@lado1_", Lado1)
            ObjCon.AsignarParametro("@lado2_", Lado2)
            ObjCon.AsignarParametro("@mxcaja_", MxCaja)
            ObjCon.AsignarParametro("@favorito_", Favorito)
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
        Dim NewIdProd As String = "0"
        Try
            ObjCon.Conectar()
            ActualizarTabla("detalleventa", idProd, NewIdProd)
            ActualizarTabla("detallecompra", idProd, NewIdProd)
            ActualizarTabla("detnotacventa", idProd, NewIdProd)
            ActualizarTabla("detnotaccompra", idProd, NewIdProd)
            ActualizarTabla("altaprod", idProd, NewIdProd)
            ActualizarTabla("bajaprod", idProd, NewIdProd)

            ObjCon.CrearComando("DELETE FROM Producto WHERE idProducto = ?idProd")
            ObjCon.AsignarParametro("?idProd", MySqlDbType.String, idProd)
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

    Private Sub ActualizarTabla(ByVal Tabla As String, ByVal idProd As String, ByVal NewIdProd As String)
        Try
            ObjCon.CrearComando("UPDATE " + Tabla + " SET idproductofk = '" + NewIdProd + "' WHERE idproductofk = '" + idProd + "'")
            ObjCon.EjecutarConsulta()
        Catch
            If CInt(NewIdProd) < 111130 Then
                ActualizarTabla(Tabla, idProd, CStr(CInt(NewIdProd) + 1))
            End If
        End Try
    End Sub

    Public Function UpdatePrecio(ByVal idProd As String, ByVal Costo As Integer, ByVal idProv As String) As Boolean
        Dim inserto As Boolean = False
        Try
            ObjCon.Conectar()
            ObjCon.CrearComando("UPDATE Producto SET Costo = ?Costo, idProveedorFK = ?idprov WHERE idProducto = ?idProd")
            ObjCon.AsignarParametro("?idprod", MySqlDbType.String, idProd)
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
        ObjCon.CrearComando("SELECT * FROM Producto WHERE idProducto = '" + Cod + "'")
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

    Public Function BuscProd(Campo1 As String, Parametro1 As String, ByVal Campo2 As String, ByVal Operador As String, ByVal Parametro2 As String) As DataTable
        ObjCon.Conectar()
        ObjCon.CrearComando("SELECT * FROM viewProducto WHERE " + Campo1 + "='" + Parametro1 + "' And " + Campo2 + Operador + Parametro2)
        BuscProd = ObjCon.EjecutarDataTable()
        ObjCon.Desconectar()
    End Function

    Public Function GetFavoritos() As DataTable
        Dim tabla As DataTable
        ObjCon.Conectar()
        ObjCon.CrearComando("SELECT * FROM producto WHERE favorito = 1")
        tabla = ObjCon.EjecutarDataTable()
        ObjCon.Desconectar()
        Return tabla
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

    Public Function ListarCateg() As DataTable
        ObjCon.Conectar()
        ObjCon.CrearComando("SELECT * FROM categoria_prod Order By descripcion")
        ListarCateg = ObjCon.EjecutarDataTable()
        ObjCon.Desconectar()
    End Function

    Public Function CargarNroProdd() As Int64
        Dim Menor As Int64 = 0
        CargarNroProdd = 0
        ObjCon.Conectar()
        ObjCon.CrearComando("SELECT idProducto FROM Producto ORDER BY idProducto ASC")
        ObjCon.dr = ObjCon.EjecutarReader()
        While ObjCon.dr.Read()
            Try
                CargarNroProdd = ObjCon.dr.GetInt64(0)
                If CargarNroProdd = Menor Then
                    Menor = CLng(Menor + 1)
                Else
                    Exit While
                End If
            Catch ex As Exception
            End Try
        End While
        ObjCon.dr.Close()
        ObjCon.Desconectar()
        CargarNroProdd = Menor
    End Function

    Public Function CargarNroCateg() As UInt32
        CargarNro("id_categoria", "categoria_prod")
    End Function

    Public Function CargarNro(ByVal Id As String, ByVal Tabla As String) As UInt32
        CargarNro = 0
        ObjCon.Conectar()
        ObjCon.CrearComando("SELECT MAX(" + Id + ") FROM " + Tabla)
        ObjCon.dr = ObjCon.EjecutarReader()
        If ObjCon.dr.Read() Then
            Try
                CargarNro = ObjCon.dr.GetUInt32(0)
            Catch
            End Try
        Else
            CargarNro = 0
        End If
        ObjCon.dr.Close()
        ObjCon.Desconectar()
        CargarNro = CUInt(CargarNro + 1)
    End Function

    Public Function CargarNroBaja() As UInt32
        CargarNroBaja = 0
        ObjCon.Conectar()
        ObjCon.CrearComando("SELECT MAX(idBaja) FROM bajaprod")
        ObjCon.dr = ObjCon.EjecutarReader()
        If ObjCon.dr.Read() Then
            Try
                CargarNroBaja = ObjCon.dr.GetUInt32(0)
            Catch
            End Try
        Else
            CargarNroBaja = 0
        End If
        ObjCon.dr.Close()
        ObjCon.Desconectar()
        CargarNroBaja = CUInt(CargarNroBaja + 1)
    End Function

    Public Function CargarNroBajaMotivo() As UInt16
        CargarNroBajaMotivo = 0
        ObjCon.Conectar()
        ObjCon.CrearComando("SELECT MAX(idMotivo) FROM bajaprodmotivo")
        ObjCon.dr = ObjCon.EjecutarReader()
        If ObjCon.dr.Read() Then
            Try
                CargarNroBajaMotivo = ObjCon.dr.GetUInt16(0)
            Catch
            End Try
        Else
            CargarNroBajaMotivo = 0
        End If
        ObjCon.dr.Close()
        ObjCon.Desconectar()
        CargarNroBajaMotivo = CUShort(CargarNroBajaMotivo + 1)
    End Function

    Public Function CargarNroAltaMotivo() As UInt16
        CargarNroAltaMotivo = 0
        ObjCon.Conectar()
        ObjCon.CrearComando("SELECT MAX(idMotivo) FROM altaprodmotivo")
        ObjCon.dr = ObjCon.EjecutarReader()
        If ObjCon.dr.Read() Then
            Try
                CargarNroAltaMotivo = ObjCon.dr.GetUInt16(0)
            Catch
            End Try
        Else
            CargarNroAltaMotivo = 0
        End If
        ObjCon.dr.Close()
        ObjCon.Desconectar()
        CargarNroAltaMotivo = CUShort(CargarNroAltaMotivo + 1)
    End Function

    Public Function CargarNroAlta() As UInt32
        CargarNroAlta = 0
        ObjCon.Conectar()
        ObjCon.CrearComando("SELECT MAX(idAlta) FROM altaprod")
        ObjCon.dr = ObjCon.EjecutarReader()
        If ObjCon.dr.Read() Then
            Try
                CargarNroAlta = ObjCon.dr.GetUInt32(0)
            Catch
            End Try
        Else
            CargarNroAlta = 0
        End If
        ObjCon.dr.Close()
        ObjCon.Desconectar()
        CargarNroAlta = CUInt(CargarNroAlta + 1)
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

    Public Function GenerarCódigo() As String
        Dim Codigo As ULong = 0
        For i As ULong = 1 To ULong.MaxValue
            If VerificarCod(CStr(i)) = True Then
                Codigo = i
                Exit For
            End If
        Next i
        Return CStr(Codigo)
    End Function

    Public Function VerificarCod(ByVal Cod As String) As Boolean   'Devuelve true si el codigo esta disponible
        Dim Tabla As DataTable = BuscProdCod(Cod)
        Dim Filas As Integer = Tabla.Rows.Count
        If Filas > 0 Then
            Return False
        Else
            Return True
        End If
    End Function

    Public Function Ajustes(ByVal Porcentaje As Integer, ByVal Multiplo As Integer, ByVal Activo As Integer) As Boolean
        Dim inserto As Boolean = False
        Try
            ObjCon.Conectar()
            ObjCon.CrearComando("zproducto_precio_ajustes")
            ObjCon.CrearProcedimiento()
            ObjCon.AsignarParametro("@porcentaje_", Porcentaje)
            ObjCon.AsignarParametro("@multiplo_", Multiplo)
            ObjCon.AsignarParametro("@activo_", Activo)
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

    Public Function VerAjustes() As DataTable
        ObjCon.Conectar()
        ObjCon.CrearComando("zproducto_precio_ajustes_view")
        ObjCon.CrearProcedimiento()
        VerAjustes = ObjCon.EjecutarDataTable()
        ObjCon.Desconectar()
    End Function

End Class
