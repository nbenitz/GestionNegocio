

Public Class FCuentasCobrar
    Dim Venta As New CVenta
    Dim TablaVenta As DataTable
    Dim TablaAux As DataTable
    Dim RowTabla As Integer

    Private Sub frmCuentasCobrar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cmbFiltrarPor.SelectedIndex = 0
        Reporte1.Formato(Reporte.Tipo.CuentaCobrar)
    End Sub

    Private Sub F_Deactivate(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Deactivate
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Form1_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        Dim strEstado As String = Me.WindowState.ToString()
        If strEstado = "Maximized" Then
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub cmbFiltrarPor_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbFiltrarPor.SelectedIndexChanged
        Dim Indice As Integer = cmbFiltrarPor.SelectedIndex
        Select Case Indice
            Case Is = 0 'Todos
                txtNroFac.Visible = False
                lblBuscar.Visible = False
                TablaVenta = Venta.BuscViewVenta("WHERE Cancelado = 'No' ORDER BY Vto DESC")
                CargarTabla(TablaVenta)
            Case Is = 1 'Nombre de Cliente
                txtNroFac.Visible = True
                lblBuscar.Visible = True
            Case Is = 2 'CI
                txtNroFac.Visible = True
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
                txtNroFac.Focus()
        End Select
    End Sub

    Private Sub CargarTabla(ByVal Tabla As DataTable)
        Dim Filas As Integer = Tabla.Rows.Count
        Dim SumaTotal As Integer = 0
        DataGridView1.Rows.Clear()
        If Filas > 0 Then
            For i = 0 To (Filas - 1)
                Dim idVenta As Integer = CInt(Tabla.Rows(i).Item(0))
                Dim Cliente As String = CStr(Tabla.Rows(i).Item(4))
                Dim Fecha As String = Format(Tabla.Rows(i).Item(1), "dd/MM/yyyy")
                Dim Vto As String = Format(Tabla.Rows(i).Item(8), "dd/MM/yyyy")
                Dim Total As Integer = CInt(Tabla.Rows(i).Item(5))
                Dim Entregado As Integer = CInt(Tabla.Rows(i).Item(7))
                Dim Saldo As Integer = Total - Entregado
                DataGridView1.Rows.Add(idVenta, Cliente, Fecha, Vto, Total, Entregado, Saldo)
                SumaTotal = SumaTotal + Convert.ToInt32(DataGridView1.Item(4, i).Value.ToString)
            Next
            txtTotal.Text = CStr(SumaTotal)
        End If
    End Sub

    Private Sub txtNroFac_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtNroFac.KeyDown
        If e.KeyCode = Keys.Enter Then
            If cmbFiltrarPor.SelectedIndex = 1 Then
                Dim Nombre As String = txtNroFac.Text
                If Nombre <> "" Then
                    TablaVenta = Venta.BuscViewVenta("WHERE cancelado = 'No' AND clien like '%" + Nombre + "%' ORDER BY Vto DESC")
                    CargarTabla(TablaVenta)
                End If
            ElseIf cmbFiltrarPor.SelectedIndex = 2 Then
                Dim Nombre As String = txtNroFac.Text
                If Nombre <> "" Then
                    TablaVenta = Venta.BuscViewVenta("WHERE cancelado = 'No' AND CICliente = '" + Nombre + "' ORDER BY Vto DESC")
                    CargarTabla(TablaVenta)
                End If
            End If
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Try
            If e.ColumnIndex = 7 Then
                Cursor.Current = Cursors.WaitCursor
                TablaAux = TablaVenta
                RowTabla = e.RowIndex
                CargarDetalle(TablaAux, RowTabla)
                ShowDetalle()
            End If
        Catch
            MessageBox.Show("Error al Cargar el Detalle de la Cuenta")
        End Try
    End Sub

    Private Sub CargarDetalle(ByVal TablaAux As DataTable, ByVal Row As Integer)
        Dim id = CStr(TablaAux.Rows(Row).Item(0))
        Dim Total = CStr(TablaAux.Rows(Row).Item(5))
        Dim Entregado = CStr(TablaAux.Rows(Row).Item(7))
        Dim Fecha = Format(TablaAux.Rows(Row).Item(1), "dd/MM/yyyy")
        Dim Vto = Format(TablaAux.Rows(Row).Item(8), "dd/MM/yyyy")
        Dim Vendedor = CStr(TablaAux.Rows(Row).Item(3))
        Dim Cliente = CStr(TablaAux.Rows(Row).Item(4))
        Dim Saldo = CStr(CInt(Total) - CInt(Entregado))
        Reporte1.Encabezado(id, Fecha, Vendedor, Cliente, Vto, Total, Entregado, Saldo)
        Reporte1.CargarDetalle(Venta.BuscViewDetVenta(id))
    End Sub

    Private Sub ShowDetalle()
        pnlCredito.Visible = False
        DataGridView1.Visible = False
        GroupBox1.Enabled = False
    End Sub

    Private Sub btnEntrega_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEntrega.Click
        txtCredEntrega.Text = ""
        pnlCredito.Visible = True
        txtCredEntrega.Focus()
    End Sub

    Private Sub btnCredCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCredCancel.Click
        pnlCredito.Visible = False
    End Sub

    Private Sub btnSalir_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        DataGridView1.Visible = True
        GroupBox1.Enabled = True
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        CancelarCuenta()
    End Sub

    Private Sub btnCredOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCredOk.Click
        If txtCredEntrega.Text <> "" Then
            Dim Total As Integer = CInt(TablaAux.Rows(RowTabla).Item(5))
            Dim Entrega As Integer = CInt(txtCredEntrega.Text)
            Dim Entregado As Integer = CInt(TablaAux.Rows(RowTabla).Item(7))
            Dim Saldo As Integer = Total - Entregado
            If Entrega = Saldo Then
                CancelarCuenta()
                Exit Sub
            End If
            Dim idVenta As UInteger = CUInt(TablaAux.Rows(RowTabla).Item(0))
            Dim fecha As String = Format(Now, "yyyy-MM-dd HH:mm:ss")
            If Entrega > Saldo Then
                MessageBox.Show("La Entrega es mayor al Saldo de la Cuenta")
            Else
                If Venta.UpdateVenta(Entrega, idVenta) = True And _
                    Venta.InserRecibo(Venta.CargarNroRecib, idVenta, fecha, Entrega) = True Then
                    Cursor.Current = Cursors.WaitCursor
                    TablaAux = Venta.BuscViewVenta("WHERE idVenta =" + CStr(idVenta))
                    RowTabla = 0
                    CargarDetalle(TablaAux, 0)
                    ShowDetalle()
                    TablaVenta = Venta.BuscViewVenta("WHERE Cancelado = 'No' ORDER BY Vto DESC")
                    CargarTabla(TablaVenta)
                    MessageBox.Show("Entrega Realizada")
                Else
                    MessageBox.Show("Error al Actualizar la base de datos")
                End If
                pnlCredito.Visible = False
            End If
        Else
            MessageBox.Show("Ingrese el monto de la Entrega")
        End If
    End Sub

    Private Sub CancelarCuenta()
        Dim idVenta As UInteger = CUInt(TablaAux.Rows(RowTabla).Item(0))
        Dim Total As Integer = CInt(TablaAux.Rows(RowTabla).Item(5))
        Dim Entregado As Integer = CInt(TablaAux.Rows(RowTabla).Item(7))
        Dim Saldo As Integer = Total - Entregado
        Dim fecha As String = Format(Now, "yyyy-MM-dd HH:mm:ss")
        If Venta.UpdateVenta(Saldo, idVenta) = True And
            Venta.InserRecibo(Venta.CargarNroRecib, idVenta, fecha, Saldo) = True And
            Venta.UpdateVenta(idVenta) = True Then
            Cursor.Current = Cursors.WaitCursor
            TablaAux = Venta.BuscViewVenta("WHERE idVenta =" + CStr(idVenta))
            RowTabla = 0
            CargarDetalle(TablaAux, 0)
            ShowDetalle()
            MessageBox.Show("Cuenta Cancelada")
            TablaVenta = Venta.BuscViewVenta("WHERE Cancelado = 'No' ORDER BY Vto DESC")
            CargarTabla(TablaVenta)
        Else
            MessageBox.Show("Error al Actualizar la base de datos")
        End If


        ''If Venta.UpdateVenta(idVenta) = True Then
        ''MessageBox.Show("Cuenta Cancelada")
        ''TablaVenta = Venta.BuscViewVenta("WHERE Cancelado = 'No' ORDER BY Vto DESC")
        ''CargarTabla(TablaVenta)
        ''Else
        ''MessageBox.Show("Error al Actualizar la base de datos")
        ''End If
    End Sub

    Private Sub txtNroFac_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNroFac.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            e.Handled = True
        End If
    End Sub
End Class