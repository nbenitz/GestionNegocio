Option Strict On
Option Explicit On

Public Class FSocioFicha
    Dim Membresia As New CMembresia
    Dim Venta As New CVenta
    Dim WithEvents FrmCuentasCobrar As New FCuentasCobrar
    Dim WithEvents FrmSocio As New FNuevoSocio
    Dim CuotaVencida As Boolean = False

    Sub New(ByVal CI As String,
            ByVal Nombre As String,
            ByVal Tel As String,
            ByVal Dir As String,
            ByVal Aliass As String,
            ByVal foto As Byte(),
            ByVal FechaNac As String,
            ByVal MembresiaNom As String,
            ByVal Vto As String,
            ByVal Acceso As String)
        InitializeComponent()
        lblCI.Text = CI
        lblNombre.Text = Nombre
        lblTelefono.Text = Tel
        lblDireccion.Text = Dir
        lblAlias.Text = Aliass
        If foto IsNot Nothing Then
            pbxFoto.Image = ByteArrayToImage(foto)
        End If
        lblFechaNac.Text = FechaNac
        lblMembresia.Text = MembresiaNom
        lblVencimiento.Text = Vto
        lblAcceso.Text = Acceso
    End Sub

    Private Sub BtnCerrarForm_Click(sender As Object, e As EventArgs) Handles BtnCerrarForm.Click
        Close()
    End Sub

    Private Sub FSocioFicha_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim CI As String = lblCI.Text
        Dim TablaMembresia As DataTable = Membresia.BuscarPagoPeriodo(CI)
        If TablaMembresia.Rows.Count > 0 Then
            Dim Vto As Date = CDate(TablaMembresia.Rows(0).Item(5))
            Dim Atraso As Integer = CInt(TablaMembresia.Rows(0).Item(9))
            GetClientStatus(CI)
        End If
    End Sub


    Private Sub GetClientStatus(ByVal CI As String)
        Dim TablaMembresia As DataTable = Membresia.BuscarPagoPeriodo(CI)
        If TablaMembresia.Rows.Count > 0 Then
            Dim NombreMembresia As String = CStr(TablaMembresia.Rows(0).Item(3))
            Dim Vto As Date = CDate(TablaMembresia.Rows(0).Item(5))
            Dim Atraso As Integer = CInt(TablaMembresia.Rows(0).Item(9))
            ShowClientStatus(Vto, Atraso, GetSaldoPendiente(CI))
        End If
    End Sub

    Function GetSaldoPendiente(ByVal CI As String) As Integer
        Dim TablaCuenta As DataTable = Venta.BuscViewCuentas("WHERE CI='" + CI + "'")
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

    Private Sub ShowClientStatus(ByVal Vencimiento As Date,
                                 ByVal Atraso As Integer,
                                 ByVal SaldoPendiente As Integer)

        lblVencimiento.Text = CStr(Vencimiento)
        lblAtraso.Text = CStr(Atraso)
        lblSaldo.Text = CStr(SaldoPendiente)

        If Date.Now.Date > Vencimiento Then
            CuotaVencida = True
            lblEstado.Text = "Cuota vencida"
            lblEstado.ForeColor = Color.White
            lblEstado.BackColor = Color.Red
        Else
            CuotaVencida = False
            lblEstado.Text = "Al día"
            lblEstado.ForeColor = Color.Lime
            lblEstado.BackColor = Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        End If

        If Atraso > 0 Then
            lblAtraso.Visible = True
            lblTituloAtraso.Visible = True
        Else
            lblAtraso.Visible = False
            lblTituloAtraso.Visible = False
        End If

        If SaldoPendiente > 0 Then
            lblSaldo.Visible = True
            lblTituloPendiente.Visible = True
            If Date.Now.Date > Vencimiento Then
                lblEstado.Text += " + Saldo Pend."
            Else
                lblEstado.Text = "Saldo Pendiente"
                lblEstado.ForeColor = Color.White
                lblEstado.BackColor = Color.Red
            End If
        Else
            lblSaldo.Visible = False
            lblTituloPendiente.Visible = False
        End If
    End Sub

    Private Sub lblEstado_Click(sender As Object, e As EventArgs) Handles lblEstado.Click
        Dim CI As String = lblCI.Text
        If lblEstado.Text = "Cuota vencida" Then
            FrmSocio.Pagar(CI, lblNombre.Text, lblMembresia.Text, CDate(lblVencimiento.Text))
            FrmSocio.ShowDialog()
        ElseIf lblEstado.Text <> "Al día" Then
            FrmCuentasCobrar.ModoPagarByCI(CI)
            FrmCuentasCobrar.ShowDialog()
        End If
    End Sub

    Private Sub onCuentasCobrar_Closed() Handles FrmCuentasCobrar.FormClosed, FrmSocio.FormClosed
        GetClientStatus(lblCI.Text)
    End Sub

    Private Sub btnSeguimiento_Click(sender As Object, e As EventArgs) Handles btnSeguimiento.Click
        Dim frm As New FSocioSeguimiento(lblCI.Text)
        frm.Show()
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        Dim Frm As New FNuevoSocio
        Frm.Editar(lblCI.Text,
                   lblNombre.Text,
                   lblTelefono.Text,
                   lblDireccion.Text,
                   lblAlias.Text,
                   ImageToByteArray(pbxFoto.Image),
                   CDate(lblFechaNac.Text),
                   lblMembresia.Text,
                   CDate(lblVencimiento.Text).AddMonths(-1),
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
        FrmSocio.Pagar(lblCI.Text, lblNombre.Text, lblMembresia.Text, CDate(lblVencimiento.Text))
        FrmSocio.ShowDialog()
    End Sub
End Class