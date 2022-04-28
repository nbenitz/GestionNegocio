Option Strict On
Option Explicit On
Public Class FListaCompra
    Dim Compra As New CCompra
    Dim Prov As New CProveedor
    Dim Producto As New CProducto
    Dim TablaProv As New DataTable
    Dim TablaCompra As New DataTable
    Dim IndiceVend As Integer = 0
    Dim Imagen As Image = My.Resources.Resources.view_text
    Dim ModoNotaCredValue As Boolean = False
    Dim TablaDet As DataTable
    Dim GridFila As Integer

    Public Sub ModoNotaCredito()
        ModoNotaCredValue = True
        btnRegistrar.Visible = True
        btnActualizar.Visible = True
        Imagen = My.Resources.Resources.apply1
        TagId.Text = "Nro. Nota:"
        Titulo.Text = "Nota de Crédito"
        lblTitulo.Visible = True
        MostrarDel()
    End Sub

    Private Sub frmReporteCompra_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        pnlReporte.Visible = False
        GroupBox1.Enabled = True
        cmbFiltrarPor.SelectedIndex = 0
        TablaProv = Prov.ListarProveed()
        cmbProveedor.Items.Clear()
        cmbProveedor.Items.Add("Todos")
        Dim Filas As Integer = TablaProv.Rows.Count
        If Filas > 0 Then
            For i As Integer = 0 To (Filas - 1)
                cmbProveedor.Items.Add(TablaProv.Rows(i).Item(1).ToString + " " + TablaProv.Rows(i).Item(2).ToString)
            Next
        End If
        cmbProveedor.SelectedIndex = 0
    End Sub

    Private Sub Form1_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        Dim strEstado As String = Me.WindowState.ToString()
        If strEstado = "Maximized" Then
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub F_Deactivate(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Deactivate
        'Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub cmbFiltrarPor_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbFiltrarPor.SelectedIndexChanged
        Dim Indice As Integer = CType(cmbFiltrarPor.SelectedIndex, Integer)
        Select Case Indice
            Case Is = 0 'Todos
                txtNroFac.Visible = False
                dtpDesde.Visible = False
                dtpHasta.Visible = False
                lblBuscar.Visible = False
                lblHasta.Visible = False
                txtNroFac.Visible = False
                lblProveedor.Visible = True
                cmbProveedor.Visible = True
                cmbProveedor.SelectedIndex = IndiceVend
                IndiceVend = cmbProveedor.SelectedIndex
                Select Case IndiceVend
                    Case Is = 0 'Todos
                        TablaCompra = Compra.BuscViewCompra("ORDER BY idCompra DESC")
                    Case Else 'Algun Proveedor
                        Dim RUC As String = TablaProv.Rows(IndiceVend - 1).Item(0).ToString
                        Dim Proveedor As String = "(select Nombre from proveedor where RUC = " + RUC + ")"
                        TablaCompra = Compra.BuscViewCompra("WHERE Proveed = " + Proveedor + "  ORDER BY idCompra DESC")
                End Select
                CargarTabla(TablaCompra)
            Case Is = 1 'Nro. Factura
                txtNroFac.Visible = True
                dtpDesde.Visible = False
                dtpHasta.Visible = False
                lblBuscar.Visible = True
                lblBuscar.Text = "Ingrese Nro. Factura"
                lblHasta.Visible = False
                IndiceVend = cmbProveedor.SelectedIndex
                lblProveedor.Visible = False
                cmbProveedor.Visible = False
            Case Is = 2 'Fecha
                txtNroFac.Visible = False
                dtpDesde.Visible = True
                dtpHasta.Visible = True
                lblBuscar.Visible = True
                lblBuscar.Text = "Desde"
                lblHasta.Visible = True
                lblHasta.Text = "Hasta"
                lblProveedor.Visible = True
                cmbProveedor.Visible = True

                dtpDesde.Value = Now
                dtpHasta.Value = Now
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
            For i As Integer = 0 To (Filas - 1)
                Dim idCompra As Integer = CInt(Tabla.Rows(i).Item(0))
                Dim Fecha As String = CType(Tabla.Rows(i).Item(1), String)
                Dim Proveedor As String = CType(Tabla.Rows(i).Item(3), String)
                Dim Total As Integer = CInt(Tabla.Rows(i).Item(4))
                DataGridView1.Rows.Add(idCompra, Fecha, Proveedor, Total, Imagen)
                SumaTotal = SumaTotal + Convert.ToInt32(DataGridView1.Item(3, i).Value.ToString)
            Next
            txtTotal.Text = String.Format("{0:N0}", SumaTotal)
        End If
    End Sub

    Private Sub txtNroFac_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtNroFac.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim NroFac As String = txtNroFac.Text
            If NroFac <> "" Then
                TablaCompra = Compra.BuscViewCompra("WHERE idCompra = " + NroFac)
                CargarTabla(TablaCompra)
            End If
        End If
    End Sub

    Private Sub dtpDesde_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpDesde.ValueChanged, dtpHasta.ValueChanged
        IndiceVend = cmbProveedor.SelectedIndex
        Dim TablaCompra As New DataTable
        Dim Fecha1 As String = Format(dtpDesde.Value, "yyyy-MM-dd")
        Dim Fecha2 As String = Format(DateAdd(DateInterval.Day, 1, dtpHasta.Value), "yyyy-MM-dd")
        Select Case IndiceVend
            Case Is = 0 'Todos
                TablaCompra = Compra.BuscViewCompra("WHERE Fecha > '" + Fecha1 + "' and Fecha < '" + Fecha2 + "' ORDER BY idCompra DESC")
            Case Else 'Algun Proveedor
                Dim RUC As String = TablaProv.Rows(IndiceVend - 1).Item(0).ToString
                Dim Proveedor As String = "(select Nombre from proveedor where RUC = " + RUC + ")"
                TablaCompra = Compra.BuscViewCompra("WHERE Fecha > '" + Fecha1 + "' and Fecha < '" + Fecha2 + "' AND Proveed = " + Proveedor + "  ORDER BY idCompra DESC")
        End Select
        CargarTabla(TablaCompra)
    End Sub

    Private Sub cmbProveedor_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbProveedor.SelectedIndexChanged
        Dim IndiceFiltrar As Integer = cmbFiltrarPor.SelectedIndex
        IndiceVend = cmbProveedor.SelectedIndex
        Select Case IndiceFiltrar
            Case Is = 0 'Todos
                Select Case IndiceVend
                    Case Is = 0 'Todos
                        TablaCompra = Compra.BuscViewCompra("ORDER BY idCompra DESC")
                    Case Else 'Algun Proveedor
                        Dim RUC As String = TablaProv.Rows(IndiceVend - 1).Item(0).ToString
                        Dim Proveedor As String = "(select Nombre from proveedor where RUC = " + RUC + ")"
                        TablaCompra = Compra.BuscViewCompra("WHERE Proveed = " + Proveedor + "  ORDER BY idCompra DESC")
                End Select
            Case Is = 2 'Fecha
                Dim Fecha1 As String = Format(dtpDesde.Value, "yyyy-MM-dd")
                Dim Fecha2 As String = Format(DateAdd(DateInterval.Day, 1, dtpHasta.Value), "yyyy-MM-dd")
                Select Case IndiceVend
                    Case Is = 0 'Todos
                        TablaCompra = Compra.BuscViewCompra("WHERE Fecha > '" + Fecha1 + "' and Fecha < '" + Fecha2 + "' ORDER BY idCompra DESC")
                    Case Else 'Algun Proveedor
                        Dim RUC As String = TablaProv.Rows(IndiceVend - 1).Item(0).ToString
                        Dim Proveedor As String = "(select Nombre from proveedor where RUC = " + RUC + ")"
                        TablaCompra = Compra.BuscViewCompra("WHERE Fecha > '" + Fecha1 + "' and Fecha < '" + Fecha2 + "' AND Proveed = " + Proveedor + "  ORDER BY idCompra DESC")
                End Select
        End Select
        CargarTabla(TablaCompra)
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Try
            If e.ColumnIndex = 4 Then
                Cursor.Current = Cursors.WaitCursor
                CargarDetalle(TablaCompra, e.RowIndex)
                ShowDetalle()
            End If
        Catch
            MessageBox.Show("Error al Cargar el Detalle de la Cuenta")
        End Try
    End Sub

    Private Sub CargarDetalle(ByVal TablaAux As DataTable, ByVal Row As Integer)
        Dim id As String = CStr(TablaAux.Rows(Row).Item(0))
        Dim Total As String = CStr(TablaAux.Rows(Row).Item(4))
        Dim Fecha As String = Format(TablaAux.Rows(Row).Item(1), "dd/MM/yyyy")
        Dim Proveed As String = CStr(TablaAux.Rows(Row).Item(3))
        Encabezado(id, Fecha, Proveed, Total)
        CargarDetalle(Compra.BuscViewDetCompra(id))
    End Sub

    Private Sub ShowDetalle()
        pnlReporte.Visible = True
        DataGridView1.Visible = False
        GroupBox1.Enabled = False
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        pnlReporte.Visible = False
        DataGridView1.Visible = True
        GroupBox1.Enabled = True
    End Sub

    Private Sub btnRegistrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegistrar.Click
        Dim idNota As Integer = Compra.CargarNroNota
        Dim idCompra As Integer = CInt(txtNro.Text)
        Dim fecha As String = Format(Now, "yyyy-MM-dd HH:mm:ss")
        Dim idProd As String
        Dim Cant As Double
        Dim Unid As Integer
        Try
            If Compra.InserNota(idNota, idCompra, fecha) = False Then
                MessageBox.Show("Hubo un problema as guardar la Nota de Crédito")
                Exit Try
            End If
            For Each row As DataGridViewRow In Detalle.Rows
                idProd = Convert.ToString(row.Cells(1).Value)
                Cant = Convert.ToDouble(row.Cells(3).Value)
                Unid = Convert.ToInt32(row.Cells(6).Value)
                If Compra.InserDetalleNota(idNota, idCompra, idProd, Cant, Unid) = False Then
                    MessageBox.Show("Hubo un problema as guardar el Detalle la Nota de Crédito")
                    Exit Try
                End If
            Next
            MessageBox.Show("Nota de Crédito Registrada correctamente")
            btnSalir_Click(Nothing, Nothing)
        Catch
            MessageBox.Show("Hubo un problema al registrar la Nota de Crédito")
        End Try
    End Sub

    Private Sub btnActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActualizar.Click
        CargarDetalle(TablaCompra, DataGridView1.CurrentRow.Index)
        ShowDetalle()
    End Sub

    Private Sub txtNroFac_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNroFac.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            e.Handled = True
        End If
    End Sub

    Private Sub BtnCerrarForm_Click(sender As Object, e As EventArgs) Handles BtnCerrarForm.Click
        Me.Close()
    End Sub

    '------------------------- Reporte--------------------------------------
    Public Sub Encabezado(ByVal NroCompra As String, ByVal Fecha As String, ByVal Proveedor As String, ByVal Total As String)
        txtNro.Text = NroCompra
        txtFecha.Text = Fecha
        txtProvVend.Text = Proveedor
        txtTotal2.Text = Total
        Detalle.Rows.Clear()
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
        If ModoNotaCredValue Then
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

    Private Sub MostrarDel()
        Del.Visible = True
        Descrip.Width = 223
    End Sub

    Private Sub OcultarDel()
        Del.Visible = False
        Descrip.Width = 245
    End Sub

    Private Sub CalcTotal()
        Dim Total As Integer
        Dim Filas As Integer = Detalle.Rows.Count - 1
        For i As Integer = 0 To Filas
            Total += Convert.ToInt32(Detalle.Item(5, i).Value.ToString)
        Next
        txtTotal2.Text = String.Format("{0:N0}", (Total))
    End Sub


    '---------------Eventos----------------------

    Private Sub Detalle_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Detalle.CellClick
        If ModoNotaCredValue Then
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
            Dim Tabla As DataTable = producto.BuscProdCod(Cod)
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

