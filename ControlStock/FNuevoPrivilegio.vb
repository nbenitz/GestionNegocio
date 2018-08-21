Option Strict On

Public Class FNuevoPrivilegio
    Dim Usuario As New CUsuario
    Dim IdPrivilegio As Integer
    Dim EditMode As Boolean

    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub BtnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Dim Rol As String = TxtNombre.Text
        Dim ProdConsult = CkbProdConsult.Checked
        Dim ProdReg = CkbProdReg.Checked
        Dim ProdActualiz = CkbProdAct.Checked
        Dim ProdEliminar = CkbProdElim.Checked
        Dim VentasConsult = CkbVentConsul.Checked
        Dim VentasReg = CkbVentReg.Checked
        Dim ComprasConsult = CkbCompCons.Checked
        Dim ComprasReg = CkbCompReg.Checked
        Dim ProvConsult = CkbProvCons.Checked
        Dim ProvReg = CkbProvReg.Checked
        Dim ProvActualiz = CkbProvAct.Checked
        Dim ProvEliminar = CkbProvElim.Checked
        Dim EmpleAdmin = CkbEmp.Checked
        Dim UsuAdmin = CkbUsu.Checked
        Dim FinanzasAdmin = CkbFinanz.Checked
        Dim HabAdmin = CkbHab.Checked
        Dim CuentasAdmin = CkbCuent.Checked
        Dim DevolAutoriCli = CkbDevCli.Checked
        Dim DevolAutoriProv = CkbDevProv.Checked
        If Rol <> "" Then
            If EditMode = False Then
                If Usuario.InsertPrivilegio(Rol,
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
                                            DevolAutoriProv) Then
                    MessageBox.Show("Nivel de Privilegio Agregado")
                    Me.Close()
                Else
                    MessageBox.Show("Hubo un problema al agregar el Nivel de Privilegio")
                End If
            Else
                If Usuario.UpdatePrivilegio(Rol,
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
                                            IdPrivilegio) Then
                    MessageBox.Show("Nivel de Privilegio Editado")
                    Me.Close()
                Else
                    MessageBox.Show("Hubo un problema al editar el Nivel de Privilegio")
                End If
            End If
                Else
            MessageBox.Show("Ingrese un Nombre para el Nivel de Privilegio")
        End If
    End Sub

    Public Sub Editar(ByVal Rol As String,
                      ByVal ProdConsult As Boolean,
                      ByVal ProdReg As Boolean,
                      ByVal ProdEdit As Boolean,
                      ByVal ProdEliminar As Boolean,
                      ByVal VentasConsult As Boolean,
                      ByVal VentasReg As Boolean,
                      ByVal ComprasConsult As Boolean,
                      ByVal ComprasReg As Boolean,
                      ByVal ProvConsult As Boolean,
                      ByVal ProvReg As Boolean,
                      ByVal ProvEdit As Boolean,
                      ByVal ProvEliminar As Boolean,
                      ByVal EmpleAdmin As Boolean,
                      ByVal UsuAdmin As Boolean,
                      ByVal FinanzasAdmin As Boolean,
                      ByVal HabAdmin As Boolean,
                      ByVal CuentasAdmin As Boolean,
                      ByVal DevolAutoriCli As Boolean,
                      ByVal DevolAutoriProv As Boolean,
                      ByVal IdPriv As Integer)
        EditMode = True
        TxtNombre.Text = Rol
        CkbProdConsult.Checked = ProdConsult
        CkbProdReg.Checked = ProdReg
        CkbProdAct.Checked = ProdEdit
        CkbProdElim.Checked = ProdEliminar
        CkbVentConsul.Checked = VentasConsult
        CkbVentReg.Checked = VentasReg
        CkbCompCons.Checked = ComprasConsult
        CkbCompReg.Checked = ComprasReg
        CkbProvCons.Checked = ProvConsult
        CkbProvReg.Checked = ProvReg
        CkbProvAct.Checked = ProvEdit
        CkbProvElim.Checked = ProvEliminar
        CkbEmp.Checked = EmpleAdmin
        CkbUsu.Checked = UsuAdmin
        CkbFinanz.Checked = FinanzasAdmin
        CkbHab.Checked = HabAdmin
        CkbCuent.Checked = CuentasAdmin
        CkbDevCli.Checked = DevolAutoriCli
        CkbDevProv.Checked = DevolAutoriProv
        IdPrivilegio = IdPriv
        Text = "Editar Nivel de Privilegio"
    End Sub

End Class