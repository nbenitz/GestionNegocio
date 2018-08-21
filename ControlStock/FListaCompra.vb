
Public Class FListaCompra
    Dim Compra As New CCompra
    Dim Prov As New CProveedor
    Dim TablaProv As New DataTable
    Dim TablaCompra As New DataTable
    Dim IndiceVend As Integer = 0
    Dim Imagen As Image

    Sub New(ByVal Formato As Reporte.Tipo)
        InitializeComponent()
        Reporte1.Formato(Formato)
        Select Case Formato
            Case Is = Reporte.Tipo.Compra
                Imagen = My.Resources.Resources.view_text
                lblTitulo.Visible = False
            Case Is = Reporte.Tipo.NotaCredCompra
                btnRegistrar.Visible = True
                btnActualizar.Visible = True
                Imagen = My.Resources.Resources.apply1
        End Select
    End Sub

    Private Sub frmReporteCompra_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Panel1.Visible = False
        GroupBox1.Enabled = True
        cmbFiltrarPor.SelectedIndex = 0
        TablaProv = Prov.ListarProveed()
        cmbProveedor.Items.Clear()
        cmbProveedor.Items.Add("Todos")
        Dim Filas As Integer = TablaProv.Rows.Count
        If Filas > 0 Then
            For i = 0 To (Filas - 1)
                cmbProveedor.Items.Add(TablaProv.Rows(i).Item(1) + " " + TablaProv.Rows(i).Item(2))
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
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub cmbFiltrarPor_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbFiltrarPor.SelectedIndexChanged
        Dim Indice As String = cmbFiltrarPor.SelectedIndex
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
                        Dim RUC As String = TablaProv.Rows(IndiceVend - 1).Item(0)
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
        Dim Indice As String = cmbFiltrarPor.SelectedIndex
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
                Dim idCompra As Integer = Tabla.Rows(i).Item(0)
                Dim Fecha As String = Tabla.Rows(i).Item(1)
                Dim Proveedor As String = Tabla.Rows(i).Item(3)
                Dim Total As Integer = Tabla.Rows(i).Item(4)
                DataGridView1.Rows.Add(idCompra, Fecha, Proveedor, Total, Imagen)
                SumaTotal = SumaTotal + Convert.ToInt32(DataGridView1.Item(3, i).Value.ToString)
            Next
            txtTotal.Text = Format(SumaTotal, "###,##0")
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
                Dim RUC As String = TablaProv.Rows(IndiceVend - 1).Item(0)
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
                        Dim RUC As String = TablaProv.Rows(IndiceVend - 1).Item(0)
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
                        Dim RUC As String = TablaProv.Rows(IndiceVend - 1).Item(0)
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
        Dim id = CStr(TablaAux.Rows(Row).Item(0))
        Dim Total = CStr(TablaAux.Rows(Row).Item(4))
        Dim Fecha = Format(TablaAux.Rows(Row).Item(1), "dd/MM/yyyy")
        Dim Proveed = CStr(TablaAux.Rows(Row).Item(3))
        Reporte1.Encabezado(id, Fecha, Proveed, Total)
        Reporte1.CargarDetalle(Compra.BuscViewDetCompra(id))
    End Sub

    Private Sub ShowDetalle()
        Panel1.Visible = True
        DataGridView1.Visible = False
        GroupBox1.Enabled = False
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Panel1.Visible = False
        DataGridView1.Visible = True
        GroupBox1.Enabled = True
    End Sub

    Private Sub btnRegistrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegistrar.Click
        Dim idNota As Integer = Compra.CargarNroNota
        Dim idCompra As Integer = CInt(Reporte1.txtNro.Text)
        Dim fecha As String = Format(Now, "yyyy-MM-dd HH:mm:ss")
        Dim idProd As UInt64
        Dim Cant As Double
        Dim Unid As Integer
        Try
            If Compra.InserNota(idNota, idCompra, fecha) = False Then
                MessageBox.Show("Hubo un problema as guardar la Nota de Crédito")
                Exit Try
            End If
            For Each row As DataGridViewRow In Reporte1.Detalle.Rows
                idProd = Convert.ToUInt64(row.Cells(1).Value)
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

    Private Sub Reporte1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Reporte1.Load

    End Sub
End Class