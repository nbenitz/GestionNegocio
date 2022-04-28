Option Strict On

Public Class FAjustesAcceso
    Dim oAjustes As New CAcceso

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Dim Tol1 As Integer
        Dim Tol2 As Integer
        Dim Tol3 As Integer

        If TxtTol1.Text <> "" Then
            Tol1 = CInt(TxtTol1.Text)
            If oAjustes.Ajustes(Tol1) = True Then
                MessageBox.Show("Los ajustes se guardaron correctamente")
                Me.Close()
            Else
                MessageBox.Show("Hubo un problema al guardar los ajustes")
            End If
        Else
            TxtTol1.Focus()
            ToolTip2.Show("Ingrese un valor", TxtTol1, 0, -40, 3000)
        End If
    End Sub

    Private Sub FEditarHabitacion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ToolTip2.IsBalloon = True
        Dim Tabla As DataTable = oAjustes.VerAjustes
        TxtTol1.Text = CStr(Tabla.Rows(0).Item(1))
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub txtTol_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtTol1.KeyPress
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

    Private Sub BtnCerrarForm_Click(sender As Object, e As EventArgs) Handles BtnCerrarForm.Click
        Me.Close()
    End Sub


End Class