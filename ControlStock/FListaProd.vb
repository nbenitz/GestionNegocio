﻿Option Strict On
Public Class FListaProd
    Dim Producto As New CProducto
    Dim Prov As New CProveedor
    Dim TablaProv As New DataTable
    Dim TablaProd As New DataTable
    Dim Orden As String = " ORDER BY Descripcion"
    Dim Condicion As String = "WHERE idproducto = 0"

    Private Sub TcmbFiltrarPor_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles TCmbFiltrarPor.Click
        TCmbFiltrarPor.DroppedDown = True
    End Sub

    Private Sub TcmbFiltrarPor_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TCmbFiltrarPor.SelectedIndexChanged
        Dim Indice As Integer = TCmbFiltrarPor.SelectedIndex
        Select Case Indice
            Case Is = 0 'Todos
                TtxtBuscar.Visible = False
                TCmbProveedor.Visible = False
                TCmbStock.Visible = True
                TlblStock.Visible = True
                TtxtUnidad.Visible = False
                lblOrden.Visible = True
                cmbOrden.Visible = True
                TablaProd = Producto.BuscProd("Stock", ">=", "0", Orden)
                Condicion = "WHERE Stock >= 0"
                CargarTabla(TablaProd)
            Case Is = 1 'Proveedores
                TtxtBuscar.Visible = False
                TCmbProveedor.Visible = True
                TCmbStock.Visible = True
                TlblStock.Visible = True
                lblOrden.Visible = True
                cmbOrden.Visible = True
                TablaProv = Prov.ListarProveed()
                TCmbProveedor.Items.Clear()
                TCmbProveedor.Text = ""
                Dim Filas As Integer = TablaProv.Rows.Count
                If Filas > 0 Then
                    For i = 0 To (Filas - 1)
                        TCmbProveedor.Items.Add(TablaProv.Rows(i).Item(1))
                    Next
                End If
                ToolTip1.Show("Lista de Proveedores", lblAux, 0, -23, 1000)
                Me.Timer1.Enabled = True
            Case Is = 2 'Código
                lblOrden.Visible = False
                cmbOrden.Visible = False
                MostrarCaja("Ingrese el Código")
            Case Is = 3 'Descripción
                lblOrden.Visible = True
                cmbOrden.Visible = True
                MostrarCaja("Ingrese la Descripión")
        End Select
    End Sub

    Private Sub frmConsultaProd_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cmbOrden.SelectedIndex = 1
        TCmbFiltrarPor.SelectedItem = "Código"
    End Sub

    Private Sub TcmbStock_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles TCmbStock.Click
        TCmbStock.DroppedDown = True
    End Sub

    Private Sub TcmbStock_DropDownClosed(ByVal sender As Object, ByVal e As System.EventArgs) Handles TCmbStock.DropDownClosed
        Dim Indice As Integer = TCmbStock.SelectedIndex
        Select Case Indice
            Case Is = 0 'Todos"                
            Case Else  'Menor o Igual a, Mayor o Igual a
                TtxtUnidad.Visible = True
                TtxtUnidad.Text = ""
                TtxtUnidad.Focus()
                If TCmbProveedor.Visible = False Then
                    ToolTip1.Show("Cantidad en Unidades", lblAux2, 0, -8, 1500)
                Else
                    ToolTip1.Show("Cantidad en Unidades", lblAux3, 0, -8, 1500)
                End If
        End Select
    End Sub

    Private Sub TcmbStock_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TCmbStock.SelectedIndexChanged
        Dim Indice As Integer = TCmbStock.SelectedIndex
        Select Case Indice
            Case Is = 0 'Todos"
                TtxtUnidad.Visible = False
                TablaProd = Producto.BuscProd("Stock", ">=", "0", Orden)
                Condicion = "WHERE Stock >= 0"
                CargarTabla(TablaProd)
            Case Else  'Menor o Igual a, Mayor o Igual a
                TtxtUnidad.Visible = True
        End Select
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        TCmbProveedor.Focus()
        TCmbProveedor.DroppedDown = True
        Timer1.Stop()
    End Sub

    Private Sub MostrarCaja(ByVal Titulo As String)
        TCmbProveedor.Visible = False
        TtxtBuscar.Visible = True
        TCmbStock.Visible = False
        TlblStock.Visible = False
        TtxtUnidad.Visible = False
        ToolTip1.Show(Titulo, lblAux, 0, -8, 1200)
        TtxtBuscar.Focus()
    End Sub

    Private Sub TcmbProveedor_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles TCmbProveedor.Click
        TCmbProveedor.DroppedDown = True
    End Sub

    Private Sub TcmbProveedor_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TCmbProveedor.SelectedIndexChanged
        Dim Indice As Integer = TCmbProveedor.SelectedIndex
        If Indice >= 0 Then
            Dim ProvFK As String = CStr(TablaProv.Rows(Indice).Item(1))
            TablaProd = Producto.BuscProd("ProveedorFK", "=", ProvFK, Orden)
            Condicion = "WHERE ProveedorFK = '" + ProvFK + "'"
            CargarTabla(TablaProd)
        End If
    End Sub

    Private Sub TtxtUnidad_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TtxtUnidad.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim Operador As String = ""
            Dim Unid As String = TtxtUnidad.Text
            If Unid <> "" Then
                Select Case TCmbStock.SelectedIndex
                    Case Is = 1 'Menor o Igual a
                        Operador = "<="
                    Case Is = 2 'Mayor o Igual a
                        Operador = ">="
                End Select
                Select Case TCmbFiltrarPor.SelectedIndex
                    Case Is = 0 'Todos
                        TablaProd = Producto.BuscProd("Stock", Operador, Unid, Orden)
                        Condicion = "WHERE Stock" + Operador + Unid
                    Case Is = 1 'Proveedor
                        Dim Indice As Integer = TCmbProveedor.SelectedIndex
                        Dim ProvFK As String = CStr(TablaProv.Rows(Indice).Item(1))
                        TablaProd = Producto.BuscProd("ProveedorFK", ProvFK, "Stock", Operador, Unid + Orden)
                        Condicion = "WHERE ProveedorFK='" + ProvFK + "' AND Stock" + Operador + Unid
                End Select
                CargarTabla(TablaProd)
            End If
        End If
    End Sub

    Private Sub CargarTabla(ByVal Tabla As DataTable) 'se tabla contiene los datos del view viewproducto
        Cursor.Current = Cursors.WaitCursor
        Dim CostoTotal As Integer = 0
        Dim SinCosto As Integer = 0
        Dim Filas As Integer = Tabla.Rows.Count
        DataGridView1.Rows.Clear()
        If Filas > 0 Then
            For i = 0 To (Filas - 1)
                Dim idProd As UInt64 = CULng(Tabla.Rows(i).Item(0))
                Dim Prov As String = CStr(Tabla.Rows(i).Item(1))
                Dim Descrip As String = CStr(Tabla.Rows(i).Item(2))
                Dim PCompra As Integer = CInt(Tabla.Rows(i).Item(3))
                Dim PVenta As Integer = CInt(Tabla.Rows(i).Item(4))
                Dim PVenta2 As Integer
                Dim Stock As Double = CDbl(Tabla.Rows(i).Item(6))
                Dim TablaAux As DataTable = Producto.BuscProdCod(CStr(idProd))
                If CStr(TablaAux.Rows(0).Item(10)) = "Si" Then
                    PVenta2 = CInt(TablaAux.Rows(0).Item(7))
                Else
                    PVenta2 = CInt(Tabla.Rows(i).Item(5))
                End If
                DataGridView1.Rows.Add(idProd, Prov, Descrip, PCompra, PVenta, PVenta2, Stock)
                CostoTotal = CInt(CostoTotal + PCompra * Stock)
                If PCompra = 0 Then
                    SinCosto += 1
                End If
            Next
        End If
        lblResultados.Text = "- Resultados: " + Format(Filas, "###,##0")
        LblCosto.Text = "    - Costo de Inversión: " + Format(CostoTotal, "###,##0") + " Gs."
        lblSinCosto.Text = "    - Productos sin Costo: " + Format(SinCosto, "###,##0")
    End Sub

    Private Sub TtxtBuscar_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TtxtBuscar.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim Param As String = TtxtBuscar.Text
            If Param <> "" Then
                Select Case TCmbFiltrarPor.SelectedIndex
                    Case Is = 2 '"Código"
                        Dim Cod As UInt64
                        Try
                            Cod = CULng(TtxtBuscar.Text)
                        Catch ex As Exception
                            TtxtBuscar.Text = ""
                            ToolTip1.Show("El código debe ser numérico", lblAux, 0, -8, 1200)
                            Exit Sub
                        End Try
                        TablaProd = Producto.BuscProd("idproducto", "=", CStr(Cod), "")
                        Condicion = "WHERE idproducto = " + CStr(Cod)
                        Dim Filas As Integer = TablaProd.Rows.Count
                        If Filas > 0 Then
                            CargarTabla(TablaProd)
                            TtxtBuscar.Select(0, TtxtBuscar.TextLength)
                            Exit Sub
                        Else
                            MessageBox.Show("El Código no existe")
                            TtxtBuscar.Select(0, TtxtBuscar.TextLength)
                        End If
                    Case Is = 3 '"Descripción"
                        TablaProd = Producto.BuscProd("WHERE Descripcion like '%" + Param + "%'" + Orden)
                        Condicion = "WHERE Descripcion like '%" + Param + "%'"
                        CargarTabla(TablaProd)
                End Select
            End If
        End If
    End Sub

    Private Sub txtBuscar_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TtxtBuscar.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TbtnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TbtnNuevo.Click
        Dim frm As New FNuevoProducto
        ''frm.MaximizeBox = False
        ''frm.MinimizeBox = False
        frm.MdiParent = Me.MdiParent
        ''frm.StartPosition = FormStartPosition.CenterParent
        frm.Show()
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        TtxtBuscar.Focus()
        Timer2.Enabled = False
    End Sub

    Private Sub TtxtUnidad_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TtxtUnidad.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            e.Handled = True
        End If
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Actualizar()
    End Sub

    Private Sub Actualizar()
        TablaProd = Producto.BuscProd(Condicion + Orden)
        CargarTabla(TablaProd)
    End Sub

    Private Sub cmbOrden_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbOrden.SelectedIndexChanged
        Select Case cmbOrden.SelectedIndex
            Case Is = 0 'Codigo
                Orden = " ORDER BY idProducto"
            Case Is = 1 'Descripcion
                Orden = " ORDER BY Descripcion"
        End Select
        TablaProd = Producto.BuscProd(Condicion + Orden)
        CargarTabla(TablaProd)
    End Sub

    Private Sub F_Deactivate(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Deactivate
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Form1_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        Dim strEstado As String = Me.WindowState.ToString()
        If strEstado = "Maximized" Then
            WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub FListaProd_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        WindowState = FormWindowState.Normal
        Actualizar()
    End Sub

    Private Sub pbxEditar_Click(sender As Object, e As EventArgs) Handles pbxEditar.Click, pnlEditar.Click, lblEditar.Click
        Try
            Dim row As Integer = DataGridView1.CurrentRow.Index
            Dim Cod As UInt64 = CULng(TablaProd.Rows(row).Item(0))
            Dim idProv As String = CStr(TablaProd.Rows(row).Item(1))
            Dim Tabla As DataTable = Producto.BuscProdCod(CStr(Cod))
            Dim Descrip As String = CStr(Tabla.Rows(0).Item(2))
            Dim Costo As Integer = CInt(Tabla.Rows(0).Item(3))
            Dim PrecioUnit As Integer = CInt(Tabla.Rows(0).Item(4))
            Dim PrecioUnit2 As Integer = CInt(Tabla.Rows(0).Item(5))
            Dim PrecioUnit3 As Integer = CInt(Tabla.Rows(0).Item(6))
            Dim PrecioPack? As Integer = Nothing
            Dim Stock As Double = CDbl(Tabla.Rows(0).Item(8))
            Dim UnidXpack? As Integer = Nothing
            Dim PorPack As String = CStr(Tabla.Rows(0).Item(10))
            Dim Foto As Byte()
            Dim Iva As Decimal = CDec(Tabla.Rows(0).Item(12))
            If PorPack = "Si" Then
                PrecioPack = CInt(Tabla.Rows(0).Item(7))
                UnidXpack = CInt(Tabla.Rows(0).Item(9))
            End If
            Try
                Foto = CType(Tabla.Rows(0).Item(11), Byte())
            Catch
                Foto = ImageToByteArray(My.Resources.Foto)
            End Try
            Dim frm As New FNuevoProducto
            frm.Text = "Editar Producto"
            frm.Editar(Cod, idProv, Descrip, Costo, PrecioUnit, PrecioUnit2, PrecioUnit3, PrecioPack, Stock, UnidXpack, PorPack, Foto, Iva)
            frm.MdiParent = MdiParent
            frm.Show()
        Catch ex As Exception
            MessageBox.Show("Debe Seleccionar un Producto de la Lista")
        End Try

    End Sub

    Private Sub LblEliminar_Click(sender As Object, e As EventArgs) Handles LblEliminar.Click, PbxEliminar.Click, PnlEliminar.Click
        Try
            Dim Result As Integer = MsgBox("Desea eliminar el Producto seleccionado?", MsgBoxStyle.YesNo, "Eliminar Proveedor")
            If Result = 6 Then
                Dim row As Integer = DataGridView1.CurrentRow.Index
                Dim Cod As String = CStr(TablaProd.Rows(row).Item(0))
                If Producto.Eliminar(Cod) Then
                    MessageBox.Show("El Producto ha sido eliminado")
                    Actualizar()
                Else
                    MessageBox.Show("Hubo un problema al eliminar el Producto")
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Debe Seleccionar un Producto de la Lista")
        End Try
    End Sub
End Class