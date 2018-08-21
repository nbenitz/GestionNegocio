Option Strict On
Public Class FListaEmple
    Dim Empleado As New CEmpleado
    Dim Usuario As New CUsuario
    Dim TablaEmple As DataTable
    Dim ModoNuevoUsuValue As Boolean = False

    Private Sub FListaEmpleados_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cmbVerPor.SelectedIndex = 0
    End Sub

    Private Sub Form1_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        Dim strEstado As String = Me.WindowState.ToString()
        If strEstado = "Maximized" Then
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub F_Deactivate(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Deactivate
        Me.WindowState = FormWindowState.Minimized
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
            For i = 0 To (Filas - 1)
                Dim CI As Integer = CInt(Tabla.Rows(i).Item(0))
                Dim Nombre As String = CStr(Tabla.Rows(i).Item(1))
                Dim Apellido As String = CStr(Tabla.Rows(i).Item(2))
                Dim Tel As String = CStr(Tabla.Rows(i).Item(3))
                Dim Dir As String = CStr(Tabla.Rows(i).Item(4))
                Dim Comision As Integer = CInt(Tabla.Rows(i).Item(5))
                DataGridView1.Rows.Add(CI, Nombre, Apellido, Tel, Dir, Comision)
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
            Case Is = 2 'Apellido
                MostrarCaja("Ingrese el Apellido")
            Case Is = 3 'CI
                MostrarCaja("Ingrese Nro de CI")
        End Select
    End Sub

    Private Sub txtBuscar_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtBuscar.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim Param As String = txtBuscar.Text
            If Param <> "" Then
                Select Case cmbVerPor.SelectedIndex
                    Case Is = 1 'Nombre
                        TablaEmple = Empleado.Buscar("WHERE Nombre like '%" + Param + "%' AND Estado = 'Activo'")
                    Case Is = 2 'Apellido
                        TablaEmple = Empleado.Buscar("WHERE Apellido like '%" + Param + "%' AND Estado = 'Activo'")
                    Case Is = 3 'CI
                        Try
                            TablaEmple = Empleado.Buscar("WHERE Estado = 'Activo' AND CI = " + Param)
                        Catch ex As Exception
                            MessageBox.Show("No hay coincidencias")
                        End Try
                End Select
                CargarTabla(TablaEmple)
            End If
        End If
    End Sub

    Private Sub txtBuscar_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBuscar.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        Dim frm As New FNuevoEmple
        frm.MaximizeBox = False
        frm.MinimizeBox = False
        frm.ShowDialog()
    End Sub

    Private Sub btnActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActualizar.Click
        VerTodos()
    End Sub

    Private Sub VerTodos()
        TablaEmple = Empleado.Buscar("WHERE Estado = 'Activo'")
        CargarTabla(TablaEmple)
    End Sub

    Public WriteOnly Property ModoNuevoUsu() As Boolean
        Set(ByVal value As Boolean)
            ModoNuevoUsuValue = value
            If value Then
                PnlEliminar.Visible = False
                pnlEditar.Visible = False
                pnlNuevoUsu.Visible = True
                MessageBox.Show("Seleccione un Empleado de la Lista para el cual desea crear un Usuario")
            End If
        End Set
    End Property

    Private Sub pbxEditar_Click(sender As Object, e As EventArgs) Handles pbxEditar.Click, pnlEditar.Click, lblEditar.Click
        Try
            Dim row As Integer = DataGridView1.CurrentRow.Index
            Dim CI As Integer = CInt(TablaEmple.Rows(row).Item(0))
            Dim Tabla As DataTable = Empleado.Buscar("WHERE ci = " + CStr(CI))
            Dim Nombre As String = CStr(Tabla.Rows(0).Item(1))
            Dim Apellido As String = CStr(Tabla.Rows(0).Item(2))
            Dim Telefono As String = CStr(Tabla.Rows(0).Item(3))
            Dim Direccion As String = CStr(Tabla.Rows(0).Item(4))
            Dim Comision As Integer = CInt(Tabla.Rows(0).Item(5))
            Dim frm As New FNuevoEmple
            frm.Editar(CI, Nombre, Apellido, Telefono, Direccion, Comision)
            frm.MaximizeBox = False
            frm.MinimizeBox = False
            frm.ShowDialog()
            VerTodos()
        Catch ex As Exception
            MessageBox.Show("Debe Seleccionar un Empleado de la Lista")
        End Try
    End Sub

    Private Sub LblEliminar_Click(sender As Object, e As EventArgs) Handles LblEliminar.Click, PbxEliminar.Click, PnlEliminar.Click
        Try
            Dim Result As Integer = MsgBox("Desea dar de baja al Empleado seleccionado?", MsgBoxStyle.YesNo, "Baja de Empleado")
            If Result = 6 Then
                Dim row As Integer = DataGridView1.CurrentRow.Index
                Dim CI As Integer = CInt(TablaEmple.Rows(row).Item(0))
                Dim Tabla As DataTable = Me.Usuario.Buscar(CI)
                Dim IdUsu As Integer = CInt(Tabla.Rows(0).Item(0))
                If Empleado.Baja(CI) And Usuario.Eliminar(IdUsu) Then
                    MessageBox.Show("El Empleado ha sido dado de Baja")
                    VerTodos()
                Else
                    MessageBox.Show("Hubo un problema al dar de Baja el Empleado")
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Debe Seleccionar un Empleado de la Lista")
        End Try
    End Sub

    Private Sub lblNuevoUsu_Click(sender As Object, e As EventArgs) Handles lblNuevoUsu.Click, pnlNuevoUsu.Click, PbxNuevoUsu.Click
        Try
            Dim row As Integer = DataGridView1.CurrentRow.Index
            Dim CI As Integer = CInt(TablaEmple.Rows(row).Item(0))
            Dim frm As New FNuevoUsuario
            If Usuario.VerificarCI(CI) Then
                MessageBox.Show("Ya existe un Usuario para el Empleado seleccionado")
                Dim Tabla As DataTable = Usuario.Buscar(CI)
                Dim IdUsu As Integer = CInt(Tabla.Rows(0).Item(0))
                Dim Usu As String = CStr(Tabla.Rows(0).Item(1))
                Dim Pass As String = CStr(Tabla.Rows(0).Item(2))
                Dim Priv As String = CStr(Tabla.Rows(0).Item(3))
                frm.Editar(IdUsu, Usu, Pass, Priv, CI)
            Else
                frm.txtEmpleado.Text = CStr(CI)
            End If
            frm.MaximizeBox = False
            frm.MinimizeBox = False
            frm.ShowDialog()
        Catch ex As Exception
            MessageBox.Show("Debe Seleccionar un Empleado de la Lista")
        End Try
    End Sub

End Class