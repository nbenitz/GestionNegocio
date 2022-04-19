Option Strict On

Public Class FResumenCaja
    Dim Caja As New CCaja
    Dim Empleado As New CEmpleado
    Dim NumCaja As UInt16 = 1
    Dim CIValue As String
    Dim DesdeHistorialValue As Boolean = False
    Dim FechaValue As String = ""
    Dim HoraValue As String = ""

    Public Encabezado As New List(Of CEncabezadoCaja)()
    Public Detalle As New List(Of CDetalleCaja)()
    Public Resumen As New List(Of CResumenCaja)()
    Public Totales As New List(Of CTotalesCaja)()

    'Public Property Titulo() As String
    Public Property Empresa() As String

    Private Sub FResumenCaja_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GenerarReporte()
    End Sub

    Private Sub GenerarReporte()
        Dim EncabezadoAux As New CEncabezadoCaja()
        Dim FechaFin As Date = Now
        If DesdeHistorialValue Then
            Dim TablaCaja As DataTable = Caja.BuscarView(FechaValue, HoraValue)
            EncabezadoAux.Empleado = CStr(TablaCaja.Rows(0).Item(0))
            EncabezadoAux.FechaApertura = CDate(CStr(TablaCaja.Rows(0).Item(2)) + " " + CType(TablaCaja.Rows(0).Item(3), TimeSpan).ToString)
            EncabezadoAux.MontoInicial = CInt(TablaCaja.Rows(0).Item(4))
            Try
                EncabezadoAux.FechaCierre = CStr(TablaCaja.Rows(0).Item(5)) + " " + CType(TablaCaja.Rows(0).Item(6), TimeSpan).ToString
                EncabezadoAux.MontoFinal = CInt(TablaCaja.Rows(0).Item(7))
                FechaFin = CDate(EncabezadoAux.FechaCierre)
            Catch
                EncabezadoAux.FechaCierre = "Abierto"
                EncabezadoAux.MontoFinal = 0
            End Try
        Else
            Dim TablaEmple As DataTable = Empleado.CargarEmple(CIValue)
            EncabezadoAux.Empleado = CStr(TablaEmple.Rows(0).Item(1)) + " " + CStr(TablaEmple.Rows(0).Item(2))
            EncabezadoAux.FechaApertura = CDate(Caja.FechaApertura(NumCaja))
            EncabezadoAux.MontoInicial = Caja.MontoInicial(NumCaja)
            If Caja.CajaAbierta(NumCaja) = False Then
                EncabezadoAux.FechaCierre = Caja.FechaCierre(NumCaja)
                EncabezadoAux.MontoFinal = Caja.MontoCierre(NumCaja)
                FechaFin = CDate(EncabezadoAux.FechaCierre)
            Else
                EncabezadoAux.FechaCierre = "Abierto"
                EncabezadoAux.MontoFinal = 0
            End If
        End If

        Dim Tabla As DataTable = Caja.BuscarDetalle(Format(EncabezadoAux.FechaApertura, "yyyy-MM-dd HH:mm:ss"), Format(FechaFin, "yyyy-MM-dd HH:mm:ss"))
        For Each row As DataRow In Tabla.Rows
            Dim DetalleAux As New CDetalleCaja()
            DetalleAux.Id = CInt(row.Item(0))
            DetalleAux.Cliente = CStr(row.Item(1))
            DetalleAux.Descripcion = CStr(row.Item(2))
            DetalleAux.FormasPago = CStr(row.Item(3))
            DetalleAux.Monto = CInt(row.Item(4))
            EncabezadoAux.Detalle.Add(DetalleAux)
        Next

        Tabla = Caja.BuscarResumen(Format(EncabezadoAux.FechaApertura, "yyyy-MM-dd HH:mm:ss"), Format(FechaFin, "yyyy-MM-dd HH:mm:ss"))
        For Each row As DataRow In Tabla.Rows
            Dim ResumenAux As New CResumenCaja()
            ResumenAux.MedioPago = CStr(row.Item(0))
            ResumenAux.Monto = CInt(row.Item(1))
            If ResumenAux.MedioPago = "Efectivo" Then
                ResumenAux.Monto += EncabezadoAux.MontoInicial
            End If
            EncabezadoAux.Resumen.Add(ResumenAux)
        Next
        If Tabla.Rows.Count = 0 Then    'Si aún no se han hecho ventas, imprimir como efectivo el monto inicial
            Dim ResumenAux As New CResumenCaja()
            ResumenAux.MedioPago = "Efectivo"
            ResumenAux.Monto = EncabezadoAux.MontoInicial
            EncabezadoAux.Resumen.Add(ResumenAux)
        End If

        Tabla = Caja.BuscarTotales(Format(EncabezadoAux.FechaApertura, "yyyy-MM-dd HH:mm:ss"), Format(FechaFin, "yyyy-MM-dd HH:mm:ss"))
        For Each row As DataRow In Tabla.Rows
            Dim TotalesAux As New CTotalesCaja()
            TotalesAux.Concepto = CStr(row.Item(0))
            TotalesAux.Monto = CInt(row.Item(1))
            EncabezadoAux.Totales.Add(TotalesAux)
        Next

        Empresa = "Comercial San Cayetano"
        Encabezado.Add(EncabezadoAux)
        Detalle = EncabezadoAux.Detalle
        Resumen = EncabezadoAux.Resumen
        Totales = EncabezadoAux.Totales
        CargarReporte()
    End Sub

    Private Sub CargarReporte()
        ReportViewer1.LocalReport.DataSources.Clear()

        Dim Parameters As ReportParameter() = New ReportParameter(0) {}
        Parameters(0) = New ReportParameter("Empresa", Empresa)
        'parameters(1) = New ReportParameter("parameterTitulo", Titulo)

        '
        'Establezcamos la lista como Datasource del Informe
        '
        ReportViewer1.LocalReport.DataSources.Add(New ReportDataSource("Encabezado", Encabezado))
        ReportViewer1.LocalReport.DataSources.Add(New ReportDataSource("Detalle", Detalle))
        ReportViewer1.LocalReport.DataSources.Add(New ReportDataSource("Resumen", Resumen))
        ReportViewer1.LocalReport.DataSources.Add(New ReportDataSource("Totales", Totales))
        '
        'Enviemos la lista de parametros
        '
        ReportViewer1.LocalReport.SetParameters(Parameters)
        '
        'Hagamos un refresh al reportViewer
        '
        ReportViewer1.RefreshReport()
    End Sub

    Public Property CIEmpleado() As String
        Get
            CIEmpleado = CIValue
        End Get
        Set(ByVal value As String)
            CIValue = value
        End Set
    End Property

    Public WriteOnly Property DesdeHistorial() As Boolean
        Set(ByVal value As Boolean)
            DesdeHistorialValue = value
        End Set
    End Property

    Public WriteOnly Property Fecha() As Date
        Set(ByVal value As Date)
            FechaValue = Format(value, "yyyy-MM-dd")
        End Set
    End Property

    Public WriteOnly Property Hora() As String
        Set(ByVal value As String)
            HoraValue = value
        End Set
    End Property

    Private Sub BtnCerrarForm_Click(sender As Object, e As EventArgs) Handles BtnCerrarForm.Click
        Me.Close()
    End Sub

End Class