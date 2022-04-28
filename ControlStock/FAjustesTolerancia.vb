Option Strict On

Public Class FAjustesTolerancia
    Dim oHabitacion As New CHabitacion

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Dim Tol1 As Integer
        Dim Tol2 As Integer
        Dim Tol3 As Integer

        If TxtTol1.Text <> "" Then
            If TxtTol2.Text <> "" Then
                If TxtTol3.Text <> "" Then
                    Tol1 = CInt(TxtTol1.Text)
                    Tol2 = CInt(TxtTol2.Text)
                    Tol3 = CInt(TxtTol3.Text)
                    If oHabitacion.Ajustes(Tol1, Tol2, Tol3) = True Then
                        MessageBox.Show("Los ajustes se guardaron correctamente")
                        Me.Close()
                    Else
                        MessageBox.Show("Hubo un problema al guardar los ajustes")
                    End If
                Else
                    TxtTol3.Focus()
                    ToolTip2.Show("Ingrese un valor", TxtTol3, 0, -40, 3000)
                End If
            Else
                TxtTol2.Focus()
                ToolTip2.Show("Ingrese un valor", TxtTol2, 0, -40, 3000)
            End If
        Else
            TxtTol1.Focus()
            ToolTip2.Show("Ingrese un valor", TxtTol1, 0, -40, 3000)
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
        Dim Tabla As DataTable = oHabitacion.VerAjustes
        TxtTol1.Text = CStr(Tabla.Rows(0).Item(1))
        TxtTol2.Text = CStr(Tabla.Rows(0).Item(2))
        TxtTol3.Text = CStr(Tabla.Rows(0).Item(3))
    End Sub

    Private Sub F_Deactivate(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Deactivate
        'Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub txtTol_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtTol1.KeyPress, TxtTol2.KeyPress, TxtTol3.KeyPress
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