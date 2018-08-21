Option Strict On

Public Class FReporteFactura
    Public Encabezado As New List(Of CEncabezadoFactura)()
    Public Detalle As New List(Of CDetalleFactura)()

    'Public Property Titulo() As String
    'Public Property Empresa() As String


    Private Sub FReporteFactura_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ReportViewer1.LocalReport.DataSources.Clear()

        'Dim parameters As ReportParameter() = New ReportParameter(1) {}
        'parameters(0) = New ReportParameter("parameterTitulo", Titulo)
        'parameters(1) = New ReportParameter("parameterEmpresa", Empresa)

        '
        'Establezcamos la lista como Datasource del Informe
        '
        ReportViewer1.LocalReport.DataSources.Add(New ReportDataSource("Encabezado", Encabezado))
        ReportViewer1.LocalReport.DataSources.Add(New ReportDataSource("Detalle", Detalle))
        '
        'Enviemos la lista de parametros
        '
        'ReportViewer1.LocalReport.SetParameters(parameters)
        '
        'Hagamos un refresh al reportViewer
        '

        ReportViewer1.RefreshReport()
    End Sub
End Class