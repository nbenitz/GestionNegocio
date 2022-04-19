Public Class FNuevoGasto
    Dim Compra As New CCompra
    Dim idGastoEdit As Int32
    Dim EditMode As Boolean

    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub

    Private Sub BtnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGuardar.Click
        Dim idGasto As Integer = Compra.CargarNroListaGasto
        Dim Descrip As String = txtGasto.Text
        If Descrip <> "" Then
            If EditMode = False Then
                If Compra.InsertListaGasto(idGasto, Descrip) Then
                    MessageBox.Show("Gasto Agregado")
                    Me.Close()
                Else
                    MessageBox.Show("Hubo un problema al agregar el gasto. Intente con otra Descripción")
                End If
            Else
                If Compra.UpdateListaGasto(idGastoEdit, Descrip) Then
                    MessageBox.Show("Gasto Editado")
                    Me.Close()
                Else
                    MessageBox.Show("Hubo un problema al editar el gasto")
                End If
            End If

        Else
            MessageBox.Show("Ingrese un Gasto")
        End If
    End Sub

    Public Sub Editar(ByVal idGastoValue As UInt16, ByVal GastoValue As String)
        EditMode = True
        idGastoEdit = idGastoValue
        Me.Text = "Editar Gasto"
        txtGasto.Text = GastoValue
    End Sub

    Private Sub BtnCerrarForm_Click(sender As Object, e As EventArgs) Handles BtnCerrarForm.Click
        Me.Close()
    End Sub
End Class