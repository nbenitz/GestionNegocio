
Imports LibPrintTicketMatriz.Class1

Public Class FImprimirFactura
    Dim TablaDetalle As DataTable
    Dim Factura, Cliente, Condicion, Vendedor As String
    Dim Fecha As DateTime
    Dim Total As Integer
    Dim Ticket1 As New CreaTicket

    Sub New(ByVal Nro As String, ByVal FechaAux As DateTime, ByVal Cli As String, ByVal Cond As String, ByVal Vend As String,
            ByVal Totl As Integer, ByVal Tabla As DataTable)

        InitializeComponent()
        TablaDetalle = Tabla
        Factura = Nro
        Fecha = FechaAux
        Cliente = Cli
        Condicion = Cond
        Vendedor = Vend
        Total = Totl
        txtPreview.Text = vbCrLf + "               COMERCIAL SOSA             " + vbCrLf
        txtPreview.Text = txtPreview.Text + "  ========================================" + vbCrLf
        txtPreview.Text = txtPreview.Text + "  FACTURA : " + Nro + vbCrLf
        txtPreview.Text = txtPreview.Text + "  FECHA   : " + Fecha.ToString + vbCrLf
        txtPreview.Text = txtPreview.Text + "  CLIENTE : " + Cli + vbCrLf
        txtPreview.Text = txtPreview.Text + "  VENTA   : " + Cond + vbCrLf
        txtPreview.Text = txtPreview.Text + "  VENDEDOR  : " + Vend + vbCrLf
        txtPreview.Text = txtPreview.Text + "  ========================================" + vbCrLf
        txtPreview.Text = txtPreview.Text + "  Cod.   Descrip  /  Cant   Precio   Subt." + vbCrLf
        txtPreview.Text = txtPreview.Text + "  ========================================" + vbCrLf
        Dim Filas As Integer = Tabla.Rows.Count - 1
        Dim Cod, Descrip As String
        Dim Cant As Double
        Dim Precio, Importe As Integer
        For i = 0 To Filas
            Cod = CStr(Tabla.Rows(i).Item(1))
            Descrip = CStr(Tabla.Rows(i).Item(2))
            Cant = CDbl(Tabla.Rows(i).Item(3))
            Precio = CInt(Tabla.Rows(i).Item(4))
            Importe = CInt(Tabla.Rows(i).Item(5))
            MostrarProducto(Cod, Descrip)
            MostrarPrecio(CStr(Cant), Format(Precio, "###,##0"), Format(Importe, "###,##0"))
        Next
        txtPreview.Text = txtPreview.Text + "                               -----------" + vbCrLf
        Dim TotalGs = "         TOTAL Gs :                       "
        Dim TotlLen = Len(Format(Totl, "###,##0"))
        TotalGs = Microsoft.VisualBasic.Left(TotalGs, 42 - TotlLen)
        txtPreview.Text = txtPreview.Text + TotalGs + Format(Totl, "###,##0") + vbCrLf
        txtPreview.Text = txtPreview.Text + "  ========================================" + vbCrLf
        txtPreview.Text = txtPreview.Text + "   Devoluciones hasta 24hs despues de la  " + vbCrLf
        txtPreview.Text = txtPreview.Text + "                  compra                  " + vbCrLf
        txtPreview.Text = txtPreview.Text + "       *** GRACIAS POR SU VISITA ***      " + vbCrLf
        txtPreview.Select(0, 0)
    End Sub

    Private Sub AgregarProducto(ByVal Cod As String, ByVal Descrip As String)
        Dim Espacio As String = "                          "  'Espacio que se le agregara a las variables
        Cod = Cod + Espacio                             'Se le agrega espacios a la dereca
        Descrip = Descrip + Espacio                     'Se le agrega espacios a la dereca

        Cod = Microsoft.VisualBasic.Left(Cod, 12)            'Se toma 8 caracteres de la izquierda
        Descrip = Microsoft.VisualBasic.Left(Descrip, 26)   'Se toma 20 caracteres de la izquierda

        Ticket1.TextoIzquierda(Cod + "  " + Descrip)
    End Sub

    Private Sub AgregarPrecio(ByVal Cant As String, ByVal Precio As String, ByVal Importe As String)
        Dim Espacio As String = "                    "  'Espacio que se le agregara a las variables
        Cant = Espacio + Cant                             'Se le agrega espacios a la izquierda
        Precio = Espacio + Precio                     'Se le agrega espacios a la izquierda
        Importe = Espacio + Importe                     'Se le agrega espacios a la izquierda

        Cant = Microsoft.VisualBasic.Right(Cant, 10)            'Se toma 12 caracteres de la derecha
        Precio = Microsoft.VisualBasic.Right(Precio, 10)   'Se toma 20 caracteres de la derecha
        Importe = Microsoft.VisualBasic.Right(Importe, 15)    'Se toma 8 caracteres de la derecha

        Ticket1.TextoIzquierda(Cant + " x " + Precio + "  " + Importe)
    End Sub

    Private Sub MostrarProducto(ByVal Cod As String, ByVal Descrip As String)
        Dim Espacio As String = "                          "  'Espacio que se le agregara a las variables
        Cod = Cod + Espacio                             'Se le agrega espacios a la dereca
        Descrip = Descrip + Espacio                     'Se le agrega espacios a la dereca

        Cod = Microsoft.VisualBasic.Left(Cod, 12)            'Se toma 8 caracteres de la izquierda
        Descrip = Microsoft.VisualBasic.Left(Descrip, 26)   'Se toma 20 caracteres de la izquierda

        txtPreview.Text = txtPreview.Text + "  " + Cod + "  " + Descrip + vbCrLf
    End Sub

    Private Sub MostrarPrecio(ByVal Cant As String, ByVal Precio As String, ByVal Importe As String)
        Dim Espacio As String = "                    "  'Espacio que se le agregara a las variables
        Cant = Espacio + Cant                             'Se le agrega espacios a la izquierda
        Precio = Espacio + Precio                     'Se le agrega espacios a la izquierda
        Importe = Espacio + Importe                     'Se le agrega espacios a la izquierda

        Cant = Microsoft.VisualBasic.Right(Cant, 10)            'Se toma 12 caracteres de la derecha
        Precio = Microsoft.VisualBasic.Right(Precio, 10)   'Se toma 20 caracteres de la derecha
        Importe = Microsoft.VisualBasic.Right(Importe, 15)    'Se toma 8 caracteres de la derecha

        txtPreview.Text = txtPreview.Text + "  " + Cant + " x " + Precio + "  " + Importe + vbCrLf
    End Sub

    Private Sub Imprimir()
        Ticket1.TextoCentro("COMERCIAL SOSA")
        Ticket1.LineasIgual()
        Ticket1.TextoIzquierda("FACTURA : " + Factura)
        Ticket1.TextoIzquierda("FECHA   : " + Fecha.ToString)
        Ticket1.TextoIzquierda("CLIENTE : " + Cliente)
        Ticket1.TextoIzquierda("VENTA   : " + Condicion)
        Ticket1.TextoIzquierda("VENDEDOR  : " + Vendedor)
        Ticket1.TextoExtremos("FECHA : " + Fecha.ToString("dd/MM/yyyy"), "HORA : " + Fecha.ToString("h:mm:ss"))
        Ticket1.LineasIgual()
        Ticket1.TextoIzquierda("Cod.   Descrip  /  Cant   Precio   Subt.")
        Ticket1.LineasIgual()
        Dim i As Integer
        Dim Cod, Descrip As String
        Dim Cant As Double
        Dim Precio, Importe As Integer
        Dim Filas = TablaDetalle.Rows.Count - 1
        For i = 0 To Filas
            Cod = CStr(TablaDetalle.Rows(i).Item(1))
            Descrip = CStr(TablaDetalle.Rows(i).Item(2))
            Cant = CDbl(TablaDetalle.Rows(i).Item(3))
            Precio = CInt(TablaDetalle.Rows(i).Item(4))
            Importe = CInt(TablaDetalle.Rows(i).Item(5))
            AgregarProducto(Cod, Descrip)
            AgregarPrecio(CStr(Cant), Format(Precio, "###,##"), Format(Importe, "###,##0"))
        Next

        Ticket1.LineasTotales()
        Ticket1.AgregaTotales("       TOTAL Gs :", Format(Total, "###,##")) ' // imprime linea con total
        Ticket1.LineasIgual()
        Ticket1.TextoCentro("Devoluciones hasta 24hs despues de la")
        Ticket1.TextoCentro("compra")
        Ticket1.TextoCentro("*** GRACIAS POR SU VISITA ***")
        Ticket1.CortaTicket() '
    End Sub


    Private Sub Imprimir_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Ticket1.impresora = "EPSON TM-U220 Receipt"
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Imprimir()
        Close()
    End Sub
End Class