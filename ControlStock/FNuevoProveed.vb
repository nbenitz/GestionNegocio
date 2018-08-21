Option Strict On
Public Class FNuevoProveed
    Dim Proveed As New CProveedor
    Dim EditMode As Boolean = False
    Dim OldRUC As String


    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Dim RUC As String = txtRUC.Text
        Dim Nombre As String = txtNombre.Text
        Dim Tel As String = txtTelefono.Text
        Dim Dir As String = txtDireccion.Text
        If RUC <> "" Then
            If Nombre <> "" Then
                If EditMode = False Then
                    If Proveed.Insert(RUC, Nombre, Tel, Dir) = True Then
                        MessageBox.Show("Proveedor Guardado")
                        Limpiar()
                    Else
                        MessageBox.Show("Hubo un problema al Guardar el Proveedor")
                    End If
                Else
                    If Proveed.Update(RUC, Nombre, Tel, Dir, OldRUC) = True Then
                        MessageBox.Show("Proveedor Guardado")
                        Me.Close()
                    Else
                        MessageBox.Show("Hubo un problema al editar el Proveedor")
                    End If
                End If
            Else
                txtNombre.Focus()
                ToolTip2.Show("Ingrese el Nombre", txtNombre, 0, -40, 3000)
            End If
        Else
            txtRUC.Focus()
            ToolTip2.Show("Ingrese un RUC válido", txtRUC, 0, -40, 3000)
        End If
    End Sub

    Private Sub Form1_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        Dim strEstado As String = Me.WindowState.ToString()
        If strEstado = "Maximized" Then
            WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub FNuevoEmple_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ToolTip2.IsBalloon = True
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
                  ByVal Dir As String)
        EditMode = True
        OldRUC = RUC
        txtRUC.Text = RUC
        txtNombre.Text = Nombre
        txtTelefono.Text = Tel
        txtDireccion.Text = Dir
    End Sub

End Class