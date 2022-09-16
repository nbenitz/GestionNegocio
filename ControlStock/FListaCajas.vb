Option Strict On
Option Explicit On
Public Class FListaCajas
    Dim Caja As New CCaja
    Dim TablaCaja As New DataTable
    Dim ModoVentaValue As Boolean
    Dim NumCaja As Integer = 1
    Dim CIValue As String
    Dim EmpleParam As String = Nothing
    Dim TablaSelIndex As Integer = -1

    'Private Sub DtpDesde_ValueChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles dtpDesde.ValueChanged
    'Dim Fecha As String = Format(dtpDesde.Value, "yyyy-MM-dd")
    'TablaCaja = Caja.BuscarView(Fecha)
    'CargarTabla(TablaCaja)
    'End Sub

    Private Sub CargarTabla(ByVal Tabla As DataTable)
        Dim Filas As Integer = Tabla.Rows.Count

        Dim TotalMontoCierre As Integer = 0
        Dim TotalDeclarado As Integer = 0
        Dim TotalFaltante As Integer = 0
        Dim TotalRetiro As Integer = 0
        Dim TotalDiferencia As Integer = 0

        DataGridView1.Rows.Clear()
        If Filas > 0 Then
            For i As Integer = 0 To (Filas - 1)
                Dim Empleado As String = CStr(Tabla.Rows(i).Item(0))
                Dim NroCaja As UInt16 = CUShort(Tabla.Rows(i).Item(1))
                Dim FechaIni As String = CDate(Tabla.Rows(i).Item(2)).ToString("dd MMM yyy HH:mm")
                Dim MontoIni As Integer = CInt(Tabla.Rows(i).Item(3))
                Dim FechaFin As String
                Dim MontoFin As Integer
                Dim IdCajaAnterior As Integer = CInt(Tabla.Rows(i).Item(6)) - 1
                Dim MontoDeclarado As Integer
                Dim Faltante As Integer = 0
                Dim Retiro As Integer
                Dim Restante As Integer
                Dim MontoRestanteAnterior As Integer? = Caja.MontoRestante(IdCajaAnterior, NroCaja)

                Dim Diferencia As Integer = 0
                If MontoRestanteAnterior.HasValue Then  'Si existe caja anterior (<> -1)
                    Diferencia = MontoIni - MontoRestanteAnterior.Value
                End If

                Try
                    FechaFin = CDate(Tabla.Rows(i).Item(4)).ToString("dd MMM yyy HH:mm")
                    MontoFin = CInt(Tabla.Rows(i).Item(5))
                    MontoDeclarado = CInt(Tabla.Rows(i).Item(7))
                    Faltante = CInt(Tabla.Rows(i).Item(8))
                    Retiro = CInt(Tabla.Rows(i).Item(9))
                    Restante = CInt(Tabla.Rows(i).Item(10))
                    DataGridView1.Rows.Add(False, Empleado, NroCaja, FechaIni, FechaFin, MontoIni, MontoFin, MontoDeclarado, Faltante, Retiro, Restante, Diferencia)

                    TotalMontoCierre += MontoFin
                    TotalDeclarado += MontoDeclarado
                    TotalFaltante += Faltante
                    TotalRetiro += Retiro
                    TotalDiferencia += Diferencia
                Catch
                    DataGridView1.Rows.Add(False, Empleado, NroCaja, FechaIni, "Abierto", MontoIni, "---", "---", "---", "---", "---", Diferencia)
                End Try
                If Faltante > 0 Or Diferencia < 0 Then
                    DataGridView1.Rows.Item(i).DefaultCellStyle.BackColor = Color.FromArgb(192, 0, 0)
                    DataGridView1.Rows.Item(i).DefaultCellStyle.SelectionBackColor = Color.FromArgb(192, 0, 0)
                    DataGridView1.Rows.Item(i).DefaultCellStyle.ForeColor = Color.LightGray
                    DataGridView1.Rows.Item(i).DefaultCellStyle.SelectionForeColor = Color.White
                Else
                    DataGridView1.Rows.Item(i).DefaultCellStyle.BackColor = Color.DarkGreen
                    DataGridView1.Rows.Item(i).DefaultCellStyle.SelectionBackColor = Color.DarkGreen
                    DataGridView1.Rows.Item(i).DefaultCellStyle.ForeColor = Color.LightGray
                    DataGridView1.Rows.Item(i).DefaultCellStyle.SelectionForeColor = Color.White
                End If
            Next

            txtTotalMontoCierre.Text = String.Format("{0:N0}", TotalMontoCierre)
            txtTotalMontoDeclarado.Text = String.Format("{0:N0}", TotalDeclarado)
            txtTotalFaltante.Text = String.Format("{0:N0}", TotalFaltante)
            txtTotalMontoRetiro.Text = String.Format("{0:N0}", TotalRetiro)
            txtTotalDiferencia.Text = String.Format("{0:N0}", TotalDiferencia)

            DataGridView1.Item(0, 0).Value = True
            TablaSelIndex = 0
        Else
            TablaSelIndex = -1
        End If
    End Sub

    Public Property CIEmpleado() As String
        Get
            CIEmpleado = CIValue
        End Get
        Set(ByVal value As String)
            CIValue = value
        End Set
    End Property


    Private Sub FListaCajas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'dtpDesde.Value = Today
        For i As Integer = 0 To 9
            cmbAno.Items.Add(Now.Year - i)
        Next
        cmbFiltrarPor.SelectedIndex = 0
    End Sub

    Private Sub BtnCerrarForm_Click(sender As Object, e As EventArgs) Handles BtnCerrarForm.Click
        Me.Close()
    End Sub

    Private Sub cmbFiltrarPor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbFiltrarPor.SelectedIndexChanged
        Cursor.Current = Cursors.WaitCursor
        Dim Indice As Integer = cmbFiltrarPor.SelectedIndex
        Select Case Indice
            Case Is = 0 'periodo_inicio
                txtNroFac.Visible = False
                dtpDesde.Visible = True
                dtpHasta.Visible = False
                LblBuscar.Visible = True
                LblBuscar.Text = "Día"
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
                LblBuscar.Visible = True
                LblBuscar.Text = "Año"
                lblHasta.Visible = True
                lblHasta.Text = "Mes"
                cmbAno.SelectedIndex = 0
                cmbMes.SelectedIndex = Now.Month - 1
            Case Is = 2 'Fecha
                txtNroFac.Visible = False
                dtpDesde.Visible = True
                dtpHasta.Visible = True
                LblBuscar.Visible = True
                LblBuscar.Text = "Desde"
                lblHasta.Visible = True
                lblHasta.Text = "Hasta"
                cmbMes.Visible = False
                cmbAno.Visible = False

                dtpDesde.Value = Now
                dtpHasta.Value = Now
            Case Is = 3 'Todos 6
                txtNroFac.Visible = False
                dtpDesde.Visible = False
                dtpHasta.Visible = False
                LblBuscar.Visible = False
                lblHasta.Visible = False
                cmbMes.Visible = False
                cmbAno.Visible = False
                VerTodos()
        End Select
    End Sub

    Private Sub cmbFiltrarPor_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbFiltrarPor.Click
        cmbFiltrarPor.DroppedDown = True
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
                Condicion = "WHERE DATE(FechaApertura) = '" + Fecha1 + "'"
            Case Is = 2, 1 'Fecha, Mes
                Condicion = "WHERE DATE(FechaApertura) >= '" + Fecha1 + "' and DATE(FechaApertura) <= '" + Fecha2 + "'"
        End Select

        If EmpleParam IsNot Nothing Then
            Condicion += " AND Empleado LIKE '%" + EmpleParam + "%'"
        End If

        TablaCaja = Caja.BuscarViewCaja(Condicion)
        CargarTabla(TablaCaja)

        'lblCantSocio.Text = CStr(acceso.CantSocioAsistencia(Condicion)) + " Socios"
    End Sub

    Private Sub cmbAno_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cmbAno.SelectedIndexChanged
        cmbMes.Text = ""
    End Sub

    Private Sub cmbMes_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cmbMes.SelectedIndexChanged
        Dim Mes As Integer = cmbMes.SelectedIndex + 1
        Dim Anho As Integer = CInt(cmbAno.Text)
        Dim Fecha1 As String = Format(New Date(Anho, Mes, 1), "yyyy-MM-dd")
        Dim Fecha2 As String = Format(New Date(Anho, Mes, 1).AddMonths(1), "yyyy-MM-dd")
        VerPorFecha(Fecha1, Fecha2)
    End Sub

    Private Sub VerTodos()
        Dim Condicion As String = ""
        If EmpleParam IsNot Nothing Then
            Condicion += " WHERE Empleado LIKE '%" + EmpleParam + "%'"
        End If
        TablaCaja = Caja.BuscarViewCaja(Condicion)
        CargarTabla(TablaCaja)
    End Sub

    Private Sub txtCI_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCI.KeyDown
        If e.KeyCode = Keys.Enter Then
            BuscarPorEmple()
        End If
    End Sub

    Private Sub BuscarPorEmple()
        EmpleParam = txtCI.Text
        If EmpleParam <> "" Then
            Select Case cmbFiltrarPor.SelectedIndex
                Case Is = 0, 2 'Dia, Fecha
                    dtpDesdeHasta_ValueChanged(Nothing, Nothing)
                Case Is = 1     'Mes
                    cmbMes_SelectedIndexChanged(Nothing, Nothing)
                Case Is = 3     'Todos
                    VerTodos()
            End Select
        End If
    End Sub

    Private Sub pbxDelCli_Click(sender As Object, e As EventArgs) Handles pbxDelCli.Click
        EmpleParam = Nothing
        txtCI.Text = ""
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim i As Integer = DataGridView1.CurrentRow.Index
        If TablaSelIndex >= 0 Then
            DataGridView1.Item(0, TablaSelIndex).Value = False
        End If
        DataGridView1.Item(0, i).Value = True
        TablaSelIndex = i
    End Sub

    Private Sub VerResumen_Click(sender As Object, e As EventArgs) Handles pbxResumen.Click, pnlResumen.Click, lblResumen.Click
        Cursor.Current = Cursors.WaitCursor
        If TablaSelIndex >= 0 Then
            If DataGridView1.Rows.Count > 0 Then
                Dim Frm As New FResumenCaja
                Frm.CIEmpleado = CIValue
                Dim row As Integer = DataGridView1.CurrentRow.Index
                Frm.Fecha = CDate(TablaCaja.Rows(row).Item(2))
                Frm.DesdeHistorial = True
                Frm.Show()
            Else
                MessageBox.Show("No hay cajas en la lista para visualizar el resumen")
            End If
        Else
            MessageBox.Show("Debe Seleccionar una opción de la Lista")
        End If
    End Sub

End Class