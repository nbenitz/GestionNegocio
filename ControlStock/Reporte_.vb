

Public Class Reporte
    Public Enum Tipo As Integer
        Compra = 0
        Venta = 1
        CuentaPagar = 2
        CuentaCobrar = 3
        NotaCredCompra = 4
        NotaCredVenta = 5
    End Enum
    Dim FormatoValue As Integer
    Dim TablaDet As DataTable
    Dim GridFila As Integer
    Dim Producto As New CProducto

    Public Sub Encabezado(ByVal NroCuentaCobrar As String,
                          ByVal Fecha As String,
                          ByVal Vendedor As String,
                          ByVal Cliente As String,
                          ByVal Vto As String,
                          ByVal Total As String,
                          ByVal Entregado As String,
                          ByVal Saldo As String)
        txtNro.Text = NroCuentaCobrar
        txtFecha.Text = Fecha
        txtProvVend.Text = Vendedor
        txtCliente.Text = Cliente
        txtVto.Text = Vto
        txtTotal.Text = Total
        txtEntregado.Text = Entregado
        txtSaldo.Text = Saldo
        Detalle.Rows.Clear()
    End Sub

    Public Sub Encabezado(ByVal NroCuentaPagar As String, ByVal Fecha As String, ByVal Proveedor As String, _
                        ByVal Vto As String, ByVal Total As String, ByVal Entregado As String, ByVal Saldo As String)
        txtNro.Text = NroCuentaPagar
        txtFecha.Text = Fecha
        txtProvVend.Text = Proveedor
        txtVto.Text = Vto
        txtTotal.Text = Total
        txtEntregado.Text = Entregado
        txtSaldo.Text = Saldo
        Detalle.Rows.Clear()
    End Sub

    Public Sub Encabezado(ByVal NroVenta As String, ByVal Fecha As String, ByVal Vendedor As String, ByVal Cliente As String, ByVal Total As String)
        txtNro.Text = NroVenta
        txtFecha.Text = Fecha
        txtProvVend.Text = Vendedor
        txtCliente.Text = Cliente
        txtTotal.Text = Total
        Detalle.Rows.Clear()
    End Sub

    Public Sub Encabezado(ByVal NroCompra As String, ByVal Fecha As String, ByVal Proveedor As String, ByVal Total As String)
        txtNro.Text = NroCompra
        txtFecha.Text = Fecha
        txtProvVend.Text = Proveedor
        txtTotal.Text = Total
        Detalle.Rows.Clear()
    End Sub

    Public Sub CargarDetalleOcup(ByVal Tabla As DataTable)
        Dim Delete As Image = My.Resources.Resources.delete
        Dim Filas As Integer = Tabla.Rows.Count
        If Filas > 0 Then
            For i As Integer = 0 To (Filas - 1)
                Dim idServ As ULong = CULng(Tabla.Rows(i).Item(2))
                Dim Descrip As String = CStr(Tabla.Rows(i).Item(3))
                Dim Tiempo As String
                If idServ = 3 Then
                    Tiempo = CStr(Tabla.Rows(i).Item(4))
                Else
                    Dim TotalMinutes As Long = CLng(CStr(Tabla.Rows(i).Item(4)))
                    Dim Horas As TimeSpan = TimeSpan.FromMinutes(TotalMinutes)
                    Tiempo = Horas.ToString
                End If
                Dim Precio As Integer = CInt(Tabla.Rows(i).Item(5))
                Dim Importe As Integer = CInt(Tabla.Rows(i).Item(6))
                Detalle.Rows.Add(Delete, idServ, Descrip, Tiempo, Precio, Importe, "")
            Next
        End If
    End Sub

    Public Sub CargarDetalle(ByVal Tabla As DataTable)
        TablaDet = Tabla
        Dim Delete As Image = My.Resources.Resources.delete
        Dim CantAnt As Double = 1
        Dim Filas As Integer = Tabla.Rows.Count
        If Filas > 0 Then
            For i As Integer = 0 To (Filas - 1)
                Dim idProd As String = CStr(Tabla.Rows(i).Item(1))
                Dim Descrip As String = CStr(Tabla.Rows(i).Item(2))
                Dim Cant As Double = CDbl(Tabla.Rows(i).Item(3))
                Dim Unidades As Integer = CInt(Tabla.Rows(i).Item(4))
                Dim Precio As Integer = CInt(Tabla.Rows(i).Item(5))
                Dim Importe As Integer = CInt(Tabla.Rows(i).Item(6))
                Detalle.Rows.Add(Delete, idProd, Descrip, Cant, Precio, Importe, Unidades)
                If Cant > CantAnt Then
                    CantAnt = Cant 'Obtener la cantidad mayor de la tabla
                End If
            Next
            MostrarInfo(Filas, CantAnt)
            CalcTotal()
        End If
    End Sub

    Private Sub MostrarInfo(ByVal Filas As Integer, ByVal Cant As Double)
        If FormatoValue = Tipo.NotaCredVenta Or FormatoValue = Tipo.NotaCredCompra Then
            If Filas > 1 Then
                lblNotaInfo1.Visible = True
                MostrarDel()
            Else
                lblNotaInfo1.Visible = False
                OcultarDel()
            End If
            If Cant > 1 Then
                lblNotaInfo2.Visible = True
            Else
                lblNotaInfo2.Visible = False
            End If
        End If
    End Sub

    Public Sub Formato(ByVal Value As Tipo)
        FormatoValue = Value
        Select Case Value
            Case Is = Tipo.Compra
                txtVto.Visible = False
                txtEntregado.Visible = False
                txtSaldo.Visible = False
                txtCliente.Visible = False
                tagVto.Visible = False
                tagEntregado.Visible = False
                tagSaldo.Visible = False
                tagCliente.Visible = False
            Case Is = Tipo.Venta
                txtVto.Visible = False
                txtEntregado.Visible = False
                txtSaldo.Visible = False
                tagVto.Visible = False
                tagEntregado.Visible = False
                tagSaldo.Visible = False
                TagId.Text = "Nro. Venta:"
                TagProvVend.Text = "Vendedor:"
                Titulo.Text = "Nota de Venta"
            Case Is = Tipo.CuentaPagar
                txtCliente.Visible = False
                tagCliente.Visible = False
                Titulo.Text = ""
            Case Is = Tipo.CuentaCobrar
                TagId.Text = "Nro. Venta:"
                TagProvVend.Text = "Vendedor:"
                Titulo.Text = ""
            Case Is = Tipo.NotaCredCompra
                txtVto.Visible = False
                txtEntregado.Visible = False
                txtSaldo.Visible = False
                txtCliente.Visible = False
                tagVto.Visible = False
                tagEntregado.Visible = False
                tagSaldo.Visible = False
                tagCliente.Visible = False
                TagId.Text = "Nro. Nota:"
                Titulo.Text = "Nota de Crédito"
                MostrarDel()
            Case Is = Tipo.NotaCredVenta
                txtVto.Visible = False
                txtEntregado.Visible = False
                txtSaldo.Visible = False
                tagVto.Visible = False
                tagEntregado.Visible = False
                tagSaldo.Visible = False
                TagId.Text = "Nro. Nota:"
                TagProvVend.Text = "Vendedor:"
                Titulo.Text = "Nota de Crédito"
                MostrarDel()
        End Select
    End Sub

    Private Sub MostrarDel()
        Del.Visible = True
        Descrip.Width = 223
    End Sub

    Private Sub OcultarDel()
        Del.Visible = False
        Descrip.Width = 245
    End Sub

    Private Sub Detalle_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Detalle.CellClick
        If FormatoValue = Tipo.NotaCredCompra Or FormatoValue = Tipo.NotaCredVenta Then
            If e.ColumnIndex = 0 Then
                Detalle.Rows.RemoveAt(e.RowIndex)
                TablaDet.Rows.RemoveAt(e.RowIndex)
                CalcTotal()
                Dim Filas As Integer = Detalle.RowCount
                If Filas = 1 Then
                    OcultarDel()
                End If
            End If
            If e.ColumnIndex = 3 And e.RowIndex >= 0 Then
                pnlEditCant.Visible = True
                txtEditCant.Text = ""
                txtEditCant.Focus()
                GridFila = e.RowIndex
            End If
        End If
    End Sub

    Private Sub CalcTotal()
        Dim Total As Integer
        Dim Filas As Integer = Detalle.Rows.Count - 1
        For i As Integer = 0 To Filas
            Total += Convert.ToInt32(Detalle.Item(5, i).Value.ToString)
        Next
        txtTotal.Text = CStr(Total)
    End Sub

    Private Sub txtEditCant_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtEditCant.KeyDown
        If e.KeyCode = Keys.Enter Then
            Try
                Dim CantMax As Double = CDbl(TablaDet.Rows(GridFila).Item(3))
                Dim CantEdit As Double = CDbl(txtEditCant.Text)

                If CantEdit <= 0 Then
                    MessageBox.Show("La cantidad debe ser mayor a cero")
                Else
                    If CantMax >= CantEdit Then
                        Detalle.Item(3, GridFila).Value = CantEdit
                        pnlEditCant.Visible = False
                        Detalle.Item(5, GridFila).Value = CDbl(Detalle.Item(3, GridFila).Value) * CInt(Detalle.Item(4, GridFila).Value)
                        CalcTotal()
                    Else
                        MessageBox.Show("La cantidad no puede ser mayor al facturado" + vbCrLf + "La cantidad máxima para el producto es " + CStr(CantMax))
                    End If
                End If
            Catch
                MessageBox.Show("Ingrese una cantidad válida")
            End Try
        End If
    End Sub

    Private Sub txtEditCant_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtEditCant.KeyPress
        Dim Caja As TextBox = CType(sender, TextBox)
        Dim Letra As Char = e.KeyChar

        If Letra = Convert.ToChar(",") Or Letra = Convert.ToChar(".") Then
            Dim Cod As String = Convert.ToString(Detalle.Item(1, GridFila).Value.ToString)
            Dim Tabla As DataTable = Producto.BuscProdCod(Cod)
            Dim Present As String = CStr(Tabla.Rows(0).Item(10))
            If Present = "Kilo" Then
                If Letra = Convert.ToChar(",") Then
                    e.Handled = False
                Else
                    e.Handled = True
                    Caja.Text = Caja.Text + ","
                    Caja.Select(Caja.Text.Length, 0)
                End If
            Else
                e.Handled = True
                Caja.Focus()
                Me.ToolTip2.Show("Los productos por unidades o paquetes no aceptan decimales", Caja, 0, -40, 4000)
            End If
        ElseIf Char.IsDigit(Letra) Then
            e.Handled = False
        ElseIf Char.IsControl(Letra) Then
            e.Handled = False
        Else
            e.Handled = True
            Caja.Focus()
            Me.ToolTip2.Show("Ingrese un valor númerico", Caja, 0, -40, 2000)
        End If
        If Letra = Convert.ToChar(Keys.Return) Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnEditCantCancel_Click(sender As Object, e As EventArgs) Handles btnEditCantCancel.Click
        pnlEditCant.Visible = False
    End Sub

End Class
