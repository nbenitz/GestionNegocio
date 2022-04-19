Option Strict On
Public Class FNuevoMotivo
    Dim Producto As New CProducto
    Dim ModoBajaValue As Boolean
    Dim idMotivoEdit As UInt16
    Dim EditMode As Boolean

    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        Close()
    End Sub

    Private Sub BtnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGuardar.Click
        Dim idMotivo As UInt16 = Producto.CargarNroBajaMotivo
        Dim Motivo As String = txtMotivo.Text
        If Motivo <> "" Then
            If ModoBajaValue Then
                If EditMode = False Then
                    If Producto.InsertMotivoBaja(idMotivo, Motivo) Then
                        MessageBox.Show("Motivo Agregado")
                        Me.Close()
                    Else
                        MessageBox.Show("Hubo un problema al agregar el motivo. Intente con otro Nombre")
                    End If
                Else
                    If Producto.UpdateMotivoBaja(idMotivoEdit, Motivo) Then
                        MessageBox.Show("Motivo Editado")
                        Me.Close()
                    Else
                        MessageBox.Show("Hubo un problema al editar el motivo")
                    End If
                End If
            Else
                If EditMode = False Then
                    If Producto.InsertMotivoAlta(idMotivo, Motivo) Then
                        MessageBox.Show("Motivo Agregado")
                        Me.Close()
                    Else
                        MessageBox.Show("Hubo un problema al agregar el motivo")
                    End If
                Else
                    If Producto.UpdateMotivoAlta(idMotivoEdit, Motivo) Then
                        MessageBox.Show("Motivo Editado")
                        Me.Close()
                    Else
                        MessageBox.Show("Hubo un problema al editar el motivo")
                    End If
                End If
            End If
        Else
            MessageBox.Show("Ingrese un Motivo")
        End If
    End Sub

    Public Sub ModoBaja(ByVal Valor As Boolean)
        ModoBajaValue = Valor
    End Sub

    Public Sub Editar(ByVal idMotivoValue As UInt16, ByVal MotivoValue As String)
        EditMode = True
        idMotivoEdit = idMotivoValue
        Me.Text = "Editar Motivo"
        txtMotivo.Text = MotivoValue
    End Sub

    Private Sub BtnCerrarForm_Click(sender As Object, e As EventArgs) Handles BtnCerrarForm.Click
        Me.Close()
    End Sub
End Class