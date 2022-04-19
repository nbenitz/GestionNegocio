Public Class FListaClientes
    Dim Cliente As New CCliente
    Dim TablaCli As DataTable

    Private Sub FListaClientes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cmbVerPor.SelectedIndex = 0
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

    Private Sub MostrarCaja(ByVal Titulo As String)
        txtBuscar.Visible = True
        ToolTip1.Show(Titulo, lblAux, 0, -8, 1200)
        txtBuscar.Focus()
    End Sub

    Private Sub CargarTabla(ByVal Tabla As DataTable)
        Dim Filas As Integer = Tabla.Rows.Count
        DataGridView1.Rows.Clear()
        If Filas > 0 Then
            For i  As Integer = 0 To (Filas - 1)
                Dim RUC As String = CStr(Tabla.Rows(i).Item(0))
                Dim Nombre As String = CStr(Tabla.Rows(i).Item(1))
                Dim Tel As String = CStr(Tabla.Rows(i).Item(3))
                Dim Dir As String = CStr(Tabla.Rows(i).Item(4))
                Dim Aliass As String = CStr(Tabla.Rows(i).Item(2))
                DataGridView1.Rows.Add(RUC, Nombre, Aliass, Tel, Dir)
            Next
        End If
    End Sub

    Private Sub cmbVerPor_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbVerPor.SelectedIndexChanged
        Dim Indice As Integer = cmbVerPor.SelectedIndex
        Select Case Indice
            Case Is = 0 'Todos
                txtBuscar.Visible = False
                VerTodos()
            Case Is = 1 'Nombre
                MostrarCaja("Ingrese el Nombre")
            Case Is = 2 'RUC
                MostrarCaja("Ingrese el CI")
        End Select
    End Sub

    Private Sub txtBuscar_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles txtBuscar.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim Param As String = txtBuscar.Text
            If Param <> "" Then
                Select Case cmbVerPor.SelectedIndex
                    Case Is = 1 'Nombre
                        TablaCli = Cliente.BuscCli("WHERE Nombre like '%" + Param + "%'")
                    Case Is = 2 'RUC
                        Try
                            TablaCli = Cliente.BuscCli("WHERE CI like '%" + Param + "%'")
                        Catch ex As Exception
                            MessageBox.Show("No hay coincidencias")
                        End Try
                End Select
                CargarTabla(TablaCli)
            End If
        End If
    End Sub

    Private Sub txtBuscar_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBuscar.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNuevo.Click
        Dim Frm As New FNuevoSocio
        Frm.MaximizeBox = False
        Frm.MinimizeBox = False
        Frm.ShowDialog()
    End Sub

    Private Sub btnActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActualizar.Click
        Actualizar()
    End Sub

    Private Sub VerTodos()
        TablaCli = Cliente.BuscCli("")
        CargarTabla(TablaCli)
    End Sub

    Private Sub Actualizar()
        If cmbVerPor.SelectedIndex = 0 Then
            VerTodos()
        Else
            Dim Tecla As KeyEventArgs = New KeyEventArgs(Keys.Enter)
            txtBuscar_KeyDown(Me, Tecla)
        End If
    End Sub

    Private Sub pbxEditar_Click(sender As Object, e As EventArgs) Handles pbxEditar.Click, pnlEditar.Click, lblEditar.Click
        Try
            Dim row As Integer = DataGridView1.CurrentRow.Index
            Dim CI As String = CStr(TablaCli.Rows(row).Item(0))
            Dim Tabla As DataTable = Cliente.BuscCli("WHERE CI = '" + CI + "'")
            Dim Nombre As String = CStr(Tabla.Rows(0).Item(1))
            Dim Telefono As String = CStr(Tabla.Rows(0).Item(3))
            Dim Direccion As String = CStr(Tabla.Rows(0).Item(4))
            Dim Aliass As String = CStr(Tabla.Rows(0).Item(2))
            Dim Frm As New FNuevoCliente
            Frm.Editar(CI, Nombre, Telefono, Direccion, " ")
            Frm.MaximizeBox = False
            Frm.MinimizeBox = False
            Frm.ShowDialog()
            Actualizar()
        Catch ex As Exception
            MessageBox.Show("Debe Seleccionar un Socio de la Lista")
        End Try
    End Sub

    Private Sub LblEliminar_Click(sender As Object, e As EventArgs) Handles LblEliminar.Click, PbxEliminar.Click, PnlEliminar.Click
        Try
            Dim Result As Integer = MsgBox("Desea eliminar al Socio seleccionado?", MsgBoxStyle.YesNo, "Eliminar Socio")
            If Result = 6 Then
                Dim row As Integer = DataGridView1.CurrentRow.Index
                Dim RUC As String = CStr(TablaCli.Rows(row).Item(0))
                If Cliente.Eliminar(RUC) Then
                    MessageBox.Show("El Socio ha sido eliminado")
                    VerTodos()
                Else
                    MessageBox.Show("Hubo un problema al eliminar al Socio")
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Debe Seleccionar un Socio de la Lista")
        End Try
    End Sub

End Class