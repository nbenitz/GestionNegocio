Option Strict On
Option Explicit On

Public Class FAsistencia
    Dim Acceso As New CAcceso
    Dim Socio As New CCliente
    Dim FrmListaSocio As New FListaSocio
    Dim TablaAsis As DataTable
    Dim TablaCli As DataTable
    Dim CIValue As String = Nothing
    Dim FechasAusente As New List(Of Date)
    Dim ModoVistaValue As Boolean = True

    Private Sub FAsistencia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddHandler FrmListaSocio.ClienteSeleccionado, AddressOf onClinteSeleccionado
        FrmListaSocio.ModoVista()
        For i As Integer = 0 To 9
            cmbAno.Items.Add(Now.Year - i)
        Next
        cmbFiltrarPor.SelectedIndex = 0
    End Sub

    Private Function GetDias(ByVal fecha1 As Date, fecha2 As Date, ByVal CI As String) As List(Of Date)
        fecha2 = If(fecha2.Date > Now.Date, Now.Date.AddDays(1), fecha2)
        Dim DiferenciaDias As Long = DateDiff(DateInterval.Day, fecha1, fecha2)
        FechasAusente.Clear()
        For i As Long = 1 To DiferenciaDias
            Dim dia As String = fecha1.ToString("ddd")
            If dia <> "sáb." And dia <> "dom." Then
                If Not Acceso.CheckAsistencia(fecha1, CI) Then
                    FechasAusente.Add(fecha1)
                End If
            End If
            fecha1 = fecha1.AddDays(1)
        Next
        Return FechasAusente
    End Function

    Public Sub ModoVista(ByVal CI As String, ByVal Nombre As String)
        CIValue = CI
        pbxBuscCli.Visible = False
        pbxDelCli.Visible = False
        txtCI.Text = Nombre
    End Sub

    Private Sub onClinteSeleccionado(ByVal CI As String, ByVal Nombre As String)
        CIValue = CI
        txtCI.Text = Nombre
    End Sub

    Private Sub cmbFiltrarPor_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbFiltrarPor.SelectedIndexChanged
        Cursor.Current = Cursors.WaitCursor
        Dim Indice As Integer = cmbFiltrarPor.SelectedIndex
        Select Case Indice
            Case Is = 0 'Dia
                dtpDesde.Visible = True
                dtpHasta.Visible = False
                lblBuscar.Visible = True
                lblBuscar.Text = "Día"
                lblHasta.Visible = False
                cmbMes.Visible = False
                cmbAno.Visible = False
                dtpDesde.Value = Now
                dgvAusencia.Visible = False
            Case Is = 1 'Mes
                cmbMes.Visible = True
                cmbAno.Visible = True
                dtpDesde.Visible = False
                dtpHasta.Visible = False
                lblBuscar.Visible = True
                lblBuscar.Text = "Año"
                lblHasta.Visible = True
                lblHasta.Text = "Mes"
                cmbAno.SelectedIndex = 0
                cmbMes.SelectedIndex = Now.Month - 1
                dgvAusencia.Visible = False
                dgvAsistencia.Visible = True
            Case Is = 2, 3, 4 'Fecha, Ausencia, Sin Ausencia
                dtpDesde.Visible = True
                dtpHasta.Visible = True
                lblBuscar.Visible = True
                lblBuscar.Text = "Desde"
                lblHasta.Visible = True
                lblHasta.Text = "Hasta"
                cmbMes.Visible = False
                cmbAno.Visible = False
                dtpDesde.Value = Now
                'dtpHasta.Value = Now
        End Select
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

    Private Sub dtpDesde_ValueChanged(sender As Object, e As EventArgs) Handles dtpDesde.ValueChanged, dtpHasta.ValueChanged
        Dim Fecha1 As String = Format(dtpDesde.Value, "yyyy-MM-dd")
        Dim Fecha2 As String = Format(DateAdd(DateInterval.Day, 1, dtpDesde.Value), "yyyy-MM-dd")

        If cmbFiltrarPor.SelectedIndex = 2 Or
            cmbFiltrarPor.SelectedIndex = 3 Or
            cmbFiltrarPor.SelectedIndex = 4 Then
            Fecha2 = Format(DateAdd(DateInterval.Day, 1, dtpHasta.Value), "yyyy-MM-dd")
        End If

        If cmbFiltrarPor.SelectedIndex = 0 Or cmbFiltrarPor.SelectedIndex = 2 Then
            dgvAusencia.Visible = False
            dgvAsistencia.Visible = True
            VerPorFecha(Fecha1, Fecha2)
        ElseIf cmbFiltrarPor.SelectedIndex = 3 Or
            cmbFiltrarPor.SelectedIndex = 4 Then
            dgvAsistencia.Visible = False
            dgvAusencia.Visible = True
            VerAusencias(Fecha1, Fecha2)
        End If

    End Sub

    Private Sub VerPorFecha(ByVal Fecha1 As String, ByVal Fecha2 As String)
        Dim Condicion As String = "WHERE Fecha > '" + Fecha1 + "' and Fecha < '" + Fecha2 + "'"

        If CIValue IsNot Nothing Then
            Condicion += " AND cedula = '" + CIValue + "'"
            GetDias(CDate(Fecha1), CDate(Fecha2), CIValue)
        End If

        TablaAsis = Acceso.BuscarAsistencia(Condicion)
        CargarTabla(TablaAsis)

        lblCantSocio.Text = CStr(Acceso.CantSocioAsistencia(Condicion)) + " Socios"
    End Sub

    Private Sub VerAusencias(ByVal Fecha1 As String, ByVal Fecha2 As String)
        Dim Condicion As String = ""

        If CIValue IsNot Nothing Then
            Condicion += " WHERE cedula = '" + CIValue + "'"
        End If

        lblCantSocio.Visible = False
        lblTitCantSocios.Visible = False

        TablaCli = Socio.BuscSocio(Condicion)
        CargarTablaAusencia(TablaCli, Fecha1, Fecha2)

        lblCantSocio.Visible = False
        lblTitCantSocios.Visible = False
        'lblCantSocio.Text = CStr(Acceso.CantSocioAsistencia(Condicion)) + " Socios"
    End Sub

    Private Sub VerTodos()
        TablaAsis = Acceso.BuscarAsistencia("")
        CargarTabla(TablaAsis)
    End Sub

    Private Sub CargarTabla(ByVal Tabla As DataTable)
        Dim Filas As Integer = Tabla.Rows.Count
        dgvAsistencia.Rows.Clear()
        If Filas > 0 Then
            For i As Integer = 0 To (Filas - 1)
                Dim Fecha As Date = CDate(Tabla.Rows(i).Item(0))
                Dim CI As String = CStr(Tabla.Rows(i).Item(1))
                Dim Nombre As String = CStr(Tabla.Rows(i).Item(2))
                Dim Estado As String = CStr(Tabla.Rows(i).Item(3))
                'Dim Saldo As String = CStr(Tabla.Rows(i).Item(4))

                dgvAsistencia.Rows.Add(FormatDateTime(Fecha, DateFormat.ShortDate),
                                       Format(Fecha, "hh:mm:ss"),
                                       CI,
                                       Nombre,
                                       Estado)
            Next
        End If
    End Sub

    Private Sub CargarTablaAusencia(ByVal Tabla As DataTable, ByVal Fecha1 As String, ByVal Fecha2 As String)
        Dim Filas As Integer = Tabla.Rows.Count
        dgvAusencia.Rows.Clear()
        If Filas > 0 Then
            For i As Integer = 0 To (Filas - 1)
                Dim CI As String = CStr(Tabla.Rows(i).Item(0))
                Dim Nombre As String = CStr(Tabla.Rows(i).Item(1))
                Dim Ausencias As Integer = GetDias(CDate(Fecha1), CDate(Fecha2), CI).Count
                If cmbFiltrarPor.SelectedIndex = 3 Then 'Listar empleados y sus ausencias
                    dgvAusencia.Rows.Add(CI, Nombre, Ausencias, My.Resources.file_find, My.Resources.file_document)
                ElseIf cmbFiltrarPor.SelectedIndex = 4 Then 'Listar socios sin ausencias
                    If Ausencias = 0 Then
                        dgvAusencia.Rows.Add(CI, Nombre, Ausencias, My.Resources.file_find, My.Resources.file_document)
                    End If
                End If
            Next
        End If
    End Sub

    Private Sub BtnCerrarForm_Click(sender As Object, e As EventArgs) Handles BtnCerrarForm.Click
        Close()
    End Sub

    Private Sub pbxBuscCli_Click(sender As Object, e As EventArgs) Handles pbxBuscCli.Click
        FrmListaSocio.ShowDialog()
    End Sub

    Private Sub bpxDelCli_Click(sender As Object, e As EventArgs) Handles pbxDelCli.Click
        CIValue = Nothing
        txtCI.Text = ""
    End Sub

    Private Sub txtCI_TextChanged(sender As Object, e As EventArgs) Handles txtCI.TextChanged
        Dim Indice As Integer = cmbFiltrarPor.SelectedIndex
        Select Case Indice
            Case Is = 0, 2, 3 'Dia, Fecha
                dtpDesde_ValueChanged(Nothing, Nothing)
            Case Is = 1     'Mes
                cmbMes_SelectedIndexChanged(Nothing, Nothing)
        End Select
    End Sub

    Private Sub dgvAusencia_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvAusencia.CellContentClick
        Try
            If e.ColumnIndex = 4 Then
                Cursor.Current = Cursors.WaitCursor
                Dim CI As String = dgvAusencia.Item(0, e.RowIndex).Value.ToString()
                Dim Tabla As DataTable = Socio.BuscSocio("WHERE cedula = '" + CI + "'")
                Dim Nombre As String = CStr(Tabla.Rows(0).Item(1))
                Dim MembresiaNom As String
                Try
                    MembresiaNom = CStr(Tabla.Rows(0).Item(2))
                Catch
                    MembresiaNom = ""
                End Try
                Dim Telefono As String = CStr(Tabla.Rows(0).Item(3))
                Dim Aliass As String = CStr(Tabla.Rows(0).Item(5))
                Dim Direccion As String = CStr(Tabla.Rows(0).Item(6))
                Dim AccesoCod As String
                Try
                    AccesoCod = CStr(Tabla.Rows(0).Item(4))
                Catch
                    AccesoCod = ""
                End Try
                Dim Foto As Byte()
                Try
                    Foto = CType(Tabla.Rows(0).Item(9), Byte())
                Catch
                End Try
                Dim FechaNac As String = CStr(Tabla.Rows(0).Item(11))
                Dim Conocio As String = CStr(Tabla.Rows(0).Item(12))
                Dim Saldo As Integer = CInt(Tabla.Rows(0).Item(13))
                Dim Estado As String = CStr(Tabla.Rows(0).Item(14))
                Dim Frm As New FSocioFicha(CI, Nombre, Telefono, Direccion, Aliass, Foto, FechaNac, Conocio, AccesoCod, Saldo)
                Frm.ShowDialog()
            End If
        Catch
            MessageBox.Show("Error al Abrir la Ficha del Socio")
        End Try
    End Sub

End Class