Option Strict On

Public Class FAjustesTiempo
    Dim Habitacion As New CHabitacion

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Dim Descrip1 As String = TxtDescrip1.Text
        Dim Descrip2 As String = TxtDescrip2.Text
        Dim Descrip3 As String = TxtDescrip3.Text
        Dim HraEntrada As TimeSpan = TimeSpan.Parse(DtpHraE.Text)
        Dim HraSalida As TimeSpan = TimeSpan.Parse(DtpHraS.Text)
        Dim Tiempo1 As Integer
        Dim Tiempo2 As Integer
        If TxtDescrip1.Text <> "" Then
            If TxtDescrip2.Text <> "" Then
                If TxtDescrip3.Text <> "" Then
                    If TxtTiempo1.Text <> "" Then
                        If TxtTiempo2.Text <> "" Then
                            '-----------------------------------------------------------------
                            Tiempo1 = CInt(TxtTiempo1.Text)
                            Tiempo2 = CInt(TxtTiempo2.Text)
                            If Habitacion.AjustesTiempo(Descrip1, Descrip2, Descrip3, Tiempo1, Tiempo2, HraEntrada, HraSalida) = True Then
                                MessageBox.Show("Los ajustes se guardaron correctamente")
                                Me.Close()
                            Else
                                MessageBox.Show("Hubo un problema al guardar los ajustes")
                            End If
                            '-----------------------------------------------------------------
                        Else
                            MostrarTooltip(TxtTiempo2, "Ingrese un valor")
                        End If
                    Else
                        MostrarTooltip(TxtTiempo1, "Ingrese un valor")
                    End If
                Else
                    MostrarTooltip(TxtDescrip3, "Ingrese la descripción")
                End If
            Else
                MostrarTooltip(TxtDescrip2, "Ingrese la descripción")
            End If
        Else
            MostrarTooltip(TxtDescrip1, "Ingrese la descripción")
        End If
    End Sub

    Private Sub Form1_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        Dim strEstado As String = Me.WindowState.ToString()
        If strEstado = "Maximized" Then
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub FEditarHabitacion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ToolTip2.IsBalloon = True
        TxtDescrip1.Text = Habitacion.GetDescrip(1)
        TxtDescrip2.Text = Habitacion.GetDescrip(2)
        TxtDescrip3.Text = Habitacion.GetDescrip(3)
        TxtTiempo1.Text = CStr(Habitacion.GetTiempo(1))
        TxtTiempo2.Text = CStr(Habitacion.GetTiempo(2))
        DtpHraE.Text = Habitacion.GetHraE.ToString
        DtpHraS.Text = Habitacion.GetHraS.ToString
    End Sub

    Private Sub F_Deactivate(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Deactivate
        'Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub txtTol_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtTiempo1.KeyPress, TxtTiempo2.KeyPress
        Dim Caja As TextBox = CType(sender, TextBox)
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
            Caja.Focus()
            Me.ToolTip2.Show("Ingrese un valor númerico", Caja, 0, -40, 2000)
        End If
    End Sub

    Private Sub MostrarTooltip(ByVal Caja As TextBox, ByVal Mensaje As String)
        Caja.Focus()
        ToolTip2.Show(Mensaje, Caja, 0, -40, 3000)
    End Sub

End Class