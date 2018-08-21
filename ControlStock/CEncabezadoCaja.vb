Public Class CEncabezadoCaja
    Public Property Empleado() As String
    Public Property FechaApertura() As DateTime
    Public Property FechaCierre() As String
    Public Property MontoInicial() As Decimal
    Public Property MontoFinal() As Decimal

    Public Detalle As New List(Of CDetalleCaja)()
    Public Resumen As New List(Of CResumenCaja)()
    Public Totales As New List(Of CTotalesCaja)()
End Class
