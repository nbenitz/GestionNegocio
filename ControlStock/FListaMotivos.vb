
Public Class FListaMotivos
    Dim Producto As New CProducto
    Dim TablaMotivos As New DataTable
    Dim ModoBajaValor As Boolean

    Private Sub FListaMotivos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
        If ModoBajaValor Then
            TablaMotivos = Producto.ListarMotivoBaja
        Else
            TablaMotivos = Producto.ListarMotivoAlta
        End If
        Dim Filas As Integer = TablaMotivos.Rows.Count
        Dim Edit As Image = My.Resources.Resources.file_edit
        Dim Delete As Image = My.Resources.Resources.file_del
        DataGridView1.Rows.Clear()
        If Filas > 0 Then
            For i  As Integer = 0 To (Filas - 1)
                Dim idMotivo As Integer = CInt(TablaMotivos.Rows(i).Item(0))
                Dim Motivo As String = CStr(TablaMotivos.Rows(i).Item(1))
                DataGridView1.Rows.Add(idMotivo, Motivo, Edit, Delete)
            Next
        End If
    End Sub

    Public Sub ModoBaja(ByVal Valor As Boolean)
        ModoBajaValor = Valor
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If e.ColumnIndex = 2 Then
            Dim row As Integer = e.RowIndex
            Dim idMotivo As UInt16 = CUShort(TablaMotivos.Rows(row).Item(0))
            Dim Motivo As String = CStr(TablaMotivos.Rows(row).Item(1))
            Dim frm As New FNuevoMotivo
            frm.ModoBaja(ModoBajaValor)
            frm.Editar(idMotivo, Motivo)
            frm.ShowDialog()
            CargarTabla()
        ElseIf e.ColumnIndex = 3 Then
            Dim Result As Integer = MsgBox("Desea eliminar el motivo seleccionado?", MsgBoxStyle.YesNo, "Eliminar Motivo")
            If Result = 6 Then
                Dim row As Integer = e.RowIndex
                Dim idMotivo As UInt16 = CUShort(TablaMotivos.Rows(row).Item(0))
                If ModoBajaValor Then
                    If Producto.DeleteMotivoBaja(idMotivo) Then
                        MessageBox.Show("Motivo eliminado")
                        CargarTabla()
                    Else
                        MessageBox.Show("No se puede eliminar el motivo. Solo los motivos NO utilizados pueden ser eliminados. " +
                                        "Los motivos utilizados solo pueden ser editados.")
                    End If
                Else
                    If Producto.DeleteMotivoAlta(idMotivo) Then
                        MessageBox.Show("Motivo eliminado")
                        CargarTabla()
                    Else
                        MessageBox.Show("No se puede eliminar el motivo. Solo los motivos NO utilizados pueden ser eliminados. " +
                                        "Los motivos utilizados solo pueden ser editados.")
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub BtnCerrarForm_Click(sender As Object, e As EventArgs) Handles BtnCerrarForm.Click
        Me.Close()
    End Sub
End Class