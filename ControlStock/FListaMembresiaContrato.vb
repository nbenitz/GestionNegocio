Option Strict On
Option Explicit On
Public Class FListaMembresiaContrato
    Dim ContratoMembresia As New CMembresia
    Dim Empleado As New CEmpleado
    Dim Socio As New CCliente
    Dim oAcceso As New CAcceso
    Dim FrmListaSocio As New FListaSocio
    Dim TablaContratos As New DataTable
    Dim SocioParam As String = Nothing


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AddHandler FrmListaSocio.ClienteSeleccionado, AddressOf onClinteSeleccionado
        FrmListaSocio.ModoVista()
        For i As Integer = 0 To 9
            cmbAno.Items.Add(Now.Year - i)
        Next
        cmbFiltrarPor.SelectedIndex = 1
    End Sub

    Private Sub onClinteSeleccionado(ByVal CI As String, ByVal Nombre As String)
        SocioParam = CI
        txtCI.Text = Nombre
        BuscarPorSocio()
    End Sub

    Private Sub Form1_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        Dim strEstado As String = Me.WindowState.ToString()
        If strEstado = "Maximized" Then
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub cmbFiltrarPor_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbFiltrarPor.SelectedIndexChanged
        Cursor.Current = Cursors.WaitCursor
        Dim Indice As Integer = cmbFiltrarPor.SelectedIndex
        Select Case Indice
            Case Is = 0 'periodo_inicio
                txtNroFac.Visible = False
                dtpDesde.Visible = True
                dtpHasta.Visible = False
                lblBuscar.Visible = True
                lblBuscar.Text = "Día"
                lblHasta.Visible = False
                cmbMes.Visible = False
                cmbAno.Visible = False
                dtpDesde.Value = Now
            Case Is = 1 'Mes
                cmbMes.Visible = True
                cmbAno.Visible = True
                txtNroFac.Visible = False
                dtpDesde.Visible = False
                dtpHasta.Visible = False
                lblBuscar.Visible = True
                lblBuscar.Text = "Año"
                lblHasta.Visible = True
                lblHasta.Text = "Mes"
                cmbAno.SelectedIndex = 0
                cmbMes.SelectedIndex = Now.Month - 1
            Case Is = 2 'Fecha
                txtNroFac.Visible = False
                dtpDesde.Visible = True
                dtpHasta.Visible = True
                lblBuscar.Visible = True
                lblBuscar.Text = "Desde"
                lblHasta.Visible = True
                lblHasta.Text = "Hasta"
                cmbMes.Visible = False
                cmbAno.Visible = False

                dtpDesde.Value = Now
                dtpHasta.Value = Now
            Case Is = 3 'Nro. Contrato
                txtNroFac.Visible = True
                dtpDesde.Visible = False
                dtpHasta.Visible = False
                lblBuscar.Visible = True
                lblBuscar.Text = "Ingrese Nro. Contrato"
                lblHasta.Visible = False
                cmbMes.Visible = False
                cmbAno.Visible = False
            Case Is = 4 'Todos 6
                txtNroFac.Visible = False
                dtpDesde.Visible = False
                dtpHasta.Visible = False
                lblBuscar.Visible = False
                lblHasta.Visible = False
                cmbMes.Visible = False
                cmbAno.Visible = False
                VerTodos()
        End Select
    End Sub

    Private Sub cmbFiltrarPor_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbFiltrarPor.Click
        cmbFiltrarPor.DroppedDown = True
    End Sub

    Private Sub cmbFiltrarPor_DropDownClosed(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbFiltrarPor.DropDownClosed
        Dim Indice As Integer = cmbFiltrarPor.SelectedIndex
        Select Case Indice
            Case Is = 3 'Nro Contrato
                txtNroFac.Focus()
        End Select
    End Sub

    Private Sub CargarTabla(ByVal Tabla As DataTable)
        Cursor.Current = Cursors.WaitCursor
        Dim Filas As Integer = Tabla.Rows.Count
        Dim TotalCostoMembresia As Integer = 0
        Dim TotalDescuento As Integer = 0
        Dim TotalTotalPagado As Integer = 0
        Dim TotalSaldoPendiente As Integer = 0
        Dim CantAtraso As Integer = 0
        dgvMembresia.Rows.Clear()
        If Filas > 0 Then
            For i As Integer = 0 To (Filas - 1)
                Dim idContrato As Integer = CInt(Tabla.Rows(i).Item(0))
                Dim CI As String = CStr(Tabla.Rows(i).Item(2))
                Dim NombreCliente As String = CStr(Tabla.Rows(i).Item(1))
                Dim NombreMembresia As String = CStr(Tabla.Rows(i).Item(3))
                Dim PeriodoInicio As String = CDate(Tabla.Rows(i).Item(4)).ToString("dd MMM - ")
                Dim Periodofin As String = CDate(Tabla.Rows(i).Item(5)).ToString("dd MMM yyy")
                Dim Periodo As String = PeriodoInicio + Periodofin
                Dim CostoMembresia As Integer = CInt(Tabla.Rows(i).Item(6))
                Dim Descuento As Integer = CInt(Tabla.Rows(i).Item(7))
                Dim TotalPagado As Integer = CInt(Tabla.Rows(i).Item(8))
                Dim SaldoPendiente As Integer = CInt(Tabla.Rows(i).Item(9))
                Dim Atraso As Integer = CInt(Tabla.Rows(i).Item(10))

                Dim TablaTolerancia As DataTable = oAcceso.VerAjustes
                Dim DiasTolerancia As Integer = CInt(TablaTolerancia.Rows(0).Item(1))
                If Atraso < 1 Then
                    Atraso = 0
                Else
                    CantAtraso += 1
                End If
                Dim AtrasoLabel As String = CStr(Atraso)
                If Atraso > DiasTolerancia Then
                    AtrasoLabel = "Vencido"
                End If

                dgvMembresia.Rows.Add(idContrato,
                                       CI,
                                       NombreCliente,
                                       NombreMembresia,
                                       Periodo,
                                       String.Format("{0:N0}", CostoMembresia),
                                       String.Format("{0:N0}", Descuento),
                                       String.Format("{0:N0}", TotalPagado),
                                       String.Format("{0:N0}", SaldoPendiente),
                                       AtrasoLabel)
                TotalCostoMembresia += CostoMembresia
                TotalDescuento += Descuento
                TotalTotalPagado += TotalPagado
                TotalSaldoPendiente += SaldoPendiente

                If AtrasoLabel = "Vencido" Then
                    dgvMembresia.Rows.Item(i).DefaultCellStyle.BackColor = Color.FromArgb(192, 0, 0)
                    dgvMembresia.Rows.Item(i).DefaultCellStyle.SelectionBackColor = Color.FromArgb(192, 0, 0)
                    dgvMembresia.Rows.Item(i).DefaultCellStyle.ForeColor = Color.LightGray
                    dgvMembresia.Rows.Item(i).DefaultCellStyle.SelectionForeColor = Color.White
                ElseIf Atraso = 0 Then
                    dgvMembresia.Rows.Item(i).DefaultCellStyle.BackColor = Color.DarkGreen
                    dgvMembresia.Rows.Item(i).DefaultCellStyle.SelectionBackColor = Color.DarkGreen
                    dgvMembresia.Rows.Item(i).DefaultCellStyle.ForeColor = Color.LightGray
                    dgvMembresia.Rows.Item(i).DefaultCellStyle.SelectionForeColor = Color.White
                Else
                    dgvMembresia.Rows.Item(i).DefaultCellStyle.BackColor = Color.FromArgb(255, 128, 0)
                    dgvMembresia.Rows.Item(i).DefaultCellStyle.SelectionBackColor = Color.FromArgb(255, 128, 0)
                    dgvMembresia.Rows.Item(i).DefaultCellStyle.ForeColor = Color.LightGray
                    dgvMembresia.Rows.Item(i).DefaultCellStyle.SelectionForeColor = Color.White
                End If

            Next

            txtTotalCostoMembresia.Text = String.Format("{0:N0}", TotalCostoMembresia)
            txtTotalDescuento.Text = String.Format("{0:N0}", TotalDescuento)
            txtTotalPagado.Text = String.Format("{0:N0}", TotalTotalPagado)
            txtTotalSaldo.Text = String.Format("{0:N0}", TotalSaldoPendiente)
            txtCantAtraso.Text = CStr(CantAtraso) + " socios"
        End If
    End Sub

    Private Sub dgvMembresia_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgvMembresia.CellMouseDoubleClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            Dim selectedRow As DataGridViewRow = dgvMembresia.Rows(e.RowIndex)
            Dim CI As String = selectedRow.Cells(1).Value.ToString
            Dim TablaCli As DataTable = Socio.BuscSocio("WHERE Cedula = '" + CI + "'")

            Dim Nombre As String = CStr(TablaCli.Rows(0).Item(1))
            Dim MembresiaNom As String
            Try
                MembresiaNom = CStr(TablaCli.Rows(0).Item(2))
            Catch
                MembresiaNom = ""
            End Try
            Dim Telefono As String = CStr(TablaCli.Rows(0).Item(3))
            Dim Aliass As String = CStr(TablaCli.Rows(0).Item(5))
            Dim Direccion As String = CStr(TablaCli.Rows(0).Item(6))
            Dim AccesoCod As String
            Try
                AccesoCod = CStr(TablaCli.Rows(0).Item(4))
            Catch
                AccesoCod = ""
            End Try
            Dim Foto As Byte()
            Try
                Foto = CType(TablaCli.Rows(0).Item(9), Byte())
            Catch
            End Try
            Dim FechaNac As String = CStr(TablaCli.Rows(0).Item(11))
            Dim Conocio As String = CStr(TablaCli.Rows(0).Item(12))
            Dim Saldo As Integer = CInt(TablaCli.Rows(0).Item(13))
            Dim Estado As String = CStr(TablaCli.Rows(0).Item(14))
            Dim Frm As New FSocioFicha(CI, Nombre, Telefono, Direccion, Aliass, Foto, FechaNac, Conocio, AccesoCod, Saldo)
            Frm.ShowDialog()
        End If
    End Sub

    Private Sub txtNroFac_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtNroFac.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim NroFac As String = txtNroFac.Text
            If NroFac <> "" Then
                TablaContratos = ContratoMembresia.BuscViewMembresia("WHERE idContrato = " + NroFac)
                CargarTabla(TablaContratos)
            End If
        End If
    End Sub

    Private Sub dtpDesdeHasta_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpDesde.ValueChanged, dtpHasta.ValueChanged
        Dim Fecha1 As String = Format(dtpDesde.Value, "yyyy-MM-dd")
        Dim Fecha2 As String = Format(dtpHasta.Value, "yyyy-MM-dd")
        VerPorFecha(Fecha1, Fecha2)

    End Sub

    Private Sub VerPorFecha(ByVal Fecha1 As String, ByVal Fecha2 As String)
        Dim Condicion As String
        Select Case cmbFiltrarPor.SelectedIndex
            Case Is = 0 'Dia
                Condicion = "WHERE periodo_inicio = '" + Fecha1 + "'"
            Case Is = 2, 1 'Fecha, Mes
                Condicion = "WHERE periodo_inicio >= '" + Fecha1 + "' and periodo_inicio <= '" + Fecha2 + "'"
        End Select

        If SocioParam IsNot Nothing Then
            Condicion += " AND (CI LIKE '%" + SocioParam + "%' OR NombreCliente LIKE '%" + SocioParam + "%')"
        End If

        TablaContratos = ContratoMembresia.BuscViewMembresia(Condicion)
        CargarTabla(TablaContratos)

        'lblCantSocio.Text = CStr(acceso.CantSocioAsistencia(Condicion)) + " Socios"
    End Sub

    Private Sub VerTodos()
        Dim Condicion As String = ""
        If SocioParam IsNot Nothing Then
            Condicion += " WHERE CI LIKE '%" + SocioParam + "%' OR NombreCliente LIKE '%" + SocioParam + "%'"
        End If
        TablaContratos = ContratoMembresia.BuscViewMembresia(Condicion)
        CargarTabla(TablaContratos)
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvMembresia.CellContentClick
        Try
            If e.ColumnIndex = 5 Then
                Cursor.Current = Cursors.WaitCursor

            End If
        Catch
            MessageBox.Show("Error")
        End Try
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
        Dim Fecha1 As String = Format(New Date(Anho, Mes, 1), "yyyy-MM-dd")
        Dim Fecha2 As String = Format(New Date(Anho, Mes, 1).AddMonths(1), "yyyy-MM-dd")
        VerPorFecha(Fecha1, Fecha2)
    End Sub

    Private Sub Imprimir()

    End Sub

    Private Sub pbxImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Imprimir()
    End Sub

    Private Sub BtnCerrarForm_Click(sender As Object, e As EventArgs) Handles BtnCerrarForm.Click
        Me.Close()
    End Sub

    Private Sub pbxBuscCli_Click(sender As Object, e As EventArgs) Handles pbxBuscCli.Click
        FrmListaSocio.ShowDialog()
    End Sub

    Private Sub pbxDelCli_Click(sender As Object, e As EventArgs) Handles pbxDelCli.Click
        SocioParam = Nothing
        txtCI.Text = ""
    End Sub

    Public Sub ModoVista(ByVal CI As String, ByVal Nombre As String)
        SocioParam = CI
        pbxBuscCli.Visible = False
        pbxDelCli.Visible = False
        txtCI.Text = Nombre
    End Sub

    Private Sub txtCI_TextChanged(sender As Object, e As EventArgs) Handles txtCI.TextChanged
        'Select Case cmbFiltrarPor.SelectedIndex
        'Case Is = 0, 2 'Dia, Fecha
        'dtpDesdeHasta_ValueChanged(Nothing, Nothing)
        'Case Is = 1     'Mes
        'cmbMes_SelectedIndexChanged(Nothing, Nothing)
        'Case Is = 4     'Todos
        'VerTodos()
        'End Select
    End Sub

    Private Sub txtCI_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCI.KeyDown
        If e.KeyCode = Keys.Enter Then
            BuscarPorSocio()
        End If
    End Sub

    Private Sub BuscarPorSocio()
        SocioParam = txtCI.Text
        If SocioParam <> "" Then
            Select Case cmbFiltrarPor.SelectedIndex
                Case Is = 0, 2 'Dia, Fecha
                    dtpDesdeHasta_ValueChanged(Nothing, Nothing)
                Case Is = 1     'Mes
                    cmbMes_SelectedIndexChanged(Nothing, Nothing)
                Case Is = 4     'Todos
                    VerTodos()
            End Select
        End If
    End Sub
End Class