Public Class FNuevoUsuario
    Dim Usuario As New CUsuario
    Dim TablaPriv As New DataTable
    Dim EditMode As Boolean = False
    Dim IdUsuValue As Integer


    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Dim Usu As String = txtUsuario.Text
        Dim Pass As String = txtPass.Text
        Dim Empleado As Integer = CInt(txtEmpleado.Text)
        If Usu <> "" Then
            If Pass <> "" Then
                If cmbPrivilegio.Text <> "" Then
                    Dim idPriv As Integer = CInt(TablaPriv.Rows(cmbPrivilegio.SelectedIndex).Item(0))
                    If EditMode = False Then
                        If Usuario.Insertar(Usu, Pass, idPriv, Empleado) = True Then
                            MessageBox.Show("Usuario Guardado")
                            Close()
                        Else
                            MessageBox.Show("Hubo un problema al Guardar el Usuario. Intente con otro Nombre de Usuario")
                        End If
                    Else
                        If Usuario.Actualizar(IdUsuValue, Usu, Pass, idPriv, Empleado) = True Then
                            MessageBox.Show("Usuario Guardado")
                            Close()
                        Else
                            MessageBox.Show("Hubo un problema al Guardar el Usuario. Intente con otro Nombre de Usuario")
                        End If
                    End If
                Else
                    cmbPrivilegio.Focus()
                    ToolTip2.Show("Ingrese el Nivel de Privilegio", cmbPrivilegio, 0, -40, 3000)
                End If
            Else
                txtPass.Focus()
                ToolTip2.Show("Ingrese la Contraseña", txtPass, 0, -40, 3000)
            End If
        Else
            txtUsuario.Focus()
            ToolTip2.Show("Ingrese el Usuario", txtUsuario, 0, -40, 3000)
        End If

    End Sub

    Private Sub FNuevoEmple_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If EditMode = False Then
            CargarPriv()
            cmbPrivilegio.SelectedIndex = 0
        End If
        ToolTip2.IsBalloon = True
    End Sub

    Private Sub Form1_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        Dim strEstado As String = Me.WindowState.ToString()
        If strEstado = "Maximized" Then
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub F_Deactivate(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Deactivate
        'Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        If EditMode = True Then
            Me.Close()
        Else
            Limpiar()
        End If
    End Sub

    Private Sub Limpiar()
        txtUsuario.Text = ""
        txtPass.Text = ""
        txtEmpleado.Text = ""
        txtUsuario.Focus()
    End Sub

    Public Sub Editar(ByVal idUsu As Integer, ByVal Usu As String, ByVal Pass As String, ByVal Priv As String,
                      ByVal idEmple As Integer)
        EditMode = True
        IdUsuValue = idUsu
        txtUsuario.Text = Usu
        txtPass.Text = Pass
        CargarPriv()
        cmbPrivilegio.SelectedItem = Priv
        txtEmpleado.Text = CStr(idEmple)
        Me.Text = "Editar Usuario"
    End Sub

    Private Sub CargarPriv()
        cmbPrivilegio.Items.Clear()
        TablaPriv = Usuario.ListarPrivilegio()
        Dim Filas As Integer = TablaPriv.Rows.Count
        If Filas > 0 Then
            For i  As Integer = 0 To (Filas - 1)
                cmbPrivilegio.Items.Add(TablaPriv.Rows(i).Item(1))
            Next
        End If
    End Sub

    Private Sub cmbProveedor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbPrivilegio.KeyPress
        e.Handled = True
    End Sub

    Private Sub pbxNewProv_Click(sender As Object, e As EventArgs) Handles pbxNewProv.Click

    End Sub

    Private Sub BtnCerrarForm_Click(sender As Object, e As EventArgs) Handles BtnCerrarForm.Click
        Me.Close()
    End Sub
End Class