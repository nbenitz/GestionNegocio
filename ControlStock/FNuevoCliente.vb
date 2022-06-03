Option Strict On
Public Class FNuevoCliente
    Dim Cliente As New CCliente
    Dim EditMode As Boolean = False
    Dim OldRUC As String

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Dim RUC As String
        Dim Nombre As String = txtNombre.Text
        Dim Tel As String = txtTelefono.Text
        Dim Dir As String = txtDireccion.Text
        Dim Propiet As String = txtPropietario.Text
        Dim foto As Byte()
        Try
            RUC = txtRUC.Text
            If Nombre <> "" Then
                If Tel = "" Then
                    Tel = " "
                End If
                If Dir = "" Then
                    Dir = " "
                End If
                If Propiet = "" Then
                    Propiet = " "
                End If
                If EditMode = False Then
                    If Cliente.InserCliente(RUC, Nombre, " ", Tel, Dir, Propiet, foto, Now, " ") = True Then
                        MessageBox.Show("Cliente Guardado")
                        Limpiar()
                    Else
                        MessageBox.Show("Hubo un problema al Guardar el Cliente")
                    End If
                Else
                    If Cliente.Update(RUC, Nombre, " ", Tel, Dir, Propiet, foto, Now, " ", OldRUC) = True Then
                        MessageBox.Show("Cliente Guardado")
                        Close()
                    Else
                        MessageBox.Show("Hubo un problema al editar el Cliente")
                    End If
                End If
            Else
                txtNombre.Focus()
                ToolTip2.Show("Ingrese el Nombre", txtNombre, 0, -40, 3000)
            End If
        Catch
            txtRUC.Focus()
            txtRUC.Select(0, txtRUC.Text.Length)
            ToolTip2.Show("Ingrese un RUC o CI válidos", txtRUC, 0, -40, 3000)
            Exit Sub
        End Try
    End Sub

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Limpiar()
    End Sub

    Private Sub Form1_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        Dim strEstado As String = WindowState.ToString()
        If strEstado = "Maximized" Then
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub F_Deactivate(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Deactivate
        'Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        If EditMode = True Then
            Close()
        Else
            Limpiar()
        End If
    End Sub

    Private Sub Limpiar()
        txtRUC.Text = ""
        txtDireccion.Text = ""
        txtNombre.Text = ""
        txtTelefono.Text = ""
        txtRUC.Focus()
    End Sub

    Public Sub Editar(ByVal RUC As String, ByVal Nombre As String, ByVal Tel As String,
                  ByVal Dir As String, ByVal Propiet As String)
        EditMode = True
        OldRUC = RUC
        txtRUC.Text = RUC
        txtNombre.Text = Nombre
        txtTelefono.Text = Tel
        txtDireccion.Text = Dir
        txtPropietario.Text = Propiet
    End Sub

    Private Sub BtnCerrarForm_Click(sender As Object, e As EventArgs) Handles BtnCerrarForm.Click
        Me.Close()
    End Sub
End Class