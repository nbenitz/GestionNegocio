Option Strict On
Option Explicit On

Imports MySql.Data.MySqlClient
Public Class CSocioSeguimiento
    Private ObjCon As New CBaseDato()

    Public Function InsertSeguimiento(Id As Integer,
                                      CI As String,
                                      fecha As Date,
                                      peso As Double,
                                      altura As Double,
                                      hombros As Double,
                                      pecho As Double,
                                      biceps1 As Double,
                                      biceps2 As Double,
                                      antebrazo As Double,
                                      muneca As Double,
                                      abdomen As Double,
                                      cintura As Double,
                                      caderas As Double,
                                      muslo As Double,
                                      rodilla As Double,
                                      gemelos As Double,
                                      tobillo As Double
                                      ) As Boolean
        Dim inserto As Boolean = False
        Try
            ObjCon.Conectar()
            ObjCon.CrearComando("INSERT INTO cliente_seguimiento VALUES(?id, ?ci, ?fecha, ?peso, ?altura, " +
                                "?hombros, ?pecho, ?biceps1, ?biceps2, ?antebrazo, ?muneca, ?abdomen, ?cintura, " +
                                "?caderas, ?muslo, ?rodilla, ?gemelos, ?tobillo)")
            ObjCon.AsignarParametro("?id", MySqlDbType.Int32, Id)
            ObjCon.AsignarParametro("?ci", MySqlDbType.String, CI)
            ObjCon.AsignarParametro("?fecha", MySqlDbType.Date, fecha)
            ObjCon.AsignarParametro("?peso", MySqlDbType.Double, peso)
            ObjCon.AsignarParametro("?altura", MySqlDbType.Double, altura)
            ObjCon.AsignarParametro("?hombros", MySqlDbType.Double, hombros)
            ObjCon.AsignarParametro("?pecho", MySqlDbType.Double, pecho)
            ObjCon.AsignarParametro("?biceps1", MySqlDbType.Double, biceps1)
            ObjCon.AsignarParametro("?biceps2", MySqlDbType.Double, biceps2)
            ObjCon.AsignarParametro("?antebrazo", MySqlDbType.Double, antebrazo)
            ObjCon.AsignarParametro("?muneca", MySqlDbType.Double, muneca)
            ObjCon.AsignarParametro("?abdomen", MySqlDbType.Double, abdomen)
            ObjCon.AsignarParametro("?cintura", MySqlDbType.Double, cintura)
            ObjCon.AsignarParametro("?caderas", MySqlDbType.Double, caderas)
            ObjCon.AsignarParametro("?muslo", MySqlDbType.Double, muslo)
            ObjCon.AsignarParametro("?rodilla", MySqlDbType.Double, rodilla)
            ObjCon.AsignarParametro("?gemelos", MySqlDbType.Double, gemelos)
            ObjCon.AsignarParametro("?tobillo", MySqlDbType.Double, tobillo)

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


    Public Function InsertFoto(ByVal IdSeguimiento As Integer,
                               ByVal Foto As Byte()) As Boolean
        Dim Id As Integer = IdSeguimientoFoto()
        Dim inserto As Boolean = False
        Try
            ObjCon.Conectar()
            ObjCon.CrearComando("INSERT INTO cliente_seguim_galeria VALUES(?id, ?seguimiento_id, ?foto)")
            ObjCon.AsignarParametro("?id", MySqlDbType.Int32, Id)
            ObjCon.AsignarParametro("?seguimiento_id", MySqlDbType.Int32, IdSeguimiento)
            ObjCon.AsignarParametro("?foto", MySqlDbType.LongBlob, Foto)
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

    Public Function BuscarSeguimiento(ByVal CI As String) As DataTable
        ObjCon.Conectar()
        ObjCon.CrearComando("SELECT * FROM cliente_seguimiento WHERE cliente_ci = '" + CI + "' ORDER BY fecha DESC")
        BuscarSeguimiento = ObjCon.EjecutarDataTable()
        ObjCon.Desconectar()
    End Function

    Public Function IdSeguimiento() As Int32
        IdSeguimiento = 0
        ObjCon.Conectar()
        ObjCon.CrearComando("SELECT MAX(id) FROM cliente_seguimiento")
        ObjCon.dr = ObjCon.EjecutarReader()
        If ObjCon.dr.Read() Then
            Try
                IdSeguimiento = ObjCon.dr.GetInt32(0)
            Catch
            End Try
        End If
        ObjCon.dr.Close()
        ObjCon.Desconectar()
        IdSeguimiento += 1
    End Function

    Public Function IdSeguimientoFoto() As Int32
        IdSeguimientoFoto = 0
        ObjCon.Conectar()
        ObjCon.CrearComando("SELECT MAX(id) FROM cliente_seguim_galeria")
        ObjCon.dr = ObjCon.EjecutarReader()
        If ObjCon.dr.Read() Then
            Try
                IdSeguimientoFoto = ObjCon.dr.GetInt32(0)
            Catch
            End Try
        End If
        ObjCon.dr.Close()
        ObjCon.Desconectar()
        IdSeguimientoFoto += 1
    End Function

End Class
