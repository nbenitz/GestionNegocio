Option Strict On

Imports System.Drawing.Drawing2D

Public Class FNuevoProducto

    Dim Producto As New CProducto
    Dim Proveedor As New CProveedor
    Dim TablaProv As New DataTable
    Dim TablaCateg As New DataTable
    Dim FrmAjustesPrecio As New FAjustesPrecio
    Dim EditMode As Boolean = False
    Dim OldIdProd As String
    Dim ModoVerDetValue As Boolean = False

    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel1.Click
        If EditMode = True Then
            Close()
        Else
            Limpiar()
        End If
    End Sub

    Private Sub BtnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGuardar1.Click
        If txtCod.Text <> "" Then
            If cmbProveedor.Text <> "" Then
                If cmbCategoria.Text <> "" Then
                    If txtDescrip.Text <> "" Then
                        If txtPrecCompra.Text <> "" Then
                            If TxtIva.Text <> "" Then
                                If txtStock.Text = "" Then
                                    txtStock.Text = "0"
                                End If
                                If cmbPresent.SelectedIndex = 0 Or cmbPresent.SelectedIndex = 5 Then 'Por Unidades o Kg
                                    If txtPrec1.Text <> "" Then
                                        txtPrec2.Text = If(txtPrec2.Text = "", txtPrec1.Text, txtPrec2.Text)
                                        If txtPrec2.Text <> "" Then
                                            GuardarProd()
                                        Else
                                            MsgBox("Ingrese el Precio de Venta")
                                        End If
                                    Else
                                        MsgBox("Ingrese el Precio de Venta")
                                    End If
                                ElseIf cmbPresent.SelectedIndex = 1 Or cmbPresent.SelectedIndex = 2 Or cmbPresent.SelectedIndex = 3 Then 'Por Paquete
                                    If txtUnidXpack.Text <> "" Then
                                        If txtPVPack.Text <> "" Then
                                            If txtPVUnid.Text <> "" Then
                                                GuardarProd()
                                            Else
                                                MsgBox("Ingrese el Precio de Venta")
                                            End If
                                        Else
                                            MsgBox("Ingrese el Precio de Venta")
                                        End If
                                    Else
                                        MsgBox("Complete todos los campos")
                                    End If
                                Else
                                    If txtUnidxPackPiso.Text <> "" Then
                                        If txtMxCaja.Text <> "" Then
                                            If txtLado1.Text <> "" Then
                                                If txtLado2.Text <> "" Then
                                                    If txtPrecioCaja.Text <> "" Then
                                                        If txtPrecioMetro.Text <> "" Then
                                                            If TxtPrecioUnid.Text <> "" Then
                                                                GuardarProd()
                                                            Else
                                                                MsgBox("Ingrese Precio x Unidad")
                                                            End If
                                                        Else
                                                            MsgBox("Ingrese el Precio x Metro")
                                                        End If
                                                    Else
                                                        MsgBox("Ingrese el Precio x Caja")
                                                    End If
                                                Else
                                                    MsgBox("Ingrese la dimensión")
                                                End If
                                            Else
                                                MsgBox("Ingrese la dimensión")
                                            End If
                                        Else
                                            MsgBox("Ingrese los Metros x Caja")
                                        End If
                                    Else
                                        MsgBox("Ingrese las Unidades por Caja")
                                    End If
                                End If
                            Else
                                MsgBox("Ingrese el IVA")
                            End If
                        Else
                            MsgBox("Ingrese el Costo de Producto")
                        End If
                    Else
                        MsgBox("Ingrese la Descripción")
                    End If
                Else
                    MsgBox("Ingrese la Categoría")
                End If
            Else
                    MsgBox("Indique el Proveedor")
            End If
        Else
            MsgBox("Ingrese el Código del Producto")
        End If
    End Sub

    Private Sub GuardarProd()
        Try
            Dim idProd As String = txtCod.Text
            Dim idProv As String = CStr(TablaProv.Rows(cmbProveedor.SelectedIndex).Item(0))
            Dim idCateg As String = CStr(TablaCateg.Rows(cmbCategoria.SelectedIndex).Item(0))
            Dim Descrip As String = txtDescrip.Text
            Dim PrecCompra As Integer = CInt(txtPrecCompra.Text)
            Dim Precio1, Precio2, PrecPack? As Integer
            Dim UnidXpack?, Lado1?, Lado2?, MxCaja As Double
            Dim CantUnit As Double = 0
            Dim PorPack As String = "No"
            Dim Foto As Byte()
            Dim Iva As Int16 = CShort(TxtIva.Text)
            If pbxFoto.Image IsNot Nothing Then
                Foto = ImageToByteArray(pbxFoto.Image)
            End If
            CantUnit = CDbl(txtStock.Text)
            Select Case cmbPresent.SelectedIndex
                Case 0
                    PorPack = "No"
                    Precio1 = CInt(txtPrec1.Text)
                    Precio2 = CInt(txtPrec2.Text)
                Case 1, 2, 3
                    Precio1 = CInt(txtPVUnid.Text)
                    PrecPack = CInt(txtPVPack.Text)
                    UnidXpack = CDbl(txtUnidXpack.Text)
                    Precio2 = 0
                    Select Case cmbPresent.SelectedIndex
                        Case 1
                            PorPack = "Si"
                        Case 2
                            PorPack = "SiCaja"
                        Case 3
                            PorPack = "SiMetro"
                    End Select
                Case 4
                    PorPack = "Piso"
                    Precio1 = CInt(txtPrecioMetro.Text)
                    Precio2 = CInt(TxtPrecioUnid.Text)
                    PrecPack = CInt(txtPrecioCaja.Text)
                    UnidXpack = CDbl(txtUnidxPackPiso.Text)
                    MxCaja = CDbl(txtMxCaja.Text)
                    Lado1 = CDbl(txtLado1.Text)
                    Lado2 = CDbl(txtLado2.Text)
                Case 5
                    PorPack = "Kilo"
                    Precio1 = CInt(txtPrec1.Text)
                    Precio2 = CInt(txtPrec2.Text)
            End Select
            Dim Favorito As Integer = If(ChkFavorito.Checked = True, 1, 0)

            If EditMode = False Then    'Para guardar un nuevo Producto
                If Producto.VerificarCod(idProd) = True Then
                    If Not Producto.InserProducto(idProd,
                                                  idProv,
                                                  idCateg,
                                                  Descrip,
                                                  PrecCompra,
                                                  Precio1,
                                                  Precio2,
                                                  0,
                                                  PrecPack,
                                                  CantUnit,
                                                  UnidXpack,
                                                  PorPack,
                                                  Foto,
                                                  Iva,
                                                  Lado1,
                                                  Lado2,
                                                  MxCaja,
                                                  Favorito) Then
                        MessageBox.Show("Hubo un error al guardar el Producto")
                    Else
                        MessageBox.Show("Producto Guardado")
                        If ChkGenerar.Checked Then
                            'txtCod.Text = CStr(Producto.CargarNroProd())
                        End If
                        Limpiar()
                        BtnCancel1.Enabled = False
                    End If
                Else
                    MessageBox.Show("El Código ingresado ya existe")
                    txtCod.Select(0, txtCod.Text.Length)
                    txtCod.Focus()
                End If
            Else    'Para editar un Producto
                If Producto.VerificarCod(txtCod.Text) = True Or txtCod.Text = OldIdProd Then
                    If Producto.Update(idProd,
                                       idProv,
                                       idCateg,
                                       Descrip,
                                       PrecCompra,
                                       Precio1,
                                       Precio2,
                                       0,
                                       PrecPack,
                                       CantUnit,
                                       UnidXpack,
                                       PorPack,
                                       Foto,
                                       Iva,
                                       OldIdProd,
                                       Lado1,
                                       Lado2,
                                       MxCaja,
                                       Favorito) = False Then
                        MessageBox.Show("Hubo un error al editar el Producto")
                    Else
                        MessageBox.Show("Producto Editado")
                        Me.Close()
                    End If
                Else
                    MessageBox.Show("El Código ingresado ya existe")
                    txtCod.Select(0, txtCod.Text.Length)
                    txtCod.Focus()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Ingrese datos válidos en todos los campos")
        End Try
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkGenerar.CheckedChanged
        If ChkGenerar.Checked Then
            txtCod.Text = Producto.GenerarCódigo()
            txtCod.ReadOnly = True
        Else
            txtCod.Text = ""
            txtCod.ReadOnly = False
        End If

    End Sub

    Private Sub Limpiar()
        txtDescrip.Text = ""
        txtPVPack.Text = ""
        txtPrec1.Text = ""
        txtPrec2.Text = ""
        txtPVPack.Text = ""
        txtPVUnid.Text = ""
        txtStock.Text = ""
        txtPrecioCaja.Text = ""
        txtPrecioMetro.Text = ""
        TxtPrecioUnid.Text = ""
        txtUnidxPackPiso.Text = ""
        txtLado1.Text = ""
        txtLado2.Text = ""
        txtCod.Focus()
    End Sub

    'Private Sub Form1_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Resize
    'Dim strEstado As String = Me.WindowState.ToString()
    'If strEstado = "Maximized" Then
    'WindowState = FormWindowState.Normal
    'End If
    'End Sub

    Private Sub FrmProducto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If EditMode = False Then
            CargarProv()
            CargarCateg()
            cmbPresent.SelectedIndex = 0
        Else
            If ModoVerDetValue = False Then
                lblBaja.Visible = True
                lblAddStock.Visible = True
            End If
        End If
        ToolTip2.IsBalloon = True
    End Sub

    Private Sub CargarProv()
        cmbProveedor.Items.Clear()
        cmbProveedor.Text = ""
        TablaProv = Proveedor.ListarProveed()
        For Each row As DataRow In TablaProv.Rows
            cmbProveedor.Items.Add(CStr(row.Item(1)))
        Next
    End Sub

    Private Sub CargarCateg()
        cmbCategoria.Items.Clear()
        cmbCategoria.Text = ""
        TablaCateg = Producto.ListarCateg()
        For Each row As DataRow In TablaCateg.Rows
            cmbCategoria.Items.Add(CStr(row.Item(1)))
        Next
    End Sub

    Private Sub cmbPresent_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbPresent.KeyPress, cmbProveedor.KeyPress, cmbCategoria.KeyPress
        e.Handled = True
    End Sub

    Private Sub cmbPresent_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbPresent.SelectedIndexChanged
        Select Case cmbPresent.SelectedIndex
            Case 0, 5      'Unidad y Kg
                lblPack.Visible = False
                txtUnidXpack.Visible = False
                lblPrec1.Visible = True
                lblPrec2.Visible = True
                txtPrec1.Visible = True
                txtPrec2.Visible = True
                txtPVPack.Visible = False
                txtPVUnid.Visible = False
                lblPVPack.Visible = False
                lblPVUnid.Visible = False
                pnlPiso.Visible = False
                lblPrec1.Text = "Precio de Venta:"
                lblPrec2.Text = "Precio Mayorista:"
                'lblPaquete.Visible = False
                'txtStockPak.Visible = False
                'lblStock2.Visible = False
                If cmbPresent.SelectedIndex = 0 Then    'Unidad
                    lblUnidMedida.Visible = False
                    lblUnidMedida.Text = "unid."
                Else
                    'Kilogramo---------------------------------
                    lblUnidMedida.Visible = True
                    lblUnidMedida.Text = "Kg."
                    '------------------------------------------
                End If
            Case 1, 2, 3 'Paquetes
                lblPack.Visible = True
                txtUnidXpack.Visible = True
                lblPrec1.Visible = False
                lblPrec2.Visible = False
                txtPrec1.Visible = False
                txtPrec2.Visible = False
                txtPVPack.Visible = True
                txtPVUnid.Visible = True
                lblPVPack.Visible = True
                lblPVUnid.Visible = True
                lblUnidMedida.Visible = True
                pnlPiso.Visible = False
                Select Case cmbPresent.SelectedIndex
                    Case 1  'Unidad y Paquete
                        lblPack.Text = "Unidades x Paquete:"
                        lblPVPack.Text = "Precio x Paquete:"
                        lblPVUnid.Text = "Precio x Unidad:"
                        lblUnidMedida.Text = "unidades"
                    Case 2  'Paquete y Caja
                        lblPack.Text = "Paquetes x Caja:"
                        lblPVPack.Text = "Precio x Caja:"
                        lblPVUnid.Text = "Precio x Paquete:"
                        lblUnidMedida.Text = "paquetes"
                    Case 3  'Metro y Entero
                        lblPack.Text = "Metros x Entero:"
                        lblPVPack.Text = "Precio x Entero:"
                        lblPVUnid.Text = "Precio x Metro:"
                        lblUnidMedida.Text = "metros"
                End Select
            Case 4
                pnlPiso.Visible = True
                lblUnidMedida.Text = "unidades"
                lblUnidMedida.Visible = True
                'lblPaquete.Visible = True
                'txtStockPak.Visible = True
                'lblStock2.Visible = True
        End Select
    End Sub

    'Generate new image dimensions
    Public Function GenerateImageDimensions(ByVal currW As Integer, ByVal currH As Integer, ByVal destW As Integer, ByVal destH As Integer) As Size
        'double to hold the final multiplier to use when scaling the image
        Dim multiplier As Double = 0

        'string for holding layout
        Dim layout As String

        'determine if it's Portrait or Landscape
        If currH > currW Then
            layout = "portrait"
        Else
            layout = "landscape"
        End If

        Select Case layout.ToLower()
            Case "portrait"
                'calculate multiplier on heights
                If destH > destW Then
                    multiplier = CDbl(destW) / CDbl(currW)
                Else

                    multiplier = CDbl(destH) / CDbl(currH)
                End If
                Exit Select
            Case "landscape"
                'calculate multiplier on widths
                If destH > destW Then
                    multiplier = CDbl(destW) / CDbl(currW)
                Else

                    multiplier = CDbl(destH) / CDbl(currH)
                End If
                Exit Select
        End Select

        'return the new image dimensions
        Return New Size(CInt((currW * multiplier)), CInt((currH * multiplier)))
    End Function

    'Resize the image
    Private Sub SetImage(ByVal pb As PictureBox)
        Try
            'create a temp image
            Dim img As Image = pb.Image

            'calculate the size of the image
            Dim imgSize As Size = GenerateImageDimensions(img.Width, img.Height, pbxFoto.Width, pbxFoto.Height)

            'create a new Bitmap with the proper dimensions
            Dim finalImg As New Bitmap(img, imgSize.Width, imgSize.Height)

            'create a new Graphics object from the image
            Dim gfx As Graphics = Graphics.FromImage(img)

            'clean up the image (take care of any image loss from resizing)
            gfx.InterpolationMode = InterpolationMode.HighQualityBicubic

            'empty the PictureBox
            pb.Image = Nothing

            'center the new image
            pb.SizeMode = PictureBoxSizeMode.CenterImage

            'set the new image
            pb.Image = finalImg
        Catch e As System.Exception
            MessageBox.Show(e.Message)
        End Try
    End Sub

    Private Sub LoadNewPict()
        ' You should replace the bold image 
        ' in the sample below with an icon of your own choosing.
        pbxFoto.Image = Image.FromFile _
        (System.Environment.GetFolderPath _
        (System.Environment.SpecialFolder.Personal) _
        & "\Image.gif")
    End Sub

    Public Sub Editar(ByVal Cod As String, ByVal Prov As String, ByVal Categ As String, ByVal Descrip As String,
                      ByVal Costo As Integer, ByVal Precio1 As Integer, ByVal Precio2 As Integer, ByVal Precio3 As Integer,
                      ByVal PrecioPack? As Integer, ByVal CantUnid As Double, ByVal UnidXpack? As Double,
                      ByVal Present As String, ByVal Foto As Byte(), ByVal Iva As Decimal,
                      ByVal Lado1? As Double, ByVal Lado2? As Double, ByVal MxCaja? As Double, ByVal Favorito As Integer)
        EditMode = True
        txtStock.ReadOnly = True
        OldIdProd = Cod
        txtCod.Text = Cod
        CargarProv()
        CargarCateg()
        cmbProveedor.SelectedItem = Prov
        cmbCategoria.SelectedItem = Categ
        txtDescrip.Text = Descrip
        txtPrecCompra.Text = CStr(Costo)
        txtPrec1.Text = CStr(Precio1)
        txtPrec2.Text = CStr(Precio2)
        'txtPrec3.Text = CStr(Precio3)
        txtStock.Text = CStr(CantUnid)
        TxtIva.Text = CStr(Iva)
        If Foto IsNot Nothing Then
            pbxFoto.Image = ByteArrayToImage(Foto)
        End If
        Select Case Present
            Case "Si", "SiCaja", "SiMetro"
                txtPVPack.Text = CStr(PrecioPack)
                txtPVUnid.Text = CStr(Precio1)
                txtUnidXpack.Text = CStr(UnidXpack)
                Select Case Present
                    Case "Si"
                        cmbPresent.SelectedIndex = 1
                    Case "SiCaja"
                        cmbPresent.SelectedIndex = 2
                    Case "SiMetro"
                        cmbPresent.SelectedIndex = 3
                End Select
            Case "Piso"
                pnlPiso.Visible = True
                txtPrecioCaja.Text = CStr(PrecioPack)
                txtPrecioMetro.Text = CStr(Precio1)
                TxtPrecioUnid.Text = CStr(Precio2)
                txtLado1.Text = CStr(Lado1)
                txtLado2.Text = CStr(Lado2)
                txtUnidxPackPiso.Text = CStr(UnidXpack)
                txtMxCaja.Text = CStr(MxCaja)
                cmbPresent.SelectedIndex = 4
            Case "No"
                cmbPresent.SelectedIndex = 0
            Case "Kilo"
                cmbPresent.SelectedIndex = 5
        End Select
        ChkFavorito.Checked = If(Favorito = 1, True, False)
    End Sub

    Private Sub pbxNewProv_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbxNewProv.Click
        Dim frm As New FNuevoProveed
        frm.TopMost = True
        frm.MaximizeBox = False
        frm.MinimizeBox = False
        frm.ShowDialog()
        CargarProv()
    End Sub

    Private Sub pbxNewCateg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbxNewCateg.Click
        Dim frm As New FNuevoCategoriaProd
        frm.TopMost = True
        frm.MaximizeBox = False
        frm.MinimizeBox = False
        frm.ShowDialog()
        CargarCateg()
    End Sub

    Private Sub lblBaja_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblBaja.Click
        Dim Present As String = "No"
        If cmbPresent.SelectedIndex = 5 Then
            Present = "Kilo"
        End If
        Dim frm As New FBajaProducto
        frm.Cargar(True, txtCod.Text, txtDescrip.Text, CInt(txtStock.Text), Present)
        'frm.TopMost = True
        frm.ShowDialog()
        Close()
    End Sub

    Private Sub lblAddStock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblAddStock.Click
        Dim Present As String = "No"
        If cmbPresent.SelectedIndex = 5 Then
            Present = "Kilo"
        End If
        Dim frm As New FBajaProducto
        frm.Cargar(False, txtCod.Text, txtDescrip.Text, CInt(txtStock.Text), Present)
        'frm.TopMost = True
        frm.ShowDialog()
        Close()
    End Sub

    Private Sub txtStock_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtStock.KeyDown
        If e.KeyCode = Keys.Enter Then
            BtnGuardar_Click(Nothing, Nothing)
        End If
    End Sub

    Private Sub txtDescrip_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDescrip.TextChanged
        Dim Resto As Integer = 50 - txtDescrip.TextLength
        lblRestoDesc.Text = CStr(Resto)
        If Resto < 0 Then
            lblRestoDesc.ForeColor = Color.Red
        Else
            lblRestoDesc.ForeColor = Color.Lime
        End If
    End Sub

    Private Sub F_Deactivate(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Deactivate
        'WindowState = FormWindowState.Minimized
    End Sub

    Private Sub F_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        WindowState = FormWindowState.Normal
    End Sub

    Private Sub txtStock_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtStock.KeyPress, txtUnidXpack.KeyPress
        Dim Caja As TextBox = CType(sender, TextBox)
        Dim Present As Integer = cmbPresent.SelectedIndex
        If e.KeyChar = Convert.ToChar(",") Then
            If Present = 3 Or Present = 5 Then
                e.Handled = False
            Else
                e.Handled = True
                Caja.Focus()
                ToolTip2.Show("No se aceptan decimales", Caja, 0, -40, 4000)
            End If
        ElseIf e.KeyChar = Convert.ToChar(".") Then
            e.Handled = True
            If Present = 3 Or Present = 5 Then
                Caja.Text = Caja.Text + ","
                Caja.Select(Caja.Text.Length, 0)
            Else
                Caja.Focus()
                ToolTip2.Show("No se aceptan decimales", Caja, 0, -40, 4000)
            End If
        ElseIf Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
            Caja.Focus()
            ToolTip2.Show("Ingrese un valor númerico", Caja, 0, -40, 2000)
        End If
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtPrecCompra_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPrecCompra.KeyPress, txtPrec1.KeyPress, txtPrec2.KeyPress, txtPVPack.KeyPress, txtPVUnid.KeyPress, TxtIva.KeyPress, TxtPrecioUnid.KeyPress, txtPrecioMetro.KeyPress, txtPrecioCaja.KeyPress
        Dim Caja As TextBox = CType(sender, TextBox)
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
            Caja.Focus()
            ToolTip2.Show("Ingrese un valor númerico", Caja, 0, -40, 2000)
        End If
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtLado1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtLado1.KeyPress, txtLado2.KeyPress
        Dim Caja As TextBox = CType(sender, TextBox)
        If e.KeyChar = Convert.ToChar(",") Then
            e.Handled = False
        ElseIf e.KeyChar = Convert.ToChar(".") Then
            e.Handled = True
            Caja.Text = Caja.Text + ","
            Caja.Select(Caja.Text.Length, 0)
        ElseIf Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
            Caja.Focus()
            ToolTip2.Show("Ingrese un valor númerico", Caja, 0, -40, 2000)
        End If
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtMxCaja_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMxCaja.KeyPress
        Dim Caja As TextBox = CType(sender, TextBox)
        Dim Present As Integer = cmbPresent.SelectedIndex
        If e.KeyChar = Convert.ToChar(",") Then
            e.Handled = False
        ElseIf e.KeyChar = Convert.ToChar(".") Then
            e.Handled = True
            Caja.Text = Caja.Text + ","
            Caja.Select(Caja.Text.Length, 0)
        ElseIf Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
            Caja.Focus()
            ToolTip2.Show("Ingrese un valor númerico", Caja, 0, -40, 2000)
        End If
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            e.Handled = True
        End If
    End Sub

    Public Sub ModoVerDetalle()
        cmbPresent.Enabled = False
        txtCod.ReadOnly = True
        cmbProveedor.Enabled = False
        cmbCategoria.Enabled = False
        txtDescrip.ReadOnly = True
        TxtIva.ReadOnly = True
        txtLado1.ReadOnly = True
        txtLado2.ReadOnly = True
        txtMxCaja.ReadOnly = True
        txtPrec1.ReadOnly = True
        txtPrec2.ReadOnly = True
        txtPrecCompra.ReadOnly = True
        txtPrecioCaja.ReadOnly = True
        txtPrecioMetro.ReadOnly = True
        TxtPrecioUnid.ReadOnly = True
        txtPVPack.ReadOnly = True
        txtPVUnid.ReadOnly = True
        txtStock.ReadOnly = True
        txtUnidXpack.ReadOnly = True
        txtUnidxPackPiso.ReadOnly = True
        pbxNewProv.Visible = False
        lblAddStock.Visible = False
        lblBaja.Visible = False
        lblRestoDesc.Visible = False
        BtnGuardar1.Visible = False
        BtnCancel1.Visible = False
        ChkFavorito.Enabled = False
        ModoVerDetValue = True
    End Sub

    Private Sub BtnCerrarForm_Click(sender As Object, e As EventArgs) Handles BtnCerrarForm.Click
        Me.Close()
    End Sub

    Private Sub pbxFoto_Click(sender As Object, e As EventArgs) Handles pbxFoto.Click
        Dim OpenFileDialog1 As New OpenFileDialog

        With OpenFileDialog1
            .CheckFileExists = True
            .ShowReadOnly = False
            .Filter = "All Files|*.*|Bitmap Files (*)|*.bmp;*.gif;*.jpg"
            .FilterIndex = 2
            If .ShowDialog = DialogResult.OK Then
                ' Load the specified file into a PictureBox control.
                If pbxFoto.Image IsNot Nothing Then
                    pbxFoto.Image.Dispose()
                    pbxFoto.Image = Nothing
                End If
                pbxFoto.Image = Image.FromFile(.FileName)
                SetImage(pbxFoto)
            End If
        End With
    End Sub

    Private Sub txtPrec1_KeyUp(sender As Object, e As KeyEventArgs) Handles txtPrec1.KeyUp, txtPrec2.KeyUp, txtPrecCompra.KeyUp, txtStock.KeyUp
        'Agregar separador de miles
        Dim Txt As TextBox = DirectCast(sender, TextBox)
        If (Txt.Text <> String.Empty) Then
            Dim importe As Decimal
            Decimal.TryParse(Txt.Text, importe)
            Txt.Text = String.Format("{0:N0}", importe)
            Txt.SelectionStart = Txt.TextLength
        End If
    End Sub



    Private Sub btnPrecioSetting_Click(sender As Object, e As EventArgs) Handles btnPrecioSetting.Click
        'FrmAjustesPrecio = New FAjustesPrecio()
        FrmAjustesPrecio.Show()
    End Sub

    Private Sub txtPrecCompra_TextChanged(sender As Object, e As EventArgs) Handles txtPrecCompra.TextChanged
        If FrmAjustesPrecio.chkActivo.Checked Then
            Try
                Dim Precio As Double
                Dim Costo As Integer = CInt(txtPrecCompra.Text)
                Dim Porcentaje As Integer = CInt(FrmAjustesPrecio.TxtPorcentaje.Text)
                Dim Multiplo As Integer = CInt(FrmAjustesPrecio.TxtMultiplo.Text)
                Precio = Costo + Costo * Porcentaje / 100
                Precio = Math.Ceiling(Precio / Multiplo) * Multiplo
                txtPrec1.Text = String.Format("{0:N0}", Precio)
            Catch ex As Exception
            End Try
        End If
    End Sub

End Class