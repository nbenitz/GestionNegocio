Option Strict On
Option Explicit On

Public Class FCuentasCobrar
    Dim Venta As New CVenta
    Dim Membresia As New CMembresia
    Dim TablaVenta As DataTable
    Dim TablaAux As DataTable
    Dim RowTabla As Integer
    Dim CIValue As String
    Dim ModoPagar As Boolean = False


    Private Sub frmCuentasCobrar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Not ModoPagar Then
            cmbFiltrarPor.SelectedIndex = 0
        Else
            Me.Size = New Size(750, 504)
            CargarTablaByCI()
        End If
    End Sub

    Public Sub ModoPagarByCI(ByVal CI As String)
        ModoPagar = True
        CIValue = CI
    End Sub

    Private Sub CargarTablaByCI()
        TablaVenta = Venta.BuscViewCuentas("WHERE CI = '" + CIValue + "'")
        CargarTabla(TablaVenta)
    End Sub


    'Private Sub Form1_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Resize
    'Dim strEstado As String = Me.WindowState.ToString()
    'If strEstado = "Maximized" Then
    'Me.WindowState = FormWindowState.Normal
    'End If
    'End Sub

    Private Sub cmbFiltrarPor_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbFiltrarPor.SelectedIndexChanged
        Dim Indice As Integer = cmbFiltrarPor.SelectedIndex
        Select Case Indice
            Case Is = 0 'Todos
                txtBusqueda.Visible = False
                lblBuscar.Visible = False
                TablaVenta = Venta.BuscViewCuentas("")
                CargarTabla(TablaVenta)
            Case Is = 1 'Nombre de Cliente
                txtBusqueda.Visible = True
                lblBuscar.Visible = True
            Case Is = 2 'CI
                txtBusqueda.Visible = True
                lblBuscar.Visible = True
        End Select
    End Sub

    Private Sub cmbFiltrarPor_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbFiltrarPor.Click
        cmbFiltrarPor.DroppedDown = True
    End Sub

    Private Sub cmbFiltrarPor_DropDownClosed(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbFiltrarPor.DropDownClosed
        Dim Indice As Integer = cmbFiltrarPor.SelectedIndex
        Select Case Indice
            Case Is = 1 'Nro Factura
                txtBusqueda.Focus()
        End Select
    End Sub

    Private Sub CargarTabla(ByVal Tabla As DataTable)
        Dim Filas As Integer = Tabla.Rows.Count
        Dim SumaTotal As Integer = 0
        DataGridView1.Rows.Clear()
        If Filas > 0 Then
            For i As Integer = 0 To (Filas - 1)
                Dim idVenta As Integer = CInt(Tabla.Rows(i).Item(0))
                Dim Cliente As String = CStr(Tabla.Rows(i).Item(3))
                Dim Concepto As String = CStr(Tabla.Rows(i).Item(4))
                Dim Fecha As String = Format(Tabla.Rows(i).Item(1), "dd/MM/yyyy")
                Dim Vto As String = Format(Tabla.Rows(i).Item(5), "dd/MM/yyyy")
                Dim Total As Integer = CInt(Tabla.Rows(i).Item(6))
                Dim Entregado As Integer = CInt(Tabla.Rows(i).Item(7))
                Dim Saldo As Integer = Total - Entregado
                DataGridView1.Rows.Add(idVenta, Fecha, Cliente, Concepto, Vto, Total, Entregado, Saldo)
                SumaTotal += Saldo
            Next
            txtSumaTotal.Text = CStr(SumaTotal)
        End If
    End Sub

    Private Sub txtBusqueda_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtBusqueda.KeyDown
        If e.KeyCode = Keys.Enter Then
            If cmbFiltrarPor.SelectedIndex = 1 Then
                Dim Nombre As String = txtBusqueda.Text
                If Nombre <> "" Then
                    TablaVenta = Venta.BuscViewCuentas("WHERE clien like '%" + Nombre + "%'")
                    CargarTabla(TablaVenta)
                End If
            ElseIf cmbFiltrarPor.SelectedIndex = 2 Then
                Dim CI As String = txtBusqueda.Text
                If CI <> "" Then
                    TablaVenta = Venta.BuscViewCuentas("WHERE CI = '" + CI + "'")
                    CargarTabla(TablaVenta)
                End If
            End If
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Try
            If e.ColumnIndex = 8 Then
                Cursor.Current = Cursors.WaitCursor
                TablaAux = TablaVenta
                RowTabla = e.RowIndex
                CargarRecibo(TablaAux, RowTabla)
                MostrarRecibo()
            End If
        Catch
            MessageBox.Show(Me, "Error al Cargar el Detalle de la Cuenta")
        End Try
    End Sub

    Private Sub CargarRecibo(ByVal TablaAux As DataTable, ByVal Row As Integer)
        Dim id As String = CStr(TablaAux.Rows(Row).Item(0))
        Dim Total As String = CStr(TablaAux.Rows(Row).Item(6))
        Dim Entregado As String = CStr(TablaAux.Rows(Row).Item(7))
        Dim Fecha As String = Format(TablaAux.Rows(Row).Item(1), "dd/MM/yyyy")
        Dim Vto As String = Format(TablaAux.Rows(Row).Item(5), "dd/MM/yyyy")
        Dim Cliente As String = CStr(TablaAux.Rows(Row).Item(3))
        Dim Saldo As String = CStr(CInt(Total) - CInt(Entregado))
        Encabezado(id, Fecha, Cliente, Vto, Total, Entregado, Saldo)

        Dim Concepto As String = CStr(TablaAux.Rows(Row).Item(4))
        If Concepto = "Venta de Productos" Then
            Cant.HeaderText = "Cant"
            Cant.Width = 100
            Descrip.Width = 245
            CargarDetalle(Venta.BuscViewDetVenta(id))
        ElseIf Concepto = "Pago de Membresía" Then
            Cant.HeaderText = "Periodo"
            Cant.Width = 140
            Descrip.Width = 205
            Detalle.Rows.Add(id,
                             "Cuota Membresía ",
                             Fecha + " - " + Vto,
                             Total,
                             Total)
        End If
    End Sub

    Private Sub MostrarRecibo()
        pnlCredito.Visible = False
        DataGridView1.Visible = False
        GroupBox1.Enabled = False
    End Sub

    Private Sub btnEntrega_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEntrega.Click
        If CInt(txtSaldo.Text) > 0 Then
            txtCredEntrega.Text = ""
            pnlCredito.Visible = True
            txtCredEntrega.Focus()
        Else
            MessageBox.Show(Me, "La cuenta ya ha sido cancelada")
        End If
    End Sub

    Private Sub btnCredCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCredCancel.Click
        pnlCredito.Visible = False
    End Sub

    Private Sub btnSalir_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        DataGridView1.Visible = True
        GroupBox1.Enabled = True
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        If CInt(txtSaldo.Text) > 0 Then
            CancelarCuenta()
        Else
            MessageBox.Show(Me, "La cuenta ya ha sido cancelada")
        End If
    End Sub

    Private Sub btnCredOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCredOk.Click
        If txtCredEntrega.Text <> "" Then
            Dim Total As Integer = CInt(txtTotal.Text)
            Dim Entrega As Integer = CInt(txtCredEntrega.Text)
            Dim Entregado As Integer = CInt(txtEntregado.Text)
            Dim Saldo As Integer = Total - Entregado
            If Entrega = Saldo Then
                CancelarCuenta()
                pnlCredito.Visible = False
                Exit Sub
            End If
            Dim Id As Integer = CInt(TablaAux.Rows(RowTabla).Item(0))
            Dim fecha As String = Format(Now, "yyyy-MM-dd HH:mm:ss")
            If Entrega > Saldo Then
                MessageBox.Show(Me, "La Entrega es mayor al Saldo de la Cuenta")
            Else
                If Cant.HeaderText = "Cant" Then    'Si se trata de pago por venta de productos
                    If Not Venta.UpdateVenta(Entrega, Id) And
                    Not Venta.InserRecibo(Venta.CargarNroRecib, Id, fecha, Entrega) Then
                        MessageBox.Show(Me, "Error al Actualizar la base de datos")
                        Exit Sub
                    End If
                Else                                'Si se trata de pago por cuota de membresía
                    If Not Membresia.Pagar(Id, CDate(fecha), Entrega) Then
                        MessageBox.Show(Me, "Error al Actualizar la base de datos")
                        Exit Sub
                    End If
                End If
                txtEntregado.Text = CStr(Entregado + Entrega)
                txtSaldo.Text = CStr(CInt(txtTotal.Text) - CInt(txtEntregado.Text))
                MessageBox.Show(Me, "Entrega Realizada")
                If Not ModoPagar Then
                    TablaVenta = Venta.BuscViewCuentas("")
                    CargarTabla(TablaVenta)
                Else
                    CargarTablaByCI()
                End If
                pnlCredito.Visible = False
            End If
        Else
            MessageBox.Show(Me, "Ingrese el monto de la Entrega")
        End If
    End Sub

    Private Sub CancelarCuenta()
        Dim Id As Integer = CInt(TablaAux.Rows(RowTabla).Item(0))
        Dim Total As Integer = CInt(TablaAux.Rows(RowTabla).Item(6))
        Dim Entregado As Integer = CInt(TablaAux.Rows(RowTabla).Item(7))
        Dim Saldo As Integer = Total - Entregado
        Dim fecha As String = Format(Now, "yyyy-MM-dd HH:mm:ss")

        If Cant.HeaderText = "Cant" Then    'Si se trata de pago por venta de productos
            If Not Venta.UpdateVenta(Saldo, Id) And
                Not Venta.InserRecibo(Venta.CargarNroRecib, Id, fecha, Saldo) And
                Not Venta.SetCancelado(Id) Then
                MessageBox.Show(Me, "Error al Actualizar la base de datos")
                Exit Sub
            End If
        Else                                'Si se trata de pago por cuota de membresía
            If Not Membresia.Pagar(Id, CDate(fecha), Saldo) Then
                MessageBox.Show(Me, "Error al Actualizar la base de datos")
                Exit Sub
            End If
        End If
        txtEntregado.Text = txtTotal.Text
        txtSaldo.Text = "0"
        MessageBox.Show(Me, "Cuenta Cancelada")
        If Not ModoPagar Then
            TablaVenta = Venta.BuscViewCuentas("")
            CargarTabla(TablaVenta)
        Else
            CargarTablaByCI()
        End If
    End Sub

    Private Sub txtNroFac_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBusqueda.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            e.Handled = True
        End If
    End Sub

    '' Recibo '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

    Public Sub Encabezado(ByVal NroCuentaCobrar As String,
                          ByVal Fecha As String,
                          ByVal Cliente As String,
                          ByVal Vto As String,
                          ByVal Total As String,
                          ByVal Entregado As String,
                          ByVal Saldo As String)
        txtNro.Text = NroCuentaCobrar
        txtFecha.Text = Fecha
        txtCliente.Text = Cliente
        txtVto.Text = Vto
        txtTotal.Text = Total
        txtEntregado.Text = Entregado
        txtSaldo.Text = Saldo
        Detalle.Rows.Clear()
    End Sub

    Public Sub CargarDetalle(ByVal Tabla As DataTable)
        Dim TablaDet As DataTable = Tabla
        'Dim CantAnt As Double = 1
        Dim Filas As Integer = Tabla.Rows.Count
        If Filas > 0 Then
            For i As Integer = 0 To (Filas - 1)
                Dim idProd As String = CStr(Tabla.Rows(i).Item(1))
                Dim Descrip As String = CStr(Tabla.Rows(i).Item(2))
                Dim Cant As Double = CDbl(Tabla.Rows(i).Item(3))
                Dim Precio As Integer = CInt(Tabla.Rows(i).Item(5))
                Dim Importe As Integer = CInt(Tabla.Rows(i).Item(6))
                Detalle.Rows.Add(idProd, Descrip, Cant, Precio, Importe)
                'If Cant > CantAnt Then
                'CantAnt = Cant 'Obtener la cantidad mayor de la tabla
                'End If
            Next
            'CalcTotal()
        End If
    End Sub


    ''''''''''''' Eventos Recibo ''''''''''''''''''''''''''''''''
    ''''''''''''''''Fin Recibo'''''''''''''''''''''''''''''''''''

    Private Sub BtnCerrarForm_Click(sender As Object, e As EventArgs) Handles BtnCerrarForm.Click
        Close()
    End Sub
End Class