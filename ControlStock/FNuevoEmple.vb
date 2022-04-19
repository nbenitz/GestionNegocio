Option Strict On
Public Class FNuevoEmple
    Dim Emple As New CEmpleado
    Dim EditMode As Boolean = False
    Dim OldCI As Integer


    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Dim CI As Integer
        Dim Nombre As String = txtNombre.Text
        Dim Apellido As String = txtApellido.Text
        Dim Tel As String = txtTelefono.Text
        Dim Dir As String = txtDireccion.Text
        Dim Comision As Integer = 0
        Try
            Comision = CInt(txtComision.Text)
        Catch ex As Exception
        End Try
        Try
            CI = CInt(txtCI.Text)
            If Nombre <> "" Then
                If Apellido <> "" Then
                    If EditMode = False Then
                        If Emple.Insert(CI, Nombre, Apellido, Tel, Dir, Comision, "Activo") = True Then
                            MessageBox.Show("Empleado Guardado")
                            Limpiar()
                        Else
                            MessageBox.Show("Hubo un problema al Guardar el Empleado")
                        End If
                    Else
                        If Emple.Update(CI, Nombre, Apellido, Tel, Dir, Comision, OldCI) = True Then
                            MessageBox.Show("Empleado Editado")
                            Me.Close()
                        Else
                            MessageBox.Show("Hubo un problema al Editar el Empleado")
                        End If
                    End If
                Else
                    txtApellido.Focus()
                    ToolTip2.Show("Ingrese Apellido", txtApellido, 0, -40, 3000)
                End If
            Else
                txtNombre.Focus()
                ToolTip2.Show("Ingrese el Nombre", txtNombre, 0, -40, 3000)
            End If
        Catch
            txtCI.Focus()
            txtCI.Select(0, txtCI.Text.Length)
            ToolTip2.Show("Ingrese un Nro de CI válido", txtCI, 0, -40, 3000)
        End Try
    End Sub

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        Limpiar()
    End Sub

    Private Sub FNuevoEmple_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If EditMode = True Then
            btnNuevo.Visible = False
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
        txtApellido.Text = ""
        txtCI.Text = ""
        txtComision.Text = ""
        txtDireccion.Text = ""
        txtNombre.Text = ""
        txtTelefono.Text = ""
        txtCI.Focus()
    End Sub

    Public Sub Editar(ByVal CI As Integer, ByVal Nombre As String, ByVal Apellido As String, ByVal Tel As String, _
                      ByVal Dir As String, ByVal Comision As Integer)
        EditMode = True
        OldCI = CI
        txtCI.Text = CStr(CI)
        txtNombre.Text = Nombre
        txtApellido.Text = Apellido
        txtTelefono.Text = Tel
        txtDireccion.Text = Dir
        txtComision.Text = CStr(Comision)
        Me.Text = "Editar Empleado"
    End Sub

    Private Sub BtnCerrarForm_Click(sender As Object, e As EventArgs) Handles BtnCerrarForm.Click
        Me.Close()
    End Sub
End Class