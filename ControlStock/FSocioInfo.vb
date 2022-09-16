Option Strict On
Option Explicit On

Public Class FSocioInfo
    Delegate Sub MostrarSocioInfoCallBack()
    Private Sub FSocioInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Public Sub MostrarSocioInfo()
        If Me.pnlInfo.InvokeRequired Then
            Dim d As New MostrarSocioInfoCallBack(AddressOf MostrarSocioInfo)
            Me.Invoke(d, New Object() {})
        Else
            pbxLogo.Height = 356
            pnlInfo.Visible = True
            tmrOcultar.Start()
        End If
    End Sub

    Public Sub ShowClientInfo(ByVal Aliass As String,
                              ByVal foto As Byte())

        'lblNombre.Text = Aliass
        lblNombre.Text = If(Aliass.Length <= 22, Aliass, Aliass.Substring(0, 22) + "...")
        pbxFoto.Image = If(foto IsNot Nothing, ByteArrayToImage(foto), My.Resources.userblack)
        MostrarSocioInfo()
    End Sub

    Public Sub ShowClientStatus(ByVal Membresia As String,
                                ByVal Vencimiento As Date,
                                ByVal Atraso As Integer,
                                ByVal SaldoPendiente As Integer)

        'lblMembresia.Text = Membresia
        lblMembresia.Text = If(Membresia.Length <= 22, Membresia, Membresia.Substring(0, 22) + "...")
        lblVencimiento.Text = CStr(Vencimiento)
        lblAtraso.Text = CStr(Atraso)
        lblSaldo.Text = CStr(SaldoPendiente)

        If Date.Now.Date > Vencimiento Then
            lblEstado.Text = "Cuota vencida"
            lblEstado.ForeColor = Color.White
            lblEstado.BackColor = Color.Red
        Else
            lblEstado.Text = "Al día"
            lblEstado.ForeColor = Color.Lime
            lblEstado.BackColor = Color.Black
        End If

        If Atraso > 0 Then
            lblTituloAtraso.Text = "Días atraso"
            lblAtraso.Text = CStr(Atraso)
            lblAtraso.ForeColor = Color.Yellow
            'lblAtraso.Visible = True
            'lblTituloAtraso.Visible = True
        Else
            'lblAtraso.Visible = False
            'lblTituloAtraso.Visible = False
            lblTituloAtraso.Text = "Días restantes"
            lblAtraso.Text = CStr(Atraso * -1)
            lblAtraso.ForeColor = Color.White
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

    Private Sub tmrOcultar_Tick(sender As Object, e As EventArgs) Handles tmrOcultar.Tick
        pnlInfo.Visible = False
        pbxLogo.Height = Me.Height
        tmrOcultar.Stop()
    End Sub

End Class