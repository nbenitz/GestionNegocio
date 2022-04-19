Public Class FNuevoMembresia
    Dim Membresia As New CMembresia
    Dim idMembresia As Int32
    Dim EditMode As Boolean

    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        Close()
    End Sub

    Private Sub BtnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGuardar.Click
        Dim Nombre As String = txtNombre.Text
        Dim Descripcion As String = txtDescripcion.Text
        Dim Precio As Integer = CInt(txtPrecio.Text)
        If txtNombre.Text <> "" And txtDescripcion.Text <> "" And txtPrecio.Text <> "" Then
            If EditMode = False Then
                If Membresia.Insert(Nombre, Descripcion, Precio) Then
                    MessageBox.Show("Membresía Agregada")
                    Me.Close()
                Else
                    MessageBox.Show("Hubo un problema al agregar la Membresía.")
                End If
            Else
                If Membresia.Update(Nombre, Descripcion, Precio, idMembresia) Then
                    MessageBox.Show("Membresía Editada")
                    Me.Close()
                Else
                    MessageBox.Show("Hubo un problema al editar la Membresía")
                End If
            End If
        Else
            MessageBox.Show("Complete todos los campos")
        End If
    End Sub


    Public Sub Editar(ByVal idMembresiaValue As Int32,
                      ByVal NombreValue As String,
                      ByVal DescripcionValue As String,
                      ByVal PrecioValue As Int32)
        EditMode = True
        idMembresia = idMembresiaValue
        Me.Text = "Editar Membresía"
        txtNombre.Text = NombreValue
        txtDescripcion.Text = DescripcionValue
        txtPrecio.Text = CStr(PrecioValue)
    End Sub

    Private Sub BtnCerrarForm_Click(sender As Object, e As EventArgs) Handles BtnCerrarForm.Click
        Me.Close()
    End Sub
End Class