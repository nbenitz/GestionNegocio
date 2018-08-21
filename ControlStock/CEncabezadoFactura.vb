
Public Class CEncabezadoFactura
    Public Property FechaFacturacion() As DateTime
    Public Property Cliente() As String
    Public Property Ruc() As String
    Public Property Direccion() As String
    Public Property Contado() As Char
    Public Property Credito() As Char
    Public Property Subtotal_0() As Decimal
    Public Property Subtotal_5() As Decimal
    Public Property Subtotal_10() As Decimal
    Public Property Iva_5() As Decimal
    Public Property Iva_10() As Decimal
    Public Property Iva_Total() As Decimal
    Public Property Total() As Decimal

    'Creamos una lista con una nueva Instancia de la clase Articulo
    'esta lista contendra el detalle de la factura
    Public Detalle As New List(Of CDetalleFactura)()
End Class
