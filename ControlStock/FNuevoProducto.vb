Option Strict On

Imports System.Drawing.Drawing2D
Imports System.IO
Imports System.Drawing.Imaging

Public Class FNuevoProducto

    Dim Producto As New CProducto
    Dim Proveedor As New CProveedor
    Dim TablaProv As New DataTable
    Dim EditMode As Boolean = False
    Dim OldIdProd As UInt64

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
                If txtDescrip.Text <> "" Then
                    If txtPrecCompra.Text <> "" Then
                        If cmbPresent.SelectedIndex = 0 Or cmbPresent.SelectedIndex = 2 Then 'Por Unidades o Kg
                            If txtPrec1.Text <> "" Then
                                If txtPrec2.Text <> "" Then
                                    If TxtIva.Text <> "" Then
                                        If txtStock.Text = "" Then
                                            txtStock.Text = "0"
                                        End If
                                        GuardarProd()
                                    Else
                                        MsgBox("Ingrese el IVA")
                                    End If
                                Else
                                    MsgBox("Ingrese el Precio de Venta 2")
                                End If
                            Else
                                MsgBox("Ingrese el Precio de Venta 1")
                            End If
                        Else 'Por Paquete
                            If txtUnidXpack.Text <> "" Then
                                If txtPVPack.Text <> "" Then
                                    If txtPVUnid.Text <> "" Then
                                        If TxtIva.Text <> "" Then
                                            If txtStock.Text = "" Then
                                                txtStock.Text = "0"
                                            End If
                                            GuardarProd()
                                        Else
                                            MsgBox("Ingrese el IVA")
                                        End If
                                    Else
                                        MsgBox("Ingrese el Precio de Venta por Unidad")
                                    End If
                                Else
                                    MsgBox("Ingrese el Precio de Venta por Pack")
                                End If
                            Else
                                MsgBox("Ingrese las Unidades por Pack")
                            End If
                        End If
                    Else
                        MsgBox("Ingrese el Costo de Producto")
                    End If
                Else
                    MsgBox("Ingrese la Descripción")
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
            Dim Codigo = txtCod.Text
            Dim idProd As UInt64 = CULng(Codigo)
            Dim idProv As String = CStr(TablaProv.Rows(cmbProveedor.SelectedIndex).Item(0))
            Dim Descrip As String = txtDescrip.Text
            Dim PrecCompra As Integer = CInt(txtPrecCompra.Text)
            Dim Precio1, Precio2, PrecPack?, UnidXpack? As Integer
            Dim CantUnit As Double = 0
            Dim PorPack As String = "No"
            Dim Foto As Byte()
            Dim Iva As Int16 = CShort(TxtIva.Text)
            Foto = ImageToByteArray(PictureBox1.Image)
            CantUnit = CDbl(txtStock.Text)
            If cmbPresent.SelectedIndex = 0 Then
                PorPack = "No"
                Precio1 = CInt(txtPrec1.Text)
                Precio2 = CInt(txtPrec2.Text)
            ElseIf cmbPresent.SelectedIndex = 1 Then
                PorPack = "Si"
                Precio1 = CInt(txtPVUnid.Text)
                PrecPack = CInt(txtPVPack.Text)
                UnidXpack = CInt(txtUnidXpack.Text)
                Precio2 = 0
                Dim StockPack As Integer
                Try
                    StockPack = CInt(txtStockPak.Text)
                Catch
                    StockPack = 0
                End Try
                CantUnit += StockPack * CInt(UnidXpack)
            ElseIf cmbPresent.SelectedIndex = 2 Then
                PorPack = "Kilo"
                Precio1 = CInt(txtPrec1.Text)
                Precio2 = CInt(txtPrec2.Text)
            End If

            If EditMode = False Then    'Para guardar un nuevo Producto
                If VerificarCod(Codigo) = True Then
                    If Producto.InserProducto(idProd, idProv, Descrip, PrecCompra, Precio1, Precio2, 0, PrecPack, CantUnit, UnidXpack, PorPack, Foto, Iva) = False Then
                        MessageBox.Show("Hubo un error al guardar el Producto")
                    Else
                        MessageBox.Show("Producto Guardado")
                        If ChkGenerar.Checked Then
                            txtCod.Text = CStr(Producto.CargarNroProd())
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
                If VerificarCod(txtCod.Text) = True Or CULng(txtCod.Text) = OldIdProd Then
                    If Producto.Update(idProd, idProv, Descrip, PrecCompra, Precio1, Precio2, 0, PrecPack, CantUnit, UnidXpack, PorPack, Foto, Iva, OldIdProd) = False Then
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

    Private Function VerificarCod(ByVal Cod As String) As Boolean   'Devuelve true si el codigo esta disponible
        Dim Tabla = Producto.BuscProdCod(Cod)
        Dim Filas As Integer = Tabla.Rows.Count
        If Filas > 0 Then
            Return False
        Else
            Return True
        End If
    End Function

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkGenerar.CheckedChanged
        If ChkGenerar.Checked Then
            txtCod.Text = CStr(Producto.CargarNroProd())
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
        PictureBox1.Image = My.Resources.Foto
        SetImage(PictureBox1)
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
            cmbPresent.SelectedIndex = 0
            PictureBox1.Image = My.Resources.Foto
            SetImage(PictureBox1)
        Else
            lblBaja.Visible = True
            lblAddStock.Visible = True
        End If
        ToolTip2.IsBalloon = True
    End Sub

    Private Sub CargarProv()
        cmbProveedor.Items.Clear()
        TablaProv = Proveedor.ListarProveed()
        Dim Filas As Integer = TablaProv.Rows.Count
        If Filas > 0 Then
            For i = 0 To (Filas - 1)
                cmbProveedor.Items.Add(TablaProv.Rows(i).Item(1))
            Next
        End If
    End Sub

    Private Sub cmbPresent_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbPresent.KeyPress, cmbProveedor.KeyPress
        e.Handled = True
    End Sub

    Private Sub cmbPresent_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbPresent.SelectedIndexChanged
        Select Case cmbPresent.SelectedIndex
            Case Is = 0, 2
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
                lblPaquete.Visible = False
                txtStockPak.Visible = False
                lblStock2.Visible = False

                If cmbPresent.SelectedIndex = 0 Then
                    lblPrec1.Text = "Precio Min.:"
                    lblPrec2.Text = "Precio May:"
                    lblUnidMedida.Visible = False
                    lblUnidMedida.Text = "unid."
                Else
                    lblPrec1.Text = "Precio por Kg. 1"
                    lblPrec2.Text = "Precio por Kg. 2"
                    lblUnidMedida.Visible = True
                    lblUnidMedida.Text = "Kg."
                End If
            Case Is = 1
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
                lblUnidMedida.Text = "unidades"
                lblPaquete.Visible = True
                txtStockPak.Visible = True
                lblStock2.Visible = True
        End Select
    End Sub

    Private Sub lblCambImg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblAddImage.Click
        Dim OpenFileDialog1 As New OpenFileDialog

        With OpenFileDialog1
            .CheckFileExists = True
            .ShowReadOnly = False
            .Filter = "All Files|*.*|Bitmap Files (*)|*.bmp;*.gif;*.jpg"
            .FilterIndex = 2
            If .ShowDialog = DialogResult.OK Then
                ' Load the specified file into a PictureBox control.
                If Not (PictureBox1.Image Is Nothing) Then
                    PictureBox1.Image.Dispose()
                    PictureBox1.Image = Nothing
                End If
                PictureBox1.Image = Image.FromFile(.FileName)
                SetImage(PictureBox1)
            End If
        End With
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
            Dim imgSize As Size = GenerateImageDimensions(img.Width, img.Height, Me.PictureBox1.Width, Me.PictureBox1.Height)

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
        PictureBox1.Image = Image.FromFile _
        (System.Environment.GetFolderPath _
        (System.Environment.SpecialFolder.Personal) _
        & "\Image.gif")
    End Sub

    Public Sub Editar(ByVal Cod As UInt64, ByVal Prov As String, ByVal Descrip As String, ByVal Costo As Integer,
                       ByVal Precio1 As Integer, ByVal Precio2 As Integer, ByVal Precio3 As Integer,
                       ByVal PrecioPack? As Integer, ByVal CantUnid As Double, ByVal UnidXpack? As Integer,
                       ByVal PorPack As String, ByVal Foto As Byte(), ByVal Iva As Decimal)
        EditMode = True
        txtStock.ReadOnly = True
        OldIdProd = Cod
        txtCod.Text = CStr(Cod)
        CargarProv()
        cmbProveedor.SelectedItem = CStr(Prov)
        txtDescrip.Text = Descrip
        txtPrecCompra.Text = CStr(Costo)
        txtPrec1.Text = CStr(Precio1)
        txtPrec2.Text = CStr(Precio2)
        'txtPrec3.Text = CStr(Precio3)
        txtStock.Text = CStr(CantUnid)
        TxtIva.Text = CStr(Iva)
        Try
            PictureBox1.Image = ByteArrayToImage(Foto)
        Catch ex As Exception
            PictureBox1.Image = My.Resources.Foto
        End Try
        SetImage(PictureBox1)
        If PorPack = "Si" Then
            cmbPresent.SelectedIndex = 1
            txtPVPack.Text = CStr(PrecioPack)
            txtPVUnid.Text = CStr(Precio1)
            txtUnidXpack.Text = CStr(UnidXpack)
        ElseIf PorPack = "No" Then
            cmbPresent.SelectedIndex = 0
        Else
            cmbPresent.SelectedIndex = 2
        End If
    End Sub

    Private Sub pbxNewProv_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbxNewProv.Click
        Dim frm As New FNuevoProveed
        frm.TopMost = True
        frm.MaximizeBox = False
        frm.MinimizeBox = False
        frm.ShowDialog()
        CargarProv()
    End Sub

    Private Sub lblBaja_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblBaja.Click
        Dim Present As String = "No"
        If cmbPresent.SelectedIndex = 2 Then
            Present = "Kilo"
        End If
        Dim frm As New FBajaProducto
        frm.Cargar(True, txtCod.Text, txtDescrip.Text, CInt(txtStock.Text), Present)
        'frm.TopMost = True
        frm.ShowDialog()
        Me.Close()
    End Sub

    Private Sub lblAddStock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblAddStock.Click
        Dim Present As String = "No"
        If cmbPresent.SelectedIndex = 2 Then
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

    Private Sub txtStock_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtStock.KeyPress, txtStockPak.KeyPress
        Dim Caja As TextBox = CType(sender, TextBox)
        Dim Present As Integer = cmbPresent.SelectedIndex
        If e.KeyChar = Convert.ToChar(",") Then
            If Present = 2 Then
                e.Handled = False
            Else
                e.Handled = True
                Caja.Focus()
                ToolTip2.Show("No se aceptan decimales", Caja, 0, -40, 4000)
            End If
        ElseIf e.KeyChar = Convert.ToChar(".") Then
            e.Handled = True
            If Present = 2 Then
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

    Private Sub txtDescrip_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDescrip.TextChanged
        Dim Resto As Integer = 30 - txtDescrip.TextLength
        lblRestoDesc.Text = CStr(Resto)
        If Resto < 0 Then
            lblRestoDesc.ForeColor = Color.Red
        Else
            lblRestoDesc.ForeColor = Color.Green
        End If
    End Sub

    Private Sub F_Deactivate(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Deactivate
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub F_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        WindowState = FormWindowState.Normal
    End Sub

    Private Sub txtPrecCompra_TextChanged(sender As Object, e As EventArgs) Handles txtPrecCompra.TextChanged

    End Sub

    Private Sub txtPrecCompra_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPrecCompra.KeyPress, txtPrec1.KeyPress, txtPrec2.KeyPress, txtPVPack.KeyPress, txtPVUnid.KeyPress, txtUnidXpack.KeyPress, txtCod.KeyPress, TxtIva.KeyPress
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
End Class