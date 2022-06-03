Option Strict On
Option Explicit On
Imports System.Configuration

Public Class FLogin
    Dim appCfg As New CAppConfig
    Dim arrastre As Boolean
    Dim ex, ey As Integer

    Private Sub BtnEntrar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles BtnEntrar.Click
        Cursor.Current = Cursors.WaitCursor
        Dim ObjUsuario As New CUsuario
        Dim ExisteUsuario As Boolean
        ExisteUsuario = ObjUsuario.Verificar(TxtUsername.Text, TxtPassword.Text)
        If ExisteUsuario Then
            Dim ProdConsult,
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
                MembresiaAdmin,
                AccesoAdmin As Boolean

            Dim IdPrivFk As Integer = ObjUsuario.IdPrivFK(TxtUsername.Text)
            Dim CIEmple As Integer = ObjUsuario.IdEmpleFK(TxtUsername.Text)
            MCaja.EmpleadoCI = CStr(CIEmple)
            Dim TablaPriv As New DataTable
            TablaPriv = ObjUsuario.ConsultaPrivilegio(IdPrivFk)
            ProdConsult = CBool(TablaPriv.Rows(0).Item(2))
            ProdReg = CBool(TablaPriv.Rows(0).Item(3))
            ProdActualiz = CBool(TablaPriv.Rows(0).Item(4))
            ProdEliminar = CBool(TablaPriv.Rows(0).Item(5))
            VentasConsult = CBool(TablaPriv.Rows(0).Item(6))
            VentasReg = CBool(TablaPriv.Rows(0).Item(7))
            ComprasConsult = CBool(TablaPriv.Rows(0).Item(8))
            ComprasReg = CBool(TablaPriv.Rows(0).Item(9))
            ProvConsult = CBool(TablaPriv.Rows(0).Item(10))
            ProvReg = CBool(TablaPriv.Rows(0).Item(11))
            ProvActualiz = CBool(TablaPriv.Rows(0).Item(12))
            ProvEliminar = CBool(TablaPriv.Rows(0).Item(13))
            EmpleAdmin = CBool(TablaPriv.Rows(0).Item(14))
            UsuAdmin = CBool(TablaPriv.Rows(0).Item(15))
            FinanzasAdmin = CBool(TablaPriv.Rows(0).Item(16))
            HabAdmin = CBool(TablaPriv.Rows(0).Item(17))
            CuentasAdmin = CBool(TablaPriv.Rows(0).Item(18))
            DevolAutoriCli = CBool(TablaPriv.Rows(0).Item(19))
            DevolAutoriProv = CBool(TablaPriv.Rows(0).Item(20))
            MembresiaAdmin = CBool(TablaPriv.Rows(0).Item(21))
            AccesoAdmin = CBool(TablaPriv.Rows(0).Item(22))

            Dim Frm As New FPrincipal(CStr(CIEmple))
            Frm.Privilegios(ProdConsult,
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
                            MembresiaAdmin,
                            AccesoAdmin)
            Frm.Show()
            Hide()
        Else
            MessageBox.Show("Usuario o contraseña incorrectos")
        End If
    End Sub

    Private Sub FrmLogin_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles MyBase.MouseDown
        ex = e.X
        ey = e.Y
        arrastre = True
    End Sub

    Private Sub FrmLogin_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles MyBase.MouseMove
        If arrastre = True Then
            Cursor.Current = Cursors.NoMove2D
            Location = PointToScreen(New Point(MousePosition.X - Location.X - ex, MousePosition.Y - Location.Y - ey))
        End If
    End Sub

    Private Sub FrmLogin_MouseUp(ByVal sender As System.Object, ByVal e As MouseEventArgs) Handles MyBase.MouseUp
        arrastre = False
    End Sub

    Private Sub TxtPassword_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles TxtPassword.KeyDown, TxtUsername.KeyDown
        If e.KeyCode = Keys.Enter Then
            BtnEntrar_Click(Nothing, Nothing)
        End If
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        End
    End Sub

    Private Sub FLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Selecciono el Tipo de Archivo de Configuracion Web/App
        appCfg.ConfigType = Convert.ToInt32(ConfigFileType.AppConfig)


        Dim IsAdmin As String = appCfg.GetValue("admin", Type.GetType("System.String")).ToString

        Dim serverSelectedIndex As String = appCfg.GetValue("serverSelectedIndex", Type.GetType("System.String")).ToString

        cmbServidor.SelectedIndex = CInt(serverSelectedIndex)

        If IsAdmin <> "si" Then 'no admin
            cmbServidor.Enabled = False
        End If

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbServidor.SelectedIndexChanged

        Dim serverIp As String
        Dim deviceIp As String
        Dim devicePort As String

        Dim cmbIndex As Integer = cmbServidor.SelectedIndex
        Select Case cmbIndex
            Case 0  'conexion local
                serverIp = appCfg.GetValue("ServerIp", Type.GetType("System.String")).ToString
                deviceIp = appCfg.GetValue("deviceIp", Type.GetType("System.String")).ToString
                appCfg.SetValue("serverSelectedIndex", cmbIndex.ToString)
                devicePort = "80"
            Case 1  'conexion remoto 1
                serverIp = appCfg.GetValue("ServerIp1", Type.GetType("System.String")).ToString
                deviceIp = appCfg.GetValue("deviceIp1", Type.GetType("System.String")).ToString
                appCfg.SetValue("serverSelectedIndex", cmbIndex.ToString)
                devicePort = "8001"
            Case 2  'conexion remoto 2
                serverIp = appCfg.GetValue("ServerIp2", Type.GetType("System.String")).ToString
                deviceIp = appCfg.GetValue("deviceIp2", Type.GetType("System.String")).ToString
                appCfg.SetValue("serverSelectedIndex", cmbIndex.ToString)
                devicePort = "8001"
        End Select

        appCfg.SetValue("server",
                        "server=" + serverIp + ";user id=remote;password=1223;database=minegocio")

        appCfg.SetConnStrValue("minegocioEntities",
                               "metadata=res://*/DB.csdl|res://*/DB.ssdl|res://*/DB.msl;provider=MySql.Data.MySqlClient;provider connection string=" & Chr(34) & "server=" + serverIp + ";user id=remote;password=1223;persistsecurityinfo=True;database=minegocio" & Chr(34))

        appCfg.SetValue("device", deviceIp)
        appCfg.SetValue("devicePort", devicePort)

        Dim serverSelectedIndex As String = appCfg.GetValue("serverSelectedIndex", Type.GetType("System.String")).ToString

        If CInt(serverSelectedIndex) <> cmbServidor.SelectedIndex Then
            Application.Restart()
        End If
    End Sub

    Private Sub TxtPassword_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles TxtPassword.KeyPress, TxtUsername.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            e.Handled = True
        End If
    End Sub


End Class
