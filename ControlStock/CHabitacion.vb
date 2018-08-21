Option Strict On

Imports MySql.Data.MySqlClient
Public Class CHabitacion
    Private ObjCon As New BaseDato()

    Public Function ViewAll() As DataTable
        ObjCon.Conectar()
        ObjCon.CrearComando("zhabitacion_viewall")
        ObjCon.CrearProcedimiento()
        ViewAll = ObjCon.EjecutarDataTable()
        ObjCon.Desconectar()
    End Function

    Public Function ViewAll2() As DataTable
        ObjCon.Conectar()
        ObjCon.CrearComando("zhabitacion_viewall2")
        ObjCon.CrearProcedimiento()
        ViewAll2 = ObjCon.EjecutarDataTable()
        ObjCon.Desconectar()
    End Function

    Public Function VerAjustes() As DataTable
        ObjCon.Conectar()
        ObjCon.CrearComando("zhabit_ajustes_view")
        ObjCon.CrearProcedimiento()
        VerAjustes = ObjCon.EjecutarDataTable()
        ObjCon.Desconectar()
    End Function

    Public Function BuscarHab(ByVal idHab As Integer, ByVal idServHab As Integer) As DataTable
        ObjCon.Conectar()
        ObjCon.CrearComando("zhabitacion_buscar")
        ObjCon.CrearProcedimiento()
        ObjCon.AsignarParametro("@idHab", idHab)
        ObjCon.AsignarParametro("@idServHab", idServHab)
        BuscarHab = ObjCon.EjecutarDataTable()
        ObjCon.Desconectar()
    End Function

    Public Function BuscarHab(ByVal idHab As Integer) As DataTable
        ObjCon.Conectar()
        ObjCon.CrearComando("zhabitacion_buscar2")
        ObjCon.CrearProcedimiento()
        ObjCon.AsignarParametro("@nroHab", idHab)
        BuscarHab = ObjCon.EjecutarDataTable()
        ObjCon.Desconectar()
    End Function

    Public Function VerReporteManual(ByVal Fecha As String) As DataTable
        ObjCon.Conectar()
        ObjCon.CrearComando("zocupmanual_view")
        ObjCon.CrearProcedimiento()
        ObjCon.AsignarParametro("@Fecha", Fecha)
        VerReporteManual = ObjCon.EjecutarDataTable()
        ObjCon.Desconectar()
    End Function

    Public Function VerReporteSensor(ByVal Fecha As String) As DataTable
        ObjCon.Conectar()
        ObjCon.CrearComando("zocupsensor_view")
        ObjCon.CrearProcedimiento()
        ObjCon.AsignarParametro("@Fecha", Fecha)
        VerReporteSensor = ObjCon.EjecutarDataTable()
        ObjCon.Desconectar()
    End Function

    Public Function BuscarReporteM(ByVal NroHabit As UInt16, ByVal HoraE As Date, ByVal HoraS As Date) As DataTable
        ObjCon.Conectar()
        ObjCon.CrearComando("zocupmanual_buscar")
        ObjCon.CrearProcedimiento()
        ObjCon.AsignarParametro("@NroHabit", NroHabit)
        ObjCon.AsignarParametro("@HoraE", HoraE)
        ObjCon.AsignarParametro("@HoraS", HoraS)
        BuscarReporteM = ObjCon.EjecutarDataTable()
        ObjCon.Desconectar()
    End Function

    Public Function BuscarReporteS(ByVal NroHabit As UInt16, ByVal HoraE As Date, ByVal HoraS As Date) As DataTable
        ObjCon.Conectar()
        ObjCon.CrearComando("zocupsensor_buscar")
        ObjCon.CrearProcedimiento()
        ObjCon.AsignarParametro("@NroHabit", NroHabit)
        ObjCon.AsignarParametro("@HoraE", HoraE)
        ObjCon.AsignarParametro("@HoraS", HoraS)
        BuscarReporteS = ObjCon.EjecutarDataTable()
        ObjCon.Desconectar()
    End Function

    Public Function BuscarServ(ByVal idServHab As Integer) As DataTable
        ObjCon.Conectar()
        ObjCon.CrearComando("zservhab_buscar")
        ObjCon.CrearProcedimiento()
        ObjCon.AsignarParametro("@idServHabit", idServHab)
        BuscarServ = ObjCon.EjecutarDataTable()
        ObjCon.Desconectar()
    End Function

    Public Function ChequearSinSalida(ByVal NroHabit As Integer) As DataTable
        ObjCon.Conectar()
        ObjCon.CrearComando("zocupmanual_sinsalida")
        ObjCon.CrearProcedimiento()
        ObjCon.AsignarParametro("@NroHabit", NroHabit)
        ChequearSinSalida = ObjCon.EjecutarDataTable()
        ObjCon.Desconectar()
    End Function

    Public Function GetId(ByVal Descrip As String) As Integer
        ObjCon.Conectar()
        ObjCon.CrearComando("zservhab_getid")
        ObjCon.CrearProcedimiento()
        ObjCon.AsignarParametro("@Descrip", Descrip)
        Dim Tabla As DataTable = ObjCon.EjecutarDataTable()
        GetId = CInt(Tabla.Rows(0).Item(0))
        ObjCon.Desconectar()
    End Function

    Public Function GetDescrip(ByVal idServ As UInt16) As String
        ObjCon.Conectar()
        ObjCon.CrearComando("zservhab_getdescrip")
        ObjCon.CrearProcedimiento()
        ObjCon.AsignarParametro("@idServHabit", idServ)
        ObjCon.dr = ObjCon.EjecutarReader()
        If ObjCon.dr.Read() Then
            GetDescrip = ObjCon.dr.GetString(0)
        Else
            GetDescrip = ""
        End If
        ObjCon.dr.Close()
        ObjCon.Desconectar()
    End Function

    Public Function GetTiempo(ByVal idServ As UInt16) As Integer
        ObjCon.Conectar()
        ObjCon.CrearComando("zservhab_gettiempo")
        ObjCon.CrearProcedimiento()
        ObjCon.AsignarParametro("@idServHabit", idServ)
        ObjCon.dr = ObjCon.EjecutarReader()
        If ObjCon.dr.Read() Then
            GetTiempo = ObjCon.dr.GetInt32(0)
        Else
            GetTiempo = 0
        End If
        ObjCon.dr.Close()
        ObjCon.Desconectar()
    End Function

    Public Function GetHraE() As TimeSpan
        ObjCon.Conectar()
        ObjCon.CrearComando("zservhab_gethrae")
        ObjCon.CrearProcedimiento()
        ObjCon.dr = ObjCon.EjecutarReader()
        If ObjCon.dr.Read() Then
            GetHraE = ObjCon.dr.GetTimeSpan(0)
        Else
            GetHraE = TimeSpan.Parse("00:00:00")
        End If
        ObjCon.dr.Close()
        ObjCon.Desconectar()
    End Function

    Public Function GetHraS() As TimeSpan
        ObjCon.Conectar()
        ObjCon.CrearComando("zservhab_gethras")
        ObjCon.CrearProcedimiento()
        ObjCon.dr = ObjCon.EjecutarReader()
        If ObjCon.dr.Read() Then
            GetHraS = ObjCon.dr.GetTimeSpan(0)
        Else
            GetHraS = TimeSpan.Parse("00:00:00")
        End If
        ObjCon.dr.Close()
        ObjCon.Desconectar()
    End Function

    Public Function Edit(ByVal idHab As Integer, ByVal idServHab As Integer, ByVal Descrip As String, ByVal Precio As Integer) As Boolean
        Dim inserto As Boolean = False
        Try
            ObjCon.Conectar()
            ObjCon.CrearComando("zhabitacion_update")
            ObjCon.CrearProcedimiento()
            ObjCon.AsignarParametro("@idHab", idHab)
            ObjCon.AsignarParametro("@idServHab", idServHab)
            ObjCon.AsignarParametro("@Descrip", Descrip)
            ObjCon.AsignarParametro("@Prec", Precio)
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

    Public Function Edit2(ByVal idHab As UInt16, ByVal Precio1 As Integer, ByVal Precio2 As Integer, ByVal Precio3 As Integer) As Boolean
        Dim inserto As Boolean = False
        Try
            ObjCon.Conectar()
            ObjCon.CrearComando("zhabitacion_update2")
            ObjCon.CrearProcedimiento()
            ObjCon.AsignarParametro("@idHab", idHab)
            ObjCon.AsignarParametro("@Prec1", Precio1)
            ObjCon.AsignarParametro("@Prec2", Precio2)
            ObjCon.AsignarParametro("@Prec3", Precio3)
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

    Public Function Ajustes(ByVal MEntrada As Integer, ByVal MSalida As Integer, ByVal Toleranc As Integer) As Boolean
        Dim inserto As Boolean = False
        Try
            ObjCon.Conectar()
            ObjCon.CrearComando("zhabit_ajustes")
            ObjCon.CrearProcedimiento()
            ObjCon.AsignarParametro("@MEntrada", MEntrada)
            ObjCon.AsignarParametro("@MSalida", MSalida)
            ObjCon.AsignarParametro("@Toleranc", Toleranc)
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

    Public Function AjustesTiempo(ByVal Descrip1 As String, ByVal Descrip2 As String, ByVal Descrip3 As String,
                                  ByVal Tiempo1 As Integer, ByVal Tiempo2 As Integer,
                                  ByVal HoraE As TimeSpan, ByVal HoraS As TimeSpan) As Boolean

        Dim inserto As Boolean = False
        Try
            ObjCon.Conectar()
            ObjCon.CrearComando("zservhab_update")
            ObjCon.CrearProcedimiento()
            ObjCon.AsignarParametro("@Descrip1", Descrip1)
            ObjCon.AsignarParametro("@Descrip2", Descrip2)
            ObjCon.AsignarParametro("@Descrip3", Descrip3)
            ObjCon.AsignarParametro("@Tiempo1", Tiempo1)
            ObjCon.AsignarParametro("@Tiempo2", Tiempo2)
            ObjCon.AsignarParametro("@HoraE", HoraE)
            ObjCon.AsignarParametro("@HoraS", HoraS)
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

    Public Function RegistrarEntrada(ByVal idHab As Integer) As Boolean
        Dim inserto As Boolean = False
        Try
            ObjCon.Conectar()
            ObjCon.CrearComando("zocupmanual_ins_in")
            ObjCon.CrearProcedimiento()
            ObjCon.AsignarParametro("@nroHabit", idHab)
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

    Public Function RegistrarSalida(ByVal idHab As Integer, ByVal IdVenta As UInteger) As Boolean
        Dim inserto As Boolean = False
        Try
            ObjCon.Conectar()
            ObjCon.CrearComando("zocupmanual_ins_out")
            ObjCon.CrearProcedimiento()
            ObjCon.AsignarParametro("@nroHabit", idHab)
            ObjCon.AsignarParametro("@idVenta", IdVenta)
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

    Public Function RegistrarSalida(ByVal idHab As Integer) As Boolean
        Dim inserto As Boolean = False
        Try
            ObjCon.Conectar()
            ObjCon.CrearComando("zocupmanual_ins_out2")
            ObjCon.CrearProcedimiento()
            ObjCon.AsignarParametro("@nroHabit", idHab)
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

    Public Function InserDetalleOcup(ByVal idVenta As UInteger, ByVal idHab As Integer, ByVal idServHab As Integer, ByVal Tiemp As Integer, ByVal Prec As UInteger, ByVal SubT As Integer) As Boolean
        Dim inserto As Boolean = False
        Try
            ObjCon.Conectar()
            ObjCon.CrearComando("zdetalleocup_insert")
            ObjCon.CrearProcedimiento()
            ObjCon.AsignarParametro("@idVenta", idVenta)
            ObjCon.AsignarParametro("@idHab", idHab)
            ObjCon.AsignarParametro("@idServHab", idServHab)
            ObjCon.AsignarParametro("@Tiemp", Tiemp)
            ObjCon.AsignarParametro("@Prec", Prec)
            ObjCon.AsignarParametro("@SubT", SubT)
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
