Option Strict On
Option Explicit On
Public Class FListaVenta
    Dim Venta As New CVenta
    Dim Empleado As New CEmpleado
    Dim Producto As New CProducto
    Dim TablaEmple As New DataTable
    Dim TablaVenta As New DataTable
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

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        pnlReporte.Visible = False
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
        'Me.WindowState = FormWindowState.Minimized
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
                lblHasta.Text = "Hasta"
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
            txtTotal.Text = String.Format("{0:N0}", (SumaTotal))
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
        Encabezado(Id, fecha, Vendedor, Cliente, Total)
        If Not ModoNotaCredValue Then
            CargarDetalleOcup(Venta.BuscViewDetOcup(Id))
        End If
        CargarDetalle(Venta.BuscViewDetVenta(Id))
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
        lblTitulo.Text = "Seleccione una Venta de la Lista al cual desea aplicar la Nota de Crédito"
    End Sub

    Private Sub btnRegistrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegistrar.Click
        Dim IdNota As Integer = Venta.CargarNroNota
        Dim IdVenta As Integer = CInt(txtNro.Text)
        Dim Fecha As String = Format(Now, "yyyy-MM-dd HH:mm:ss")
        Dim IdProd As String
        Dim Cant As Double
        Dim Unid As Integer
        Try
            If Venta.InserNota(IdNota, IdVenta, Fecha) = False Then
                MessageBox.Show("Hubo un problema as guardar la Nota de Crédito")
                Exit Try
            End If
            For Each row As DataGridViewRow In Detalle.Rows
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
        Dim NroFac As String = txtNro.Text
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
        For Each dgvCol As DataGridViewColumn In Detalle.Columns
            col = New System.Data.DataColumn(dgvCol.Name)
            ds.Tables("GVData").Columns.Add(col)
        Next

        Dim row As System.Data.DataRow
        Dim colcount As Integer = Detalle.Columns.Count - 1
        For i As Integer = 0 To Detalle.Rows.Count - 1
            row = ds.Tables("GVData").Rows.Add
            For Each column As DataGridViewColumn In Detalle.Columns
                row.Item(column.Index) = Detalle.Rows.Item(CInt(i)).Cells(column.Index).Value
            Next
        Next
        Dim frm As New FImprimir(NroFac, Fecha, txtCliente.Text, Condicion, txtVend.Text,
                                CInt(txtTotal2.Text), ds.Tables("GVData"))
        frm.ShowDialog()

    End Sub

    Private Sub pbxImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbxImprimir.Click
        Imprimir()
    End Sub

    Private Sub BtnCerrarForm_Click(sender As Object, e As EventArgs) Handles BtnCerrarForm.Click
        Me.Close()
    End Sub

    '------------------------Reporte----------------------------------------------
    Public Sub Encabezado(ByVal NroVenta As String, ByVal Fecha As String, ByVal Vendedor As String, ByVal Cliente As String, ByVal Total As String)
        txtNro.Text = NroVenta
        txtFecha.Text = Fecha
        txtVend.Text = Vendedor
        txtCliente.Text = Cliente
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

    '---------------------------Eventos------------------------------

    Private Sub Detalle_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Detalle.CellClick
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