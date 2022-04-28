Option Strict On
Option Explicit On

Public Class FSocioInfo
    Private Sub FSocioInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Public Sub ShowClientInfo(ByVal Aliass As String,
                              ByVal foto As Byte())

        lblNombre.Text = Aliass
        pbxFoto.Image = If(foto IsNot Nothing, ByteArrayToImage(foto), My.Resources.userblack)
        pnlSocioInfo.Visible = True
    End Sub

    Public Sub ShowClientStatus(ByVal Membresia As String,
                                ByVal Vencimiento As Date,
                                ByVal Atraso As Integer,
                                ByVal SaldoPendiente As Integer)

        lblMembresia.Text = Membresia
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

End Class