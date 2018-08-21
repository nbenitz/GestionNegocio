Option Strict On

Public Class FListaPrivilegios
    Dim Usuario As New CUsuario
    Dim TablaPriv As New DataTable

    Private Sub FListaMotivos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
        TablaPriv = Usuario.ListarPrivilegio()
        Dim Filas As Integer = TablaPriv.Rows.Count
        Dim Edit As Image = My.Resources.file_edit
        Dim Delete As Image = My.Resources.file_del
        DataGridView1.Rows.Clear()
        If Filas > 0 Then
            For i = 0 To (Filas - 1)
                Dim idPriv As Integer = CInt(TablaPriv.Rows(i).Item(0))
                Dim Privilegio As String = CStr(TablaPriv.Rows(i).Item(1))
                DataGridView1.Rows.Add(idPriv, Privilegio, Edit, Delete)
            Next
        End If
    End Sub

    Private Sub pbxEditar_Click(sender As Object, e As EventArgs) Handles pbxEditar.Click, pnlEditar.Click, lblEditar.Click
        Try
            Dim row As Integer = DataGridView1.CurrentRow.Index
            Dim IdPriv As Integer = CInt(TablaPriv.Rows(row).Item(0))
            Dim Rol As String = CStr(TablaPriv.Rows(row).Item(1))
            Dim ProdConsult = CBool(TablaPriv.Rows(row).Item(2))
            Dim ProdReg = CBool(TablaPriv.Rows(row).Item(3))
            Dim ProdActualiz = CBool(TablaPriv.Rows(row).Item(4))
            Dim ProdEliminar = CBool(TablaPriv.Rows(row).Item(5))
            Dim VentasConsult = CBool(TablaPriv.Rows(row).Item(6))
            Dim VentasReg = CBool(TablaPriv.Rows(row).Item(7))
            Dim ComprasConsult = CBool(TablaPriv.Rows(row).Item(8))
            Dim ComprasReg = CBool(TablaPriv.Rows(row).Item(9))
            Dim ProvConsult = CBool(TablaPriv.Rows(row).Item(10))
            Dim ProvReg = CBool(TablaPriv.Rows(row).Item(11))
            Dim ProvActualiz = CBool(TablaPriv.Rows(row).Item(12))
            Dim ProvEliminar = CBool(TablaPriv.Rows(row).Item(13))
            Dim EmpleAdmin = CBool(TablaPriv.Rows(row).Item(14))
            Dim UsuAdmin = CBool(TablaPriv.Rows(row).Item(15))
            Dim FinanzasAdmin = CBool(TablaPriv.Rows(row).Item(16))
            Dim HabAdmin = CBool(TablaPriv.Rows(row).Item(17))
            Dim CuentasAdmin = CBool(TablaPriv.Rows(row).Item(18))
            Dim DevolAutoriCli = CBool(TablaPriv.Rows(row).Item(19))
            Dim DevolAutoriProv = CBool(TablaPriv.Rows(row).Item(20))
            Dim Frm As New FNuevoPrivilegio
            Frm.Editar(Rol,
                       ProdConsult,
                       ProdReg,
                       ProdActualiz,
                       ProdEliminar,
                       VentasConsult,
                       VentasReg,
                       ComprasConsult,
                       ComprasReg,
                       ProvConsult,
                       ProvReg,
                       ProvActualiz,
                       ProvEliminar,
                       EmpleAdmin,
                       UsuAdmin,
                       FinanzasAdmin,
                       HabAdmin,
                       CuentasAdmin,
                       DevolAutoriCli,
                       DevolAutoriProv,
                       IdPriv)
            frm.MaximizeBox = False
            frm.MinimizeBox = False
            frm.ShowDialog()
            CargarTabla()
        Catch ex As Exception
            MessageBox.Show("Debe Seleccionar un Item de la Lista")
        End Try

    End Sub

    Private Sub LblEliminar_Click(sender As Object, e As EventArgs) Handles LblEliminar.Click, PbxEliminar.Click, PnlEliminar.Click
        Try
            Dim Result As Integer = MsgBox("Desea eliminar el motivo seleccionado?", MsgBoxStyle.YesNo, "Eliminar Motivo")
            If Result = 6 Then
                Dim row As Integer = DataGridView1.CurrentRow.Index
                Dim IdPriv As Integer = CInt(TablaPriv.Rows(row).Item(0))
                If Usuario.EliminarPriv(IdPriv) Then
                    MessageBox.Show("Nivel de Privilegio Eliminado")
                    CargarTabla()
                Else
                    MessageBox.Show("No se puede eliminar el Nivel de Privilegio. Para poder eliminar un Nivel de Privilegio éste no debe ser asignado a ningún Usuario.")
                End If

            End If
        Catch ex As Exception
            MessageBox.Show("Debe Seleccionar un Producto de la Lista")
        End Try
    End Sub


End Class