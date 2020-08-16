Option Strict On

Public Class FCompra
    Dim Compra As New CCompra
    Dim Producto As New CProducto
    Dim Proveedor As New CProveedor
    Dim Tabla As New DataTable
    Dim TablaProv As New DataTable
    Dim RUC As String
    Dim Param As String
    Dim Entrega? As Integer = Nothing
    Dim GridFila As Integer

    Private Sub Orden_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtNroFac.Text = CStr(Compra.CargarNroFacCompra())
        txtFecha.Text = Now.Date.ToShortDateString
        Limpiar()
        ToolTip2.IsBalloon = True
    End Sub

    Private Sub Form1_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        Dim strEstado As String = Me.WindowState.ToString()
        If strEstado = "Maximized" Then
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub F_Deactivate(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Deactivate
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub CargarProv()
        TablaProv = Proveedor.ListarProveed()
        cmbProveedor.Items.Clear()
        cmbProveedor.Text = ""
        Dim Filas As Integer = TablaProv.Rows.Count
        If Filas > 0 Then
            For i As Integer = 0 To (Filas - 1)
                cmbProveedor.Items.Add(TablaProv.Rows(i).Item(1))
            Next
        End If
    End Sub

    Private Sub txtBuscar_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtBuscar.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmbDescrip.Items.Clear()
            cmbDescrip.Text = ""
            Param = txtBuscar.Text
            If Param <> "" Then
                '------------------------------------------------------------------------------------------------------
                If optDesc.Checked Then                                     'BUSCAR POR DESCRIPCION
                    Tabla = Producto.BuscProdDesc(Param)
                    Dim Filas As Integer = Tabla.Rows.Count
                    If Filas > 0 Then
                        For i As Integer = 0 To (Filas - 1)
                            cmbDescrip.Items.Add(Tabla.Rows(i).Item(3))
                        Next
                        cmbDescrip.Text = CStr(cmbDescrip.Items(0))
                        cmbDescrip.Focus()
                        Timer1.Enabled = True
                    End If
                    '------------------------------------------------------------------------------------------------------
                Else                                                        'BUSCAR POR CODIGO
                    Dim Cod As String = txtBuscar.Text
                    Tabla = Producto.BuscProdCod(Cod)
                    Dim Filas As Integer = Tabla.Rows.Count
                    If Filas > 0 Then
                        cmbDescrip.Items.Add(Tabla.Rows(0).Item(3))
                        cmbDescrip.Text = CStr(cmbDescrip.Items(0))
                        txtCant.Focus()
                        Exit Sub
                    Else
                        MessageBox.Show("El Código no existe")
                        txtBuscar.Select(0, txtBuscar.TextLength)
                    End If

                End If
            Else

            End If
        End If
    End Sub

    Private Sub txtBuscar_KeyDow(ByVal sender As Object, ByVal e As KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            cmbDescrip.Items.Clear()
            cmbDescrip.Text = ""
            Param = txtBuscar.Text
            If Param <> "" Then
                If optDesc.Checked = True Then
                    Tabla = Producto.BuscProdDesc(Param)
                Else
                    Dim Cod As String
                    Cod = txtBuscar.Text
                    Tabla = Producto.BuscProdCod(Cod)
                End If
                Dim Filas As Integer = Tabla.Rows.Count
                If Filas > 0 Then
                    For i As Integer = 0 To (Filas - 1)
                        cmbDescrip.Items.Add(Tabla.Rows(i).Item(3))
                    Next
                    cmbDescrip.Text = CStr(cmbDescrip.Items(0))
                    cmbDescrip.Focus()
                    Timer1.Enabled = True
                End If
            Else
                ''cmbDescrip.Items.Clear()
            End If
        End If
    End Sub

    Private Sub txtBuscar_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBuscar.KeyPress
        'If optCod.Checked Then
        'If Char.IsDigit(e.KeyChar) Then
        'e.Handled = False
        'ElseIf Char.IsControl(e.KeyChar) Then
        'e.Handled = False
        'Else
        'e.Handled = True
        'End If
        'End If
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtBuscar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBuscar.Click
        txtBuscar.Select(0, txtBuscar.Text.Length)
    End Sub

    Private Sub txtCant_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCant.Click
        txtCant.Select(0, txtCant.Text.Length)
    End Sub

    Private Sub txtCant_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCant.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnAgregar.Focus()
        End If
    End Sub

    Private Sub cmbDescrip_DropDownClosed(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbDescrip.DropDownClosed
        txtCant.Focus()
        txtCant.Select(0, txtCant.Text.Length)
    End Sub

    Private Sub cmbDescrip_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbDescrip.SelectedIndexChanged
        Dim Fila As Integer = cmbDescrip.SelectedIndex
        lblInfoCod.Text = CStr(Tabla.Rows(Fila).Item(0))
        lblInfoDesc.Text = CStr(Tabla.Rows(Fila).Item(3))
        lblInfoCosto.Text = CStr(Tabla.Rows(Fila).Item(4))
        lblInfoStock.Text = CStr(Tabla.Rows(Fila).Item(9))


        pnlProdInfo.Visible = True
        Try
            PictureBox1.Image = Nothing
            PictureBox1.SizeMode = PictureBoxSizeMode.CenterImage
            PictureBox1.Image = MImagen.ByteArrayToImage(CType(Tabla.Rows(Fila).Item(12), Byte()))
        Catch
        End Try
        lblInfoCod.Text = CStr(Tabla.Rows(Fila).Item(0))
        lblInfoDesc.Text = CStr(Tabla.Rows(Fila).Item(3))
        lblInfoStock.Text = CStr(Tabla.Rows(Fila).Item(9))
        lblInfoCosto.Text = CStr(Tabla.Rows(Fila).Item(4))

        Select Case CStr(Tabla.Rows(Fila).Item(11))
            Case "Si", "SiCaja", "SiMetro"
                lblX.Visible = True
                lblUnidXpack.Visible = True
                lblUnidXpack.Text = CStr(Tabla.Rows(Fila).Item(11))
                lblUnidXPackInfo.Text = CStr(Tabla.Rows(Fila).Item(11))
                lblUnidXPackInfo.Visible = True
                lblUnidXPackTit.Visible = True
                pnlInfoPiso.Visible = False
                Select Case CStr(Tabla.Rows(Fila).Item(11))
                    Case "Si"
                        lblPresent.Text = "Por Paquete"
                    Case "SiCaja"
                        lblPresent.Text = "Por Caja"
                    Case "SiMetro"
                        lblPresent.Text = "Entero"
                End Select
            Case "No"
                lblPresent.Text = "Por Unidad"
                lblX.Visible = False
                lblUnidXpack.Visible = False
                lblUnidXPackInfo.Visible = False
                lblUnidXPackTit.Visible = False
                pnlInfoPiso.Visible = False
            Case "Piso"
                lblInfoStock.Text = lblInfoStock.Text + " unidades"
                lblMxCaja.Text = CStr(Tabla.Rows(Fila).Item(16))
                lblUnidxCaja.Text = CStr(Tabla.Rows(Fila).Item(10))
                pnlInfoPiso.Visible = True
        End Select
    End Sub

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        Dim Delete As Image = My.Resources.Resources.button_cancel
        Dim Fila As Integer = cmbDescrip.SelectedIndex
        Param = cmbDescrip.Text
        Dim Cant As Double = CDbl(txtCant.Text)
        Dim Unidades As Double = 1
        Dim Obs As String = ""
        Dim idProd As String = CStr(Tabla.Rows(Fila).Item(0))
        Dim Costo As Integer = CInt(Tabla.Rows(Fila).Item(4))
        Dim flag As Boolean = False 'Para saber si ya se ingreso el producto en el datagrid
        Dim Indice As Integer
        Dim idProdAux As String
        Dim CantAux As Double

        Select Case CStr(Tabla.Rows(Fila).Item(11))
            Case "Si", "SiCaja", "SiMetro"
                Unidades = CDbl(Tabla.Rows(Fila).Item(10))
                Obs = "(Paquete)"
            Case "Piso"
                Unidades = CDbl(Tabla.Rows(Fila).Item(10))
                Obs = "(Caja)"
        End Select

        Dim Row As Integer = DataGridView1.Rows.Count
        If Row > 0 Then
            For i As Integer = 0 To Row - 1            'Buscar en el datagrid si ya se ingreso el producto
                idProdAux = Convert.ToString(DataGridView1.Item(1, i).Value.ToString)
                CantAux = Convert.ToDouble(DataGridView1.Item(2, i).Value.ToString)
                If idProdAux = idProd Then  'si se encuentra
                    flag = True             'activar el flag
                    Indice = i              'guardar la fila donde se encuentra el producto
                    Cant += CantAux         'sumar la cantidad anterior a la cantidad actual
                End If
            Next
        End If

        Dim Importe As Integer = CInt(Cant * Costo)

        If flag = False Then 'Si aun no se ingreso, hecer
            DataGridView1.Rows.Add(Delete, idProd, Cant, Param, Costo, Importe, Unidades, Obs)
        Else 'Sino, hecer
            DataGridView1.Rows.RemoveAt(Indice)
            DataGridView1.Rows.Insert(Indice, Delete, idProd, Cant, Param, Costo, Importe, Unidades, Obs)
        End If
        tmrTotal.Enabled = True
        txtBuscar.Focus()
        txtBuscar.Select(0, txtBuscar.Text.Length)
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Limpiar()
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Dim Filas As Integer = DataGridView1.Rows.Count
        If Filas > 0 Then
            If cmbProveedor.Text <> "" Then
                If optCredito.Checked = True Then
                    btnCredOk.Visible = False
                    lblCredGs.Visible = False
                    txtCredEntrega.Visible = False
                    pnlCredito.Visible = True
                Else
                    GuardarCompra()
                End If
            Else
                cmbProveedor.Focus()
                Me.ToolTip2.Show("Ingrese Proveedor", cmbProveedor, 0, -40, 2000)
            End If
        Else
            txtBuscar.Focus()
            Me.ToolTip2.Show("Ingrese Productos", txtBuscar, 0, -40, 2000)
        End If
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        End
    End Sub

    Private Sub Limpiar()
        Entrega = 0
        txtBuscar.Text = ""
        txtTotal.Text = "0"
        txtCant.Text = "1"
        cmbDescrip.Text = ""
        lblInfoDesc.Text = ""
        lblInfoCod.Text = ""
        lblInfoCosto.Text = ""
        lblInfoStock.Text = ""
        cmbDescrip.Items.Clear()
        DataGridView1.Rows.Clear()
        cmbProveedor.Text = ""
        optContado.Checked = True
        pnlProdInfo.Visible = False
        lblX.Visible = False
        lblUnidXpack.Visible = False
        txtBuscar.Focus()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        cmbDescrip.DroppedDown = True
        Timer1.Enabled = False
    End Sub

    Private Sub tmrTotal_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrTotal.Tick
        Dim Total As Integer
        Dim Filas As Integer = DataGridView1.Rows.Count - 1
        For i As Integer = 0 To Filas
            Total += Convert.ToInt32(DataGridView1.Item(5, i).Value.ToString)
        Next
        txtTotal.Text = Format(Total, "###,##0")
        tmrTotal.Enabled = False
    End Sub

    Private Sub cmbProveedor_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbProveedor.Click
        CargarProv()
        cmbProveedor.DroppedDown = True
    End Sub


    Private Sub cmbProveedor_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbProveedor.SelectedIndexChanged
        Dim Indice As Integer = cmbProveedor.SelectedIndex
        If Indice >= 0 Then
            RUC = CStr(TablaProv.Rows(Indice).Item(0))
        End If
    End Sub

    Private Sub btnCredOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCredOk.Click
        If txtCredEntrega.Text <> "" Then
            Entrega = CInt(txtCredEntrega.Text)
            If Entrega < CInt(txtTotal.Text) Then
                pnlCredito.Visible = False
                GuardarCompra()
            Else
                txtCredEntrega.Focus()
                Me.ToolTip2.Show("La Entrega debe ser menor que el monto Total", txtCredEntrega, 0, -40, 2000)
            End If
        Else
            txtCredEntrega.Focus()
            Me.ToolTip2.Show("Ingrese el monto de la Entrega", txtCredEntrega, 0, -40, 2000)
        End If
    End Sub

    Private Sub btnCredNo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCredNo.Click
        Entrega = 0
        pnlCredito.Visible = False
        GuardarCompra()
    End Sub

    Private Sub GuardarCompra()
        Dim Filas As Integer = DataGridView1.Rows.Count
        Dim idProd As String
        Dim Cant As Double
        Dim Precio As Integer
        Dim Unidades As Integer
        Dim Obs As String = ""
        Dim Cancelado As String
        Dim fecha As String = Format(Now, "yyyy-MM-dd HH:mm:ss")
        Dim Vto As String = Format(dtpVto.Value, "yyyy-MM-dd")
        If optContado.Checked = True Then
            Cancelado = "Si"
        Else
            Cancelado = "No"
        End If
        Try
            If Compra.InserCompra(CInt(txtNroFac.Text), RUC, fecha, Cancelado, Entrega, Vto) = False Then
                MessageBox.Show("Hubo un error al guardar la factura.")
                Exit Try
            End If
            For i As Integer = 0 To Filas - 1
                idProd = Convert.ToString(DataGridView1.Item(1, i).Value.ToString)
                Cant = Convert.ToDouble(DataGridView1.Item(2, i).Value.ToString)
                Precio = Convert.ToInt32(DataGridView1.Item(4, i).Value.ToString)
                Unidades = Convert.ToInt32(DataGridView1.Item(6, i).Value.ToString)
                Obs = Convert.ToString(DataGridView1.Item(7, i).Value.ToString)
                If Compra.InserDetalleCompra(CInt(txtNroFac.Text), idProd, Cant, Unidades, Precio, Obs) = False Then
                    MessageBox.Show("Hubo un error al guardar la factura..")
                    Exit Try
                End If
            Next
            UpdatePrecProv()
            txtNroFac.Text = CStr(Compra.CargarNroFacCompra())
            MessageBox.Show("Factura Guardada")
            Limpiar()
        Catch
            MessageBox.Show("Hubo un error al guardar la factura...")
        End Try
    End Sub

    Private Sub UpdatePrecProv()
        Dim idProd As String
        Dim Precio As Integer
        Dim Filas As Integer = DataGridView1.Rows.Count
        Try
            For i As Integer = 0 To Filas - 1
                idProd = Convert.ToString(DataGridView1.Item(1, i).Value.ToString)
                Precio = Convert.ToInt32(DataGridView1.Item(4, i).Value.ToString)
                If Producto.UpdatePrecio(idProd, Precio, RUC) = False Then
                    MessageBox.Show("Hubo un error al guardar la factura..")
                End If
            Next
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnCredSi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCredSi.Click
        lblCredGs.Visible = True
        txtCredEntrega.Text = ""
        txtCredEntrega.Visible = True
        btnCredOk.Visible = True
        txtCredEntrega.Focus()
    End Sub

    Private Sub btnCredCancel_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCredCancel.Click
        pnlCredito.Visible = False
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        Dim frm As New FNuevoProducto
        frm.MaximizeBox = False
        frm.MinimizeBox = False
        frm.ShowDialog()

    End Sub

    Private Sub pbxNewProv_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbxNewProv.Click
        Dim Frm As New FNuevoProveed
        Frm.MaximizeBox = False
        frm.MinimizeBox = False
        frm.ShowDialog()
    End Sub

    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If e.ColumnIndex = 0 Then
            DataGridView1.Rows.RemoveAt(e.RowIndex)
            tmrTotal.Enabled = True
        End If
        If e.ColumnIndex = 2 And e.RowIndex >= 0 Then
            pnlEditCant.Visible = True
            txtEditCant.Text = ""
            txtEditCant.Focus()
            GridFila = e.RowIndex
        End If
        If e.ColumnIndex = 4 And e.RowIndex >= 0 Then
            pnlEditPrec.Visible = True
            txtEditPrec.Text = ""
            txtEditPrec.Focus()
            GridFila = e.RowIndex
        End If
    End Sub

    Private Sub DataGridView1_CellValueChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellValueChanged
        ''If e.ColumnIndex = 4 And DataGridView1.RowCount > 0 Then
        ''Dim row As Integer = e.RowIndex
        ''Try
        ''DataGridView1.Item(5, row).Value = CInt(DataGridView1.Item(4, row).Value) * _
        ''CInt(DataGridView1.Item(2, row).Value)
        ''tmrTotal.Enabled = True
        ''Catch
        ''MessageBox.Show("Ingrese una cantidad válida")
        ''DataGridView1.Item(4, row).Value = CInt(DataGridView1.Item(5, row).Value) / _
        ''CInt(DataGridView1.Item(2, row).Value)
        ''End Try
        ''End If
    End Sub

    Private Sub btnAgregar_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAgregar.GotFocus
        btnAgregar.ForeColor = Color.Orange
    End Sub

    Private Sub btnAgregar_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAgregar.LostFocus
        btnAgregar.ForeColor = Color.White
    End Sub

    Private Sub txtEditCant_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtEditCant.KeyDown
        If e.KeyCode = Keys.Enter Then
            Try
                Dim CantEdit As Double = CDbl(txtEditCant.Text)
                If CantEdit <= 0 Then
                    MessageBox.Show("La cantidad debe ser mayor a cero")
                Else
                    DataGridView1.Item(2, GridFila).Value = CantEdit
                    pnlEditCant.Visible = False
                    txtBuscar.Focus()
                    txtBuscar.Select(0, txtBuscar.Text.Length)
                    'Try
                    DataGridView1.Item(5, GridFila).Value = CDbl(DataGridView1.Item(4, GridFila).Value) * _
                        CDbl(DataGridView1.Item(2, GridFila).Value)
                    tmrTotal.Enabled = True
                    'Catch
                    '   MessageBox.Show("Ingrese una cantidad válida")
                    '  DataGridView1.Item(4, row).Value = CInt(DataGridView1.Item(5, row).Value) / _
                    'CInt(DataGridView1.Item(3, row).Value)
                    'End Try

                    End If
            Catch ex As Exception
                MessageBox.Show("Valor de Cantidad no Válida")
            End Try
        End If
    End Sub

    Private Sub txtCant_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCant.KeyPress, txtEditCant.KeyPress
        Dim Caja As TextBox = CType(sender, TextBox)
        Dim Letra As Char = e.KeyChar
        If Letra = Convert.ToChar(",") Or Letra = Convert.ToChar(".") Then
            Dim Present As String = "Kilo"
            If Caja Is txtCant Then
                Try
                    Present = CStr(Tabla.Rows(cmbDescrip.SelectedIndex).Item(11))
                Catch ex As Exception
                End Try
            Else
                Dim Cod As String = Convert.ToString(DataGridView1.Item(1, GridFila).Value.ToString)
                Tabla = Producto.BuscProdCod(CStr(Cod))
                Present = CStr(Tabla.Rows(0).Item(11))
            End If
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

    Private Sub btnEditCantCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditCantCancel.Click
        pnlEditCant.Visible = False
    End Sub

    Private Sub txtEditPrec_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtEditPrec.KeyDown
        If e.KeyCode = Keys.Enter Then
            Try
                Dim Precio As Double = CDbl(txtEditPrec.Text)

                DataGridView1.Item(4, GridFila).Value = Precio
                pnlEditPrec.Visible = False
                txtBuscar.Focus()
                txtBuscar.Select(0, txtBuscar.Text.Length)
                DataGridView1.Item(5, GridFila).Value = CDbl(DataGridView1.Item(4, GridFila).Value) * _
                    CDbl(DataGridView1.Item(2, GridFila).Value)
                tmrTotal.Enabled = True
            Catch ex As Exception
                MessageBox.Show("Valor de Cantidad no Válida")
            End Try
        End If
    End Sub

    Private Sub txtEditPrec_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtEditPrec.KeyPress
        Dim Caja As TextBox = CType(sender, TextBox)
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
            Caja.Focus()
            Me.ToolTip2.Show("Ingrese un valor númerico", Caja, 0, -40, 2000)
        End If
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnEditPrecCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditPrecCancel.Click
        pnlEditPrec.Visible = False
    End Sub

    Private Sub optCod_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles optCod.Click, optDesc.Click, _
        txtFecha.Click, txtNroFac.Click, txtTotal.Click, DataGridView1.Click, _
        optContado.Click, optCredito.Click

        txtBuscar.Focus()
        txtBuscar.Select(0, txtBuscar.Text.Length)
    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged

    End Sub

    Private Sub txtEditPrec_TextChanged(sender As Object, e As EventArgs) Handles txtEditPrec.TextChanged

    End Sub

    Private Sub txtBuscar_KeyUp(sender As Object, e As KeyEventArgs) Handles txtBuscar.KeyUp

    End Sub
End Class