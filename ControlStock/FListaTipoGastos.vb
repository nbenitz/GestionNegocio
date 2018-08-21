Public Class FListaTipoGastos
    Dim Compra As New CCompra
    Dim TablaGastos As New DataTable

    Private Sub FListaGastos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
        TablaGastos = Compra.ListarGasto
        Dim Filas As Integer = TablaGastos.Rows.Count
        Dim Edit As Image = My.Resources.Resources.file_edit
        Dim Delete As Image = My.Resources.Resources.file_del
        DataGridView1.Rows.Clear()
        If Filas > 0 Then
            For i = 0 To (Filas - 1)
                Dim idGasto As Integer = TablaGastos.Rows(i).Item(0)
                Dim Descrip As String = CStr(TablaGastos.Rows(i).Item(1))
                DataGridView1.Rows.Add(idGasto, Descrip, Edit, Delete)
            Next
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If e.ColumnIndex = 2 Then
            Dim row As Integer = e.RowIndex
            Dim idGasto As UInt16 = CUShort(TablaGastos.Rows(row).Item(0))
            Dim Descrip As String = CStr(TablaGastos.Rows(row).Item(1))
            Dim frm As New FNuevoGasto
            frm.Editar(idGasto, Descrip)
            frm.ShowDialog()
            CargarTabla()
        ElseIf e.ColumnIndex = 3 Then
            Dim Result As Integer = MsgBox("Desea eliminar el gasto seleccionado?", MsgBoxStyle.YesNo, "Eliminar Motivo")
            If Result = 6 Then
                Dim row As Integer = e.RowIndex
                Dim idMotivo As UInt16 = CUShort(TablaGastos.Rows(row).Item(0))
                If Compra.DeleteGasto(idMotivo) Then
                    MessageBox.Show("Motivo eliminado")
                End If
                CargarTabla()
            Else
                MessageBox.Show("No se puede eliminar el gasto. Solo los gastos NO utilizados pueden ser eliminados. " +
                                        "Los gastos utilizados solo pueden ser editados.")
            End If

        End If
    End Sub
End Class