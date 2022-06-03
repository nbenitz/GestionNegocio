Option Strict On
Option Explicit On

Public Class FSocioFicha
    Dim oMembresia As New CMembresia
    Dim Venta As New CVenta
    Dim WithEvents FrmCuentasCobrar As New FCuentasCobrar
    Dim TablaContratos As DataTable
    Dim CuotaVencida As Boolean = False
    Dim TablaSelIndex As Integer = -1

    Sub New(ByVal CI As String,
            ByVal Nombre As String,
            ByVal Tel As String,
            ByVal Dir As String,
            ByVal Aliass As String,
            ByVal foto As Byte(),
            ByVal FechaNac As String,
            ByVal Conocio As String,
            ByVal Acceso As String,
            ByVal Saldo As Integer)
        InitializeComponent()
        lblCI.Text = CI
        lblNombre.Text = Nombre
        lblTelefono.Text = Tel
        lblDireccion.Text = Dir
        lblAlias.Text = Aliass
        lblConocio.Text = Conocio
        If foto IsNot Nothing Then
            pbxFoto.Image = ByteArrayToImage(foto)
        End If
        lblFechaNac.Text = FechaNac
        lblAcceso.Text = Acceso
        SetSaldo(Saldo)
    End Sub

    Private Sub SetSaldo(Saldo As Integer)
        lblSaldoPendiente.Text = String.Format("{0:N0}", Saldo)
        If Saldo > 0 Then
            lblSaldoPendiente.BackColor = Color.Red
        End If
    End Sub

    Private Sub BtnCerrarForm_Click(sender As Object, e As EventArgs) Handles BtnCerrarForm.Click
        Close()
    End Sub

    Private Sub FSocioFicha_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarMembresias()
    End Sub

    Private Sub CargarMembresias()
        Dim CI As String = lblCI.Text
        TablaContratos = oMembresia.BuscarViewClienteMembresia(CI)
        CargarTabla(TablaContratos)
    End Sub

    Private Sub CargarTabla(ByVal Tabla As DataTable)
        Cursor.Current = Cursors.WaitCursor
        Dim Filas As Integer = Tabla.Rows.Count
        dgvMembresias.Rows.Clear()
        If Filas > 0 Then
            For i As Integer = 0 To (Filas - 1)
                Dim NombreMembresia As String = CStr(Tabla.Rows(i).Item(3))
                Dim PeriodoInicio As String = CDate(Tabla.Rows(i).Item(4)).ToString("dd MMM")
                Dim Periodofin As String = CDate(Tabla.Rows(i).Item(5)).ToString("dd MMM yyy")
                Dim CostoMembresia As Integer = CInt(Tabla.Rows(i).Item(6))
                Dim TotalPagado As Integer = CInt(Tabla.Rows(i).Item(8))
                Dim SaldoPendiente As Integer = CInt(Tabla.Rows(i).Item(9))
                Dim Atraso As Integer = CInt(Tabla.Rows(i).Item(10))
                If Atraso < 1 Then
                    Atraso = 0
                End If

                dgvMembresias.Rows.Add(False,
                                       NombreMembresia,
                                       PeriodoInicio,
                                       Periodofin,
                                       String.Format("{0:N0}", CostoMembresia),
                                       String.Format("{0:N0}", TotalPagado),
                                       String.Format("{0:N0}", SaldoPendiente),
                                       Atraso)

                If CDate(Periodofin) < Now Then
                    dgvMembresias.Rows.Item(i).DefaultCellStyle.BackColor = Color.FromArgb(192, 0, 0)
                    dgvMembresias.Rows.Item(i).DefaultCellStyle.SelectionBackColor = Color.FromArgb(192, 0, 0)
                    dgvMembresias.Rows.Item(i).DefaultCellStyle.ForeColor = Color.LightGray
                    dgvMembresias.Rows.Item(i).DefaultCellStyle.SelectionForeColor = Color.White
                Else
                    dgvMembresias.Rows.Item(i).DefaultCellStyle.BackColor = Color.DarkGreen
                    dgvMembresias.Rows.Item(i).DefaultCellStyle.SelectionBackColor = Color.DarkGreen
                    dgvMembresias.Rows.Item(i).DefaultCellStyle.ForeColor = Color.LightGray
                    dgvMembresias.Rows.Item(i).DefaultCellStyle.SelectionForeColor = Color.White
                End If
            Next
            dgvMembresias.Item(0, 0).Value = True
            TablaSelIndex = 0
        Else
            TablaSelIndex = -1
        End If


    End Sub

    'Private Sub GetClientStatus(ByVal CI As String)
    'Dim TablaMembresia As DataTable = Membresia.BuscarViewClienteMembresia(CI)
    'Dim Count As Integer = TablaMembresia.Rows.Count
    'If Count > 0 Then
    'Dim NombreMembresia As String = CStr(TablaMembresia.Rows(Count - 1).Item(3))
    'Dim Vto As Date = CDate(TablaMembresia.Rows(Count - 1).Item(5))
    'Dim Atraso As Integer = CInt(TablaMembresia.Rows(Count - 1).Item(10))
    'End If
    'End Sub

    Function GetSaldoPendiente() As Integer
        Dim TablaCuenta As DataTable = Venta.BuscViewCuentas("WHERE CI='" + lblCI.Text + "'")
        Dim SaldoPendiente As Integer = 0
        If TablaCuenta.Rows.Count > 0 Then
            For i As Integer = 0 To (TablaCuenta.Rows.Count - 1)
                Dim Total As Integer = CInt(TablaCuenta.Rows(i).Item(6))
                Dim Entregado As Integer = CInt(TablaCuenta.Rows(i).Item(7))
                SaldoPendiente += CInt(Total) - CInt(Entregado)
            Next
        End If
        Return SaldoPendiente
    End Function

    Private Sub onCuentasCobrar_Closed() Handles FrmCuentasCobrar.FormClosed
        Cursor.Current = Cursors.WaitCursor
        CargarMembresias()
        SetSaldo(GetSaldoPendiente())
    End Sub

    Private Sub btnSeguimiento_Click(sender As Object, e As EventArgs) Handles btnSeguimiento.Click
        Dim frm As New FSocioSeguimiento(lblCI.Text)
        frm.Show()
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        Cursor.Current = Cursors.WaitCursor
        Dim Frm As New FNuevoSocio
        Frm.Editar(lblCI.Text,
                   lblNombre.Text,
                   lblTelefono.Text,
                   lblDireccion.Text,
                   lblAlias.Text,
                   ImageToByteArray(pbxFoto.Image),
                   CDate(lblFechaNac.Text),
                   lblConocio.Text,
                   lblAcceso.Text)
        Frm.ShowDialog()
    End Sub

    Private Sub btnAsistencia_Click(sender As Object, e As EventArgs) Handles btnAsistencia.Click
        Dim FrmAsistencia As New FAsistencia
        FrmAsistencia.ModoVista(lblCI.Text, lblNombre.Text)
        FrmAsistencia.Show()
    End Sub

    Private Sub BtnCuentas_Click(sender As Object, e As EventArgs) Handles BtnCuentas.Click
        FrmCuentasCobrar.ModoPagarByCI(lblCI.Text)
        FrmCuentasCobrar.ShowDialog()
    End Sub

    Private Sub btnCobrar_Click(sender As Object, e As EventArgs) Handles btnCobrar.Click
        Dim MembresiaNom As String = ""
        Dim Vto As Date = Now
        If dgvMembresias.Rows.Count > 0 Then
            MembresiaNom = CStr(dgvMembresias.Item(1, 0).Value)
            Vto = CDate(dgvMembresias.Item(3, 0).Value)
        End If
        Dim FrmSocio As New FNuevoSocio
        FrmSocio.Pagar(lblCI.Text, lblNombre.Text, MembresiaNom, Vto)
        FrmSocio.ShowDialog()
        CargarMembresias()
        SetSaldo(GetSaldoPendiente())
    End Sub

    Private Sub dgvMembresias_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvMembresias.CellClick
        Dim i As Integer = dgvMembresias.CurrentRow.Index
        If TablaSelIndex >= 0 Then
            dgvMembresias.Item(0, TablaSelIndex).Value = False
        End If
        dgvMembresias.Item(0, i).Value = True
        TablaSelIndex = i
    End Sub

    Private Sub pbxEditar_Click(sender As Object, e As EventArgs) Handles pbxEditar.Click, pnlEditar.Click, lblEditar.Click
        Cursor.Current = Cursors.WaitCursor
        If TablaSelIndex >= 0 Then
            Dim MembresiaNom As String = CStr(dgvMembresias.Item(1, TablaSelIndex).Value)
            Dim FechaInicio As Date = CDate(dgvMembresias.Item(2, TablaSelIndex).Value)
            Dim FrmSocio As New FNuevoSocio
            FrmSocio.EditarMembresia(lblCI.Text, lblNombre.Text, MembresiaNom, FechaInicio)
            FrmSocio.ShowDialog()
            CargarMembresias()
            SetSaldo(GetSaldoPendiente())
        Else
            MessageBox.Show("Debe Seleccionar una Membresía de la Lista")
        End If
    End Sub

    Private Sub LblEliminar_Click(sender As Object, e As EventArgs) Handles LblEliminar.Click, PbxEliminar.Click, PnlEliminar.Click

        If TablaSelIndex >= 0 Then
            Dim Result As Integer = MsgBox("Desea eliminar la membresía seleccionada?", MsgBoxStyle.YesNo, "Eliminar Socio")
            If Result = 6 Then
                Dim IdContrato As String = CStr(TablaContratos.Rows(TablaSelIndex).Item(0))
                If oMembresia.EliminarClienteMembresiaByID(IdContrato) = False Then
                    MessageBox.Show("Hubo un problema al eliminar la Membresía del Socio")
                    Exit Sub
                End If
                CargarMembresias()
                SetSaldo(GetSaldoPendiente())
            End If
        Else
            MessageBox.Show("Debe Seleccionar una Membresía de la Lista")
        End If
    End Sub

    Private Sub lblSaldoPendiente_Click(sender As Object, e As EventArgs) Handles lblSaldoPendiente.Click
        If CInt(lblSaldoPendiente.Text) > 0 Then
            FrmCuentasCobrar.ModoPagarByCI(lblCI.Text)
            FrmCuentasCobrar.ShowDialog()
        End If
    End Sub

End Class