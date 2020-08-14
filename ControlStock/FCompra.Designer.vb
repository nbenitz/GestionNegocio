<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FCompra
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FCompra))
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Del = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Cod = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cant = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Precio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Importe = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Unidades = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Obs = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblInfoDesc = New System.Windows.Forms.Label()
        Me.lblInfoCod = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.lblInfoStock = New System.Windows.Forms.Label()
        Me.lblInfoCosto = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.optCredito = New System.Windows.Forms.RadioButton()
        Me.optContado = New System.Windows.Forms.RadioButton()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.tmrTotal = New System.Windows.Forms.Timer(Me.components)
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.btnGuardar = New System.Windows.Forms.PictureBox()
        Me.pnlEditPrec = New System.Windows.Forms.Panel()
        Me.btnEditPrecCancel = New System.Windows.Forms.Button()
        Me.txtEditPrec = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.PictureBox()
        Me.pnlEditCant = New System.Windows.Forms.Panel()
        Me.btnEditCantCancel = New System.Windows.Forms.Button()
        Me.txtEditCant = New System.Windows.Forms.TextBox()
        Me.lblEditCant = New System.Windows.Forms.Label()
        Me.pbxNewProv = New System.Windows.Forms.PictureBox()
        Me.pnlCredito = New System.Windows.Forms.Panel()
        Me.btnCredCancel = New System.Windows.Forms.Button()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.dtpVto = New System.Windows.Forms.DateTimePicker()
        Me.lblCredGs = New System.Windows.Forms.Label()
        Me.btnCredOk = New System.Windows.Forms.Button()
        Me.txtCredEntrega = New System.Windows.Forms.TextBox()
        Me.btnCredNo = New System.Windows.Forms.Button()
        Me.btnCredSi = New System.Windows.Forms.Button()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.cmbProveedor = New System.Windows.Forms.ComboBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtFecha = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNroFac = New System.Windows.Forms.TextBox()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.pnlProdInfo = New System.Windows.Forms.Panel()
        Me.lblUnidXPackInfo = New System.Windows.Forms.Label()
        Me.lblUnidXPackTit = New System.Windows.Forms.Label()
        Me.lblPresent = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.pnlBuscProd = New System.Windows.Forms.Panel()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.optCod = New System.Windows.Forms.RadioButton()
        Me.cmbDescrip = New System.Windows.Forms.ComboBox()
        Me.txtCant = New System.Windows.Forms.TextBox()
        Me.optDesc = New System.Windows.Forms.RadioButton()
        Me.lblUnidXpack = New System.Windows.Forms.Label()
        Me.lblX = New System.Windows.Forms.Label()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTip2 = New System.Windows.Forms.ToolTip(Me.components)
        Me.pnlInfoPiso = New System.Windows.Forms.Panel()
        Me.lblUnidxCaja = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.lblMxCaja = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.btnGuardar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlEditPrec.SuspendLayout()
        CType(Me.btnCancel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlEditCant.SuspendLayout()
        CType(Me.pbxNewProv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlCredito.SuspendLayout()
        Me.pnlProdInfo.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlBuscProd.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlInfoPiso.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Del, Me.Cod, Me.Cant, Me.Descripcion, Me.Precio, Me.Importe, Me.Unidades, Me.Obs})
        Me.DataGridView1.Location = New System.Drawing.Point(11, 125)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.Size = New System.Drawing.Size(548, 329)
        Me.DataGridView1.TabIndex = 0
        '
        'Del
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.NullValue = CType(resources.GetObject("DataGridViewCellStyle1.NullValue"), Object)
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White
        Me.Del.DefaultCellStyle = DataGridViewCellStyle1
        Me.Del.Frozen = True
        Me.Del.HeaderText = ""
        Me.Del.Name = "Del"
        Me.Del.ReadOnly = True
        Me.Del.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Del.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Del.Width = 22
        '
        'Cod
        '
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        Me.Cod.DefaultCellStyle = DataGridViewCellStyle2
        Me.Cod.FillWeight = 40.0!
        Me.Cod.Frozen = True
        Me.Cod.HeaderText = "Código"
        Me.Cod.Name = "Cod"
        Me.Cod.ReadOnly = True
        Me.Cod.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Cod.Width = 74
        '
        'Cant
        '
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        Me.Cant.DefaultCellStyle = DataGridViewCellStyle3
        Me.Cant.HeaderText = "Cant"
        Me.Cant.Name = "Cant"
        Me.Cant.ReadOnly = True
        Me.Cant.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Cant.Width = 65
        '
        'Descripcion
        '
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        Me.Descripcion.DefaultCellStyle = DataGridViewCellStyle4
        Me.Descripcion.HeaderText = "Descripción"
        Me.Descripcion.Name = "Descripcion"
        Me.Descripcion.ReadOnly = True
        Me.Descripcion.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Descripcion.Width = 235
        '
        'Precio
        '
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
        Me.Precio.DefaultCellStyle = DataGridViewCellStyle5
        Me.Precio.HeaderText = "Precio"
        Me.Precio.Name = "Precio"
        Me.Precio.ReadOnly = True
        Me.Precio.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Precio.Width = 75
        '
        'Importe
        '
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black
        Me.Importe.DefaultCellStyle = DataGridViewCellStyle6
        Me.Importe.HeaderText = "Importe"
        Me.Importe.Name = "Importe"
        Me.Importe.ReadOnly = True
        Me.Importe.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Importe.Width = 75
        '
        'Unidades
        '
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black
        Me.Unidades.DefaultCellStyle = DataGridViewCellStyle7
        Me.Unidades.HeaderText = "Unidades"
        Me.Unidades.Name = "Unidades"
        Me.Unidades.ReadOnly = True
        Me.Unidades.Visible = False
        Me.Unidades.Width = 50
        '
        'Obs
        '
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black
        Me.Obs.DefaultCellStyle = DataGridViewCellStyle8
        Me.Obs.HeaderText = "Obs"
        Me.Obs.Name = "Obs"
        Me.Obs.ReadOnly = True
        Me.Obs.Visible = False
        '
        'lblInfoDesc
        '
        Me.lblInfoDesc.AutoSize = True
        Me.lblInfoDesc.ForeColor = System.Drawing.Color.White
        Me.lblInfoDesc.Location = New System.Drawing.Point(69, 247)
        Me.lblInfoDesc.Name = "lblInfoDesc"
        Me.lblInfoDesc.Size = New System.Drawing.Size(22, 13)
        Me.lblInfoDesc.TabIndex = 61
        Me.lblInfoDesc.Text = "xxx"
        '
        'lblInfoCod
        '
        Me.lblInfoCod.AutoSize = True
        Me.lblInfoCod.ForeColor = System.Drawing.Color.White
        Me.lblInfoCod.Location = New System.Drawing.Point(47, 224)
        Me.lblInfoCod.Name = "lblInfoCod"
        Me.lblInfoCod.Size = New System.Drawing.Size(22, 13)
        Me.lblInfoCod.TabIndex = 62
        Me.lblInfoCod.Text = "xxx"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.Label24.Location = New System.Drawing.Point(69, 179)
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
        Me.Label23.Location = New System.Drawing.Point(101, 6)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(32, 13)
        Me.Label23.TabIndex = 63
        Me.Label23.Text = "Foto"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.Label26.Location = New System.Drawing.Point(14, 290)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(39, 13)
        Me.Label26.TabIndex = 65
        Me.Label26.Text = "Costo"
        '
        'lblInfoStock
        '
        Me.lblInfoStock.AutoSize = True
        Me.lblInfoStock.ForeColor = System.Drawing.Color.White
        Me.lblInfoStock.Location = New System.Drawing.Point(57, 269)
        Me.lblInfoStock.Name = "lblInfoStock"
        Me.lblInfoStock.Size = New System.Drawing.Size(22, 13)
        Me.lblInfoStock.TabIndex = 60
        Me.lblInfoStock.Text = "xxx"
        '
        'lblInfoCosto
        '
        Me.lblInfoCosto.AutoSize = True
        Me.lblInfoCosto.ForeColor = System.Drawing.Color.White
        Me.lblInfoCosto.Location = New System.Drawing.Point(60, 290)
        Me.lblInfoCosto.Name = "lblInfoCosto"
        Me.lblInfoCosto.Size = New System.Drawing.Size(22, 13)
        Me.lblInfoCosto.TabIndex = 66
        Me.lblInfoCosto.Text = "xxx"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(394, 441)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(84, 13)
        Me.Label6.TabIndex = 48
        Me.Label6.Text = "Total a Pagar"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(361, 97)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 52
        Me.Label1.Text = "Condición"
        '
        'optCredito
        '
        Me.optCredito.AutoSize = True
        Me.optCredito.ForeColor = System.Drawing.Color.Black
        Me.optCredito.Location = New System.Drawing.Point(501, 95)
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
        Me.optContado.ForeColor = System.Drawing.Color.Black
        Me.optContado.Location = New System.Drawing.Point(430, 95)
        Me.optContado.Name = "optContado"
        Me.optContado.Size = New System.Drawing.Size(65, 17)
        Me.optContado.TabIndex = 50
        Me.optContado.TabStop = True
        Me.optContado.Text = "Contado"
        Me.optContado.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 20
        '
        'tmrTotal
        '
        Me.tmrTotal.Interval = 10
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.SplitContainer1.Location = New System.Drawing.Point(12, 12)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.BackColor = System.Drawing.Color.White
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnGuardar)
        Me.SplitContainer1.Panel1.Controls.Add(Me.pnlEditPrec)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnCancel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.pnlEditCant)
        Me.SplitContainer1.Panel1.Controls.Add(Me.pbxNewProv)
        Me.SplitContainer1.Panel1.Controls.Add(Me.pnlCredito)
        Me.SplitContainer1.Panel1.Controls.Add(Me.cmbProveedor)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.optCredito)
        Me.SplitContainer1.Panel1.Controls.Add(Me.optContado)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label6)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label16)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label18)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtFecha)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label3)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtNroFac)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtTotal)
        Me.SplitContainer1.Panel1.Controls.Add(Me.DataGridView1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.pnlProdInfo)
        Me.SplitContainer1.Panel2.Controls.Add(Me.pnlBuscProd)
        Me.SplitContainer1.Size = New System.Drawing.Size(848, 507)
        Me.SplitContainer1.SplitterDistance = 586
        Me.SplitContainer1.TabIndex = 74
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.Color.Transparent
        Me.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGuardar.Image = Global.ControlStock.My.Resources.Resources.file_apply
        Me.btnGuardar.Location = New System.Drawing.Point(43, 452)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(41, 38)
        Me.btnGuardar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnGuardar.TabIndex = 77
        Me.btnGuardar.TabStop = False
        Me.ToolTip1.SetToolTip(Me.btnGuardar, "Registrar Compra")
        '
        'pnlEditPrec
        '
        Me.pnlEditPrec.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlEditPrec.Controls.Add(Me.btnEditPrecCancel)
        Me.pnlEditPrec.Controls.Add(Me.txtEditPrec)
        Me.pnlEditPrec.Controls.Add(Me.Label12)
        Me.pnlEditPrec.Location = New System.Drawing.Point(372, 177)
        Me.pnlEditPrec.Name = "pnlEditPrec"
        Me.pnlEditPrec.Size = New System.Drawing.Size(204, 70)
        Me.pnlEditPrec.TabIndex = 83
        Me.pnlEditPrec.Visible = False
        '
        'btnEditPrecCancel
        '
        Me.btnEditPrecCancel.BackColor = System.Drawing.Color.White
        Me.btnEditPrecCancel.FlatAppearance.BorderSize = 0
        Me.btnEditPrecCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditPrecCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditPrecCancel.Image = Global.ControlStock.My.Resources.Resources.cancel
        Me.btnEditPrecCancel.Location = New System.Drawing.Point(181, 3)
        Me.btnEditPrecCancel.Name = "btnEditPrecCancel"
        Me.btnEditPrecCancel.Size = New System.Drawing.Size(18, 18)
        Me.btnEditPrecCancel.TabIndex = 71
        Me.btnEditPrecCancel.UseVisualStyleBackColor = False
        '
        'txtEditPrec
        '
        Me.txtEditPrec.Location = New System.Drawing.Point(18, 34)
        Me.txtEditPrec.Name = "txtEditPrec"
        Me.txtEditPrec.Size = New System.Drawing.Size(168, 20)
        Me.txtEditPrec.TabIndex = 68
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label12.Location = New System.Drawing.Point(15, 10)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(106, 18)
        Me.Label12.TabIndex = 65
        Me.Label12.Text = "Editar Precio"
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.Transparent
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancel.Image = Global.ControlStock.My.Resources.Resources.file_exclude
        Me.btnCancel.Location = New System.Drawing.Point(3, 452)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(41, 38)
        Me.btnCancel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnCancel.TabIndex = 76
        Me.btnCancel.TabStop = False
        Me.ToolTip1.SetToolTip(Me.btnCancel, "Cancelar")
        '
        'pnlEditCant
        '
        Me.pnlEditCant.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlEditCant.Controls.Add(Me.btnEditCantCancel)
        Me.pnlEditCant.Controls.Add(Me.txtEditCant)
        Me.pnlEditCant.Controls.Add(Me.lblEditCant)
        Me.pnlEditCant.Location = New System.Drawing.Point(179, 177)
        Me.pnlEditCant.Name = "pnlEditCant"
        Me.pnlEditCant.Size = New System.Drawing.Size(204, 70)
        Me.pnlEditCant.TabIndex = 82
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
        'pbxNewProv
        '
        Me.pbxNewProv.BackColor = System.Drawing.Color.Transparent
        Me.pbxNewProv.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pbxNewProv.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbxNewProv.Image = Global.ControlStock.My.Resources.Resources.Plus_over2
        Me.pbxNewProv.Location = New System.Drawing.Point(221, 97)
        Me.pbxNewProv.Name = "pbxNewProv"
        Me.pbxNewProv.Size = New System.Drawing.Size(21, 16)
        Me.pbxNewProv.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbxNewProv.TabIndex = 78
        Me.pbxNewProv.TabStop = False
        Me.ToolTip1.SetToolTip(Me.pbxNewProv, "Nuevo Proveedor")
        '
        'pnlCredito
        '
        Me.pnlCredito.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlCredito.Controls.Add(Me.btnCredCancel)
        Me.pnlCredito.Controls.Add(Me.Label39)
        Me.pnlCredito.Controls.Add(Me.dtpVto)
        Me.pnlCredito.Controls.Add(Me.lblCredGs)
        Me.pnlCredito.Controls.Add(Me.btnCredOk)
        Me.pnlCredito.Controls.Add(Me.txtCredEntrega)
        Me.pnlCredito.Controls.Add(Me.btnCredNo)
        Me.pnlCredito.Controls.Add(Me.btnCredSi)
        Me.pnlCredito.Controls.Add(Me.Label38)
        Me.pnlCredito.Controls.Add(Me.Label37)
        Me.pnlCredito.Location = New System.Drawing.Point(133, 253)
        Me.pnlCredito.Name = "pnlCredito"
        Me.pnlCredito.Size = New System.Drawing.Size(291, 179)
        Me.pnlCredito.TabIndex = 57
        Me.pnlCredito.Visible = False
        '
        'btnCredCancel
        '
        Me.btnCredCancel.BackColor = System.Drawing.Color.White
        Me.btnCredCancel.FlatAppearance.BorderSize = 0
        Me.btnCredCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCredCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCredCancel.Image = Global.ControlStock.My.Resources.Resources.cancel
        Me.btnCredCancel.Location = New System.Drawing.Point(266, 3)
        Me.btnCredCancel.Name = "btnCredCancel"
        Me.btnCredCancel.Size = New System.Drawing.Size(18, 18)
        Me.btnCredCancel.TabIndex = 74
        Me.btnCredCancel.UseVisualStyleBackColor = False
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
        Me.btnCredOk.ForeColor = System.Drawing.Color.Black
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
        Me.btnCredNo.ForeColor = System.Drawing.Color.Black
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
        Me.btnCredSi.ForeColor = System.Drawing.Color.Black
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
        Me.Label37.Size = New System.Drawing.Size(173, 24)
        Me.Label37.TabIndex = 64
        Me.Label37.Text = "Compra a Crédito"
        '
        'cmbProveedor
        '
        Me.cmbProveedor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbProveedor.BackColor = System.Drawing.Color.White
        Me.cmbProveedor.FormattingEnabled = True
        Me.cmbProveedor.Location = New System.Drawing.Point(86, 94)
        Me.cmbProveedor.Name = "cmbProveedor"
        Me.cmbProveedor.Size = New System.Drawing.Size(130, 21)
        Me.cmbProveedor.TabIndex = 55
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(8, 97)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(65, 13)
        Me.Label16.TabIndex = 45
        Me.Label16.Text = "Proveedor"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Black
        Me.Label18.Location = New System.Drawing.Point(241, 22)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(150, 20)
        Me.Label18.TabIndex = 40
        Me.Label18.Text = "Orden de Compra"
        '
        'txtFecha
        '
        Me.txtFecha.BackColor = System.Drawing.Color.White
        Me.txtFecha.Location = New System.Drawing.Point(86, 66)
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
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(8, 41)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 13)
        Me.Label3.TabIndex = 37
        Me.Label3.Text = "Nro. Compra"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(8, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 13)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "Fecha"
        '
        'txtNroFac
        '
        Me.txtNroFac.BackColor = System.Drawing.Color.White
        Me.txtNroFac.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNroFac.Location = New System.Drawing.Point(86, 38)
        Me.txtNroFac.Name = "txtNroFac"
        Me.txtNroFac.ReadOnly = True
        Me.txtNroFac.Size = New System.Drawing.Size(111, 20)
        Me.txtNroFac.TabIndex = 36
        Me.txtNroFac.Text = "0"
        Me.txtNroFac.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTotal
        '
        Me.txtTotal.BackColor = System.Drawing.Color.White
        Me.txtTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.Location = New System.Drawing.Point(486, 463)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtTotal.Size = New System.Drawing.Size(73, 20)
        Me.txtTotal.TabIndex = 38
        Me.txtTotal.Text = "0"
        '
        'pnlProdInfo
        '
        Me.pnlProdInfo.Controls.Add(Me.pnlInfoPiso)
        Me.pnlProdInfo.Controls.Add(Me.lblUnidXPackInfo)
        Me.pnlProdInfo.Controls.Add(Me.lblUnidXPackTit)
        Me.pnlProdInfo.Controls.Add(Me.lblPresent)
        Me.pnlProdInfo.Controls.Add(Me.Label11)
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
        Me.pnlProdInfo.Controls.Add(Me.lblInfoCosto)
        Me.pnlProdInfo.Location = New System.Drawing.Point(3, 157)
        Me.pnlProdInfo.Name = "pnlProdInfo"
        Me.pnlProdInfo.Size = New System.Drawing.Size(248, 343)
        Me.pnlProdInfo.TabIndex = 67
        '
        'lblUnidXPackInfo
        '
        Me.lblUnidXPackInfo.AutoSize = True
        Me.lblUnidXPackInfo.ForeColor = System.Drawing.Color.White
        Me.lblUnidXPackInfo.Location = New System.Drawing.Point(124, 313)
        Me.lblUnidXPackInfo.Name = "lblUnidXPackInfo"
        Me.lblUnidXPackInfo.Size = New System.Drawing.Size(22, 13)
        Me.lblUnidXPackInfo.TabIndex = 72
        Me.lblUnidXPackInfo.Text = "xxx"
        '
        'lblUnidXPackTit
        '
        Me.lblUnidXPackTit.AutoSize = True
        Me.lblUnidXPackTit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUnidXPackTit.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.lblUnidXPackTit.Location = New System.Drawing.Point(14, 313)
        Me.lblUnidXPackTit.Name = "lblUnidXPackTit"
        Me.lblUnidXPackTit.Size = New System.Drawing.Size(106, 13)
        Me.lblUnidXPackTit.TabIndex = 71
        Me.lblUnidXPackTit.Text = "Unid por Paquete"
        '
        'lblPresent
        '
        Me.lblPresent.AutoSize = True
        Me.lblPresent.ForeColor = System.Drawing.Color.White
        Me.lblPresent.Location = New System.Drawing.Point(101, 201)
        Me.lblPresent.Name = "lblPresent"
        Me.lblPresent.Size = New System.Drawing.Size(22, 13)
        Me.lblPresent.TabIndex = 70
        Me.lblPresent.Text = "xxx"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.Label11.Location = New System.Drawing.Point(14, 201)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(81, 13)
        Me.Label11.TabIndex = 69
        Me.Label11.Text = "Presentación"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.InitialImage = Nothing
        Me.PictureBox1.Location = New System.Drawing.Point(21, 22)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(203, 144)
        Me.PictureBox1.TabIndex = 54
        Me.PictureBox1.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.Label7.Location = New System.Drawing.Point(14, 224)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(33, 13)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Cód."
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.Label8.Location = New System.Drawing.Point(14, 247)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(54, 13)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Descrip."
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.Label10.Location = New System.Drawing.Point(14, 269)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(40, 13)
        Me.Label10.TabIndex = 3
        Me.Label10.Text = "Stock"
        '
        'pnlBuscProd
        '
        Me.pnlBuscProd.Controls.Add(Me.Label15)
        Me.pnlBuscProd.Controls.Add(Me.txtBuscar)
        Me.pnlBuscProd.Controls.Add(Me.PictureBox2)
        Me.pnlBuscProd.Controls.Add(Me.Label4)
        Me.pnlBuscProd.Controls.Add(Me.Label9)
        Me.pnlBuscProd.Controls.Add(Me.Label5)
        Me.pnlBuscProd.Controls.Add(Me.optCod)
        Me.pnlBuscProd.Controls.Add(Me.cmbDescrip)
        Me.pnlBuscProd.Controls.Add(Me.txtCant)
        Me.pnlBuscProd.Controls.Add(Me.optDesc)
        Me.pnlBuscProd.Controls.Add(Me.lblUnidXpack)
        Me.pnlBuscProd.Controls.Add(Me.lblX)
        Me.pnlBuscProd.Controls.Add(Me.btnAgregar)
        Me.pnlBuscProd.Location = New System.Drawing.Point(3, 3)
        Me.pnlBuscProd.Name = "pnlBuscProd"
        Me.pnlBuscProd.Size = New System.Drawing.Size(248, 157)
        Me.pnlBuscProd.TabIndex = 68
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.Label15.Location = New System.Drawing.Point(69, 7)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(101, 13)
        Me.Label15.TabIndex = 81
        Me.Label15.Text = "Buscar Producto"
        '
        'txtBuscar
        '
        Me.txtBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscar.Location = New System.Drawing.Point(64, 59)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(140, 20)
        Me.txtBuscar.TabIndex = 42
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox2.Image = Global.ControlStock.My.Resources.Resources.Plus_over2
        Me.PictureBox2.Location = New System.Drawing.Point(207, 59)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(25, 20)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 79
        Me.PictureBox2.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PictureBox2, "Nuevo Producto")
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(12, 119)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 13)
        Me.Label4.TabIndex = 41
        Me.Label4.Text = "Cant."
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(11, 32)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(26, 13)
        Me.Label9.TabIndex = 39
        Me.Label9.Text = "Por"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(11, 62)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 13)
        Me.Label5.TabIndex = 43
        Me.Label5.Text = "Buscar"
        '
        'optCod
        '
        Me.optCod.AutoSize = True
        Me.optCod.Checked = True
        Me.optCod.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optCod.ForeColor = System.Drawing.Color.White
        Me.optCod.Location = New System.Drawing.Point(137, 30)
        Me.optCod.Name = "optCod"
        Me.optCod.Size = New System.Drawing.Size(64, 17)
        Me.optCod.TabIndex = 38
        Me.optCod.TabStop = True
        Me.optCod.Text = "Código"
        Me.optCod.UseVisualStyleBackColor = True
        '
        'cmbDescrip
        '
        Me.cmbDescrip.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbDescrip.FormattingEnabled = True
        Me.cmbDescrip.Location = New System.Drawing.Point(14, 87)
        Me.cmbDescrip.Name = "cmbDescrip"
        Me.cmbDescrip.Size = New System.Drawing.Size(218, 21)
        Me.cmbDescrip.TabIndex = 44
        '
        'txtCant
        '
        Me.txtCant.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCant.Location = New System.Drawing.Point(49, 116)
        Me.txtCant.Name = "txtCant"
        Me.txtCant.Size = New System.Drawing.Size(81, 20)
        Me.txtCant.TabIndex = 40
        Me.txtCant.Text = "1"
        '
        'optDesc
        '
        Me.optDesc.AutoSize = True
        Me.optDesc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optDesc.ForeColor = System.Drawing.Color.White
        Me.optDesc.Location = New System.Drawing.Point(43, 30)
        Me.optDesc.Name = "optDesc"
        Me.optDesc.Size = New System.Drawing.Size(92, 17)
        Me.optDesc.TabIndex = 37
        Me.optDesc.Text = "Descripción"
        Me.optDesc.UseVisualStyleBackColor = True
        '
        'lblUnidXpack
        '
        Me.lblUnidXpack.AutoSize = True
        Me.lblUnidXpack.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUnidXpack.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.lblUnidXpack.Location = New System.Drawing.Point(140, 119)
        Me.lblUnidXpack.Name = "lblUnidXpack"
        Me.lblUnidXpack.Size = New System.Drawing.Size(21, 13)
        Me.lblUnidXpack.TabIndex = 68
        Me.lblUnidXpack.Text = "00"
        '
        'lblX
        '
        Me.lblX.AutoSize = True
        Me.lblX.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblX.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.lblX.Location = New System.Drawing.Point(131, 118)
        Me.lblX.Name = "lblX"
        Me.lblX.Size = New System.Drawing.Size(17, 13)
        Me.lblX.TabIndex = 67
        Me.lblX.Text = "x "
        '
        'btnAgregar
        '
        Me.btnAgregar.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAgregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnAgregar.Location = New System.Drawing.Point(167, 114)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(65, 23)
        Me.btnAgregar.TabIndex = 34
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = False
        '
        'ToolTip1
        '
        Me.ToolTip1.AutomaticDelay = 10
        Me.ToolTip1.AutoPopDelay = 3000
        Me.ToolTip1.InitialDelay = 10
        Me.ToolTip1.ReshowDelay = 2
        '
        'pnlInfoPiso
        '
        Me.pnlInfoPiso.Controls.Add(Me.lblUnidxCaja)
        Me.pnlInfoPiso.Controls.Add(Me.Label19)
        Me.pnlInfoPiso.Controls.Add(Me.lblMxCaja)
        Me.pnlInfoPiso.Controls.Add(Me.Label14)
        Me.pnlInfoPiso.Location = New System.Drawing.Point(0, 306)
        Me.pnlInfoPiso.Name = "pnlInfoPiso"
        Me.pnlInfoPiso.Size = New System.Drawing.Size(248, 42)
        Me.pnlInfoPiso.TabIndex = 73
        Me.pnlInfoPiso.Visible = False
        '
        'lblUnidxCaja
        '
        Me.lblUnidxCaja.AutoSize = True
        Me.lblUnidxCaja.ForeColor = System.Drawing.Color.White
        Me.lblUnidxCaja.Location = New System.Drawing.Point(129, 23)
        Me.lblUnidxCaja.Name = "lblUnidxCaja"
        Me.lblUnidxCaja.Size = New System.Drawing.Size(22, 13)
        Me.lblUnidxCaja.TabIndex = 65
        Me.lblUnidxCaja.Text = "xxx"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.Label19.Location = New System.Drawing.Point(14, 23)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(103, 13)
        Me.Label19.TabIndex = 64
        Me.Label19.Text = "Unidades x Caja:"
        '
        'lblMxCaja
        '
        Me.lblMxCaja.AutoSize = True
        Me.lblMxCaja.ForeColor = System.Drawing.Color.White
        Me.lblMxCaja.Location = New System.Drawing.Point(113, 4)
        Me.lblMxCaja.Name = "lblMxCaja"
        Me.lblMxCaja.Size = New System.Drawing.Size(22, 13)
        Me.lblMxCaja.TabIndex = 63
        Me.lblMxCaja.Text = "xxx"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.Label14.Location = New System.Drawing.Point(14, 4)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(88, 13)
        Me.Label14.TabIndex = 62
        Me.Label14.Text = "Metros x Caja:"
        '
        'FCompra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(873, 533)
        Me.Controls.Add(Me.SplitContainer1)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "FCompra"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Compras"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.btnGuardar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlEditPrec.ResumeLayout(False)
        Me.pnlEditPrec.PerformLayout()
        CType(Me.btnCancel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlEditCant.ResumeLayout(False)
        Me.pnlEditCant.PerformLayout()
        CType(Me.pbxNewProv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlCredito.ResumeLayout(False)
        Me.pnlCredito.PerformLayout()
        Me.pnlProdInfo.ResumeLayout(False)
        Me.pnlProdInfo.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlBuscProd.ResumeLayout(False)
        Me.pnlBuscProd.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlInfoPiso.ResumeLayout(False)
        Me.pnlInfoPiso.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents lblInfoDesc As System.Windows.Forms.Label
    Friend WithEvents lblInfoCod As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents lblInfoStock As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblInfoCosto As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents optCredito As System.Windows.Forms.RadioButton
    Friend WithEvents optContado As System.Windows.Forms.RadioButton
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents tmrTotal As System.Windows.Forms.Timer
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtFecha As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtNroFac As System.Windows.Forms.TextBox
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents pnlProdInfo As System.Windows.Forms.Panel
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cmbProveedor As System.Windows.Forms.ComboBox
    Friend WithEvents cmbDescrip As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtBuscar As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtCant As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents optCod As System.Windows.Forms.RadioButton
    Friend WithEvents optDesc As System.Windows.Forms.RadioButton
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents lblUnidXpack As System.Windows.Forms.Label
    Friend WithEvents lblX As System.Windows.Forms.Label
    Friend WithEvents lblUnidXPackInfo As System.Windows.Forms.Label
    Friend WithEvents lblUnidXPackTit As System.Windows.Forms.Label
    Friend WithEvents lblPresent As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents pnlCredito As System.Windows.Forms.Panel
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents dtpVto As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblCredGs As System.Windows.Forms.Label
    Friend WithEvents btnCredOk As System.Windows.Forms.Button
    Friend WithEvents txtCredEntrega As System.Windows.Forms.TextBox
    Friend WithEvents btnCredNo As System.Windows.Forms.Button
    Friend WithEvents btnCredSi As System.Windows.Forms.Button
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents btnCredCancel As System.Windows.Forms.Button
    Friend WithEvents btnGuardar As System.Windows.Forms.PictureBox
    Friend WithEvents btnCancel As System.Windows.Forms.PictureBox
    Friend WithEvents pbxNewProv As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents ToolTip2 As System.Windows.Forms.ToolTip
    Friend WithEvents pnlBuscProd As System.Windows.Forms.Panel
    Friend WithEvents pnlEditCant As System.Windows.Forms.Panel
    Friend WithEvents btnEditCantCancel As System.Windows.Forms.Button
    Friend WithEvents txtEditCant As System.Windows.Forms.TextBox
    Friend WithEvents lblEditCant As System.Windows.Forms.Label
    Friend WithEvents pnlEditPrec As System.Windows.Forms.Panel
    Friend WithEvents btnEditPrecCancel As System.Windows.Forms.Button
    Friend WithEvents txtEditPrec As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Del As DataGridViewImageColumn
    Friend WithEvents Cod As DataGridViewTextBoxColumn
    Friend WithEvents Cant As DataGridViewTextBoxColumn
    Friend WithEvents Descripcion As DataGridViewTextBoxColumn
    Friend WithEvents Precio As DataGridViewTextBoxColumn
    Friend WithEvents Importe As DataGridViewTextBoxColumn
    Friend WithEvents Unidades As DataGridViewTextBoxColumn
    Friend WithEvents Obs As DataGridViewTextBoxColumn
    Friend WithEvents pnlInfoPiso As Panel
    Friend WithEvents lblUnidxCaja As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents lblMxCaja As Label
    Friend WithEvents Label14 As Label
End Class
