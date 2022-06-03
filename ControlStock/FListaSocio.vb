Option Strict On
Option Explicit On

Public Class FListaSocio
    Dim Cliente As New CCliente
    Dim oMembresia As New CMembresia
    Dim oAcceso As New CAcceso
    Dim Caja As New CCaja
    Dim NumCaja As UInt16 = 1
    Dim TablaCli As DataTable
    Dim ModoVistaValue As Boolean = False
    Public Event ClienteSeleccionado(ByVal CI As String, ByVal Nombre As String)
    Dim TablaSelIndex As Integer = -1

    Private Sub FListaSocio_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cmbVerPor.SelectedIndex = 0
        txtBuscar.Focus()
    End Sub

    Private Sub MostrarCaja(ByVal Titulo As String)
        txtBuscar.Visible = True
        ToolTip1.Show(Titulo, lblAux, 0, -8, 1200)
        txtBuscar.Focus()
    End Sub

    Private Sub CargarTabla(ByVal Tabla As DataTable)
        Dim Filas As Integer = Tabla.Rows.Count
        dgvCliente.Rows.Clear()
        If Filas > 0 Then
            For i As Integer = 0 To (Filas - 1)
                Dim Foto As Image
                Try
                    Foto = ByteArrayToImage(CType(Tabla.Rows(i).Item(9), Byte()))
                Catch
                    Foto = My.Resources.userblack
                End Try
                Dim RUC As String = CStr(Tabla.Rows(i).Item(0))
                Dim Nombre As String = CStr(Tabla.Rows(i).Item(1))
                Dim MembresiaNom As String = ""
                Try
                    MembresiaNom = CStr(Tabla.Rows(i).Item(2))
                Catch
                End Try
                Dim Tel As String = CStr(Tabla.Rows(i).Item(3))
                Dim Saldo As Integer = CInt(Tabla.Rows(i).Item(13))
                Dim Estado As String = CStr(Tabla.Rows(i).Item(14))
                Dim AccesoCod As String = ""
                Try
                    AccesoCod = CStr(Tabla.Rows(i).Item(4))
                Catch
                End Try

                dgvCliente.Rows.Add(False, Foto, RUC, Nombre, MembresiaNom, Tel, Saldo, Estado)

                If Estado = "Cuota Vencida" Then
                    dgvCliente.Rows.Item(i).DefaultCellStyle.BackColor = Color.FromArgb(192, 0, 0)
                    dgvCliente.Rows.Item(i).DefaultCellStyle.SelectionBackColor = Color.FromArgb(192, 0, 0)
                    dgvCliente.Rows.Item(i).DefaultCellStyle.ForeColor = Color.LightGray
                    dgvCliente.Rows.Item(i).DefaultCellStyle.SelectionForeColor = Color.White
                Else
                    dgvCliente.Rows.Item(i).DefaultCellStyle.BackColor = Color.DarkGreen
                    dgvCliente.Rows.Item(i).DefaultCellStyle.SelectionBackColor = Color.DarkGreen
                    dgvCliente.Rows.Item(i).DefaultCellStyle.ForeColor = Color.LightGray
                    dgvCliente.Rows.Item(i).DefaultCellStyle.SelectionForeColor = Color.White
                End If

            Next
            dgvCliente.Item(0, 0).Value = True
            TablaSelIndex = 0
        End If
    End Sub

    Private Sub cmbVerPor_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbVerPor.SelectedIndexChanged
        Dim Indice As Integer = cmbVerPor.SelectedIndex
        Select Case Indice
            Case Is = 0 'Todos
                VerTodos()
            Case Else
                VerConFiltro()
        End Select
        txtBuscar.Text = ""
    End Sub

    Private Sub txtBuscar_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles txtBuscar.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim Param As String = txtBuscar.Text
            If Param <> "" Then
                TablaCli = Cliente.BuscSocio("WHERE Nombre like '%" + Param + "%' OR Cedula like '%" + Param + "%' OR Alias like '%" + Param + "%'")
                CargarTabla(TablaCli)
            End If
            cmbVerPor.Text = ""
        End If
    End Sub

    Private Sub txtBuscar_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBuscar.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNuevo.Click
        If Caja.CajaAbierta(NumCaja) Then
            Cursor.Current = Cursors.WaitCursor
            Dim Frm As New FNuevoSocio
            Frm.ShowDialog()
            Actualizar()
        Else
            MessageBox.Show("Debe abrir la Caja para poder cobrar una membresía a un socio")
            Dim Frm As New FCajaMostrador
            Frm.CIEmpleado = MCaja.EmpleadoCI
            Frm.ShowDialog()
        End If
    End Sub

    Private Sub btnActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActualizar.Click
        Actualizar()
    End Sub

    Private Sub VerTodos()
        TablaCli = Cliente.BuscSocio("")
        CargarTabla(TablaCli)
    End Sub

    Private Sub VerConFiltro()
        Dim Condicion As String = ""
        Select Case cmbVerPor.SelectedIndex
            Case Is = 1 'Al día
                Condicion = "WHERE estado = 'Cuota al día'"
            Case Is = 2 'Con Cuota Vencida
                Condicion = "WHERE estado = 'Cuota Vencida'"
            Case Is = 3 'Con Deuda
                Condicion = "WHERE Saldo > 0"
            Case Is = 4 'Activos

            Case Is = 5 'Inactivos

        End Select

        TablaCli = Cliente.BuscSocio(Condicion)
        CargarTabla(TablaCli)

        'lblCantSocio.Text = CStr(acceso.CantSocioAsistencia(Condicion)) + " Socios"
    End Sub

    Private Sub VerDeudores()
        TablaCli = Cliente.BuscSocio(" WHERE Saldo > 0")
        CargarTabla(TablaCli)
    End Sub

    Private Sub Actualizar()
        Dim Param As String = txtBuscar.Text
        If Param <> "" Then
            Dim Tecla As KeyEventArgs = New KeyEventArgs(Keys.Enter)
            txtBuscar_KeyDown(Me, Tecla)
            Exit Sub
        End If

        If cmbVerPor.SelectedIndex = 0 Then
            VerTodos()
        Else
            VerConFiltro()
        End If
    End Sub

    Private Sub pbxEditar_Click(sender As Object, e As EventArgs) Handles pbxEditar.Click, pnlEditar.Click, lblEditar.Click
        Cursor.Current = Cursors.WaitCursor
        If TablaSelIndex >= 0 Then
            Dim row As Integer = dgvCliente.CurrentRow.Index
            Dim CI As String = CStr(TablaCli.Rows(row).Item(0))
            Dim Nombre As String = CStr(TablaCli.Rows(row).Item(1))
            Dim Telefono As String = CStr(TablaCli.Rows(row).Item(3))
            Dim AccesoCod As String
            Try
                AccesoCod = CStr(TablaCli.Rows(row).Item(4))
            Catch
                AccesoCod = ""
            End Try
            Dim Aliass As String = CStr(TablaCli.Rows(row).Item(5))
            Dim Direccion As String = CStr(TablaCli.Rows(row).Item(6))
            Dim Foto As Byte()
            Try
                Foto = CType(TablaCli.Rows(row).Item(9), Byte())
            Catch
            End Try
            Dim FechaNac As Date = CDate(TablaCli.Rows(row).Item(11))
            Dim Conocio As String = CStr(TablaCli.Rows(row).Item(12))
            Dim Frm As New FNuevoSocio
            Frm.Editar(CI, Nombre, Telefono, Direccion, Aliass, Foto, FechaNac, Conocio, AccesoCod)
            Frm.ShowDialog()
            Actualizar()
        Else
            MessageBox.Show("Debe Seleccionar un Socio de la Lista")
        End If
    End Sub

    Private Sub LblEliminar_Click(sender As Object, e As EventArgs) Handles LblEliminar.Click, PbxEliminar.Click, PnlEliminar.Click
        If TablaSelIndex >= 0 Then
            Dim Result As Integer = MsgBox("Desea eliminar al Socio seleccionado?", MsgBoxStyle.YesNo, "Eliminar Socio")
            If Result = 6 Then
                Dim row As Integer = dgvCliente.CurrentRow.Index
                Dim RUC As String = CStr(TablaCli.Rows(row).Item(0))
                If oAcceso.IdClienteAcceso(RUC) >= 0 Then
                    If oAcceso.EliminarClienteAcceso(RUC) = False Then
                        MessageBox.Show("Hubo un problema al eliminar el acceso del Socio")
                        Exit Sub
                    End If
                End If

                If oMembresia.IdClienteMembresia(RUC) >= 0 Then
                    If oMembresia.EliminarClienteMembresiaByCI(RUC) = False Then
                        MessageBox.Show("Hubo un problema al eliminar la membresía del Socio")
                        Exit Sub
                    End If
                End If

                If Cliente.Eliminar(RUC) Then
                    MessageBox.Show("El Socio ha sido eliminado")
                    VerTodos()
                Else
                    MessageBox.Show("Hubo un problema al eliminar al Socio")
                End If

            End If
        Else
            MessageBox.Show("Debe Seleccionar un Socio de la Lista")
        End If
    End Sub

    Private Sub VerFicha_Click(sender As Object, e As EventArgs) Handles pbxFicha.Click, pnlFicha.Click, lblFicha.Click
        Cursor.Current = Cursors.WaitCursor
        If TablaSelIndex >= 0 Then
            Dim row As Integer = dgvCliente.CurrentRow.Index
            Dim CI As String = CStr(TablaCli.Rows(row).Item(0))
            Dim Nombre As String = CStr(TablaCli.Rows(row).Item(1))
            Dim MembresiaNom As String
            Try
                MembresiaNom = CStr(TablaCli.Rows(row).Item(2))
            Catch
                MembresiaNom = ""
            End Try
            Dim Telefono As String = CStr(TablaCli.Rows(row).Item(3))
            Dim Aliass As String = CStr(TablaCli.Rows(row).Item(5))
            Dim Direccion As String = CStr(TablaCli.Rows(row).Item(6))
            Dim AccesoCod As String
            Try
                AccesoCod = CStr(TablaCli.Rows(row).Item(4))
            Catch
                AccesoCod = ""
            End Try
            Dim Foto As Byte()
            Try
                Foto = CType(TablaCli.Rows(row).Item(9), Byte())
            Catch
            End Try
            Dim FechaNac As String = CStr(TablaCli.Rows(row).Item(11))
            Dim Conocio As String = CStr(TablaCli.Rows(row).Item(12))
            Dim Saldo As Integer = CInt(TablaCli.Rows(row).Item(13))
            Dim Estado As String = CStr(TablaCli.Rows(row).Item(14))
            Dim Frm As New FSocioFicha(CI, Nombre, Telefono, Direccion, Aliass, Foto, FechaNac, Conocio, AccesoCod, Saldo)
            Frm.ShowDialog()
        Else
            MessageBox.Show("Debe Seleccionar un Socio de la Lista")
        End If
    End Sub

    Private Sub BtnCerrarForm_Click(sender As Object, e As EventArgs) Handles BtnCerrarForm.Click
        Close()
    End Sub

    Public Sub ModoVista()
        ModoVistaValue = True
        dgvCliente.Width = 421
        Me.Size = New Size(435, 416)
        pnlSeleccionar.Visible = True
        Memb.Visible = False
        Tel.Visible = False
        Acc.Visible = False
    End Sub

    Private Sub Seleccionar_Click(sender As Object, e As EventArgs) Handles lblSeleccionar.Click, pnlSeleccionar.Click, pbxSeleccionar.Click
        If TablaSelIndex >= 0 Then
            Dim row As Integer = dgvCliente.CurrentRow.Index
            Dim CI As String = CStr(TablaCli.Rows(row).Item(0))
            Dim Nombre As String = CStr(TablaCli.Rows(row).Item(1))
            RaiseEvent ClienteSeleccionado(CI, Nombre)
            Close()
        Else
            MessageBox.Show("Debe Seleccionar un Socio de la Lista")
        End If
    End Sub

    Private Sub dgvCliente_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCliente.CellClick
        Dim i As Integer = dgvCliente.CurrentRow.Index
        If TablaSelIndex >= 0 Then
            dgvCliente.Item(0, TablaSelIndex).Value = False
        End If
        dgvCliente.Item(0, i).Value = True
        TablaSelIndex = i
    End Sub

    Private Sub txtBuscar_KeyUp(sender As Object, e As KeyEventArgs) Handles txtBuscar.KeyUp
        Dim Param As String = txtBuscar.Text
        If Param = "" Then
            cmbVerPor.SelectedIndex = 0
        End If
    End Sub

    Private Sub cmbVerPor_Click(sender As Object, e As EventArgs) Handles cmbVerPor.Click

    End Sub
End Class