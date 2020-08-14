<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FNuevoProducto
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.pnlPiso = New System.Windows.Forms.Panel()
        Me.txtMxCaja = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtPrecioMetro = New System.Windows.Forms.TextBox()
        Me.txtPrecioCaja = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TxtPrecioUnid = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtUnidxPackPiso = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtLado2 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtLado1 = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.pnlUnid = New System.Windows.Forms.Panel()
        Me.lblPrec2 = New System.Windows.Forms.Label()
        Me.lblPVUnid = New System.Windows.Forms.Label()
        Me.txtPVUnid = New System.Windows.Forms.TextBox()
        Me.txtPVPack = New System.Windows.Forms.TextBox()
        Me.lblPVPack = New System.Windows.Forms.Label()
        Me.lblPrec1 = New System.Windows.Forms.Label()
        Me.txtUnidXpack = New System.Windows.Forms.TextBox()
        Me.txtPrec1 = New System.Windows.Forms.TextBox()
        Me.lblPack = New System.Windows.Forms.Label()
        Me.txtPrec2 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtIva = New System.Windows.Forms.TextBox()
        Me.BtnGuardar1 = New System.Windows.Forms.PictureBox()
        Me.BtnCancel1 = New System.Windows.Forms.PictureBox()
        Me.lblAddImage = New System.Windows.Forms.Label()
        Me.lblRestoDesc = New System.Windows.Forms.Label()
        Me.lblAddStock = New System.Windows.Forms.Label()
        Me.lblBaja = New System.Windows.Forms.Label()
        Me.pbxNewProv = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmbPresent = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmbProveedor = New System.Windows.Forms.ComboBox()
        Me.txtStock = New System.Windows.Forms.TextBox()
        Me.lblStock = New System.Windows.Forms.Label()
        Me.ChkGenerar = New System.Windows.Forms.CheckBox()
        Me.txtPrecCompra = New System.Windows.Forms.TextBox()
        Me.txtDescrip = New System.Windows.Forms.TextBox()
        Me.txtCod = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblUnidMedida = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTip2 = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.pnlPiso.SuspendLayout()
        Me.pnlUnid.SuspendLayout()
        CType(Me.BtnGuardar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnCancel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxNewProv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.pnlPiso)
        Me.GroupBox1.Controls.Add(Me.pnlUnid)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.TxtIva)
        Me.GroupBox1.Controls.Add(Me.BtnGuardar1)
        Me.GroupBox1.Controls.Add(Me.BtnCancel1)
        Me.GroupBox1.Controls.Add(Me.lblAddImage)
        Me.GroupBox1.Controls.Add(Me.lblRestoDesc)
        Me.GroupBox1.Controls.Add(Me.lblAddStock)
        Me.GroupBox1.Controls.Add(Me.lblBaja)
        Me.GroupBox1.Controls.Add(Me.pbxNewProv)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.cmbPresent)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.cmbProveedor)
        Me.GroupBox1.Controls.Add(Me.txtStock)
        Me.GroupBox1.Controls.Add(Me.lblStock)
        Me.GroupBox1.Controls.Add(Me.ChkGenerar)
        Me.GroupBox1.Controls.Add(Me.txtPrecCompra)
        Me.GroupBox1.Controls.Add(Me.txtDescrip)
        Me.GroupBox1.Controls.Add(Me.txtCod)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.lblUnidMedida)
        Me.GroupBox1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(16, 9)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(734, 452)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos del Producto"
        '
        'pnlPiso
        '
        Me.pnlPiso.Controls.Add(Me.txtMxCaja)
        Me.pnlPiso.Controls.Add(Me.Label10)
        Me.pnlPiso.Controls.Add(Me.Label16)
        Me.pnlPiso.Controls.Add(Me.txtPrecioMetro)
        Me.pnlPiso.Controls.Add(Me.txtPrecioCaja)
        Me.pnlPiso.Controls.Add(Me.Label14)
        Me.pnlPiso.Controls.Add(Me.Label15)
        Me.pnlPiso.Controls.Add(Me.TxtPrecioUnid)
        Me.pnlPiso.Controls.Add(Me.Label12)
        Me.pnlPiso.Controls.Add(Me.txtUnidxPackPiso)
        Me.pnlPiso.Controls.Add(Me.Label9)
        Me.pnlPiso.Controls.Add(Me.txtLado2)
        Me.pnlPiso.Controls.Add(Me.Label8)
        Me.pnlPiso.Controls.Add(Me.txtLado1)
        Me.pnlPiso.Controls.Add(Me.Label13)
        Me.pnlPiso.Location = New System.Drawing.Point(5, 212)
        Me.pnlPiso.Name = "pnlPiso"
        Me.pnlPiso.Size = New System.Drawing.Size(391, 230)
        Me.pnlPiso.TabIndex = 1
        '
        'txtMxCaja
        '
        Me.txtMxCaja.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMxCaja.Location = New System.Drawing.Point(168, 46)
        Me.txtMxCaja.Name = "txtMxCaja"
        Me.txtMxCaja.Size = New System.Drawing.Size(193, 27)
        Me.txtMxCaja.TabIndex = 10
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(22, 50)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(95, 18)
        Me.Label10.TabIndex = 107
        Me.Label10.Text = "Metros x Caja:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.White
        Me.Label16.Location = New System.Drawing.Point(22, 200)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(104, 18)
        Me.Label16.TabIndex = 105
        Me.Label16.Text = "Precio x Unidad"
        '
        'txtPrecioMetro
        '
        Me.txtPrecioMetro.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrecioMetro.Location = New System.Drawing.Point(142, 160)
        Me.txtPrecioMetro.Name = "txtPrecioMetro"
        Me.txtPrecioMetro.Size = New System.Drawing.Size(244, 27)
        Me.txtPrecioMetro.TabIndex = 14
        '
        'txtPrecioCaja
        '
        Me.txtPrecioCaja.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrecioCaja.Location = New System.Drawing.Point(142, 124)
        Me.txtPrecioCaja.MaxLength = 50
        Me.txtPrecioCaja.Name = "txtPrecioCaja"
        Me.txtPrecioCaja.Size = New System.Drawing.Size(244, 27)
        Me.txtPrecioCaja.TabIndex = 13
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(22, 164)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(98, 18)
        Me.Label14.TabIndex = 102
        Me.Label14.Text = "Precio x Metro"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(22, 128)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(90, 18)
        Me.Label15.TabIndex = 100
        Me.Label15.Text = "Precio x Caja:"
        '
        'TxtPrecioUnid
        '
        Me.TxtPrecioUnid.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPrecioUnid.Location = New System.Drawing.Point(142, 196)
        Me.TxtPrecioUnid.Name = "TxtPrecioUnid"
        Me.TxtPrecioUnid.Size = New System.Drawing.Size(244, 27)
        Me.TxtPrecioUnid.TabIndex = 15
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(245, 85)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(39, 18)
        Me.Label12.TabIndex = 99
        Me.Label12.Text = "cm  x"
        '
        'txtUnidxPackPiso
        '
        Me.txtUnidxPackPiso.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUnidxPackPiso.Location = New System.Drawing.Point(168, 11)
        Me.txtUnidxPackPiso.Name = "txtUnidxPackPiso"
        Me.txtUnidxPackPiso.Size = New System.Drawing.Size(193, 27)
        Me.txtUnidxPackPiso.TabIndex = 9
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(22, 15)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(109, 18)
        Me.Label9.TabIndex = 91
        Me.Label9.Text = "Unidades x Caja:"
        '
        'txtLado2
        '
        Me.txtLado2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLado2.Location = New System.Drawing.Point(290, 81)
        Me.txtLado2.Name = "txtLado2"
        Me.txtLado2.Size = New System.Drawing.Size(71, 27)
        Me.txtLado2.TabIndex = 12
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(22, 85)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(131, 18)
        Me.Label8.TabIndex = 95
        Me.Label8.Text = "Dimensión del Piso:"
        '
        'txtLado1
        '
        Me.txtLado1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLado1.Location = New System.Drawing.Point(168, 81)
        Me.txtLado1.Name = "txtLado1"
        Me.txtLado1.Size = New System.Drawing.Size(71, 27)
        Me.txtLado1.TabIndex = 11
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(360, 85)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(26, 18)
        Me.Label13.TabIndex = 97
        Me.Label13.Text = "cm"
        '
        'pnlUnid
        '
        Me.pnlUnid.Controls.Add(Me.lblPrec2)
        Me.pnlUnid.Controls.Add(Me.lblPVUnid)
        Me.pnlUnid.Controls.Add(Me.txtPVUnid)
        Me.pnlUnid.Controls.Add(Me.txtPVPack)
        Me.pnlUnid.Controls.Add(Me.lblPVPack)
        Me.pnlUnid.Controls.Add(Me.lblPrec1)
        Me.pnlUnid.Controls.Add(Me.txtUnidXpack)
        Me.pnlUnid.Controls.Add(Me.txtPrec1)
        Me.pnlUnid.Controls.Add(Me.lblPack)
        Me.pnlUnid.Controls.Add(Me.txtPrec2)
        Me.pnlUnid.Location = New System.Drawing.Point(5, 209)
        Me.pnlUnid.Name = "pnlUnid"
        Me.pnlUnid.Size = New System.Drawing.Size(392, 119)
        Me.pnlUnid.TabIndex = 1009
        '
        'lblPrec2
        '
        Me.lblPrec2.AutoSize = True
        Me.lblPrec2.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrec2.ForeColor = System.Drawing.Color.White
        Me.lblPrec2.Location = New System.Drawing.Point(23, 50)
        Me.lblPrec2.Name = "lblPrec2"
        Me.lblPrec2.Size = New System.Drawing.Size(106, 18)
        Me.lblPrec2.TabIndex = 1004
        Me.lblPrec2.Text = "Precio Contado:"
        '
        'lblPVUnid
        '
        Me.lblPVUnid.AutoSize = True
        Me.lblPVUnid.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPVUnid.ForeColor = System.Drawing.Color.White
        Me.lblPVUnid.Location = New System.Drawing.Point(23, 86)
        Me.lblPVUnid.Name = "lblPVUnid"
        Me.lblPVUnid.Size = New System.Drawing.Size(108, 18)
        Me.lblPVUnid.TabIndex = 93
        Me.lblPVUnid.Text = "Precio x Unidad:"
        '
        'txtPVUnid
        '
        Me.txtPVUnid.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPVUnid.Location = New System.Drawing.Point(169, 82)
        Me.txtPVUnid.Name = "txtPVUnid"
        Me.txtPVUnid.Size = New System.Drawing.Size(218, 27)
        Me.txtPVUnid.TabIndex = 8
        '
        'txtPVPack
        '
        Me.txtPVPack.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPVPack.Location = New System.Drawing.Point(169, 46)
        Me.txtPVPack.Name = "txtPVPack"
        Me.txtPVPack.Size = New System.Drawing.Size(218, 27)
        Me.txtPVPack.TabIndex = 7
        '
        'lblPVPack
        '
        Me.lblPVPack.AutoSize = True
        Me.lblPVPack.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPVPack.ForeColor = System.Drawing.Color.White
        Me.lblPVPack.Location = New System.Drawing.Point(19, 50)
        Me.lblPVPack.Name = "lblPVPack"
        Me.lblPVPack.Size = New System.Drawing.Size(116, 18)
        Me.lblPVPack.TabIndex = 88
        Me.lblPVPack.Text = "Precio x Paquete:"
        '
        'lblPrec1
        '
        Me.lblPrec1.AutoSize = True
        Me.lblPrec1.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrec1.ForeColor = System.Drawing.Color.White
        Me.lblPrec1.Location = New System.Drawing.Point(23, 14)
        Me.lblPrec1.Name = "lblPrec1"
        Me.lblPrec1.Size = New System.Drawing.Size(100, 18)
        Me.lblPrec1.TabIndex = 28
        Me.lblPrec1.Text = "Precio Crédito:"
        '
        'txtUnidXpack
        '
        Me.txtUnidXpack.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUnidXpack.Location = New System.Drawing.Point(169, 10)
        Me.txtUnidXpack.Name = "txtUnidXpack"
        Me.txtUnidXpack.Size = New System.Drawing.Size(218, 27)
        Me.txtUnidXpack.TabIndex = 6
        '
        'txtPrec1
        '
        Me.txtPrec1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrec1.Location = New System.Drawing.Point(143, 10)
        Me.txtPrec1.Name = "txtPrec1"
        Me.txtPrec1.Size = New System.Drawing.Size(244, 27)
        Me.txtPrec1.TabIndex = 4
        '
        'lblPack
        '
        Me.lblPack.AutoSize = True
        Me.lblPack.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPack.ForeColor = System.Drawing.Color.White
        Me.lblPack.Location = New System.Drawing.Point(19, 14)
        Me.lblPack.Name = "lblPack"
        Me.lblPack.Size = New System.Drawing.Size(135, 18)
        Me.lblPack.TabIndex = 22
        Me.lblPack.Text = "Unidades x Paquete:"
        '
        'txtPrec2
        '
        Me.txtPrec2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrec2.Location = New System.Drawing.Point(143, 46)
        Me.txtPrec2.Name = "txtPrec2"
        Me.txtPrec2.Size = New System.Drawing.Size(244, 27)
        Me.txtPrec2.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(664, 227)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(20, 19)
        Me.Label5.TabIndex = 1008
        Me.Label5.Text = "%"
        Me.Label5.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(407, 223)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(33, 18)
        Me.Label4.TabIndex = 1007
        Me.Label4.Text = "IVA:"
        '
        'TxtIva
        '
        Me.TxtIva.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtIva.Location = New System.Drawing.Point(458, 219)
        Me.TxtIva.Name = "TxtIva"
        Me.TxtIva.Size = New System.Drawing.Size(203, 27)
        Me.TxtIva.TabIndex = 16
        Me.TxtIva.Text = "10"
        '
        'BtnGuardar1
        '
        Me.BtnGuardar1.BackColor = System.Drawing.Color.Transparent
        Me.BtnGuardar1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnGuardar1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnGuardar1.Image = Global.ControlStock.My.Resources.Resources.file_apply
        Me.BtnGuardar1.Location = New System.Drawing.Point(573, 393)
        Me.BtnGuardar1.Name = "BtnGuardar1"
        Me.BtnGuardar1.Size = New System.Drawing.Size(41, 38)
        Me.BtnGuardar1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BtnGuardar1.TabIndex = 80
        Me.BtnGuardar1.TabStop = False
        Me.ToolTip1.SetToolTip(Me.BtnGuardar1, "Guardar")
        '
        'BtnCancel1
        '
        Me.BtnCancel1.BackColor = System.Drawing.Color.Transparent
        Me.BtnCancel1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCancel1.Image = Global.ControlStock.My.Resources.Resources.file_exclude
        Me.BtnCancel1.Location = New System.Drawing.Point(620, 393)
        Me.BtnCancel1.Name = "BtnCancel1"
        Me.BtnCancel1.Size = New System.Drawing.Size(41, 38)
        Me.BtnCancel1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BtnCancel1.TabIndex = 79
        Me.BtnCancel1.TabStop = False
        Me.ToolTip1.SetToolTip(Me.BtnCancel1, "Cancelar")
        '
        'lblAddImage
        '
        Me.lblAddImage.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.lblAddImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAddImage.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblAddImage.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddImage.ForeColor = System.Drawing.Color.White
        Me.lblAddImage.Location = New System.Drawing.Point(502, 181)
        Me.lblAddImage.Name = "lblAddImage"
        Me.lblAddImage.Size = New System.Drawing.Size(117, 29)
        Me.lblAddImage.TabIndex = 11
        Me.lblAddImage.Text = "Cambiar Imagen"
        Me.lblAddImage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblRestoDesc
        '
        Me.lblRestoDesc.AutoSize = True
        Me.lblRestoDesc.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRestoDesc.ForeColor = System.Drawing.Color.Lime
        Me.lblRestoDesc.Location = New System.Drawing.Point(399, 150)
        Me.lblRestoDesc.Name = "lblRestoDesc"
        Me.lblRestoDesc.Size = New System.Drawing.Size(25, 19)
        Me.lblRestoDesc.TabIndex = 85
        Me.lblRestoDesc.Text = "50"
        '
        'lblAddStock
        '
        Me.lblAddStock.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.lblAddStock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAddStock.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblAddStock.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddStock.ForeColor = System.Drawing.Color.White
        Me.lblAddStock.Location = New System.Drawing.Point(438, 295)
        Me.lblAddStock.Name = "lblAddStock"
        Me.lblAddStock.Size = New System.Drawing.Size(109, 29)
        Me.lblAddStock.TabIndex = 84
        Me.lblAddStock.Text = "Agregar Stock"
        Me.lblAddStock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblAddStock.Visible = False
        '
        'lblBaja
        '
        Me.lblBaja.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.lblBaja.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblBaja.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblBaja.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBaja.ForeColor = System.Drawing.Color.White
        Me.lblBaja.Location = New System.Drawing.Point(553, 295)
        Me.lblBaja.Name = "lblBaja"
        Me.lblBaja.Size = New System.Drawing.Size(129, 29)
        Me.lblBaja.TabIndex = 83
        Me.lblBaja.Text = "Descontar Stock"
        Me.lblBaja.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblBaja.Visible = False
        '
        'pbxNewProv
        '
        Me.pbxNewProv.BackColor = System.Drawing.Color.Transparent
        Me.pbxNewProv.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pbxNewProv.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbxNewProv.Image = Global.ControlStock.My.Resources.Resources.Plus_over2
        Me.pbxNewProv.Location = New System.Drawing.Point(398, 111)
        Me.pbxNewProv.Name = "pbxNewProv"
        Me.pbxNewProv.Size = New System.Drawing.Size(25, 20)
        Me.pbxNewProv.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbxNewProv.TabIndex = 80
        Me.pbxNewProv.TabStop = False
        Me.ToolTip1.SetToolTip(Me.pbxNewProv, "Nuevo Proveedor")
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox1.InitialImage = Nothing
        Me.PictureBox1.Location = New System.Drawing.Point(458, 36)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(203, 144)
        Me.PictureBox1.TabIndex = 29
        Me.PictureBox1.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(28, 39)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(93, 18)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "Presentación:"
        '
        'cmbPresent
        '
        Me.cmbPresent.AllowDrop = True
        Me.cmbPresent.BackColor = System.Drawing.Color.Snow
        Me.cmbPresent.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbPresent.FormattingEnabled = True
        Me.cmbPresent.Items.AddRange(New Object() {"Unidad", "Unidad y Paquete", "Paquete y Caja", "Metro y Entero", "Piso", "Kilo"})
        Me.cmbPresent.Location = New System.Drawing.Point(148, 35)
        Me.cmbPresent.Name = "cmbPresent"
        Me.cmbPresent.Size = New System.Drawing.Size(244, 27)
        Me.cmbPresent.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(28, 113)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(77, 18)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Proveedor:"
        '
        'cmbProveedor
        '
        Me.cmbProveedor.BackColor = System.Drawing.Color.Snow
        Me.cmbProveedor.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbProveedor.FormattingEnabled = True
        Me.cmbProveedor.Location = New System.Drawing.Point(148, 109)
        Me.cmbProveedor.Name = "cmbProveedor"
        Me.cmbProveedor.Size = New System.Drawing.Size(244, 27)
        Me.cmbProveedor.TabIndex = 1
        '
        'txtStock
        '
        Me.txtStock.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStock.Location = New System.Drawing.Point(458, 255)
        Me.txtStock.Name = "txtStock"
        Me.txtStock.Size = New System.Drawing.Size(203, 27)
        Me.txtStock.TabIndex = 17
        '
        'lblStock
        '
        Me.lblStock.AutoSize = True
        Me.lblStock.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStock.ForeColor = System.Drawing.Color.White
        Me.lblStock.Location = New System.Drawing.Point(407, 259)
        Me.lblStock.Name = "lblStock"
        Me.lblStock.Size = New System.Drawing.Size(45, 18)
        Me.lblStock.TabIndex = 4
        Me.lblStock.Text = "Stock:"
        '
        'ChkGenerar
        '
        Me.ChkGenerar.AutoSize = True
        Me.ChkGenerar.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkGenerar.ForeColor = System.Drawing.Color.White
        Me.ChkGenerar.Location = New System.Drawing.Point(317, 75)
        Me.ChkGenerar.Name = "ChkGenerar"
        Me.ChkGenerar.Size = New System.Drawing.Size(80, 23)
        Me.ChkGenerar.TabIndex = 14
        Me.ChkGenerar.Text = "Generar"
        Me.ChkGenerar.UseVisualStyleBackColor = True
        Me.ChkGenerar.Visible = False
        '
        'txtPrecCompra
        '
        Me.txtPrecCompra.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrecCompra.Location = New System.Drawing.Point(148, 183)
        Me.txtPrecCompra.Name = "txtPrecCompra"
        Me.txtPrecCompra.Size = New System.Drawing.Size(244, 27)
        Me.txtPrecCompra.TabIndex = 3
        '
        'txtDescrip
        '
        Me.txtDescrip.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescrip.Location = New System.Drawing.Point(148, 147)
        Me.txtDescrip.MaxLength = 50
        Me.txtDescrip.Name = "txtDescrip"
        Me.txtDescrip.Size = New System.Drawing.Size(244, 27)
        Me.txtDescrip.TabIndex = 2
        '
        'txtCod
        '
        Me.txtCod.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCod.Location = New System.Drawing.Point(148, 73)
        Me.txtCod.Name = "txtCod"
        Me.txtCod.Size = New System.Drawing.Size(163, 27)
        Me.txtCod.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(28, 187)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 18)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Costo:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(28, 151)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Descripción:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(28, 77)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Código:"
        '
        'lblUnidMedida
        '
        Me.lblUnidMedida.AutoSize = True
        Me.lblUnidMedida.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUnidMedida.ForeColor = System.Drawing.Color.White
        Me.lblUnidMedida.Location = New System.Drawing.Point(664, 259)
        Me.lblUnidMedida.Name = "lblUnidMedida"
        Me.lblUnidMedida.Size = New System.Drawing.Size(29, 19)
        Me.lblUnidMedida.TabIndex = 86
        Me.lblUnidMedida.Text = "Kg."
        Me.lblUnidMedida.Visible = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'ToolTip1
        '
        Me.ToolTip1.AutomaticDelay = 10
        Me.ToolTip1.AutoPopDelay = 2000
        Me.ToolTip1.InitialDelay = 10
        Me.ToolTip1.ReshowDelay = 2
        '
        'FNuevoProducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(765, 476)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "FNuevoProducto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Nuevo Producto"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.pnlPiso.ResumeLayout(False)
        Me.pnlPiso.PerformLayout()
        Me.pnlUnid.ResumeLayout(False)
        Me.pnlUnid.PerformLayout()
        CType(Me.BtnGuardar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnCancel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxNewProv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblStock As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtStock As System.Windows.Forms.TextBox
    Friend WithEvents txtPrecCompra As System.Windows.Forms.TextBox
    Friend WithEvents txtDescrip As System.Windows.Forms.TextBox
    Friend WithEvents txtCod As System.Windows.Forms.TextBox
    Friend WithEvents ChkGenerar As System.Windows.Forms.CheckBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmbProveedor As System.Windows.Forms.ComboBox
    Friend WithEvents lblPack As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtUnidXpack As System.Windows.Forms.TextBox
    Friend WithEvents cmbPresent As System.Windows.Forms.ComboBox
    Friend WithEvents lblPrec1 As System.Windows.Forms.Label
    Friend WithEvents txtPrec1 As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents BtnGuardar1 As System.Windows.Forms.PictureBox
    Friend WithEvents BtnCancel1 As System.Windows.Forms.PictureBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents pbxNewProv As System.Windows.Forms.PictureBox
    Friend WithEvents lblBaja As System.Windows.Forms.Label
    Friend WithEvents lblAddStock As System.Windows.Forms.Label
    Friend WithEvents lblRestoDesc As System.Windows.Forms.Label
    Friend WithEvents lblUnidMedida As System.Windows.Forms.Label
    Friend WithEvents ToolTip2 As System.Windows.Forms.ToolTip
    Friend WithEvents lblPVUnid As System.Windows.Forms.Label
    Friend WithEvents txtPVUnid As System.Windows.Forms.TextBox
    Friend WithEvents txtPVPack As System.Windows.Forms.TextBox
    Friend WithEvents lblPVPack As System.Windows.Forms.Label
    Friend WithEvents lblAddImage As System.Windows.Forms.Label
    Friend WithEvents txtPrec2 As System.Windows.Forms.TextBox
    Friend WithEvents lblPrec2 As System.Windows.Forms.Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtIva As TextBox
    Friend WithEvents pnlPiso As Panel
    Friend WithEvents txtUnidxPackPiso As TextBox
    Friend WithEvents txtLado1 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents txtPrecioMetro As TextBox
    Friend WithEvents txtPrecioCaja As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents TxtPrecioUnid As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtLado2 As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txtMxCaja As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents pnlUnid As Panel
End Class
