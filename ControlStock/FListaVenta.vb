Option Strict On

Public Class FListaVenta
    Dim Venta As New CVenta
    Dim Empleado As New CEmpleado
    Dim TablaEmple As New DataTable
    Dim TablaVenta As New DataTable
    Dim IndiceVend As Integer = 0
    Dim Imagen As Image
    Dim FormatoValue As Reporte.Tipo

    Sub New(ByVal Formato As Reporte.Tipo)
        InitializeComponent()
        Reporte1.Formato(Formato)
        FormatoValue = Formato
        Select Case Formato
            Case Is = Reporte.Tipo.Venta
                Imagen = My.Resources.Resources.view_text
                lblTitulo.Visible = False
            Case Is = Reporte.Tipo.NotaCredVenta
                btnRegistrar.Visible = True
                btnActualizar.Visible = True
                Imagen = My.Resources.Resources.apply1
        End Select
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Panel1.Visible = False
        For i As Integer = 0 To 9
            cmbAno.Items.Add(Now.Year - i)
        Next
        TablaEmple = Empleado.ListarEmple()
        cmbVendedor.Items.Clear()
        cmbVendedor.Items.Add("Todos")
        Dim Filas As Integer = TablaEmple.Rows.Count
        If Filas > 0 Then
            For i As Integer = 0 To (Filas - 1)
                cmbVendedor.Items.Add(CStr(TablaEmple.Rows(i).Item(1)) + " " + CStr(TablaEmple.Rows(i).Item(2)))
            Next
        End If
        cmbVendedor.SelectedIndex = 0
        cmbFiltrarPor.SelectedIndex = 0
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
        Cursor.Current = Cursors.WaitCursor
        Dim Indice As Integer = cmbFiltrarPor.SelectedIndex
        Select Case Indice
            Case Is = 0 'Dia
                txtNroFac.Visible = False
                dtpDesde.Visible = True
                dtpHasta.Visible = False
                lblBuscar.Visible = True
                lblBuscar.Text = "Día"
                lblHasta.Visible = False
                cmbMes.Visible = False
                cmbAno.Visible = False
                lblVendedor.Visible = False '' True
                cmbVendedor.Visible = False '' True
                dtpDesde.Value = Now
            'Case Is = 1 'Semana
            Case Is = 1 'Mes 2
                cmbMes.Visible = True
                cmbAno.Visible = True
                txtNroFac.Visible = False
                dtpDesde.Visible = False
                dtpHasta.Visible = False
                lblBuscar.Visible = True
                lblBuscar.Text = "Año"
                lblHasta.Visible = True
                lblHasta.Text = "Mes"
                lblVendedor.Visible = False '' True
                cmbVendedor.Visible = False '' True
                cmbAno.SelectedIndex = 0
                cmbMes.SelectedIndex = Now.Month - 1
            'Case Is = 3 'Año
            Case Is = 2 'Fecha 4
                txtNroFac.Visible = False
                dtpDesde.Visible = True
                dtpHasta.Visible = True
                lblBuscar.Visible = True
                lblBuscar.Text = "Desde"
                lblHasta.Visible = True
                cmbMes.Visible = False
                cmbAno.Visible = False
                lblVendedor.Visible = True
                cmbVendedor.Visible = True

                dtpDesde.Value = Now
                dtpHasta.Value = Now
            Case Is = 3 'Nro. Factura 5
                txtNroFac.Visible = True
                dtpDesde.Visible = False
                dtpHasta.Visible = False
                lblBuscar.Visible = True
                lblBuscar.Text = "Ingrese Nro. Factura"
                lblHasta.Visible = False
                cmbMes.Visible = False
                cmbAno.Visible = False
                IndiceVend = cmbVendedor.SelectedIndex
                lblVendedor.Visible = False
                cmbVendedor.Visible = False
            Case Is = 4 'Todos 6
                txtNroFac.Visible = False
                dtpDesde.Visible = False
                dtpHasta.Visible = False
                lblBuscar.Visible = False
                lblHasta.Visible = False
                txtNroFac.Visible = False
                cmbMes.Visible = False
                cmbAno.Visible = False
                lblVendedor.Visible = True
                cmbVendedor.Visible = True
                cmbVendedor.SelectedIndex = IndiceVend
                IndiceVend = cmbVendedor.SelectedIndex
                Select Case IndiceVend
                    Case Is = 0 'Todos
                        TablaVenta = Venta.BuscViewVenta("ORDER BY idVenta DESC")
                    Case Else 'Algun Vendedor
                        Dim CI As String = CStr(TablaEmple.Rows(IndiceVend - 1).Item(0))
                        Dim Vendedor As String = "(select concat(Nombre,' ',Apellido) from empleado where ci = " + CI + ")"
                        TablaVenta = Venta.BuscViewVenta("WHERE vendedor = " + Vendedor + "  ORDER BY idVenta DESC")
                End Select
                CargarTabla(TablaVenta)
        End Select
    End Sub

    Private Sub cmbFiltrarPor_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbFiltrarPor.Click
        cmbFiltrarPor.DroppedDown = True
    End Sub

    Private Sub cmbFiltrarPor_DropDownClosed(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbFiltrarPor.DropDownClosed
        Dim Indice As Integer = cmbFiltrarPor.SelectedIndex
        Select Case Indice
            Case Is = 3 'Nro Factura
                txtNroFac.Focus()
        End Select
    End Sub

    Private Sub CargarTabla(ByVal Tabla As DataTable)
        Dim Filas As Integer = Tabla.Rows.Count
        Dim SumaTotal As Integer = 0
        DataGridView1.Rows.Clear()
        If Filas > 0 Then
            For i As Integer = 0 To (Filas - 1)
                Dim idVenta As Integer = CInt(Tabla.Rows(i).Item(0))
                Dim Fecha As String = CStr(Tabla.Rows(i).Item(1))
                Dim Vendedor As String = CStr(Tabla.Rows(i).Item(3))
                Dim Cliente As String = CStr(Tabla.Rows(i).Item(4))
                Dim Total As Integer = 0
                Try
                    Total = CInt(Tabla.Rows(i).Item(5))
                Catch ex As Exception
                End Try
                DataGridView1.Rows.Add(idVenta, Fecha, Vendedor, Cliente, Total, Imagen)
                SumaTotal = SumaTotal + Convert.ToInt32(DataGridView1.Item(4, i).Value.ToString)
            Next
            txtTotal.Text = Format(SumaTotal, "###,##0")
        End If
    End Sub

    Private Sub txtNroFac_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtNroFac.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim NroFac As String = txtNroFac.Text
            If NroFac <> "" Then
                TablaVenta = Venta.BuscViewVenta("WHERE idVenta = " + NroFac)
                CargarTabla(TablaVenta)
            End If
        End If
    End Sub

    Private Sub dtpDesde_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpDesde.ValueChanged, dtpHasta.ValueChanged
        IndiceVend = cmbVendedor.SelectedIndex
        Dim Fecha1 As String = Format(dtpDesde.Value, "yyyy-MM-dd")
        Dim Fecha2 As String = Format(DateAdd(DateInterval.Day, 1, dtpDesde.Value), "yyyy-MM-dd")
        Select Case cmbFiltrarPor.SelectedIndex
            Case Is = 2 'Fecha
                Fecha2 = Format(DateAdd(DateInterval.Day, 1, dtpHasta.Value), "yyyy-MM-dd")
        End Select
        Select Case IndiceVend
            Case Is = 0 'Día
                TablaVenta = Venta.BuscViewVenta("WHERE Fecha > '" + Fecha1 + "' and Fecha < '" + Fecha2 + "' ORDER BY idVenta DESC")
            Case Else 'Algun Vendedor
                Dim CI As String = CStr(TablaEmple.Rows(IndiceVend - 1).Item(0))
                Dim Vendedor As String = "(select concat(Nombre,' ',Apellido) from empleado where ci = " + CI + ")"
                TablaVenta = Venta.BuscViewVenta("WHERE Fecha > '" + Fecha1 + "' and Fecha < '" + Fecha2 + "' AND vendedor = " + Vendedor + "  ORDER BY idVenta DESC")
        End Select
        CargarTabla(TablaVenta)
    End Sub

    Private Sub cmbVendedor_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbVendedor.SelectedIndexChanged
        Dim IndiceFiltrar As Integer = cmbFiltrarPor.SelectedIndex
        IndiceVend = cmbVendedor.SelectedIndex
        Select Case IndiceFiltrar
            Case Is = 4 'Todos
                Select Case IndiceVend
                    Case Is = 0 'Todos
                        TablaVenta = Venta.BuscViewVenta("ORDER BY idVenta DESC")
                    Case Else 'Algun Vendedor
                        Dim CI As String = CStr(TablaEmple.Rows(IndiceVend - 1).Item(0))
                        Dim Vendedor As String = "(select concat(Nombre,' ',Apellido) from empleado where ci = " + CI + ")"
                        TablaVenta = Venta.BuscViewVenta("WHERE vendedor = " + Vendedor + "  ORDER BY idVenta DESC")
                End Select
            Case Is = 2 'Fecha
                Dim Fecha1 As String = Format(dtpDesde.Value, "yyyy-MM-dd")
                Dim Fecha2 As String = Format(DateAdd(DateInterval.Day, 1, dtpHasta.Value), "yyyy-MM-dd")
                Select Case IndiceVend
                    Case Is = 0 'Todos
                        TablaVenta = Venta.BuscViewVenta("WHERE Fecha > '" + Fecha1 + "' and Fecha < '" + Fecha2 + "' ORDER BY idVenta DESC")
                    Case Else 'Algun Vendedor
                        Dim CI As String = CStr(TablaEmple.Rows(IndiceVend - 1).Item(0))
                        Dim Vendedor As String = "(select concat(Nombre,' ',Apellido) from empleado where ci = " + CI + ")"
                        TablaVenta = Venta.BuscViewVenta("WHERE Fecha > '" + Fecha1 + "' and Fecha < '" + Fecha2 + "' AND vendedor = " + Vendedor + "  ORDER BY idVenta DESC")
                End Select
        End Select
        CargarTabla(TablaVenta)
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Try
            If e.ColumnIndex = 5 Then
                Cursor.Current = Cursors.WaitCursor
                CargarDetalle(TablaVenta, e.RowIndex)
                ShowDetalle()
                lblTitulo.Text = "Productos a devolver"
            End If
        Catch
            MessageBox.Show("Error al Abrir la Nota de Crédito")
        End Try
    End Sub

    Private Sub CargarDetalle(ByVal TablaVenta As DataTable, ByVal Row As Integer)
        Dim Id As String = CStr(TablaVenta.Rows(Row).Item(0))
        Dim Total As String = CStr(TablaVenta.Rows(Row).Item(5))
        Dim fecha As String = Format(TablaVenta.Rows(Row).Item(1), "dd/MM/yyyy")
        Dim Vendedor As String = CStr(TablaVenta.Rows(Row).Item(3))
        Dim Cliente As String = CStr(TablaVenta.Rows(Row).Item(4))
        Reporte1.Encabezado(Id, fecha, Vendedor, Cliente, Total)
        If FormatoValue = Reporte.Tipo.Venta Then
            Reporte1.CargarDetalleOcup(Venta.BuscViewDetOcup(Id))
        End If
        Reporte1.CargarDetalle(Venta.BuscViewDetVenta(Id))
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
        lblTitulo.Text = "Seleccione una Venta de la Lista al cual desea aplicar la Nota de Crédito"
    End Sub

    Private Sub btnRegistrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegistrar.Click
        Dim IdNota As Integer = Venta.CargarNroNota
        Dim IdVenta As Integer = CInt(Reporte1.txtNro.Text)
        Dim Fecha As String = Format(Now, "yyyy-MM-dd HH:mm:ss")
        Dim IdProd As String
        Dim Cant As Double
        Dim Unid As Integer
        Try
            If Venta.InserNota(IdNota, IdVenta, Fecha) = False Then
                MessageBox.Show("Hubo un problema as guardar la Nota de Crédito")
                Exit Try
            End If
            For Each row As DataGridViewRow In Reporte1.Detalle.Rows
                IdProd = Convert.ToString(row.Cells(1).Value)
                Cant = Convert.ToDouble(row.Cells(3).Value)
                Unid = Convert.ToInt32(row.Cells(6).Value)
                If Venta.InserDetalleNota(IdNota, IdVenta, IdProd, Cant, Unid) = False Then
                    MessageBox.Show("Hubo un problema al guardar el Detalle la Nota de Crédito")
                    Exit Try
                End If
            Next
            MessageBox.Show("Nota de Crédito Registrada correctamente")
            btnSalir_Click(Nothing, Nothing)
        Catch
        End Try
    End Sub

    Private Sub btnActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActualizar.Click
        CargarDetalle(TablaVenta, DataGridView1.CurrentRow.Index)
        ShowDetalle()
    End Sub

    Private Sub txtNroFac_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNroFac.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            e.Handled = True
        End If
    End Sub

    Private Sub cmbAno_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbAno.SelectedIndexChanged
        cmbMes.Text = ""
    End Sub

    Private Sub cmbMes_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbMes.SelectedIndexChanged
        Dim Mes As Integer = cmbMes.SelectedIndex + 1
        Dim Anho As Integer = CInt(cmbAno.Text)
        ''Dim UltimoDia = New Date(Anho, Mes, 1).AddMonths(1)
        Dim Fecha1 As String = Format(New Date(Anho, Mes, 1), "yyyy-MM-dd")
        Dim Fecha2 As String = Format(New Date(Anho, Mes, 1).AddMonths(1), "yyyy-MM-dd")
        Select Case IndiceVend
            Case Is = 0 'Todos
                TablaVenta = Venta.BuscViewVenta("WHERE Fecha > '" + Fecha1 + "' and Fecha < '" + Fecha2 + "' ORDER BY idVenta DESC")
            Case Else 'Algun Vendedor
                Dim CI As String = CStr(TablaEmple.Rows(IndiceVend - 1).Item(0))
                Dim Vendedor As String = "(select concat(Nombre,' ',Apellido) from empleado where ci = " + CI + ")"
                TablaVenta = Venta.BuscViewVenta("WHERE Fecha > '" + Fecha1 + "' and Fecha < '" + Fecha2 + "' AND vendedor = " + Vendedor + "  ORDER BY idVenta DESC")
        End Select
        CargarTabla(TablaVenta)
    End Sub

    Private Sub Imprimir()
        Dim NroFac As String = Reporte1.txtNro.Text
        Dim Tabla As DataTable = Venta.BuscViewVenta("WHERE idVenta = " + NroFac)
        Dim Cancelado As String = CStr(Tabla.Rows(0).Item(6))
        Dim Fecha As DateTime = CDate(Tabla.Rows(0).Item(1))
        Dim Condicion As String
        If Cancelado = "Si" Then
            Condicion = "Contado"
        Else
            Condicion = "Credito"
        End If

        Dim ds As New DataSet
        ds.Tables.Add("GVData")

        Dim col As System.Data.DataColumn
        For Each dgvCol As DataGridViewColumn In Me.Reporte1.Detalle.Columns
            col = New System.Data.DataColumn(dgvCol.Name)
            ds.Tables("GVData").Columns.Add(col)
        Next

        Dim row As System.Data.DataRow
        Dim colcount As Integer = Me.Reporte1.Detalle.Columns.Count - 1
        For i = 0 To Me.Reporte1.Detalle.Rows.Count - 1
            row = ds.Tables("GVData").Rows.Add
            For Each column As DataGridViewColumn In Me.Reporte1.Detalle.Columns
                row.Item(column.Index) = Reporte1.Detalle.Rows.Item(CInt(i)).Cells(column.Index).Value
            Next
        Next
        Dim frm As New FImprimir(NroFac, Fecha, Reporte1.txtCliente.Text, Condicion, Reporte1.txtProvVend.Text, _
                                CInt(Reporte1.txtTotal.Text), ds.Tables("GVData"))
        frm.ShowDialog()

    End Sub

    Private Sub pbxImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbxImprimir.Click
        Imprimir()
    End Sub

End Class