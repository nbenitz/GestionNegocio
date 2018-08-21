<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FVenta
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Del = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Cod = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cantt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Precio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Importe = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descuento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Unidades = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Obs = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Iva = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.tmrTotal = New System.Windows.Forms.Timer(Me.components)
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblHab2 = New System.Windows.Forms.Label()
        Me.lblHab = New System.Windows.Forms.Label()
        Me.LblTituloHab = New System.Windows.Forms.Label()
        Me.cmbVendedor = New System.Windows.Forms.ComboBox()
        Me.btnGuardar = New System.Windows.Forms.PictureBox()
        Me.btnCancel = New System.Windows.Forms.PictureBox()
        Me.pnlXPack = New System.Windows.Forms.Panel()
        Me.btnUnidad = New System.Windows.Forms.Button()
        Me.btnPack = New System.Windows.Forms.Button()
        Me.btnPackCancel = New System.Windows.Forms.Button()
        Me.lblTituloXPack = New System.Windows.Forms.Label()
        Me.pnlPrecios = New System.Windows.Forms.Panel()
        Me.optPrecio3 = New System.Windows.Forms.RadioButton()
        Me.optPrecio2 = New System.Windows.Forms.RadioButton()
        Me.optPrecio1 = New System.Windows.Forms.RadioButton()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.lblTitPrecios = New System.Windows.Forms.Label()
        Me.pnlEditCant = New System.Windows.Forms.Panel()
        Me.btnEditCantCancel = New System.Windows.Forms.Button()
        Me.txtEditCant = New System.Windows.Forms.TextBox()
        Me.lblEditCant = New System.Windows.Forms.Label()
        Me.chkMayorista = New System.Windows.Forms.CheckBox()
        Me.pbxBuscCli = New System.Windows.Forms.PictureBox()
        Me.pnlCredito = New System.Windows.Forms.Panel()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.dtpVto = New System.Windows.Forms.DateTimePicker()
        Me.btnCredCancel = New System.Windows.Forms.Button()
        Me.lblCredGs = New System.Windows.Forms.Label()
        Me.btnCredOk = New System.Windows.Forms.Button()
        Me.txtCredEntrega = New System.Windows.Forms.TextBox()
        Me.btnCredNo = New System.Windows.Forms.Button()
        Me.btnCredSi = New System.Windows.Forms.Button()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.optCredito = New System.Windows.Forms.RadioButton()
        Me.optContado = New System.Windows.Forms.RadioButton()
        Me.txtCliente = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtFecha = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNroFac = New System.Windows.Forms.TextBox()
        Me.pnlProdInfo = New System.Windows.Forms.Panel()
        Me.pnlPrecVenta = New System.Windows.Forms.Panel()
        Me.lblCantDesc = New System.Windows.Forms.Label()
        Me.lblPrecCant = New System.Windows.Forms.Label()
        Me.lblPrecPack = New System.Windows.Forms.Label()
        Me.lblPrecUnit = New System.Windows.Forms.Label()
        Me.Label90 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.lblInfoCod = New System.Windows.Forms.Label()
        Me.lblInfoDesc = New System.Windows.Forms.Label()
        Me.lblInfoStock = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.lblInfoPrec = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lblInfoPrec2 = New System.Windows.Forms.Label()
        Me.pnlCliente = New System.Windows.Forms.Panel()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnCliGuardar = New System.Windows.Forms.Button()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.txtCliTel = New System.Windows.Forms.TextBox()
        Me.txtCliCI = New System.Windows.Forms.TextBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.txtCliDir = New System.Windows.Forms.TextBox()
        Me.txtCliNom = New System.Windows.Forms.TextBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.btnBusCliCancel = New System.Windows.Forms.Button()
        Me.btnCliAdd = New System.Windows.Forms.Button()
        Me.pnlInfoCli = New System.Windows.Forms.Panel()
        Me.lblCliDir = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.lblCliTel = New System.Windows.Forms.Label()
        Me.lblCliNom = New System.Windows.Forms.Label()
        Me.lblCliCI = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.cmbCliResult = New System.Windows.Forms.ComboBox()
        Me.cmbCliBuscarPor = New System.Windows.Forms.ComboBox()
        Me.txtCliBuscar = New System.Windows.Forms.TextBox()
        Me.pnlBuscProd = New System.Windows.Forms.Panel()
        Me.lblUnidXpack = New System.Windows.Forms.Label()
        Me.pnlVenderPor = New System.Windows.Forms.Panel()
        Me.optPaquete = New System.Windows.Forms.RadioButton()
        Me.optUnidad = New System.Windows.Forms.RadioButton()
        Me.lblVenderPor = New System.Windows.Forms.Label()
        Me.txtDescuent = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.lblX = New System.Windows.Forms.Label()
        Me.cmbDescrip = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.lblCant = New System.Windows.Forms.Label()
        Me.lblDesc = New System.Windows.Forms.Label()
        Me.txtCant = New System.Windows.Forms.TextBox()
        Me.chkDesc = New System.Windows.Forms.CheckBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.optCod = New System.Windows.Forms.RadioButton()
        Me.optDesc = New System.Windows.Forms.RadioButton()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.tmrCliente = New System.Windows.Forms.Timer(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTip2 = New System.Windows.Forms.ToolTip(Me.components)
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.btnGuardar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnCancel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlXPack.SuspendLayout()
        Me.pnlPrecios.SuspendLayout()
        Me.pnlEditCant.SuspendLayout()
        CType(Me.pbxBuscCli, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlCredito.SuspendLayout()
        Me.pnlProdInfo.SuspendLayout()
        Me.pnlPrecVenta.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlCliente.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.pnlInfoCli.SuspendLayout()
        Me.pnlBuscProd.SuspendLayout()
        Me.pnlVenderPor.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Del, Me.Cod, Me.Descripcion, Me.Cantt, Me.Precio, Me.Importe, Me.Descuento, Me.Unidades, Me.Obs, Me.Iva})
        Me.DataGridView1.Location = New System.Drawing.Point(8, 117)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.Size = New System.Drawing.Size(565, 361)
        Me.DataGridView1.TabIndex = 0
        '
        'Del
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.NullValue = Nothing
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.White
        Me.Del.DefaultCellStyle = DataGridViewCellStyle5
        Me.Del.HeaderText = ""
        Me.Del.Name = "Del"
        Me.Del.ReadOnly = True
        Me.Del.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Del.Width = 22
        '
        'Cod
        '
        Me.Cod.FillWeight = 40.0!
        Me.Cod.HeaderText = "Código"
        Me.Cod.Name = "Cod"
        Me.Cod.ReadOnly = True
        Me.Cod.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Cod.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Cod.Width = 74
        '
        'Descripcion
        '
        Me.Descripcion.HeaderText = "Descripción"
        Me.Descripcion.Name = "Descripcion"
        Me.Descripcion.ReadOnly = True
        Me.Descripcion.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Descripcion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Descripcion.Width = 235
        '
        'Cantt
        '
        Me.Cantt.HeaderText = "Cant"
        Me.Cantt.Name = "Cantt"
        Me.Cantt.ReadOnly = True
        Me.Cantt.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Cantt.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Cantt.Width = 65
        '
        'Precio
        '
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle6.Format = "N0"
        DataGridViewCellStyle6.NullValue = Nothing
        Me.Precio.DefaultCellStyle = DataGridViewCellStyle6
        Me.Precio.HeaderText = "Precio"
        Me.Precio.Name = "Precio"
        Me.Precio.ReadOnly = True
        Me.Precio.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Precio.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Precio.Width = 75
        '
        'Importe
        '
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle7.Format = "N0"
        DataGridViewCellStyle7.NullValue = Nothing
        Me.Importe.DefaultCellStyle = DataGridViewCellStyle7
        Me.Importe.HeaderText = "Importe"
        Me.Importe.Name = "Importe"
        Me.Importe.ReadOnly = True
        Me.Importe.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Importe.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Importe.Width = 75
        '
        'Descuento
        '
        Me.Descuento.HeaderText = "Desc"
        Me.Descuento.Name = "Descuento"
        Me.Descuento.ReadOnly = True
        Me.Descuento.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Descuento.Visible = False
        Me.Descuento.Width = 50
        '
        'Unidades
        '
        Me.Unidades.HeaderText = "Unidades"
        Me.Unidades.Name = "Unidades"
        Me.Unidades.ReadOnly = True
        Me.Unidades.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Unidades.Visible = False
        '
        'Obs
        '
        Me.Obs.HeaderText = "Obs"
        Me.Obs.Name = "Obs"
        Me.Obs.ReadOnly = True
        Me.Obs.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Obs.Visible = False
        '
        'Iva
        '
        Me.Iva.HeaderText = "Iva"
        Me.Iva.Name = "Iva"
        Me.Iva.ReadOnly = True
        Me.Iva.Visible = False
        Me.Iva.Width = 50
        '
        'txtTotal
        '
        Me.txtTotal.BackColor = System.Drawing.Color.White
        Me.txtTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.Location = New System.Drawing.Point(433, 495)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtTotal.Size = New System.Drawing.Size(138, 31)
        Me.txtTotal.TabIndex = 38
        Me.txtTotal.Text = "0"
        '
        'Timer1
        '
        Me.Timer1.Interval = 20
        '
        'tmrTotal
        '
        Me.tmrTotal.Interval = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(324, 502)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(103, 16)
        Me.Label6.TabIndex = 48
        Me.Label6.Text = "Total a Pagar"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.Label10.Location = New System.Drawing.Point(11, 229)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(40, 13)
        Me.Label10.TabIndex = 3
        Me.Label10.Text = "Stock"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.Label9.Location = New System.Drawing.Point(67, 2)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(104, 13)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "Precios de Venta"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.Label8.Location = New System.Drawing.Point(11, 207)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(54, 13)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Descrip."
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.Label7.Location = New System.Drawing.Point(11, 184)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(33, 13)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Cód."
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.SplitContainer1.Location = New System.Drawing.Point(3, 5)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.BackColor = System.Drawing.Color.White
        Me.SplitContainer1.Panel1.Controls.Add(Me.Panel1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.pnlProdInfo)
        Me.SplitContainer1.Panel2.Controls.Add(Me.pnlCliente)
        Me.SplitContainer1.Size = New System.Drawing.Size(848, 554)
        Me.SplitContainer1.SplitterDistance = 584
        Me.SplitContainer1.TabIndex = 54
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lblHab2)
        Me.Panel1.Controls.Add(Me.lblHab)
        Me.Panel1.Controls.Add(Me.LblTituloHab)
        Me.Panel1.Controls.Add(Me.cmbVendedor)
        Me.Panel1.Controls.Add(Me.btnGuardar)
        Me.Panel1.Controls.Add(Me.btnCancel)
        Me.Panel1.Controls.Add(Me.pnlXPack)
        Me.Panel1.Controls.Add(Me.pnlPrecios)
        Me.Panel1.Controls.Add(Me.pnlEditCant)
        Me.Panel1.Controls.Add(Me.chkMayorista)
        Me.Panel1.Controls.Add(Me.pbxBuscCli)
        Me.Panel1.Controls.Add(Me.pnlCredito)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.txtTotal)
        Me.Panel1.Controls.Add(Me.Label17)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.optCredito)
        Me.Panel1.Controls.Add(Me.DataGridView1)
        Me.Panel1.Controls.Add(Me.optContado)
        Me.Panel1.Controls.Add(Me.txtCliente)
        Me.Panel1.Controls.Add(Me.Label16)
        Me.Panel1.Controls.Add(Me.Label18)
        Me.Panel1.Controls.Add(Me.txtFecha)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txtNroFac)
        Me.Panel1.Location = New System.Drawing.Point(3, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(576, 541)
        Me.Panel1.TabIndex = 55
        '
        'lblHab2
        '
        Me.lblHab2.AutoSize = True
        Me.lblHab2.BackColor = System.Drawing.Color.Black
        Me.lblHab2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lblHab2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold)
        Me.lblHab2.ForeColor = System.Drawing.Color.White
        Me.lblHab2.Location = New System.Drawing.Point(0, 0)
        Me.lblHab2.Name = "lblHab2"
        Me.lblHab2.Size = New System.Drawing.Size(21, 22)
        Me.lblHab2.TabIndex = 89
        Me.lblHab2.Text = "0"
        Me.lblHab2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblHab
        '
        Me.lblHab.AutoSize = True
        Me.lblHab.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHab.Location = New System.Drawing.Point(323, 33)
        Me.lblHab.Name = "lblHab"
        Me.lblHab.Size = New System.Drawing.Size(19, 20)
        Me.lblHab.TabIndex = 88
        Me.lblHab.Text = "0"
        '
        'LblTituloHab
        '
        Me.LblTituloHab.AutoSize = True
        Me.LblTituloHab.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTituloHab.Location = New System.Drawing.Point(229, 33)
        Me.LblTituloHab.Name = "LblTituloHab"
        Me.LblTituloHab.Size = New System.Drawing.Size(100, 20)
        Me.LblTituloHab.TabIndex = 87
        Me.LblTituloHab.Text = "Habitación "
        '
        'cmbVendedor
        '
        Me.cmbVendedor.Enabled = False
        Me.cmbVendedor.FormattingEnabled = True
        Me.cmbVendedor.Location = New System.Drawing.Point(83, 89)
        Me.cmbVendedor.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbVendedor.Name = "cmbVendedor"
        Me.cmbVendedor.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmbVendedor.Size = New System.Drawing.Size(111, 21)
        Me.cmbVendedor.TabIndex = 84
        '
        'btnGuardar
        '
        Me.btnGuardar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnGuardar.BackColor = System.Drawing.Color.Transparent
        Me.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGuardar.Image = Global.ControlStock.My.Resources.Resources.file_apply
        Me.btnGuardar.Location = New System.Drawing.Point(60, 479)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(57, 57)
        Me.btnGuardar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnGuardar.TabIndex = 42
        Me.btnGuardar.TabStop = False
        Me.ToolTip1.SetToolTip(Me.btnGuardar, "Registrar Venta")
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnCancel.BackColor = System.Drawing.Color.Transparent
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancel.Image = Global.ControlStock.My.Resources.Resources.file_exclude
        Me.btnCancel.Location = New System.Drawing.Point(4, 479)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(57, 57)
        Me.btnCancel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnCancel.TabIndex = 41
        Me.btnCancel.TabStop = False
        Me.ToolTip1.SetToolTip(Me.btnCancel, "Cancelar")
        '
        'pnlXPack
        '
        Me.pnlXPack.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlXPack.Controls.Add(Me.btnUnidad)
        Me.pnlXPack.Controls.Add(Me.btnPack)
        Me.pnlXPack.Controls.Add(Me.btnPackCancel)
        Me.pnlXPack.Controls.Add(Me.lblTituloXPack)
        Me.pnlXPack.Location = New System.Drawing.Point(173, 236)
        Me.pnlXPack.Name = "pnlXPack"
        Me.pnlXPack.Size = New System.Drawing.Size(209, 91)
        Me.pnlXPack.TabIndex = 82
        Me.pnlXPack.Visible = False
        '
        'btnUnidad
        '
        Me.btnUnidad.BackColor = System.Drawing.Color.White
        Me.btnUnidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUnidad.Location = New System.Drawing.Point(113, 44)
        Me.btnUnidad.Name = "btnUnidad"
        Me.btnUnidad.Size = New System.Drawing.Size(70, 25)
        Me.btnUnidad.TabIndex = 73
        Me.btnUnidad.Text = "Unidad"
        Me.btnUnidad.UseVisualStyleBackColor = False
        '
        'btnPack
        '
        Me.btnPack.BackColor = System.Drawing.Color.White
        Me.btnPack.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPack.Location = New System.Drawing.Point(22, 44)
        Me.btnPack.Name = "btnPack"
        Me.btnPack.Size = New System.Drawing.Size(70, 25)
        Me.btnPack.TabIndex = 72
        Me.btnPack.Text = "Paquete"
        Me.btnPack.UseVisualStyleBackColor = False
        '
        'btnPackCancel
        '
        Me.btnPackCancel.BackColor = System.Drawing.Color.White
        Me.btnPackCancel.FlatAppearance.BorderSize = 0
        Me.btnPackCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPackCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPackCancel.Image = Global.ControlStock.My.Resources.Resources.cancel
        Me.btnPackCancel.Location = New System.Drawing.Point(186, 3)
        Me.btnPackCancel.Name = "btnPackCancel"
        Me.btnPackCancel.Size = New System.Drawing.Size(18, 18)
        Me.btnPackCancel.TabIndex = 71
        Me.btnPackCancel.UseVisualStyleBackColor = False
        '
        'lblTituloXPack
        '
        Me.lblTituloXPack.AutoSize = True
        Me.lblTituloXPack.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTituloXPack.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lblTituloXPack.Location = New System.Drawing.Point(56, 10)
        Me.lblTituloXPack.Name = "lblTituloXPack"
        Me.lblTituloXPack.Size = New System.Drawing.Size(92, 18)
        Me.lblTituloXPack.TabIndex = 65
        Me.lblTituloXPack.Text = "Vender Por"
        '
        'pnlPrecios
        '
        Me.pnlPrecios.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlPrecios.Controls.Add(Me.optPrecio3)
        Me.pnlPrecios.Controls.Add(Me.optPrecio2)
        Me.pnlPrecios.Controls.Add(Me.optPrecio1)
        Me.pnlPrecios.Controls.Add(Me.Button2)
        Me.pnlPrecios.Controls.Add(Me.lblTitPrecios)
        Me.pnlPrecios.Location = New System.Drawing.Point(363, 195)
        Me.pnlPrecios.Name = "pnlPrecios"
        Me.pnlPrecios.Size = New System.Drawing.Size(181, 102)
        Me.pnlPrecios.TabIndex = 83
        Me.pnlPrecios.Visible = False
        '
        'optPrecio3
        '
        Me.optPrecio3.AutoSize = True
        Me.optPrecio3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optPrecio3.ForeColor = System.Drawing.Color.Black
        Me.optPrecio3.Location = New System.Drawing.Point(41, 82)
        Me.optPrecio3.Name = "optPrecio3"
        Me.optPrecio3.Size = New System.Drawing.Size(64, 17)
        Me.optPrecio3.TabIndex = 74
        Me.optPrecio3.Text = "Precio 3"
        Me.optPrecio3.UseVisualStyleBackColor = True
        Me.optPrecio3.Visible = False
        '
        'optPrecio2
        '
        Me.optPrecio2.AutoSize = True
        Me.optPrecio2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optPrecio2.ForeColor = System.Drawing.Color.Black
        Me.optPrecio2.Location = New System.Drawing.Point(41, 59)
        Me.optPrecio2.Name = "optPrecio2"
        Me.optPrecio2.Size = New System.Drawing.Size(64, 17)
        Me.optPrecio2.TabIndex = 73
        Me.optPrecio2.Text = "Precio 2"
        Me.optPrecio2.UseVisualStyleBackColor = True
        '
        'optPrecio1
        '
        Me.optPrecio1.AutoSize = True
        Me.optPrecio1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optPrecio1.ForeColor = System.Drawing.Color.Black
        Me.optPrecio1.Location = New System.Drawing.Point(41, 36)
        Me.optPrecio1.Name = "optPrecio1"
        Me.optPrecio1.Size = New System.Drawing.Size(64, 17)
        Me.optPrecio1.TabIndex = 72
        Me.optPrecio1.Text = "Precio 1"
        Me.optPrecio1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.White
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Image = Global.ControlStock.My.Resources.Resources.cancel
        Me.Button2.Location = New System.Drawing.Point(157, 2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(18, 18)
        Me.Button2.TabIndex = 71
        Me.Button2.UseVisualStyleBackColor = False
        '
        'lblTitPrecios
        '
        Me.lblTitPrecios.AutoSize = True
        Me.lblTitPrecios.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitPrecios.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lblTitPrecios.Location = New System.Drawing.Point(15, 10)
        Me.lblTitPrecios.Name = "lblTitPrecios"
        Me.lblTitPrecios.Size = New System.Drawing.Size(136, 18)
        Me.lblTitPrecios.TabIndex = 65
        Me.lblTitPrecios.Text = "Precios de Venta"
        '
        'pnlEditCant
        '
        Me.pnlEditCant.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlEditCant.Controls.Add(Me.btnEditCantCancel)
        Me.pnlEditCant.Controls.Add(Me.txtEditCant)
        Me.pnlEditCant.Controls.Add(Me.lblEditCant)
        Me.pnlEditCant.Location = New System.Drawing.Point(176, 195)
        Me.pnlEditCant.Name = "pnlEditCant"
        Me.pnlEditCant.Size = New System.Drawing.Size(204, 70)
        Me.pnlEditCant.TabIndex = 81
        Me.pnlEditCant.Visible = False
        '
        'btnEditCantCancel
        '
        Me.btnEditCantCancel.BackColor = System.Drawing.Color.White
        Me.btnEditCantCancel.FlatAppearance.BorderSize = 0
        Me.btnEditCantCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditCantCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditCantCancel.Image = Global.ControlStock.My.Resources.Resources.cancel
        Me.btnEditCantCancel.Location = New System.Drawing.Point(181, 3)
        Me.btnEditCantCancel.Name = "btnEditCantCancel"
        Me.btnEditCantCancel.Size = New System.Drawing.Size(18, 18)
        Me.btnEditCantCancel.TabIndex = 71
        Me.btnEditCantCancel.UseVisualStyleBackColor = False
        '
        'txtEditCant
        '
        Me.txtEditCant.Location = New System.Drawing.Point(18, 34)
        Me.txtEditCant.Name = "txtEditCant"
        Me.txtEditCant.Size = New System.Drawing.Size(168, 20)
        Me.txtEditCant.TabIndex = 68
        '
        'lblEditCant
        '
        Me.lblEditCant.AutoSize = True
        Me.lblEditCant.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEditCant.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lblEditCant.Location = New System.Drawing.Point(15, 10)
        Me.lblEditCant.Name = "lblEditCant"
        Me.lblEditCant.Size = New System.Drawing.Size(123, 18)
        Me.lblEditCant.TabIndex = 65
        Me.lblEditCant.Text = "Editar Cantidad"
        '
        'chkMayorista
        '
        Me.chkMayorista.AutoSize = True
        Me.chkMayorista.Location = New System.Drawing.Point(425, 35)
        Me.chkMayorista.Name = "chkMayorista"
        Me.chkMayorista.Size = New System.Drawing.Size(71, 17)
        Me.chkMayorista.TabIndex = 80
        Me.chkMayorista.Text = "Mayorista"
        Me.chkMayorista.UseVisualStyleBackColor = True
        '
        'pbxBuscCli
        '
        Me.pbxBuscCli.BackColor = System.Drawing.Color.Transparent
        Me.pbxBuscCli.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pbxBuscCli.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbxBuscCli.Image = Global.ControlStock.My.Resources.Resources.find
        Me.pbxBuscCli.Location = New System.Drawing.Point(529, 60)
        Me.pbxBuscCli.Name = "pbxBuscCli"
        Me.pbxBuscCli.Size = New System.Drawing.Size(25, 22)
        Me.pbxBuscCli.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbxBuscCli.TabIndex = 79
        Me.pbxBuscCli.TabStop = False
        Me.ToolTip1.SetToolTip(Me.pbxBuscCli, "Buscar Cliente")
        '
        'pnlCredito
        '
        Me.pnlCredito.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlCredito.Controls.Add(Me.Label39)
        Me.pnlCredito.Controls.Add(Me.dtpVto)
        Me.pnlCredito.Controls.Add(Me.btnCredCancel)
        Me.pnlCredito.Controls.Add(Me.lblCredGs)
        Me.pnlCredito.Controls.Add(Me.btnCredOk)
        Me.pnlCredito.Controls.Add(Me.txtCredEntrega)
        Me.pnlCredito.Controls.Add(Me.btnCredNo)
        Me.pnlCredito.Controls.Add(Me.btnCredSi)
        Me.pnlCredito.Controls.Add(Me.Label38)
        Me.pnlCredito.Controls.Add(Me.Label37)
        Me.pnlCredito.Location = New System.Drawing.Point(130, 288)
        Me.pnlCredito.Name = "pnlCredito"
        Me.pnlCredito.Size = New System.Drawing.Size(291, 179)
        Me.pnlCredito.TabIndex = 56
        Me.pnlCredito.Visible = False
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label39.ForeColor = System.Drawing.Color.Maroon
        Me.Label39.Location = New System.Drawing.Point(33, 45)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(93, 16)
        Me.Label39.TabIndex = 73
        Me.Label39.Text = "Vencimiento"
        '
        'dtpVto
        '
        Me.dtpVto.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpVto.Location = New System.Drawing.Point(132, 44)
        Me.dtpVto.Name = "dtpVto"
        Me.dtpVto.Size = New System.Drawing.Size(117, 20)
        Me.dtpVto.TabIndex = 72
        '
        'btnCredCancel
        '
        Me.btnCredCancel.BackColor = System.Drawing.Color.White
        Me.btnCredCancel.FlatAppearance.BorderSize = 0
        Me.btnCredCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCredCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCredCancel.Image = Global.ControlStock.My.Resources.Resources.cancel
        Me.btnCredCancel.Location = New System.Drawing.Point(264, 5)
        Me.btnCredCancel.Name = "btnCredCancel"
        Me.btnCredCancel.Size = New System.Drawing.Size(18, 18)
        Me.btnCredCancel.TabIndex = 70
        Me.btnCredCancel.UseVisualStyleBackColor = False
        '
        'lblCredGs
        '
        Me.lblCredGs.AutoSize = True
        Me.lblCredGs.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCredGs.ForeColor = System.Drawing.Color.Black
        Me.lblCredGs.Location = New System.Drawing.Point(45, 141)
        Me.lblCredGs.Name = "lblCredGs"
        Me.lblCredGs.Size = New System.Drawing.Size(31, 16)
        Me.lblCredGs.TabIndex = 69
        Me.lblCredGs.Text = "Gs."
        '
        'btnCredOk
        '
        Me.btnCredOk.BackColor = System.Drawing.Color.White
        Me.btnCredOk.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCredOk.Location = New System.Drawing.Point(210, 137)
        Me.btnCredOk.Name = "btnCredOk"
        Me.btnCredOk.Size = New System.Drawing.Size(63, 25)
        Me.btnCredOk.TabIndex = 68
        Me.btnCredOk.Text = "Aceptar"
        Me.btnCredOk.UseVisualStyleBackColor = False
        '
        'txtCredEntrega
        '
        Me.txtCredEntrega.Location = New System.Drawing.Point(79, 140)
        Me.txtCredEntrega.Name = "txtCredEntrega"
        Me.txtCredEntrega.Size = New System.Drawing.Size(125, 20)
        Me.txtCredEntrega.TabIndex = 67
        '
        'btnCredNo
        '
        Me.btnCredNo.BackColor = System.Drawing.Color.White
        Me.btnCredNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCredNo.Location = New System.Drawing.Point(154, 102)
        Me.btnCredNo.Name = "btnCredNo"
        Me.btnCredNo.Size = New System.Drawing.Size(35, 25)
        Me.btnCredNo.TabIndex = 66
        Me.btnCredNo.Text = "No"
        Me.btnCredNo.UseVisualStyleBackColor = False
        '
        'btnCredSi
        '
        Me.btnCredSi.BackColor = System.Drawing.Color.White
        Me.btnCredSi.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCredSi.Location = New System.Drawing.Point(95, 102)
        Me.btnCredSi.Name = "btnCredSi"
        Me.btnCredSi.Size = New System.Drawing.Size(35, 25)
        Me.btnCredSi.TabIndex = 65
        Me.btnCredSi.Text = "Si"
        Me.btnCredSi.UseVisualStyleBackColor = False
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label38.ForeColor = System.Drawing.Color.Maroon
        Me.Label38.Location = New System.Drawing.Point(16, 73)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(257, 16)
        Me.Label38.TabIndex = 64
        Me.Label38.Text = "¿Desea realizar una entrega inicial?"
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label37.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label37.Location = New System.Drawing.Point(67, 14)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(154, 24)
        Me.Label37.TabIndex = 64
        Me.Label37.Text = "Venta a Crédito"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(358, 64)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(46, 13)
        Me.Label17.TabIndex = 53
        Me.Label17.Text = "Cliente"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(358, 92)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 52
        Me.Label1.Text = "Condición"
        '
        'optCredito
        '
        Me.optCredito.AutoSize = True
        Me.optCredito.Location = New System.Drawing.Point(498, 91)
        Me.optCredito.Name = "optCredito"
        Me.optCredito.Size = New System.Drawing.Size(58, 17)
        Me.optCredito.TabIndex = 51
        Me.optCredito.Text = "Crédito"
        Me.optCredito.UseVisualStyleBackColor = True
        '
        'optContado
        '
        Me.optContado.AutoSize = True
        Me.optContado.Checked = True
        Me.optContado.Location = New System.Drawing.Point(425, 91)
        Me.optContado.Name = "optContado"
        Me.optContado.Size = New System.Drawing.Size(65, 17)
        Me.optContado.TabIndex = 50
        Me.optContado.TabStop = True
        Me.optContado.Text = "Contado"
        Me.optContado.UseVisualStyleBackColor = True
        '
        'txtCliente
        '
        Me.txtCliente.BackColor = System.Drawing.Color.White
        Me.txtCliente.Location = New System.Drawing.Point(425, 61)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.ReadOnly = True
        Me.txtCliente.Size = New System.Drawing.Size(99, 20)
        Me.txtCliente.TabIndex = 49
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(5, 92)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(60, 13)
        Me.Label16.TabIndex = 45
        Me.Label16.Text = "Cajero/ra"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(229, 12)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(71, 20)
        Me.Label18.TabIndex = 40
        Me.Label18.Text = "Factura"
        '
        'txtFecha
        '
        Me.txtFecha.BackColor = System.Drawing.Color.White
        Me.txtFecha.Location = New System.Drawing.Point(83, 61)
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.ReadOnly = True
        Me.txtFecha.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtFecha.Size = New System.Drawing.Size(111, 20)
        Me.txtFecha.TabIndex = 42
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(5, 36)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 13)
        Me.Label3.TabIndex = 37
        Me.Label3.Text = "Nro. Factura"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(5, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 13)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "Fecha"
        '
        'txtNroFac
        '
        Me.txtNroFac.BackColor = System.Drawing.Color.White
        Me.txtNroFac.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNroFac.Location = New System.Drawing.Point(83, 33)
        Me.txtNroFac.Name = "txtNroFac"
        Me.txtNroFac.ReadOnly = True
        Me.txtNroFac.Size = New System.Drawing.Size(111, 20)
        Me.txtNroFac.TabIndex = 36
        Me.txtNroFac.Text = "0"
        Me.txtNroFac.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'pnlProdInfo
        '
        Me.pnlProdInfo.Controls.Add(Me.pnlPrecVenta)
        Me.pnlProdInfo.Controls.Add(Me.Label24)
        Me.pnlProdInfo.Controls.Add(Me.Label23)
        Me.pnlProdInfo.Controls.Add(Me.lblInfoCod)
        Me.pnlProdInfo.Controls.Add(Me.lblInfoDesc)
        Me.pnlProdInfo.Controls.Add(Me.lblInfoStock)
        Me.pnlProdInfo.Controls.Add(Me.PictureBox1)
        Me.pnlProdInfo.Controls.Add(Me.Label7)
        Me.pnlProdInfo.Controls.Add(Me.Label26)
        Me.pnlProdInfo.Controls.Add(Me.Label8)
        Me.pnlProdInfo.Controls.Add(Me.Label10)
        Me.pnlProdInfo.Controls.Add(Me.lblInfoPrec)
        Me.pnlProdInfo.Controls.Add(Me.Label12)
        Me.pnlProdInfo.Controls.Add(Me.lblInfoPrec2)
        Me.pnlProdInfo.Location = New System.Drawing.Point(3, 202)
        Me.pnlProdInfo.Name = "pnlProdInfo"
        Me.pnlProdInfo.Size = New System.Drawing.Size(248, 343)
        Me.pnlProdInfo.TabIndex = 67
        '
        'pnlPrecVenta
        '
        Me.pnlPrecVenta.Controls.Add(Me.lblCantDesc)
        Me.pnlPrecVenta.Controls.Add(Me.lblPrecCant)
        Me.pnlPrecVenta.Controls.Add(Me.lblPrecPack)
        Me.pnlPrecVenta.Controls.Add(Me.lblPrecUnit)
        Me.pnlPrecVenta.Controls.Add(Me.Label90)
        Me.pnlPrecVenta.Controls.Add(Me.Label19)
        Me.pnlPrecVenta.Controls.Add(Me.Label21)
        Me.pnlPrecVenta.Controls.Add(Me.Label20)
        Me.pnlPrecVenta.Controls.Add(Me.Label9)
        Me.pnlPrecVenta.Location = New System.Drawing.Point(0, 247)
        Me.pnlPrecVenta.Name = "pnlPrecVenta"
        Me.pnlPrecVenta.Size = New System.Drawing.Size(248, 96)
        Me.pnlPrecVenta.TabIndex = 55
        '
        'lblCantDesc
        '
        Me.lblCantDesc.AutoSize = True
        Me.lblCantDesc.ForeColor = System.Drawing.Color.White
        Me.lblCantDesc.Location = New System.Drawing.Point(170, 78)
        Me.lblCantDesc.Name = "lblCantDesc"
        Me.lblCantDesc.Size = New System.Drawing.Size(73, 13)
        Me.lblCantDesc.TabIndex = 62
        Me.lblCantDesc.Text = "xxx Unidades)"
        Me.lblCantDesc.Visible = False
        '
        'lblPrecCant
        '
        Me.lblPrecCant.AutoSize = True
        Me.lblPrecCant.ForeColor = System.Drawing.Color.White
        Me.lblPrecCant.Location = New System.Drawing.Point(96, 62)
        Me.lblPrecCant.Name = "lblPrecCant"
        Me.lblPrecCant.Size = New System.Drawing.Size(22, 13)
        Me.lblPrecCant.TabIndex = 61
        Me.lblPrecCant.Text = "xxx"
        Me.lblPrecCant.Visible = False
        '
        'lblPrecPack
        '
        Me.lblPrecPack.AutoSize = True
        Me.lblPrecPack.ForeColor = System.Drawing.Color.White
        Me.lblPrecPack.Location = New System.Drawing.Point(93, 41)
        Me.lblPrecPack.Name = "lblPrecPack"
        Me.lblPrecPack.Size = New System.Drawing.Size(22, 13)
        Me.lblPrecPack.TabIndex = 60
        Me.lblPrecPack.Text = "xxx"
        '
        'lblPrecUnit
        '
        Me.lblPrecUnit.AutoSize = True
        Me.lblPrecUnit.ForeColor = System.Drawing.Color.White
        Me.lblPrecUnit.Location = New System.Drawing.Point(86, 20)
        Me.lblPrecUnit.Name = "lblPrecUnit"
        Me.lblPrecUnit.Size = New System.Drawing.Size(22, 13)
        Me.lblPrecUnit.TabIndex = 59
        Me.lblPrecUnit.Text = "xxx"
        '
        'Label90
        '
        Me.Label90.AutoSize = True
        Me.Label90.ForeColor = System.Drawing.Color.White
        Me.Label90.Location = New System.Drawing.Point(113, 78)
        Me.Label90.Name = "Label90"
        Me.Label90.Size = New System.Drawing.Size(58, 13)
        Me.Label90.TabIndex = 58
        Me.Label90.Text = "(A partir de"
        Me.Label90.Visible = False
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.Label19.Location = New System.Drawing.Point(3, 20)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(82, 13)
        Me.Label19.TabIndex = 56
        Me.Label19.Text = "- Por Unidad:"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.Label21.Location = New System.Drawing.Point(3, 41)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(89, 13)
        Me.Label21.TabIndex = 57
        Me.Label21.Text = "- Por Paquete:"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.Label20.Location = New System.Drawing.Point(3, 62)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(92, 13)
        Me.Label20.TabIndex = 3
        Me.Label20.Text = "- Por Cantidad:"
        Me.Label20.Visible = False
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.Label24.Location = New System.Drawing.Point(66, 169)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(106, 13)
        Me.Label24.TabIndex = 64
        Me.Label24.Text = "Info. de Producto"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.Label23.Location = New System.Drawing.Point(98, 4)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(32, 13)
        Me.Label23.TabIndex = 63
        Me.Label23.Text = "Foto"
        '
        'lblInfoCod
        '
        Me.lblInfoCod.AutoSize = True
        Me.lblInfoCod.ForeColor = System.Drawing.Color.White
        Me.lblInfoCod.Location = New System.Drawing.Point(44, 184)
        Me.lblInfoCod.Name = "lblInfoCod"
        Me.lblInfoCod.Size = New System.Drawing.Size(22, 13)
        Me.lblInfoCod.TabIndex = 62
        Me.lblInfoCod.Text = "xxx"
        '
        'lblInfoDesc
        '
        Me.lblInfoDesc.AutoSize = True
        Me.lblInfoDesc.ForeColor = System.Drawing.Color.White
        Me.lblInfoDesc.Location = New System.Drawing.Point(66, 207)
        Me.lblInfoDesc.Name = "lblInfoDesc"
        Me.lblInfoDesc.Size = New System.Drawing.Size(22, 13)
        Me.lblInfoDesc.TabIndex = 61
        Me.lblInfoDesc.Text = "xxx"
        '
        'lblInfoStock
        '
        Me.lblInfoStock.AutoSize = True
        Me.lblInfoStock.ForeColor = System.Drawing.Color.White
        Me.lblInfoStock.Location = New System.Drawing.Point(54, 229)
        Me.lblInfoStock.Name = "lblInfoStock"
        Me.lblInfoStock.Size = New System.Drawing.Size(22, 13)
        Me.lblInfoStock.TabIndex = 60
        Me.lblInfoStock.Text = "xxx"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.InitialImage = Nothing
        Me.PictureBox1.Location = New System.Drawing.Point(18, 20)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(203, 144)
        Me.PictureBox1.TabIndex = 54
        Me.PictureBox1.TabStop = False
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.Label26.Location = New System.Drawing.Point(11, 255)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(43, 13)
        Me.Label26.TabIndex = 65
        Me.Label26.Text = "Precio"
        '
        'lblInfoPrec
        '
        Me.lblInfoPrec.AutoSize = True
        Me.lblInfoPrec.ForeColor = System.Drawing.Color.White
        Me.lblInfoPrec.Location = New System.Drawing.Point(57, 255)
        Me.lblInfoPrec.Name = "lblInfoPrec"
        Me.lblInfoPrec.Size = New System.Drawing.Size(22, 13)
        Me.lblInfoPrec.TabIndex = 66
        Me.lblInfoPrec.Text = "xxx"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.Label12.Location = New System.Drawing.Point(11, 276)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(101, 13)
        Me.Label12.TabIndex = 67
        Me.Label12.Text = "Precio Mayorista"
        '
        'lblInfoPrec2
        '
        Me.lblInfoPrec2.AutoSize = True
        Me.lblInfoPrec2.ForeColor = System.Drawing.Color.White
        Me.lblInfoPrec2.Location = New System.Drawing.Point(116, 276)
        Me.lblInfoPrec2.Name = "lblInfoPrec2"
        Me.lblInfoPrec2.Size = New System.Drawing.Size(22, 13)
        Me.lblInfoPrec2.TabIndex = 68
        Me.lblInfoPrec2.Text = "xxx"
        '
        'pnlCliente
        '
        Me.pnlCliente.Controls.Add(Me.TabControl1)
        Me.pnlCliente.Location = New System.Drawing.Point(3, 4)
        Me.pnlCliente.Name = "pnlCliente"
        Me.pnlCliente.Size = New System.Drawing.Size(248, 361)
        Me.pnlCliente.TabIndex = 68
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Location = New System.Drawing.Point(3, 3)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(242, 353)
        Me.TabControl1.TabIndex = 1
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.TabPage2.Controls.Add(Me.Button1)
        Me.TabPage2.Controls.Add(Me.btnCliGuardar)
        Me.TabPage2.Controls.Add(Me.Label31)
        Me.TabPage2.Controls.Add(Me.txtCliTel)
        Me.TabPage2.Controls.Add(Me.txtCliCI)
        Me.TabPage2.Controls.Add(Me.Label30)
        Me.TabPage2.Controls.Add(Me.txtCliDir)
        Me.TabPage2.Controls.Add(Me.txtCliNom)
        Me.TabPage2.Controls.Add(Me.Label29)
        Me.TabPage2.Controls.Add(Me.Label28)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(234, 327)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Nuevo Cliente"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(135, 225)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 76
        Me.Button1.Text = "Cancelar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btnCliGuardar
        '
        Me.btnCliGuardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.btnCliGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCliGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCliGuardar.ForeColor = System.Drawing.Color.White
        Me.btnCliGuardar.Location = New System.Drawing.Point(24, 225)
        Me.btnCliGuardar.Name = "btnCliGuardar"
        Me.btnCliGuardar.Size = New System.Drawing.Size(75, 23)
        Me.btnCliGuardar.TabIndex = 8
        Me.btnCliGuardar.Text = "Guardar"
        Me.btnCliGuardar.UseVisualStyleBackColor = False
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.Label31.Location = New System.Drawing.Point(21, 17)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(47, 13)
        Me.Label31.TabIndex = 7
        Me.Label31.Text = "CI Nro."
        '
        'txtCliTel
        '
        Me.txtCliTel.Location = New System.Drawing.Point(24, 129)
        Me.txtCliTel.Name = "txtCliTel"
        Me.txtCliTel.Size = New System.Drawing.Size(186, 20)
        Me.txtCliTel.TabIndex = 1
        '
        'txtCliCI
        '
        Me.txtCliCI.Location = New System.Drawing.Point(24, 33)
        Me.txtCliCI.Name = "txtCliCI"
        Me.txtCliCI.Size = New System.Drawing.Size(186, 20)
        Me.txtCliCI.TabIndex = 0
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.Label30.Location = New System.Drawing.Point(21, 65)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(109, 13)
        Me.Label30.TabIndex = 6
        Me.Label30.Text = "Nombre y Apellido"
        '
        'txtCliDir
        '
        Me.txtCliDir.Location = New System.Drawing.Point(24, 179)
        Me.txtCliDir.Name = "txtCliDir"
        Me.txtCliDir.Size = New System.Drawing.Size(186, 20)
        Me.txtCliDir.TabIndex = 2
        '
        'txtCliNom
        '
        Me.txtCliNom.Location = New System.Drawing.Point(24, 81)
        Me.txtCliNom.Name = "txtCliNom"
        Me.txtCliNom.Size = New System.Drawing.Size(186, 20)
        Me.txtCliNom.TabIndex = 3
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.Label29.Location = New System.Drawing.Point(21, 113)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(57, 13)
        Me.Label29.TabIndex = 5
        Me.Label29.Text = "Teléfono"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.Label28.Location = New System.Drawing.Point(21, 163)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(61, 13)
        Me.Label28.TabIndex = 4
        Me.Label28.Text = "Dirección"
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.TabPage1.Controls.Add(Me.btnBusCliCancel)
        Me.TabPage1.Controls.Add(Me.btnCliAdd)
        Me.TabPage1.Controls.Add(Me.pnlInfoCli)
        Me.TabPage1.Controls.Add(Me.Label22)
        Me.TabPage1.Controls.Add(Me.Label25)
        Me.TabPage1.Controls.Add(Me.Label27)
        Me.TabPage1.Controls.Add(Me.cmbCliResult)
        Me.TabPage1.Controls.Add(Me.cmbCliBuscarPor)
        Me.TabPage1.Controls.Add(Me.txtCliBuscar)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(234, 327)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Buscar Cliente"
        '
        'btnBusCliCancel
        '
        Me.btnBusCliCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.btnBusCliCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBusCliCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBusCliCancel.ForeColor = System.Drawing.Color.White
        Me.btnBusCliCancel.Location = New System.Drawing.Point(108, 159)
        Me.btnBusCliCancel.Name = "btnBusCliCancel"
        Me.btnBusCliCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnBusCliCancel.TabIndex = 75
        Me.btnBusCliCancel.Text = "Cancelar"
        Me.btnBusCliCancel.UseVisualStyleBackColor = False
        '
        'btnCliAdd
        '
        Me.btnCliAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.btnCliAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCliAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCliAdd.ForeColor = System.Drawing.Color.White
        Me.btnCliAdd.Location = New System.Drawing.Point(18, 159)
        Me.btnCliAdd.Name = "btnCliAdd"
        Me.btnCliAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnCliAdd.TabIndex = 74
        Me.btnCliAdd.Text = "Agregar"
        Me.btnCliAdd.UseVisualStyleBackColor = False
        '
        'pnlInfoCli
        '
        Me.pnlInfoCli.Controls.Add(Me.lblCliDir)
        Me.pnlInfoCli.Controls.Add(Me.Label32)
        Me.pnlInfoCli.Controls.Add(Me.lblCliTel)
        Me.pnlInfoCli.Controls.Add(Me.lblCliNom)
        Me.pnlInfoCli.Controls.Add(Me.lblCliCI)
        Me.pnlInfoCli.Controls.Add(Me.Label33)
        Me.pnlInfoCli.Controls.Add(Me.Label34)
        Me.pnlInfoCli.Controls.Add(Me.Label35)
        Me.pnlInfoCli.Controls.Add(Me.Label36)
        Me.pnlInfoCli.Location = New System.Drawing.Point(0, 201)
        Me.pnlInfoCli.Name = "pnlInfoCli"
        Me.pnlInfoCli.Size = New System.Drawing.Size(234, 126)
        Me.pnlInfoCli.TabIndex = 73
        '
        'lblCliDir
        '
        Me.lblCliDir.AutoSize = True
        Me.lblCliDir.ForeColor = System.Drawing.Color.White
        Me.lblCliDir.Location = New System.Drawing.Point(80, 90)
        Me.lblCliDir.Name = "lblCliDir"
        Me.lblCliDir.Size = New System.Drawing.Size(22, 13)
        Me.lblCliDir.TabIndex = 63
        Me.lblCliDir.Text = "- - -"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.Label32.Location = New System.Drawing.Point(13, 90)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(61, 13)
        Me.Label32.TabIndex = 62
        Me.Label32.Text = "Dirección"
        '
        'lblCliTel
        '
        Me.lblCliTel.AutoSize = True
        Me.lblCliTel.ForeColor = System.Drawing.Color.White
        Me.lblCliTel.Location = New System.Drawing.Point(76, 68)
        Me.lblCliTel.Name = "lblCliTel"
        Me.lblCliTel.Size = New System.Drawing.Size(22, 13)
        Me.lblCliTel.TabIndex = 61
        Me.lblCliTel.Text = "- - -"
        '
        'lblCliNom
        '
        Me.lblCliNom.AutoSize = True
        Me.lblCliNom.ForeColor = System.Drawing.Color.White
        Me.lblCliNom.Location = New System.Drawing.Point(69, 47)
        Me.lblCliNom.Name = "lblCliNom"
        Me.lblCliNom.Size = New System.Drawing.Size(22, 13)
        Me.lblCliNom.TabIndex = 60
        Me.lblCliNom.Text = "xxx"
        '
        'lblCliCI
        '
        Me.lblCliCI.AutoSize = True
        Me.lblCliCI.ForeColor = System.Drawing.Color.White
        Me.lblCliCI.Location = New System.Drawing.Point(63, 26)
        Me.lblCliCI.Name = "lblCliCI"
        Me.lblCliCI.Size = New System.Drawing.Size(22, 13)
        Me.lblCliCI.TabIndex = 59
        Me.lblCliCI.Text = "xxx"
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.Label33.Location = New System.Drawing.Point(13, 26)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(47, 13)
        Me.Label33.TabIndex = 56
        Me.Label33.Text = "CI Nro."
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.Label34.Location = New System.Drawing.Point(13, 47)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(50, 13)
        Me.Label34.TabIndex = 57
        Me.Label34.Text = "Nombre"
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.Label35.Location = New System.Drawing.Point(13, 68)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(57, 13)
        Me.Label35.TabIndex = 3
        Me.Label35.Text = "Teléfono"
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.Label36.Location = New System.Drawing.Point(67, 5)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(94, 13)
        Me.Label36.TabIndex = 2
        Me.Label36.Text = "Info. de Cliente"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.Label22.Location = New System.Drawing.Point(15, 101)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(64, 13)
        Me.Label22.TabIndex = 72
        Me.Label22.Text = "Resultado"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.Label25.Location = New System.Drawing.Point(15, 60)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(53, 13)
        Me.Label25.TabIndex = 71
        Me.Label25.Text = "Ingresar"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.Label27.Location = New System.Drawing.Point(15, 18)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(69, 13)
        Me.Label27.TabIndex = 68
        Me.Label27.Text = "Buscar Por"
        '
        'cmbCliResult
        '
        Me.cmbCliResult.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCliResult.FormattingEnabled = True
        Me.cmbCliResult.Location = New System.Drawing.Point(18, 117)
        Me.cmbCliResult.Name = "cmbCliResult"
        Me.cmbCliResult.Size = New System.Drawing.Size(187, 21)
        Me.cmbCliResult.TabIndex = 69
        '
        'cmbCliBuscarPor
        '
        Me.cmbCliBuscarPor.FormattingEnabled = True
        Me.cmbCliBuscarPor.Items.AddRange(New Object() {"CI", "Nombre"})
        Me.cmbCliBuscarPor.Location = New System.Drawing.Point(18, 33)
        Me.cmbCliBuscarPor.Name = "cmbCliBuscarPor"
        Me.cmbCliBuscarPor.Size = New System.Drawing.Size(87, 21)
        Me.cmbCliBuscarPor.TabIndex = 70
        '
        'txtCliBuscar
        '
        Me.txtCliBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCliBuscar.Location = New System.Drawing.Point(18, 76)
        Me.txtCliBuscar.Name = "txtCliBuscar"
        Me.txtCliBuscar.Size = New System.Drawing.Size(187, 20)
        Me.txtCliBuscar.TabIndex = 67
        '
        'pnlBuscProd
        '
        Me.pnlBuscProd.Controls.Add(Me.lblUnidXpack)
        Me.pnlBuscProd.Controls.Add(Me.pnlVenderPor)
        Me.pnlBuscProd.Controls.Add(Me.txtDescuent)
        Me.pnlBuscProd.Controls.Add(Me.Label15)
        Me.pnlBuscProd.Controls.Add(Me.lblX)
        Me.pnlBuscProd.Controls.Add(Me.cmbDescrip)
        Me.pnlBuscProd.Controls.Add(Me.Label5)
        Me.pnlBuscProd.Controls.Add(Me.txtBuscar)
        Me.pnlBuscProd.Controls.Add(Me.lblCant)
        Me.pnlBuscProd.Controls.Add(Me.lblDesc)
        Me.pnlBuscProd.Controls.Add(Me.txtCant)
        Me.pnlBuscProd.Controls.Add(Me.chkDesc)
        Me.pnlBuscProd.Controls.Add(Me.Label11)
        Me.pnlBuscProd.Controls.Add(Me.optCod)
        Me.pnlBuscProd.Controls.Add(Me.optDesc)
        Me.pnlBuscProd.Controls.Add(Me.btnAgregar)
        Me.pnlBuscProd.Location = New System.Drawing.Point(596, 12)
        Me.pnlBuscProd.Name = "pnlBuscProd"
        Me.pnlBuscProd.Size = New System.Drawing.Size(248, 198)
        Me.pnlBuscProd.TabIndex = 84
        '
        'lblUnidXpack
        '
        Me.lblUnidXpack.AutoSize = True
        Me.lblUnidXpack.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUnidXpack.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.lblUnidXpack.Location = New System.Drawing.Point(141, 118)
        Me.lblUnidXpack.Name = "lblUnidXpack"
        Me.lblUnidXpack.Size = New System.Drawing.Size(21, 13)
        Me.lblUnidXpack.TabIndex = 79
        Me.lblUnidXpack.Text = "00"
        '
        'pnlVenderPor
        '
        Me.pnlVenderPor.Controls.Add(Me.optPaquete)
        Me.pnlVenderPor.Controls.Add(Me.optUnidad)
        Me.pnlVenderPor.Controls.Add(Me.lblVenderPor)
        Me.pnlVenderPor.Location = New System.Drawing.Point(7, 167)
        Me.pnlVenderPor.Name = "pnlVenderPor"
        Me.pnlVenderPor.Size = New System.Drawing.Size(217, 25)
        Me.pnlVenderPor.TabIndex = 83
        '
        'optPaquete
        '
        Me.optPaquete.AutoSize = True
        Me.optPaquete.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optPaquete.ForeColor = System.Drawing.Color.White
        Me.optPaquete.Location = New System.Drawing.Point(148, 1)
        Me.optPaquete.Name = "optPaquete"
        Me.optPaquete.Size = New System.Drawing.Size(65, 17)
        Me.optPaquete.TabIndex = 82
        Me.optPaquete.TabStop = True
        Me.optPaquete.Text = "Paquete"
        Me.optPaquete.UseVisualStyleBackColor = True
        '
        'optUnidad
        '
        Me.optUnidad.AutoSize = True
        Me.optUnidad.Checked = True
        Me.optUnidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optUnidad.ForeColor = System.Drawing.Color.White
        Me.optUnidad.Location = New System.Drawing.Point(79, 1)
        Me.optUnidad.Name = "optUnidad"
        Me.optUnidad.Size = New System.Drawing.Size(59, 17)
        Me.optUnidad.TabIndex = 81
        Me.optUnidad.TabStop = True
        Me.optUnidad.Text = "Unidad"
        Me.optUnidad.UseVisualStyleBackColor = True
        '
        'lblVenderPor
        '
        Me.lblVenderPor.AutoSize = True
        Me.lblVenderPor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVenderPor.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.lblVenderPor.Location = New System.Drawing.Point(5, 3)
        Me.lblVenderPor.Name = "lblVenderPor"
        Me.lblVenderPor.Size = New System.Drawing.Size(70, 13)
        Me.lblVenderPor.TabIndex = 56
        Me.lblVenderPor.Text = "Vender Por"
        '
        'txtDescuent
        '
        Me.txtDescuent.Location = New System.Drawing.Point(71, 142)
        Me.txtDescuent.Name = "txtDescuent"
        Me.txtDescuent.Size = New System.Drawing.Size(60, 20)
        Me.txtDescuent.TabIndex = 45
        Me.txtDescuent.Visible = False
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.Label15.Location = New System.Drawing.Point(66, 6)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(101, 13)
        Me.Label15.TabIndex = 80
        Me.Label15.Text = "Buscar Producto"
        '
        'lblX
        '
        Me.lblX.AutoSize = True
        Me.lblX.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblX.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.lblX.Location = New System.Drawing.Point(132, 117)
        Me.lblX.Name = "lblX"
        Me.lblX.Size = New System.Drawing.Size(17, 13)
        Me.lblX.TabIndex = 78
        Me.lblX.Text = "x "
        '
        'cmbDescrip
        '
        Me.cmbDescrip.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbDescrip.FormattingEnabled = True
        Me.cmbDescrip.Location = New System.Drawing.Point(15, 86)
        Me.cmbDescrip.Name = "cmbDescrip"
        Me.cmbDescrip.Size = New System.Drawing.Size(218, 21)
        Me.cmbDescrip.TabIndex = 77
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(12, 61)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 13)
        Me.Label5.TabIndex = 76
        Me.Label5.Text = "Buscar"
        '
        'txtBuscar
        '
        Me.txtBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscar.Location = New System.Drawing.Point(65, 58)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(168, 20)
        Me.txtBuscar.TabIndex = 75
        '
        'lblCant
        '
        Me.lblCant.AutoSize = True
        Me.lblCant.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCant.ForeColor = System.Drawing.Color.White
        Me.lblCant.Location = New System.Drawing.Point(12, 118)
        Me.lblCant.Name = "lblCant"
        Me.lblCant.Size = New System.Drawing.Size(37, 13)
        Me.lblCant.TabIndex = 74
        Me.lblCant.Text = "Cant."
        '
        'lblDesc
        '
        Me.lblDesc.AutoSize = True
        Me.lblDesc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDesc.ForeColor = System.Drawing.Color.White
        Me.lblDesc.Location = New System.Drawing.Point(131, 145)
        Me.lblDesc.Name = "lblDesc"
        Me.lblDesc.Size = New System.Drawing.Size(16, 13)
        Me.lblDesc.TabIndex = 47
        Me.lblDesc.Text = "%"
        Me.lblDesc.Visible = False
        '
        'txtCant
        '
        Me.txtCant.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCant.Location = New System.Drawing.Point(50, 115)
        Me.txtCant.Name = "txtCant"
        Me.txtCant.Size = New System.Drawing.Size(81, 20)
        Me.txtCant.TabIndex = 73
        Me.txtCant.Text = "1"
        '
        'chkDesc
        '
        Me.chkDesc.AutoSize = True
        Me.chkDesc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkDesc.ForeColor = System.Drawing.Color.White
        Me.chkDesc.Location = New System.Drawing.Point(15, 144)
        Me.chkDesc.Name = "chkDesc"
        Me.chkDesc.Size = New System.Drawing.Size(63, 17)
        Me.chkDesc.TabIndex = 46
        Me.chkDesc.Text = "Desc. "
        Me.chkDesc.UseVisualStyleBackColor = True
        Me.chkDesc.Visible = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.Label11.Location = New System.Drawing.Point(12, 31)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(26, 13)
        Me.Label11.TabIndex = 72
        Me.Label11.Text = "Por"
        '
        'optCod
        '
        Me.optCod.AutoSize = True
        Me.optCod.Checked = True
        Me.optCod.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optCod.ForeColor = System.Drawing.Color.White
        Me.optCod.Location = New System.Drawing.Point(138, 29)
        Me.optCod.Name = "optCod"
        Me.optCod.Size = New System.Drawing.Size(58, 17)
        Me.optCod.TabIndex = 71
        Me.optCod.TabStop = True
        Me.optCod.Text = "Código"
        Me.optCod.UseVisualStyleBackColor = True
        '
        'optDesc
        '
        Me.optDesc.AutoSize = True
        Me.optDesc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optDesc.ForeColor = System.Drawing.Color.White
        Me.optDesc.Location = New System.Drawing.Point(44, 29)
        Me.optDesc.Name = "optDesc"
        Me.optDesc.Size = New System.Drawing.Size(81, 17)
        Me.optDesc.TabIndex = 70
        Me.optDesc.Text = "Descripción"
        Me.optDesc.UseVisualStyleBackColor = True
        '
        'btnAgregar
        '
        Me.btnAgregar.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAgregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnAgregar.Location = New System.Drawing.Point(168, 113)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(65, 23)
        Me.btnAgregar.TabIndex = 69
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = False
        '
        'tmrCliente
        '
        Me.tmrCliente.Interval = 20
        '
        'ToolTip1
        '
        Me.ToolTip1.AutomaticDelay = 10
        Me.ToolTip1.AutoPopDelay = 2000
        Me.ToolTip1.InitialDelay = 10
        Me.ToolTip1.ReshowDelay = 2
        '
        'ToolTip2
        '
        Me.ToolTip2.AutomaticDelay = 10
        '
        'DataGridViewImageColumn1
        '
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle8.NullValue = Nothing
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.White
        Me.DataGridViewImageColumn1.DefaultCellStyle = DataGridViewCellStyle8
        Me.DataGridViewImageColumn1.HeaderText = ""
        Me.DataGridViewImageColumn1.Image = Global.ControlStock.My.Resources.Resources.button_cancel
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        Me.DataGridViewImageColumn1.ReadOnly = True
        Me.DataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewImageColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewImageColumn1.Width = 22
        '
        'FVenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(855, 564)
        Me.Controls.Add(Me.pnlBuscProd)
        Me.Controls.Add(Me.SplitContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(855, 564)
        Me.MinimumSize = New System.Drawing.Size(855, 564)
        Me.Name = "FVenta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Factura"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.btnGuardar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnCancel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlXPack.ResumeLayout(False)
        Me.pnlXPack.PerformLayout()
        Me.pnlPrecios.ResumeLayout(False)
        Me.pnlPrecios.PerformLayout()
        Me.pnlEditCant.ResumeLayout(False)
        Me.pnlEditCant.PerformLayout()
        CType(Me.pbxBuscCli, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlCredito.ResumeLayout(False)
        Me.pnlCredito.PerformLayout()
        Me.pnlProdInfo.ResumeLayout(False)
        Me.pnlProdInfo.PerformLayout()
        Me.pnlPrecVenta.ResumeLayout(False)
        Me.pnlPrecVenta.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlCliente.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.pnlInfoCli.ResumeLayout(False)
        Me.pnlInfoCli.PerformLayout()
        Me.pnlBuscProd.ResumeLayout(False)
        Me.pnlBuscProd.PerformLayout()
        Me.pnlVenderPor.ResumeLayout(False)
        Me.pnlVenderPor.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents btnGuardar As System.Windows.Forms.PictureBox
    Friend WithEvents btnCancel As System.Windows.Forms.PictureBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents tmrTotal As System.Windows.Forms.Timer
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents pnlPrecVenta As System.Windows.Forms.Panel
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents lblPrecCant As System.Windows.Forms.Label
    Friend WithEvents lblPrecPack As System.Windows.Forms.Label
    Friend WithEvents lblPrecUnit As System.Windows.Forms.Label
    Friend WithEvents Label90 As System.Windows.Forms.Label
    Friend WithEvents lblInfoCod As System.Windows.Forms.Label
    Friend WithEvents lblInfoDesc As System.Windows.Forms.Label
    Friend WithEvents lblInfoStock As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents pnlProdInfo As System.Windows.Forms.Panel
    Friend WithEvents lblInfoPrec As System.Windows.Forms.Label
    Friend WithEvents lblCantDesc As System.Windows.Forms.Label
    Friend WithEvents pnlCliente As System.Windows.Forms.Panel
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents pnlInfoCli As System.Windows.Forms.Panel
    Friend WithEvents lblCliDir As System.Windows.Forms.Label
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents lblCliTel As System.Windows.Forms.Label
    Friend WithEvents lblCliNom As System.Windows.Forms.Label
    Friend WithEvents lblCliCI As System.Windows.Forms.Label
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents cmbCliResult As System.Windows.Forms.ComboBox
    Friend WithEvents cmbCliBuscarPor As System.Windows.Forms.ComboBox
    Friend WithEvents txtCliBuscar As System.Windows.Forms.TextBox
    Friend WithEvents btnCliGuardar As System.Windows.Forms.Button
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents txtCliNom As System.Windows.Forms.TextBox
    Friend WithEvents txtCliDir As System.Windows.Forms.TextBox
    Friend WithEvents txtCliTel As System.Windows.Forms.TextBox
    Friend WithEvents txtCliCI As System.Windows.Forms.TextBox
    Friend WithEvents btnCliAdd As System.Windows.Forms.Button
    Friend WithEvents tmrCliente As System.Windows.Forms.Timer
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents optCredito As System.Windows.Forms.RadioButton
    Friend WithEvents optContado As System.Windows.Forms.RadioButton
    Friend WithEvents txtCliente As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtFecha As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtNroFac As System.Windows.Forms.TextBox
    Friend WithEvents pnlCredito As System.Windows.Forms.Panel
    Friend WithEvents btnCredCancel As System.Windows.Forms.Button
    Friend WithEvents lblCredGs As System.Windows.Forms.Label
    Friend WithEvents btnCredOk As System.Windows.Forms.Button
    Friend WithEvents txtCredEntrega As System.Windows.Forms.TextBox
    Friend WithEvents btnCredNo As System.Windows.Forms.Button
    Friend WithEvents btnCredSi As System.Windows.Forms.Button
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents dtpVto As System.Windows.Forms.DateTimePicker
    Friend WithEvents DataGridViewImageColumn1 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents pbxBuscCli As System.Windows.Forms.PictureBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents ToolTip2 As System.Windows.Forms.ToolTip
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents btnBusCliCancel As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents pnlBuscProd As System.Windows.Forms.Panel
    Friend WithEvents lblUnidXpack As System.Windows.Forms.Label
    Friend WithEvents pnlVenderPor As System.Windows.Forms.Panel
    Friend WithEvents optPaquete As System.Windows.Forms.RadioButton
    Friend WithEvents optUnidad As System.Windows.Forms.RadioButton
    Friend WithEvents lblVenderPor As System.Windows.Forms.Label
    Friend WithEvents txtDescuent As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents lblX As System.Windows.Forms.Label
    Friend WithEvents cmbDescrip As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtBuscar As System.Windows.Forms.TextBox
    Friend WithEvents lblCant As System.Windows.Forms.Label
    Friend WithEvents lblDesc As System.Windows.Forms.Label
    Friend WithEvents txtCant As System.Windows.Forms.TextBox
    Friend WithEvents chkDesc As System.Windows.Forms.CheckBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents optCod As System.Windows.Forms.RadioButton
    Friend WithEvents optDesc As System.Windows.Forms.RadioButton
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents chkMayorista As System.Windows.Forms.CheckBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents lblInfoPrec2 As System.Windows.Forms.Label
    Friend WithEvents pnlEditCant As System.Windows.Forms.Panel
    Friend WithEvents txtEditCant As System.Windows.Forms.TextBox
    Friend WithEvents lblEditCant As System.Windows.Forms.Label
    Friend WithEvents btnEditCantCancel As System.Windows.Forms.Button
    Friend WithEvents pnlXPack As System.Windows.Forms.Panel
    Friend WithEvents btnUnidad As System.Windows.Forms.Button
    Friend WithEvents btnPack As System.Windows.Forms.Button
    Friend WithEvents btnPackCancel As System.Windows.Forms.Button
    Friend WithEvents lblTituloXPack As System.Windows.Forms.Label
    Friend WithEvents pnlPrecios As System.Windows.Forms.Panel
    Friend WithEvents optPrecio3 As System.Windows.Forms.RadioButton
    Friend WithEvents optPrecio2 As System.Windows.Forms.RadioButton
    Friend WithEvents optPrecio1 As System.Windows.Forms.RadioButton
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents lblTitPrecios As System.Windows.Forms.Label
    Friend WithEvents cmbVendedor As System.Windows.Forms.ComboBox
    Friend WithEvents lblHab As Label
    Friend WithEvents LblTituloHab As Label
    Friend WithEvents lblHab2 As Label
    Friend WithEvents Del As DataGridViewImageColumn
    Friend WithEvents Cod As DataGridViewTextBoxColumn
    Friend WithEvents Descripcion As DataGridViewTextBoxColumn
    Friend WithEvents Cantt As DataGridViewTextBoxColumn
    Friend WithEvents Precio As DataGridViewTextBoxColumn
    Friend WithEvents Importe As DataGridViewTextBoxColumn
    Friend WithEvents Descuento As DataGridViewTextBoxColumn
    Friend WithEvents Unidades As DataGridViewTextBoxColumn
    Friend WithEvents Obs As DataGridViewTextBoxColumn
    Friend WithEvents Iva As DataGridViewTextBoxColumn
End Class
