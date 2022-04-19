Public Class FAcercaDe
    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Close()
    End Sub

    Private Sub FAcercaDe_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnAceptar.Focus()
    End Sub

    Private Sub BtnCerrarForm_Click(sender As Object, e As EventArgs) Handles BtnCerrarForm.Click
        Me.Close()
    End Sub
End Class