﻿Option Strict On
Imports MySql.Data.MySqlClient

Public Class CCaja
    Private ObjCon As New CBaseDato()

    Public Function CajaAbierta(ByVal NroCaja As Decimal) As Boolean
        CajaAbierta = False
        Dim Count As Integer = 0   'Count es 0 si la caja esta cerrada
        ObjCon.Conectar()
        ObjCon.CrearComando("zcajam_verificar")
        ObjCon.CrearProcedimiento()
        ObjCon.AsignarParametro("@NumCaja", NroCaja)
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
            CajaAbierta = True
        Else
            CajaAbierta = False
        End If
        ObjCon.dr.Close()
        ObjCon.Desconectar()
    End Function

    Public Function Abrir(ByVal NumCaja As UInt16, ByVal IdEmple As UInteger, ByVal MontoInicial As UInteger) As Boolean
        Dim Inserto As Boolean = False
        Try
            ObjCon.Conectar()
            ObjCon.CrearComando("zcajam_abrir")
            ObjCon.CrearProcedimiento()
            ObjCon.AsignarParametro("@NumCaja", NumCaja)
            ObjCon.AsignarParametro("@idEmple", IdEmple)
            ObjCon.AsignarParametro("@MontoIni", MontoInicial)
            If ObjCon.EjecutarConsulta() > 0 Then
                Inserto = True
            Else
                Inserto = False
            End If
            ObjCon.Desconectar()
        Catch mierror As MySqlException
            Inserto = False
        End Try
        Return Inserto
    End Function

    Public Function Cerrar(ByVal NumCaja As UInt16, MontoDeclarado As Integer, MontoRetiro As Integer) As Boolean
        Dim Inserto As Boolean = False
        Try
            ObjCon.Conectar()
            ObjCon.CrearComando("zcajam_cerrar")
            ObjCon.CrearProcedimiento()
            ObjCon.AsignarParametro("@NumCaja", NumCaja)
            ObjCon.AsignarParametro("@MontoDeclarado", MontoDeclarado)
            ObjCon.AsignarParametro("@MontoRetiro_", MontoRetiro)
            If ObjCon.EjecutarConsulta() > 0 Then
                Inserto = True
            Else
                Inserto = False
            End If
            ObjCon.Desconectar()
        Catch mierror As MySqlException
            Inserto = False
        End Try
        Return Inserto
    End Function


    Public Function Gasto(ByVal NumCaja As Integer, ByVal IdGasto As Integer) As Boolean
        Dim Inserto As Boolean = False
        Try
            ObjCon.Conectar()
            ObjCon.CrearComando("zcajam_ins_gasto")
            ObjCon.CrearProcedimiento()
            ObjCon.AsignarParametro("@NumCaja", NumCaja)
            ObjCon.AsignarParametro("@gasto_id", IdGasto)
            If ObjCon.EjecutarConsulta() > 0 Then
                Inserto = True
            Else
                Inserto = False
            End If
            ObjCon.Desconectar()
        Catch mierror As MySqlException
            Inserto = False
        End Try
        Return Inserto
    End Function



    Public Function MontoCierre(ByVal NumCaja As UInt16) As Integer
        Try
            ObjCon.Conectar()
            ObjCon.CrearComando("zcajam_calc_montofin")
            ObjCon.CrearProcedimiento()
            ObjCon.AsignarParametro("@NumCaja", NumCaja)
            ObjCon.AsignarParametroSalida("@MontoFin", MySqlDbType.Int32)
            ObjCon.EjecutarConsulta()
            MontoCierre = CInt(ObjCon.ParametroSalida("@MontoFin"))
            ObjCon.Desconectar()
        Catch mierror As MySqlException
            MontoCierre = 0
        End Try
    End Function

    Public Function MontoInicial(ByVal NumCaja As UInt16) As Integer
        Try
            ObjCon.Conectar()
            ObjCon.CrearComando("zcajam_get_montoini")
            ObjCon.CrearProcedimiento()
            ObjCon.AsignarParametro("@NumCaja", NumCaja)
            ObjCon.AsignarParametroSalida("@MontoIni", MySqlDbType.Int32)
            ObjCon.EjecutarConsulta()
            MontoInicial = CInt(ObjCon.ParametroSalida("@MontoIni"))
            ObjCon.Desconectar()
        Catch mierror As MySqlException
            MontoInicial = 0
        End Try
    End Function

    Public Function FechaApertura(ByVal NumCaja As UInt16) As String
        Try
            ObjCon.Conectar()
            ObjCon.CrearComando("zcajam_get_fechaini")
            ObjCon.CrearProcedimiento()
            ObjCon.AsignarParametro("@NumCaja", NumCaja)
            ObjCon.AsignarParametroSalida("@Fecha", MySqlDbType.DateTime)
            ObjCon.EjecutarConsulta()
            FechaApertura = CStr(ObjCon.ParametroSalida("@Fecha"))
            ObjCon.Desconectar()
        Catch mierror As MySqlException
            FechaApertura = "..."
        End Try
    End Function

    Public Function FechaCierre(ByVal NumCaja As UInt16) As String
        Try
            ObjCon.Conectar()
            ObjCon.CrearComando("zcajam_get_fechafin")
            ObjCon.CrearProcedimiento()
            ObjCon.AsignarParametro("@NumCaja", NumCaja)
            ObjCon.AsignarParametroSalida("@Fecha", MySqlDbType.DateTime)
            ObjCon.EjecutarConsulta()
            FechaCierre = CStr(ObjCon.ParametroSalida("@Fecha"))
            ObjCon.Desconectar()
        Catch mierror As MySqlException
            FechaCierre = "Abierto"
        End Try
    End Function

    Public Function BuscarView(ByVal Fecha As String, ByVal Hora As String) As DataTable
        ObjCon.Conectar()
        ObjCon.CrearComando("zcajam_buscar2")
        ObjCon.CrearProcedimiento()
        ObjCon.AsignarParametro("@Fecha", Fecha)
        ObjCon.AsignarParametro("@Hora", Hora)
        BuscarView = ObjCon.EjecutarDataTable()
        ObjCon.Desconectar()
    End Function

    Public Function BuscarView(ByVal Fecha As Date) As DataTable
        ObjCon.Conectar()
        ObjCon.CrearComando("zcajam_buscar")
        ObjCon.CrearProcedimiento()
        ObjCon.AsignarParametro("@Fecha", Fecha)
        BuscarView = ObjCon.EjecutarDataTable()
        ObjCon.Desconectar()
    End Function

    Public Function MontoRestante(ByVal IdCajaAnterior As Integer, ByVal NroCaja As Integer) As Integer?
        ObjCon.Conectar()
        ObjCon.CrearComando("zcajam_get_montorestante")
        ObjCon.CrearProcedimiento()
        ObjCon.AsignarParametro("@IdCaja_", IdCajaAnterior)
        ObjCon.AsignarParametro("@NroCaja_", NroCaja)
        ObjCon.AsignarParametroSalida("@MontoFinal_", MySqlDbType.Int32)
        ObjCon.EjecutarConsulta()
        Try
            If Not IsDBNull(ObjCon.ParametroSalida("@MontoFinal_")) Then
                MontoRestante = CInt(ObjCon.ParametroSalida("@MontoFinal_"))
            Else
                Return Nothing
            End If

        Catch ex As Exception
            MontoRestante = -1
        End Try
        ObjCon.Desconectar()
    End Function

    Public Function LastMontoFinal(ByVal NroCaja As Integer) As Integer
        ObjCon.Conectar()
        ObjCon.CrearComando("zcajam_get_lastmontorestante")
        ObjCon.CrearProcedimiento()
        ObjCon.AsignarParametro("@NroCaja_", NroCaja)
        ObjCon.AsignarParametroSalida("@MontoRestante", MySqlDbType.Int32)
        ObjCon.EjecutarConsulta()
        Try
            LastMontoFinal = CInt(ObjCon.ParametroSalida("@MontoRestante"))
        Catch ex As Exception
            LastMontoFinal = 0
        End Try
        ObjCon.Desconectar()
    End Function

    Public Function BuscarViewCaja(ByVal Condicion As String) As DataTable
        ObjCon.Conectar()
        ObjCon.CrearComando("SELECT * FROM viewcajamostrador " + Condicion)
        BuscarViewCaja = ObjCon.EjecutarDataTable()
        ObjCon.Desconectar()
    End Function

    Public Function BuscarDetalle(ByVal FechaIni As String, ByVal FechaFin As String) As DataTable
        ObjCon.Conectar()
        ObjCon.CrearComando("zingreso_busc_detalle")
        ObjCon.CrearProcedimiento()
        ObjCon.AsignarParametro("@FechaIni", FechaIni)
        ObjCon.AsignarParametro("@FechaFin", FechaFin)
        BuscarDetalle = ObjCon.EjecutarDataTable()
        ObjCon.Desconectar()
    End Function

    Public Function BuscarTotales(ByVal FechaIni As String, ByVal FechaFin As String) As DataTable
        ObjCon.Conectar()
        ObjCon.CrearComando("zingreso_busc_totales")
        ObjCon.CrearProcedimiento()
        ObjCon.AsignarParametro("@FechaIni", FechaIni)
        ObjCon.AsignarParametro("@FechaFin", FechaFin)
        BuscarTotales = ObjCon.EjecutarDataTable()
        ObjCon.Desconectar()
    End Function

    Public Function BuscarResumen(ByVal FechaIni As String, ByVal FechaFin As String) As DataTable
        ObjCon.Conectar()
        ObjCon.CrearComando("zingreso_busc_resum")
        ObjCon.CrearProcedimiento()
        ObjCon.AsignarParametro("@FechaIni", FechaIni)
        ObjCon.AsignarParametro("@FechaFin", FechaFin)
        BuscarResumen = ObjCon.EjecutarDataTable()
        ObjCon.Desconectar()
    End Function

End Class
