Option Strict On

Public Class FLogin

    Dim ObjUsuario As New CUsuario
    Dim arrastre As Boolean
    Dim ex, ey As Integer

    Private Sub BtnEntrar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles BtnEntrar.Click
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
                DevolAutoriProv As Boolean

            Dim IdPrivFk As Integer = ObjUsuario.IdPrivFK(TxtUsername.Text)
            Dim CIEmple As Integer = ObjUsuario.IdEmpleFK(TxtUsername.Text)
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
                            DevolAutoriProv)
            frm.Show()
            Hide()
        Else
            MessageBox.Show("Por favor completa los campos")
        End If
    End Sub

    Private Sub FrmLogin_MouseDown(ByVal sender As System.Object, ByVal e As MouseEventArgs) Handles MyBase.MouseDown
        ex = e.X
        ey = e.Y
        arrastre = True
    End Sub

    Private Sub FrmLogin_MouseMove(ByVal sender As System.Object, ByVal e As MouseEventArgs) Handles MyBase.MouseMove
        If arrastre = True Then
            Cursor.Current = Cursors.NoMove2D
            Location = PointToScreen(New Point(MousePosition.X - Location.X - ex, MousePosition.Y - Location.Y - ey))
        End If
    End Sub

    Private Sub FrmLogin_MouseUp(ByVal sender As System.Object, ByVal e As MouseEventArgs) Handles MyBase.MouseUp
        arrastre = False
    End Sub

    Private Sub TxtPassword_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles TxtPassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            BtnEntrar_Click(Nothing, Nothing)
        End If
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        End
    End Sub

    Private Sub TxtPassword_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles TxtPassword.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            e.Handled = True
        End If
    End Sub

End Class
