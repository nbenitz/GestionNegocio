Public Class FNuevoCategoriaProd
    Dim Producto As New CProducto
    Dim idCategEdit As UInt32
    Dim EditMode As Boolean

    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub

    Private Sub BtnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGuardar.Click
        Dim idCateg As UInt32 = Producto.CargarNroCateg()
        Dim Descrip As String = txtDescrip.Text
        If Descrip <> "" Then
            If EditMode = False Then
                If Producto.InsertCategoria(idCateg, Descrip) Then
                    MessageBox.Show("Categoría Agregada")
                    Me.Close()
                Else
                    MessageBox.Show("Hubo un problema al agregar la Categoría. Intente con otra Descripción")
                End If
            Else
                If Producto.UpdateCategoria(idCategEdit, Descrip) Then
                    MessageBox.Show("Categoría Editada")
                    Me.Close()
                Else
                    MessageBox.Show("Hubo un problema al editar la Categoría")
                End If
            End If

        Else
            MessageBox.Show("Ingrese un Gasto")
        End If
    End Sub

    Public Sub Editar(ByVal idGastoValue As UInt16, ByVal GastoValue As String)
        EditMode = True
        idCategEdit = idGastoValue
        Me.Text = "Editar Categoría"
        txtDescrip.Text = GastoValue
    End Sub

    Private Sub BtnCerrarForm_Click(sender As Object, e As EventArgs) Handles BtnCerrarForm.Click
        Me.Close()
    End Sub
End Class