Public Class FListaCategoriaProd
    Dim Producto As New CProducto
    Dim TablaCategorias As New DataTable

    Private Sub FListaCategoriaProd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarTabla()
    End Sub

    Private Sub F_Deactivate(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Deactivate
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Form1_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        Dim strEstado As String = Me.WindowState.ToString()
        If strEstado = "Maximized" Then
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub CargarTabla()
        TablaCategorias = Producto.ListarCateg
        Dim Filas As Integer = TablaCategorias.Rows.Count
        Dim Edit As Image = My.Resources.Resources.file_edit
        Dim Delete As Image = My.Resources.Resources.file_del
        DataGridView1.Rows.Clear()
        If Filas > 0 Then
            For i = 0 To (Filas - 1)
                Dim idCateg As Integer = CInt(TablaCategorias.Rows(i).Item(0))
                Dim Categoria As String = CStr(TablaCategorias.Rows(i).Item(1))
                DataGridView1.Rows.Add(idCateg, Categoria, Edit, Delete)
            Next
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If e.ColumnIndex = 2 Then
            Dim row As Integer = e.RowIndex
            Dim idCateg As UInt32 = CUShort(TablaCategorias.Rows(row).Item(0))
            Dim Categoria As String = CStr(TablaCategorias.Rows(row).Item(1))
            Dim frm As New FNuevoCategoriaProd
            frm.Editar(idCateg, Categoria)
            frm.ShowDialog()
            CargarTabla()
        ElseIf e.ColumnIndex = 3 Then
            Dim Result As Integer = MsgBox("Desea eliminar la categoría seleccionada?", MsgBoxStyle.YesNo, "Eliminar Categoría")
            If Result = 6 Then
                Dim row As Integer = e.RowIndex
                Dim idCateg As UInt32 = CUInt(TablaCategorias.Rows(row).Item(0))
                If Producto.DeleteCategoria(idCateg) Then
                    MessageBox.Show("Categoría eliminada")
                    CargarTabla()
                Else
                    MessageBox.Show("No se puede eliminar la categoría. Solo las categorías NO utilizadas pueden ser eliminadas. " +
                                    "Las categorías utilizadas solo pueden ser editadas.")
                End If
            End If
        End If
    End Sub

End Class