Public Class FListaMembresia
    Dim Membresia As New CMembresia
    Dim TablaMembresias As New DataTable
    Dim ModoBajaValor As Boolean

    Private Sub FListaMembresia_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CargarTabla()
    End Sub

    Private Sub F_Deactivate(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Deactivate
        'Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Form1_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        Dim strEstado As String = Me.WindowState.ToString()
        If strEstado = "Maximized" Then
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub CargarTabla()
        TablaMembresias = Membresia.Listar
        Dim Filas As Integer = TablaMembresias.Rows.Count
        Dim Edit As Image = My.Resources.Resources.file_edit
        Dim Delete As Image = My.Resources.Resources.file_del
        DataGridView1.Rows.Clear()
        If Filas > 0 Then
            For i  As Integer = 0 To (Filas - 1)
                Dim Nombre As String = CStr(TablaMembresias.Rows(i).Item(1))
                Dim Precio As Integer = CInt(TablaMembresias.Rows(i).Item(3))
                DataGridView1.Rows.Add(Nombre, Precio, Edit, Delete)
            Next
        End If
    End Sub


    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If e.ColumnIndex = 2 Then
            Dim row As Integer = e.RowIndex
            Dim Id As Int32 = CInt(TablaMembresias.Rows(row).Item(0))
            Dim Nombre As String = CStr(TablaMembresias.Rows(row).Item(1))
            Dim Descripcion As String = CStr(TablaMembresias.Rows(row).Item(2))
            Dim Precio As Int32 = CInt(TablaMembresias.Rows(row).Item(3))
            Dim frm As New FNuevoMembresia
            frm.Editar(Id, Nombre, Descripcion, Precio)
            frm.ShowDialog()
            CargarTabla()
        ElseIf e.ColumnIndex = 3 Then
            Dim Result As Integer = MsgBox("Desea eliminar la membresía seleccionada?", MsgBoxStyle.YesNo, "Eliminar Membresía")
            If Result = 6 Then
                Dim row As Integer = e.RowIndex
                Dim id As Int32 = CInt(TablaMembresias.Rows(row).Item(0))
                If Membresia.Eliminar(id) Then
                    MessageBox.Show("Membresía eliminada")
                    CargarTabla()
                Else
                    MessageBox.Show("No se puede eliminar la Membresía. Solo las Membresías NO asignadas a un socio pueden ser eliminadas. " +
                                        "Las membresías asignadas solo pueden ser editadas.")
                End If
            End If
        End If
    End Sub

    Private Sub BtnCerrarForm_Click(sender As Object, e As EventArgs) Handles BtnCerrarForm.Click
        Me.Close()
    End Sub
End Class