

Public Class FNuevoPrivilegio
    Dim Usuario As New CUsuario
    Dim IdPrivilegio As Integer
    Dim EditMode As Boolean

    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub BtnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Dim Rol As String = TxtNombre.Text
        Dim ProdConsult As Boolean = CkbProdConsult.Checked
        Dim ProdReg As Boolean = CkbProdReg.Checked
        Dim ProdActualiz As Boolean = CkbProdAct.Checked
        Dim ProdEliminar As Boolean = CkbProdElim.Checked
        Dim VentasConsult As Boolean = CkbVentConsul.Checked
        Dim VentasReg As Boolean = CkbVentReg.Checked
        Dim ComprasConsult As Boolean = CkbCompCons.Checked
        Dim ComprasReg As Boolean = CkbCompReg.Checked
        Dim ProvConsult As Boolean = CkbProvCons.Checked
        Dim ProvReg As Boolean = CkbProvReg.Checked
        Dim ProvActualiz As Boolean = CkbProvAct.Checked
        Dim ProvEliminar As Boolean = CkbProvElim.Checked
        Dim EmpleAdmin As Boolean = CkbEmp.Checked
        Dim UsuAdmin As Boolean = CkbUsu.Checked
        Dim FinanzasAdmin As Boolean = CkbFinanz.Checked
        Dim HabAdmin As Boolean = CkbHab.Checked
        Dim CuentasAdmin As Boolean = CkbCuent.Checked
        Dim DevolAutoriCli As Boolean = CkbDevCli.Checked
        Dim DevolAutoriProv As Boolean = CkbDevProv.Checked
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
                                            DevolAutoriProv, 0, 0) Then
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
                                            DevolAutoriProv, 0, 0,
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

    Private Sub BtnCerrarForm_Click(sender As Object, e As EventArgs) Handles BtnCerrarForm.Click
        Me.Close()
    End Sub
End Class