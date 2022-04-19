Option Strict On
Option Explicit On

Public Class FListaSocio
    Dim Cliente As New CCliente
    Dim oMembresia As New CMembresia
    Dim oAcceso As New CAcceso
    Dim TablaCli As DataTable
    Dim ModoVistaValue As Boolean = False
    Public Event ClienteSeleccionado(ByVal CI As String, ByVal Nombre As String)

    Private Sub FListaSocio_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Not ModoVistaValue Then
            cmbVerPor.SelectedIndex = 0
        Else
            cmbVerPor.SelectedIndex = 2
        End If
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
        dgvCliente.Rows.Clear()
        If Filas > 0 Then
            For i As Integer = 0 To (Filas - 1)
                Dim RUC As String = CStr(Tabla.Rows(i).Item(0))
                Dim Nombre As String = CStr(Tabla.Rows(i).Item(1))
                Dim MembresiaNom As String = ""
                Try
                    MembresiaNom = CStr(Tabla.Rows(i).Item(2))
                Catch
                End Try
                Dim Tel As String = CStr(Tabla.Rows(i).Item(3))
                Dim AccesoCod As String = ""
                Try
                    AccesoCod = CStr(Tabla.Rows(i).Item(4))
                Catch
                End Try

                dgvCliente.Rows.Add(RUC, Nombre, MembresiaNom, Tel, AccesoCod)
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
                        TablaCli = Cliente.BuscSocio("WHERE Nombre like '%" + Param + "%'")
                    Case Is = 2 'RUC
                        Try
                            TablaCli = Cliente.BuscSocio("WHERE Cedula like '%" + Param + "%'")
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
        Actualizar()
    End Sub

    Private Sub btnActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActualizar.Click
        Actualizar()
    End Sub

    Private Sub VerTodos()
        TablaCli = Cliente.BuscSocio("")
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
        Cursor.Current = Cursors.WaitCursor
        Try
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
            Dim AccesoCod As String
            Try
                AccesoCod = CStr(TablaCli.Rows(row).Item(4))
            Catch
                AccesoCod = ""
            End Try
            Dim Aliass As String = CStr(TablaCli.Rows(row).Item(5))
            Dim Direccion As String = CStr(TablaCli.Rows(row).Item(6))
            Dim FechaInicio As Date = CDate(TablaCli.Rows(row).Item(7))
            Dim Foto As Byte()
            Try
                Foto = CType(TablaCli.Rows(row).Item(8), Byte())
            Catch
            End Try
            Dim FechaNac As Date = CDate(TablaCli.Rows(row).Item(10))
            Dim Frm As New FNuevoSocio
            Frm.Editar(CI, Nombre, Telefono, Direccion, Aliass, Foto, FechaNac, MembresiaNom, FechaInicio, AccesoCod)
            Frm.ShowDialog()
            Actualizar()
        Catch ex As Exception
            MessageBox.Show("Debe Seleccionar un Socio de la Lista" + ex.Message)
        End Try
    End Sub

    Private Sub LblEliminar_Click(sender As Object, e As EventArgs) Handles LblEliminar.Click, PbxEliminar.Click, PnlEliminar.Click
        Try
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
                    If oMembresia.EliminarClienteMembresia(RUC) = False Then
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
        Catch ex As Exception
            MessageBox.Show("Debe Seleccionar un Socio de la Lista")
        End Try
    End Sub

    Private Sub VerFicha_Click(sender As Object, e As EventArgs) Handles pbxFicha.Click, pnlFicha.Click, lblFicha.Click
        Cursor.Current = Cursors.WaitCursor
        Try
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
            Dim Vto As String = CStr(CDate(TablaCli.Rows(row).Item(7)).AddMonths(1))
            Dim AccesoCod As String
            Try
                AccesoCod = CStr(TablaCli.Rows(row).Item(4))
            Catch
                AccesoCod = ""
            End Try
            Dim Foto As Byte()
            Try
                Foto = CType(TablaCli.Rows(row).Item(8), Byte())
            Catch
            End Try
            Dim FechaNac As String = CStr(TablaCli.Rows(row).Item(10))
            Dim Frm As New FSocioFicha(CI, Nombre, Telefono, Direccion, Aliass, Foto, FechaNac, MembresiaNom, Vto, AccesoCod)
            Frm.ShowDialog()
        Catch ex As Exception
            MessageBox.Show("Debe Seleccionar un Socio de la Lista")
        End Try
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
        Try
            Dim row As Integer = dgvCliente.CurrentRow.Index
            Dim CI As String = CStr(TablaCli.Rows(row).Item(0))
            Dim Nombre As String = CStr(TablaCli.Rows(row).Item(1))
            RaiseEvent ClienteSeleccionado(CI, Nombre)
            Close()
        Catch ex As Exception
            MessageBox.Show("Debe Seleccionar un Socio de la Lista")
        End Try
    End Sub

End Class